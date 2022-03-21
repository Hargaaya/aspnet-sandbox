using Microsoft.EntityFrameworkCore;
using aspnet_marketplace.Models;

namespace aspnet_marketplace.Data
{
    public class MarketplaceContext : DbContext
    {
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        public MarketplaceContext(DbContextOptions<MarketplaceContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User { UserId = 1, Username = "HäxanSurtant", Email = "kontakt@surtantAb.se", Phonenumber = "01045509315" },
                new User { UserId = 2, Username = "maskeradeZorro", Email = "r.guggenheim@hotmail.com", Phonenumber = "046739159754" });

            builder.Entity<Advertisement>().HasData(
                new Advertisement { AdvertisementId = 1, UserId = 1, CategoryId = 1, LocationId = 1, Title = "Fjällräven KEB jacket small", Price = 1015, Description = "Oanvänd, säljer då den va för liten, storlek small." },
                new Advertisement { AdvertisementId = 2, UserId = 1, CategoryId = 2, LocationId = 2, Title = "Seletti bordslampa stående apa O_o", Price = 1490, Description = "Booz bordslampa stående apa svart Här har du en riktigt cool bordslampa i form av en stående apa som kan väcka diskussioner och kanske att denna aplampa kan ge ditt hem en ännu fränare look.Lampan tillverkad i formgjuten metallegering, lackerad i svart halvblank pulverlack, sockeln till lampan är av hårdplast. Fakta Höjd 60 cm Bredd 30 cm med svans Vikt: 1,6 kilo" },
                new Advertisement { AdvertisementId = 3, UserId = 2, CategoryId = 3, LocationId = 3, Title = "Leica M4 kromad! Fin klädsel!", Price = 15000, Description = "En Leica M4 som fungerar perfekt! Nyservad så alla tider stämmer. Bara ut och ladda med Tri-X och fota loss. Mätsökaren klar och fin och stämmer med mina objektiv. Medföljer också ett originallock. I övrigt enligt bilder. Mycket fin klädsel! Kameran är från 1970.För den som önskar kan jag skicka fler bilder.Fråga innan du bjuder! Skickas som rekommenderat och försäkrat paket(värde upp till 25000)." },
                new Advertisement { AdvertisementId = 4, UserId = 2, CategoryId = 4, LocationId = 4, Title = "Yamaha dx9 1980tal. Vintage", Price = 740, Description = "Up for sale, a 1980s Yamaha DX9 digital synthesizer in good working order and overall clean cosmetic condition :)" });

            builder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Clothes", Description = "Chlothes are items worn on the body." },
                new Category { CategoryId = 2, Name = "Furniture", Description = "Furniture refers to movable objects intended to support human activities." },
                new Category { CategoryId = 3, Name = "Electronics", Description = "Home electronics are electronic equipment intended for everyday use." },
                new Category { CategoryId = 4, Name = "Hobbies", Description = "A hobby is considered to be a regular activity that is done for enjoyment." });

            builder.Entity<Image>().HasData(
                new Image { ImageId = 1, AdvertisementId = 1, Url = "https://www.fjallraven.com/49f934/globalassets/catalogs/fjallraven/f8/f872/f87211/features/keb_jacket_m_87211-550_e_model_fjr.jpg" },
                new Image { ImageId = 2, AdvertisementId = 1, Url = "https://www.fjallraven.com/49f972/globalassets/catalogs/fjallraven/f8/f872/f87211/features/keb_jacket_m_87211-550_l_detail_fjr.jpg" },
                new Image { ImageId = 3, AdvertisementId = 1, Url = "https://www.fjallraven.com/4adc3d/globalassets/catalogs/fjallraven/f8/f872/f87211/features/f87211_ss19_srrh_keb_jacket_m_fjaellraeven_21.jpg" },
                new Image { ImageId = 4, AdvertisementId = 2, Url = "https://royaldesign.se/image/1/seletti-monkey-lamp-outdoor-standing-svart-1" },
                new Image { ImageId = 5, AdvertisementId = 2, Url = "https://www.norrmalmsel.se/pub_images/large/14920_Monkey-Black.jpg" },
                new Image { ImageId = 6, AdvertisementId = 3, Url = "https://www.35mmc.com/wp-content/uploads/2016/07/DSC0705.jpg" },
                new Image { ImageId = 7, AdvertisementId = 4, Url = "https://i.pinimg.com/originals/b8/75/2e/b8752e591d586e077a33532a5c8ac021.jpg" });

            builder.Entity<Location>().HasData(
                new Location { LocationId = 1, Region = "Stockholm" },
                new Location { LocationId = 2, Region = "Uppsala" },
                new Location { LocationId = 3, Region = "Sörmland" },
                new Location { LocationId = 4, Region = "Östergötland" },
                new Location { LocationId = 5, Region = "Jönköping län" },
                new Location { LocationId = 6, Region = "Kronoberg" },
                new Location { LocationId = 7, Region = "Kalmar län" },
                new Location { LocationId = 8, Region = "Gotland" },
                new Location { LocationId = 9, Region = "Blekinge" },
                new Location { LocationId = 10, Region = "Skåne" },
                new Location { LocationId = 11, Region = "Halland" },
                new Location { LocationId = 12, Region = "Götalandsregionen" },
                new Location { LocationId = 13, Region = "Värmland" },
                new Location { LocationId = 14, Region = "Örebro län" },
                new Location { LocationId = 15, Region = "Västmandland" },
                new Location { LocationId = 16, Region = "Dalarna" },
                new Location { LocationId = 17, Region = "Gävleborg" },
                new Location { LocationId = 18, Region = "Västernorrland" },
                new Location { LocationId = 19, Region = "Jämtland Härjedalen" },
                new Location { LocationId = 20, Region = "Västerbotten" },
                new Location { LocationId = 21, Region = "Norrbotten" });

            builder.Entity<Tag>().HasData(
                new Tag { TagId = 1, Name = "Oanvänd" },
                new Tag { TagId = 2, Name = "Svart" },
                new Tag { TagId = 3, Name = "Fjällräven" },
                new Tag { TagId = 4, Name = "Fint skick" }
                );

            builder.Entity<Advertisement>()
                .HasMany(adv => adv.Tags)
                .WithMany(tag => tag.Advertisements)
                .UsingEntity(b => b.HasData(
                    new { AdvertisementsAdvertisementId = 1, TagsTagId = 1 },
                    new { AdvertisementsAdvertisementId = 1, TagsTagId = 3 },
                    new { AdvertisementsAdvertisementId = 2, TagsTagId = 2 },
                    new { AdvertisementsAdvertisementId = 2, TagsTagId = 1 },
                    new { AdvertisementsAdvertisementId = 3, TagsTagId = 4 },
                    new { AdvertisementsAdvertisementId = 4, TagsTagId = 2 },
                    new { AdvertisementsAdvertisementId = 4, TagsTagId = 4 }));
        }
    }
}
