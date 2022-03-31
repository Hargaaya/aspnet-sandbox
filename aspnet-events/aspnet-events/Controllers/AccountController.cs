using aspnet_events.Models;
using aspnet_events.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_events.Controllers
{
    public class AccountController : Controller
    {

        private SignInManager<User> _sim;
        private UserManager<User> _um;
        private RoleManager<IdentityRole> _rm;
        private IUserEventService _es;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IUserEventService userEventService)
        {
            _sim = signInManager;
            _um = userManager;
            _rm = roleManager;
            _es = userEventService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Username,Password")] LoginModel loginModel)
        {
            var res = await _sim.PasswordSignInAsync(loginModel.Username, loginModel.Password, false, false);
            if (res.Succeeded)
            {
                Console.WriteLine("It worked WOOO!");
            }
            else
            {
                Console.WriteLine("It did not work :(");
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _sim.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TryRegister([Bind("Username,FirstName,LastName,Email,PhoneNumber,Password")] RegisterModel rm)
        {

            User newUser = new User { UserName = rm.Username, FirstName = rm.FirstName, LastName = rm.LastName, Email = rm.Email, PhoneNumber = rm.PhoneNumber };

            // Skapar användare med lösenord asynkront och returnerar IdentityResult
            var res = await _um.CreateAsync(newUser, rm.Password);

            if (res.Succeeded)
            {
                var users = await _es.GetUsers();
                await _um.AddToRoleAsync(users.Where(u => u.UserName == rm.Username).FirstOrDefault(), "Attendee");
                Console.WriteLine("Did work! WOO");
                return RedirectToAction("Login");
            }
            else
            {
                return View("Register", res.Errors.ToList());
            }
        }

        public async Task<IActionResult> AdminAsync()
        {
            var users = await _es.GetUsersWithOrg();
            return View(users);
        }

        public async Task<IActionResult> toggleRole(string username)
        {
            // Convert GetUsers to IQueryable????
            var userList = await _es.GetUsers();
            var user = userList.Where(u => u.UserName == username).FirstOrDefault();
            bool isOrganizer = await _um.IsInRoleAsync(user, "Organizer");

            if (isOrganizer)
            {
                await _um.RemoveFromRoleAsync(user, "Organizer");
                await _um.AddToRoleAsync(user, "Attendee");
            }
            else
            {
                await _um.RemoveFromRoleAsync(user, "Attendee");
                await _um.AddToRoleAsync(user, "Organizer");
            }

            return RedirectToAction("Admin");
        }
    }
}
