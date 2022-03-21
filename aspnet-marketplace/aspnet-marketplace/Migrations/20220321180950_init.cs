using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnet_marketplace.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    AdvertisementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.AdvertisementId);
                    table.ForeignKey(
                        name: "FK_Advertisements_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertisementTag",
                columns: table => new
                {
                    AdvertisementsAdvertisementId = table.Column<int>(type: "int", nullable: false),
                    TagsTagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementTag", x => new { x.AdvertisementsAdvertisementId, x.TagsTagId });
                    table.ForeignKey(
                        name: "FK_AdvertisementTag_Advertisements_AdvertisementsAdvertisementId",
                        column: x => x.AdvertisementsAdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "AdvertisementId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertisementTag_Tags_TagsTagId",
                        column: x => x.TagsTagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AdvertisementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "AdvertisementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Chlothes are items worn on the body.", "Clothes" },
                    { 2, "Furniture refers to movable objects intended to support human activities.", "Furniture" },
                    { 3, "Home electronics are electronic equipment intended for everyday use.", "Electronics" },
                    { 4, "A hobby is considered to be a regular activity that is done for enjoyment.", "Hobbies" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Region" },
                values: new object[,]
                {
                    { 1, "Stockholm" },
                    { 2, "Uppsala" },
                    { 3, "Sörmland" },
                    { 4, "Östergötland" },
                    { 5, "Jönköping län" },
                    { 6, "Kronoberg" },
                    { 7, "Kalmar län" },
                    { 8, "Gotland" },
                    { 9, "Blekinge" },
                    { 10, "Skåne" },
                    { 11, "Halland" },
                    { 12, "Götalandsregionen" },
                    { 13, "Värmland" },
                    { 14, "Örebro län" },
                    { 15, "Västmandland" },
                    { 16, "Dalarna" },
                    { 17, "Gävleborg" },
                    { 18, "Västernorrland" },
                    { 19, "Jämtland Härjedalen" },
                    { 20, "Västerbotten" },
                    { 21, "Norrbotten" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 1, "Oanvänd" },
                    { 2, "Svart" },
                    { 3, "Fjällräven" },
                    { 4, "Fint skick" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Phonenumber", "Username" },
                values: new object[,]
                {
                    { 1, "kontakt@surtantAb.se", "01045509315", "HäxanSurtant" },
                    { 2, "r.guggenheim@hotmail.com", "046739159754", "maskeradeZorro" }
                });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "AdvertisementId", "CategoryId", "Description", "LocationId", "Price", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Oanvänd, säljer då den va för liten, storlek small.", 1, 1015, "Fjällräven KEB jacket small", 1 },
                    { 2, 2, "Booz bordslampa stående apa svart Här har du en riktigt cool bordslampa i form av en stående apa som kan väcka diskussioner och kanske att denna aplampa kan ge ditt hem en ännu fränare look.Lampan tillverkad i formgjuten metallegering, lackerad i svart halvblank pulverlack, sockeln till lampan är av hårdplast. Fakta Höjd 60 cm Bredd 30 cm med svans Vikt: 1,6 kilo", 2, 1490, "Seletti bordslampa stående apa O_o", 1 },
                    { 3, 3, "En Leica M4 som fungerar perfekt! Nyservad så alla tider stämmer. Bara ut och ladda med Tri-X och fota loss. Mätsökaren klar och fin och stämmer med mina objektiv. Medföljer också ett originallock. I övrigt enligt bilder. Mycket fin klädsel! Kameran är från 1970.För den som önskar kan jag skicka fler bilder.Fråga innan du bjuder! Skickas som rekommenderat och försäkrat paket(värde upp till 25000).", 3, 15000, "Leica M4 kromad! Fin klädsel!", 2 },
                    { 4, 4, "Up for sale, a 1980s Yamaha DX9 digital synthesizer in good working order and overall clean cosmetic condition :)", 4, 740, "Yamaha dx9 1980tal. Vintage", 2 }
                });

            migrationBuilder.InsertData(
                table: "AdvertisementTag",
                columns: new[] { "AdvertisementsAdvertisementId", "TagsTagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 4 },
                    { 4, 2 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "AdvertisementId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://www.fjallraven.com/49f934/globalassets/catalogs/fjallraven/f8/f872/f87211/features/keb_jacket_m_87211-550_e_model_fjr.jpg" },
                    { 2, 1, "https://www.fjallraven.com/49f972/globalassets/catalogs/fjallraven/f8/f872/f87211/features/keb_jacket_m_87211-550_l_detail_fjr.jpg" },
                    { 3, 1, "https://www.fjallraven.com/4adc3d/globalassets/catalogs/fjallraven/f8/f872/f87211/features/f87211_ss19_srrh_keb_jacket_m_fjaellraeven_21.jpg" },
                    { 4, 2, "https://royaldesign.se/image/1/seletti-monkey-lamp-outdoor-standing-svart-1" },
                    { 5, 2, "https://www.norrmalmsel.se/pub_images/large/14920_Monkey-Black.jpg" },
                    { 6, 3, "https://www.35mmc.com/wp-content/uploads/2016/07/DSC0705.jpg" },
                    { 7, 4, "https://i.pinimg.com/originals/b8/75/2e/b8752e591d586e077a33532a5c8ac021.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_CategoryId",
                table: "Advertisements",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_LocationId",
                table: "Advertisements",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_UserId",
                table: "Advertisements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisementTag_TagsTagId",
                table: "AdvertisementTag",
                column: "TagsTagId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_AdvertisementId",
                table: "Images",
                column: "AdvertisementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertisementTag");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
