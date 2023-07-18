using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Desc Libro 1", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.designyourway.net%2Fblog%2Fwp-content%2Fuploads%2F2017%2F12%2FThe_Girl_Of_Ink_and_Stars__.jpg&f=1&nofb=1&ipt=4b053c1f0547098b089d27ec8244e07f36b5fa189430ea378635494c4bf850ca&ipo=images", 9.99m, "Libro 1" },
                    { 2, "Desc Libro 2", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Febooklaunch.com%2Fwp-content%2Fuploads%2F2019%2F03%2Febooklaunch_ebookformatting-printformatting-bookcoverdesign_500x800_hingesofbroamseld.jpg&f=1&nofb=1&ipt=3a420bf1a7496063bb2ce2f9a51bd2303da1f64a8ade6b1958ec968125b2d120&ipo=images", 9.99m, "Libro 2" },
                    { 3, "Desc Libro 3", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.slidesharecdn.com%2Fss_thumbnails%2Fcreativebookcoverdesignsamples-130420011144-phpapp01-thumbnail-4.jpg%3Fcb%3D1366421345&f=1&nofb=1&ipt=ddcf1a40c7e076996cdc2f3bf9f350d99941a7c1df5996fb170d07ebb1042f4a&ipo=images", 9.99m, "Libro 3" },
                    { 4, "Desc Libro 4", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fgetcovers.com%2Fwp-content%2Fuploads%2F2020%2F12%2Fimage49-954x1536.jpg&f=1&nofb=1&ipt=dfdb32d13e0d46bffb1491ee819a953b58465eaff6546058e7872d6f3f37bde0&ipo=images", 9.99m, "Libro 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
