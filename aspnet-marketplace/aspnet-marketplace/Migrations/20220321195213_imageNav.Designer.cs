﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnet_marketplace.Data;

#nullable disable

namespace aspnet_marketplace.Migrations
{
    [DbContext(typeof(MarketplaceContext))]
    [Migration("20220321195213_imageNav")]
    partial class imageNav
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AdvertisementTag", b =>
                {
                    b.Property<int>("AdvertisementsAdvertisementId")
                        .HasColumnType("int");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("int");

                    b.HasKey("AdvertisementsAdvertisementId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("AdvertisementTag");

                    b.HasData(
                        new
                        {
                            AdvertisementsAdvertisementId = 1,
                            TagsTagId = 1
                        },
                        new
                        {
                            AdvertisementsAdvertisementId = 1,
                            TagsTagId = 3
                        },
                        new
                        {
                            AdvertisementsAdvertisementId = 2,
                            TagsTagId = 2
                        },
                        new
                        {
                            AdvertisementsAdvertisementId = 2,
                            TagsTagId = 1
                        },
                        new
                        {
                            AdvertisementsAdvertisementId = 3,
                            TagsTagId = 4
                        },
                        new
                        {
                            AdvertisementsAdvertisementId = 4,
                            TagsTagId = 2
                        },
                        new
                        {
                            AdvertisementsAdvertisementId = 4,
                            TagsTagId = 4
                        });
                });

            modelBuilder.Entity("aspnet_marketplace.Models.Advertisement", b =>
                {
                    b.Property<int>("AdvertisementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdvertisementId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdvertisementId");

                    b.HasIndex("CategoryId")
                        .IsUnique();

                    b.HasIndex("LocationId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Advertisements");

                    b.HasData(
                        new
                        {
                            AdvertisementId = 1,
                            CategoryId = 1,
                            Description = "Oanvänd, säljer då den va för liten, storlek small.",
                            LocationId = 1,
                            Price = 1015,
                            Title = "Fjällräven KEB jacket small",
                            UserId = 1
                        },
                        new
                        {
                            AdvertisementId = 2,
                            CategoryId = 2,
                            Description = "Booz bordslampa stående apa svart Här har du en riktigt cool bordslampa i form av en stående apa som kan väcka diskussioner och kanske att denna aplampa kan ge ditt hem en ännu fränare look.Lampan tillverkad i formgjuten metallegering, lackerad i svart halvblank pulverlack, sockeln till lampan är av hårdplast. Fakta Höjd 60 cm Bredd 30 cm med svans Vikt: 1,6 kilo",
                            LocationId = 2,
                            Price = 1490,
                            Title = "Seletti bordslampa stående apa O_o",
                            UserId = 1
                        },
                        new
                        {
                            AdvertisementId = 3,
                            CategoryId = 3,
                            Description = "En Leica M4 som fungerar perfekt! Nyservad så alla tider stämmer. Bara ut och ladda med Tri-X och fota loss. Mätsökaren klar och fin och stämmer med mina objektiv. Medföljer också ett originallock. I övrigt enligt bilder. Mycket fin klädsel! Kameran är från 1970.För den som önskar kan jag skicka fler bilder.Fråga innan du bjuder! Skickas som rekommenderat och försäkrat paket(värde upp till 25000).",
                            LocationId = 3,
                            Price = 15000,
                            Title = "Leica M4 kromad! Fin klädsel!",
                            UserId = 2
                        },
                        new
                        {
                            AdvertisementId = 4,
                            CategoryId = 4,
                            Description = "Up for sale, a 1980s Yamaha DX9 digital synthesizer in good working order and overall clean cosmetic condition :)",
                            LocationId = 4,
                            Price = 740,
                            Title = "Yamaha dx9 1980tal. Vintage",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("aspnet_marketplace.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Chlothes are items worn on the body.",
                            Name = "Clothes"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Furniture refers to movable objects intended to support human activities.",
                            Name = "Furniture"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Home electronics are electronic equipment intended for everyday use.",
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "A hobby is considered to be a regular activity that is done for enjoyment.",
                            Name = "Hobbies"
                        });
                });

            modelBuilder.Entity("aspnet_marketplace.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"), 1L, 1);

                    b.Property<int>("AdvertisementId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ImageId");

