using Microsoft.EntityFrameworkCore.Migrations;

namespace StockageAPI.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "Area", "Description", "Name", "Soort", "Supplier" },
                values: new object[,]
                {
                    { 45, 1, "Breakfast", "Per pak", "Eieren", "Food", "Van Zon" },
                    { 59, 1, "Other", "Per unit", "Inkt printer", "Balie", "Onbekend" },
                    { 58, 1, "Other", "Per unit", "Papier printer", "Balie", "Karlo" },
                    { 57, 1, "Cleaning", "Per unit", "Minibar Fanta", "General", "Van Zon" },
                    { 56, 1, "Cleaning", "Per unit", "Minibar Coca Cola", "General", "Van Zon" },
                    { 55, 1, "Cleaning", "Per unit", "Minibar bier", "General", "Van Zon" },
                    { 54, 1, "Cleaning", "Per pak", "WC-product", "General", "Fris Doekske" },
                    { 60, 1, "Other", "Per unit", "Nietjes", "Balie", "De Standaard Boekhandel" },
                    { 53, 1, "Cleaning", "Per pak", "WC-papier", "General", "Fris Doekske" },
                    { 51, 1, "Breakfast", "Per unit", "Appels", "Fruit", "De Haspengouwer" },
                    { 50, 1, "Breakfast", "Per pak", "Brie", "Food", "Van Zon" },
                    { 49, 1, "Breakfast", "Per pak", "Zalm", "Food", "Van Zon" },
                    { 48, 1, "Breakfast", "Per pak", "Varesa Fruitsap", "Drinks", "Van Zon" },
                    { 47, 1, "Breakfast", "Per pak", "Jonge Kaas", "Food", "Van Zon" },
                    { 46, 1, "Breakfast", "Per pak", "Spek", "Food", "Van Zon" },
                    { 52, 1, "Breakfast", "Per unit", "Appelsienen", "Fruit", "De Haspengouwer" },
                    { 61, 1, "Other", "Per unit", "Enveloppes", "Balie", "PrintSalon" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);
        }
    }
}
