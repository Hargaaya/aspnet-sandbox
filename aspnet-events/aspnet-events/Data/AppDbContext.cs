using aspnet_events.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace aspnet_events.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        private IPasswordHasher<User> _hasher;

        public DbSet<UserEvent> Events { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options, IPasswordHasher<User> Hasher) : base(options)
        {
            _hasher = Hasher;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            const string ADM_USER_ID = "748a69e9-fc2f-461f-a2c5-cc3d22771351";
            const string ADM_ROLE_ID = "1fb96894-87ad-4af5-9e02-e3703f2259f7";

            const string ORG_USER_ID = "781231d3-90c5-4e55-b7c9-e27bd26be513";
            const string ORG_ROLE_ID = "da981ce2-f658-4e40-87c6-d93d5e2ffbe2";

            const string ATT_USER_ID = "0c5cdc66-a621-4c0c-9ccd-f661674dc62d";
            const string ATT_ROLE_ID = "2fea37b6-ad6c-4122-933b-76da443b4db5";

            User Adm = new User { Id = ADM_USER_ID, FirstName = "Karlson", LastName = "Taket", UserName = "Admin", NormalizedUserName = "ADMIN", Email = "Karlsonpataket@telia.se", PhoneNumber = "+46739149576", SecurityStamp = Guid.NewGuid().ToString() };
            Adm.PasswordHash = _hasher.HashPassword(Adm, "Password10!");
            User Org = new User { Id = ORG_USER_ID, FirstName = "Bubbles", LastName = "Jonóre", UserName = "Organizer", NormalizedUserName = "ORGANIZER", Email = "Bulle@bubble.se", PhoneNumber = "+46091239012", SecurityStamp = Guid.NewGuid().ToString() };
            Org.PasswordHash = _hasher.HashPassword(Org, "Password10!");
            User Att = new User { Id = ATT_USER_ID, FirstName = "Street", LastName = "Scripters", UserName = "Attendee", NormalizedUserName = "ATTENDEE", Email = "Streetscripters@gamb.com", PhoneNumber = "+45902319459", SecurityStamp = Guid.NewGuid().ToString() };
            Att.PasswordHash = _hasher.HashPassword(Att, "Password10!");

            builder.Entity<User>().HasData(Adm, Org, Att);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = ADM_ROLE_ID, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = ORG_ROLE_ID, Name = "Organizer", NormalizedName = "ORGANIZER" },
                new IdentityRole { Id = ATT_ROLE_ID, Name = "Attendee", NormalizedName = "ATTENDEE" });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = ADM_ROLE_ID, UserId = ADM_USER_ID },
                new IdentityUserRole<string> { RoleId = ORG_ROLE_ID, UserId = ORG_USER_ID },
                new IdentityUserRole<string> { RoleId = ATT_ROLE_ID, UserId = ATT_USER_ID });

            builder.Entity<UserEvent>().HasOne(e => e.Organizer).WithMany(o => o.HostedEvents);

            builder.Entity<UserEvent>().HasData(
                new UserEvent { OrganizerId = ORG_USER_ID, EventId = 1, Title = "Spaghetti harvesting festival", Description = "Stora affärer is hosting a festival to start of this years spaghetti harvest in Italy", Address = "Grazie 15, 957864 Pregi", Date = new DateTime(2022, 4, 12), SpotsAvailable = 40, Place = "Mi scusi" },
                new UserEvent { OrganizerId = ORG_USER_ID, EventId = 2, Title = "Lil Pest Listening party", Description = "The cockroach Lil Pest is having a listening party for his 9th album", Address = "Sveavägen 73, 113 80 Stockholm", Date = new DateTime(2022, 3, 31), SpotsAvailable = 120, Place = "Stadsbiblioteket" },
                new UserEvent { OrganizerId = ORG_USER_ID, EventId = 3, Title = "World of Concrete", Description = "Annual international event dedicated to the commercial concrete and masonry construction industries.", Address = "Humongous Street 23, 80468 Las Vegas, Nevada", Date = new DateTime(2023, 5, 12), SpotsAvailable = 1500, Place = "The Gazino" },
                new UserEvent { OrganizerId = ORG_USER_ID, EventId = 4, Title = "CES 2022", Description = "The show will display the next wave of innovation that will shape 2022", Address = "Big Avenue, 90652 Dallas, Texas", Date = new DateTime(2023, 1, 2), SpotsAvailable = 1000, Place = "Big Avenue" },
                new UserEvent { OrganizerId = ORG_USER_ID, EventId = 5, Title = "Lorem ipsum Conference", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed to", Address = "Lorem 23, 0xFFFF Ipsum", Date = new DateTime(2022, 6, 21), SpotsAvailable = 5, Place = "127.0.0.1" });

        }
    }
}
