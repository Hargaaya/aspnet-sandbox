using aspnet_events.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_events.Controllers
{
    public class AccountController : Controller
    {

        private SignInManager<User> _sim;
        private UserManager<User> _um;
        private IUserStore<User> _us;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, IUserStore<User> userStore)
        {
            _sim = signInManager;
            _um = userManager;
            _us = userStore;
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
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task Register([Bind("Username,FirstName,LastName,Email,PhoneNumber,Password")] RegisterModel rm)
        {

            User newUser = new User { UserName = rm.Username, FirstName = rm.FirstName, LastName = rm.LastName, Email = rm.Email, PhoneNumber = rm.PhoneNumber };

            // Skapar användare med lösenord asynkront och returnerar IdentityResult
            var res = await _um.CreateAsync(newUser, rm.Password);

            if (res.Succeeded)
            {
                Console.WriteLine("Did work! WOO");
            }
            else
            {
                Console.WriteLine("Did not work");
            }
        }
    }
}