                    b.HasIndex("AdvertisementId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ImageId = 1,
                            AdvertisementId = 1,
                            Url = "https://www.fjallraven.com/49f934/globalassets/catalogs/fjallraven/f8/f872/f87211/features/keb_jacket_m_87211-550_e_model_fjr.jpg"
                        },
                        new
                        {
                            ImageId = 2,
                            AdvertisementId = 1,
                            Url = "https://www.fjallraven.com/49f972/globalassets/catalogs/fjallraven/f8/f872/f87211/features/keb_jacket_m_87211-550_l_detail_fjr.jpg"
                        },
                        new
                        {
                            ImageId = 3,
                            AdvertisementId = 1,
                            Url = "https://www.fjallraven.com/4adc3d/globalassets/catalogs/fjallraven/f8/f872/f87211/features/f87211_ss19_srrh_keb_jacket_m_fjaellraeven_21.jpg"
                        },
                        new
                        {
                            ImageId = 4,
                            AdvertisementId = 2,
                            Url = "https://royaldesign.se/image/1/seletti-monkey-lamp-outdoor-standing-svart-1"
                        },
                        new
                        {
                            ImageId = 5,
                            AdvertisementId = 2,
                            Url = "https://www.norrmalmsel.se/pub_images/large/14920_Monkey-Black.jpg"
                        },
                        new
                        {
                            ImageId = 6,
                            AdvertisementId = 3,
                            Url = "https://www.35mmc.com/wp-content/uploads/2016/07/DSC0705.jpg"
                        },
                        new
                        {
                            ImageId = 7,
                            AdvertisementId = 4,
                            Url = "https://i.pinimg.com/originals/b8/75/2e/b8752e591d586e077a33532a5c8ac021.jpg"
                        });
                });

            modelBuilder.Entity("aspnet_marketplace.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Region = "Stockholm"
                        },
                        new
                        {
                            LocationId = 2,
                            Region = "Uppsala"
                        },
                        new
                        {
                            LocationId = 3,
                            Region = "Sörmland"
                        },
                        new
                        {
                            LocationId = 4,
                            Region = "Östergötland"
                        },
                        new
                        {
                            LocationId = 5,
                            Region = "Jönköping län"
                        },
                        new
                        {
                            LocationId = 6,
                            Region = "Kronoberg"
                        },
                        new
                        {
                            LocationId = 7,
                            Region = "Kalmar län"
                        },
                        new
                        {
                            LocationId = 8,
                            Region = "Gotland"
                        },
                        new
                        {
                            LocationId = 9,
                            Region = "Blekinge"
                        },
                        new
                        {
                            LocationId = 10,
                            Region = "Skåne"
                        },
                        new
                        {
                            LocationId = 11,
                            Region = "Halland"
                        },
                        new
                        {
                            LocationId = 12,
                            Region = "Götalandsregionen"
                        },
                        new
                        {
                            LocationId = 13,
                            Region = "Värmland"
                        },
                        new
                        {
                            LocationId = 14,
                            Region = "Örebro län"
                        },
                        new
                        {
                            LocationId = 15,
                            Region = "Västmandland"
                        },
                        new
                        {
                            LocationId = 16,
                            Region = "Dalarna"
                        },
                        new
                        {
                            LocationId = 17,
                            Region = "Gävleborg"
                        },
                        new
                        {
                            LocationId = 18,
                            Region = "Västernorrland"
                        },
                        new
                        {
                            LocationId = 19,
                            Region = "Jämtland Härjedalen"
                        },
                        new
                        {
                            LocationId = 20,
                            Region = "Västerbotten"
                        },
                        new
                        {
                            LocationId = 21,
                            Region = "Norrbotten"
                        });
                });

            modelBuilder.Entity("aspnet_marketplace.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            TagId = 1,
                            Name = "Oanvänd"
                        },
                        new
                        {
                            TagId = 2,
                            Name = "Svart"
                        },
                        new
                        {
                            TagId = 3,
                            Name = "Fjällräven"
                        },
                        new
                        {
                            TagId = 4,
                            Name = "Fint skick"
                        });
                });

            modelBuilder.Entity("aspnet_marketplace.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "kontakt@surtantAb.se",
                            Phonenumber = "01045509315",
                            Username = "HäxanSurtant"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "r.guggenheim@hotmail.com",
                            Phonenumber = "046739159754",
                            Username = "maskeradeZorro"
                        });
                });

            modelBuilder.Entity("AdvertisementTag", b =>
                {
                    b.HasOne("aspnet_marketplace.Models.Advertisement", null)
                        .WithMany()
                        .HasForeignKey("AdvertisementsAdvertisementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("aspnet_marketplace.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("aspnet_marketplace.Models.Advertisement", b =>
                {
                    b.HasOne("aspnet_marketplace.Models.Category", "Category")
                        .WithOne("Advertisement")
                        .HasForeignKey("aspnet_marketplace.Models.Advertisement", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("aspnet_marketplace.Models.Location", "Location")
                        .WithOne("Advertisement")
                        .HasForeignKey("aspnet_marketplace.Models.Advertisement", "LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("aspnet_marketplace.Models.User", "User")
                        .WithMany("Advertisements")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Location");

                    b.Navigation("User");
                });

            modelBuilder.Entity("aspnet_marketplace.Models.Image", b =>
                {
                    b.HasOne("aspnet_marketplace.Models.Advertisement", null)
                        .WithMany("Images")
                        .HasForeignKey("AdvertisementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("aspnet_marketplace.Models.Advertisement", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("aspnet_marketplace.Models.Category", b =>
                {
                    b.Navigation("Advertisement");
                });

            modelBuilder.Entity("aspnet_marketplace.Models.Location", b =>
                {
                    b.Navigation("Advertisement");
                });

            modelBuilder.Entity("aspnet_marketplace.Models.User", b =>
                {
                    b.Navigation("Advertisements");
                });
#pragma warning restore 612, 618
        }
    }
}
