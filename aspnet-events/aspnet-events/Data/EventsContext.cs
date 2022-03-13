using Microsoft.EntityFrameworkCore;
using aspnet_events.Models;

namespace aspnet_events.Data
{
    public class EventsContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }


        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Organizer>().HasData(
                new Organizer { OrganizerId = 1, Name = "Stora affärer AB", Email = "contact@storaaffarer.se", PhoneNumber = "+4639401402" },
                new Organizer { OrganizerId = 2, Name = "Großes geschäft AG", Email = "contact@großesgeschäft.ge", PhoneNumber = "+4639401402" },
                new Organizer { OrganizerId = 3, Name = "Grosse affaire SA", Email = "contact@grosseaffaire.fr", PhoneNumber = "+4639401402" });

            builder.Entity<Attendee>().HasData(
                new Attendee { AttendeeId = 1, Name = "CautiousCow", Email = "CautiousCow@animail.com", PhoneNumber = "+4689424241" },
                new Attendee { AttendeeId = 2, Name = "ReasonableShark", Email = "ReasonableShark@animail.com", PhoneNumber = "+4689428761" },
                new Attendee { AttendeeId = 3, Name = "AmusedCat", Email = "AmusedCat@animail.com", PhoneNumber = "+4646228051" },
                new Attendee { AttendeeId = 4, Name = "JoblessRat", Email = "JoblessRat@animail.com", PhoneNumber = "+4689574051" }
                );

            builder.Entity<Event>().HasData(
                new Event { OrganizerId = 1, EventId = 1, Title = "Spaghetti harvesting festival", Description = "Stora affärer is hosting a festival to start of this years spaghetti harvest in Italy", Address = "Grazie 15, 957864 Pregi", Date = new DateTime(2022, 4, 12), SpotsAvailable = 40, Place = "Mi scusi" },
                new Event { OrganizerId = 2, EventId = 2, Title = "Lil Pest Listening party", Description = "The cockroach Lil Pest is having a listening party for his 9th album", Address = "Sveavägen 73, 113 80 Stockholm", Date = new DateTime(2022, 3, 31), SpotsAvailable = 120, Place = "Stadsbiblioteket" },
                new Event { OrganizerId = 2, EventId = 3, Title = "World of Concrete", Description = "Annual international event dedicated to the commercial concrete and masonry construction industries.", Address = "Humongous Street 23, 80468 Las Vegas, Nevada", Date = new DateTime(2023, 5, 12), SpotsAvailable = 1500, Place = "The Gazino" },
                new Event { OrganizerId = 3, EventId = 4, Title = "CES 2022", Description = "The show will display the next wave of innovation that will shape 2022", Address = "Big Avenue, 90652 Dallas, Texas", Date = new DateTime(2023, 1, 2), SpotsAvailable = 1000, Place = "Big Avenue" },
                new Event { OrganizerId = 3, EventId = 5, Title = "Lorem ipsum Conference", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed to", Address = "Lorem 23, 0xFFFF Ipsum", Date = new DateTime(2022, 6, 21), SpotsAvailable = 5, Place = "127.0.0.1" });

            // Joint table Many-to-many
            builder.Entity<Attendee>()
                .HasMany(a => a.Events)
                .WithMany(a => a.Attendees)
                .UsingEntity(j => j.HasData(
                    new { EventsEventId = 1, AttendeesAttendeeId = 1 },
                    new { EventsEventId = 1, AttendeesAttendeeId = 2 },
                    new { EventsEventId = 2, AttendeesAttendeeId = 3 },
                    new { EventsEventId = 2, AttendeesAttendeeId = 4 },
                    new { EventsEventId = 3, AttendeesAttendeeId = 1 },
                    new { EventsEventId = 3, AttendeesAttendeeId = 2 },
                    new { EventsEventId = 4, AttendeesAttendeeId = 3 },
                    new { EventsEventId = 4, AttendeesAttendeeId = 4 }));
        }
    }
}
