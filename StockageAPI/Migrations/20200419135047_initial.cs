using Microsoft.EntityFrameworkCore.Migrations;

namespace StockageAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Supplier = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Area", "Description", "Name", "Supplier" },
                values: new object[,]
                {
                    { 1, 1, null, "Per fles", "Sauvignon Friuli", "Olio Vino" },
                    { 26, 1, null, "Per fles", "Bekaa de Marsyas Rood", "ViniFera" },
                    { 27, 1, null, "Per fles", "Rioja Gabaxo", "ViniFera" },
                    { 28, 1, null, "Per fles", "Taurasi", "Olio Vino" },
                    { 29, 1, null, "Per fles", "Rully La Chaume", "ViniFera" },
                    { 30, 1, null, "Per fles", "Saint Emilion Grand Cru", "ViniFera" },
                    { 31, 1, null, "Per fles", "Meone", "Olio Vino" },
                    { 32, 1, null, "Per fles", "Brunello di Montalcino", "Olio Vino" },
                    { 33, 1, null, "Per fles", "Chateauneuf de Pape", "ViniFera" },
                    { 34, 1, null, "Per fles", "Amarone", "Olio Vino" },
                    { 35, 1, null, "Per fles", "Barolo Galina", "Olio Vino" },
                    { 36, 1, null, "Per fles", "T Cuvee Rosé", "Olio Vino" },
                    { 37, 1, null, "Per fles", "AIX normale fles", "ViniFera" },
                    { 38, 1, null, "Per fles", "AIX magnumfles", "ViniFera" },
                    { 39, 1, null, "Per fles", "Prosecco Brut", "ViniFera" },
                    { 40, 1, null, "Per fles", "Prosecco Rosé", "ViniFera" },
                    { 41, 1, null, "Per fles", "Champagne Cuvee de Reserve", "ViniFera" },
                    { 42, 1, null, "Per fles", "Champagne Grande Reserve Chardonnay", "ViniFera" },
                    { 43, 1, null, "Per fles", "Champagne Rosé", "ViniFera" },
                    { 44, 1, null, "Per fles", "Champagne Cuvee Carbon", "ViniFera" },
                    { 25, 1, null, "Per fles", "Barbera d'Alba Canova Superiore", "Olio Vino" },
                    { 24, 1, null, "Per fles", "Jumilla Monastrell", "ViniFera" },
                    { 23, 1, null, "Per fles", "Ronco dei Quatroventi", "Olio Vino" },
                    { 22, 1, null, "Per fles", "Cahors Le Pur Fruit du Causse", "ViniFera" },
                    { 2, 1, null, "Per fles", "Bordeaux Sirius White", "ViniFera" },
                    { 3, 1, null, "Per fles", "Soltema", "Olio Vino" },
                    { 4, 1, null, "Per fles", "Bordeaux Sirius Red", "ViniFera" },
                    { 5, 1, null, "Per fles", "Poesia", "Olio Vino" },
                    { 6, 1, null, "Per fles", "Bordeaux Sirius Rosé", "ViniFera" },
                    { 7, 1, null, "Per fles", "Côtes de Gascogne Chardonnay", "ViniFera" },
                    { 8, 1, null, "Per fles", "Recorbian Soave", "Olio Vino" },
                    { 9, 1, null, "Per fles", "Pinot Grigio", "Olio Vino" },
                    { 10, 1, null, "Per fles", "Rueda Menade", "ViniFera" },
                    { 11, 1, null, "Per fles", "Côtes du Rhone Parallele 45", "ViniFera" },
                    { 13, 1, null, "Per fles", "Fiano di Avellino", "Olio Vino" },
                    { 14, 1, null, "Per fles", "Stellenbosch Ken Forrester", "ViniFera" },
                    { 15, 1, null, "Per fles", "Roero Arneis La Brina", "Olio Vino" },
                    { 16, 1, null, "Per fles", "Ligeja Vermentino di Sardegna", "Olio Vino" },
                    { 17, 1, null, "Per fles", "Bekaa de Marsyas Wit", "ViniFera" },
                    { 18, 1, null, "Per fles", "Pouilly-Fumé La Moynerie", "ViniFera" },
                    { 19, 1, null, "Per fles", "Chablis Saint Martin", "ViniFera" },
                    { 20, 1, null, "Per fles", "Stoan Bianco", "Olio Vino" },
                    { 21, 1, null, "Per fles", "Chassagne Montrachet", "ViniFera" },
                    { 12, 1, null, "Per fles", "Nuricante", "Olio Vino" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "Bram", "Test123" },
                    { 2, "Karlo", "Test123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
