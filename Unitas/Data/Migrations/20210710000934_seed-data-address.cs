using Microsoft.EntityFrameworkCore.Migrations;

namespace Unitas.Data.Migrations
{
    public partial class seeddataaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "State", "Street", "Zipcode" },
                values: new object[,]
                {
                    { -930, "Houston ", null, "TX", null, 0 },
                    { -699, "Green Bay", null, "WI", null, 0 },
                    { -34 , "Hortonville", null, "WI", null, 0 },
                    { -23 , "Greenville", null, "WI", null, 0 },
                    { -799, "Appleton", null, "WI", null, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: -930);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: -799);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: -699);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: -23);
        }
    }
}
