using Microsoft.EntityFrameworkCore.Migrations;

namespace Unitas.Data.Migrations
{
    public partial class ChangetoDOB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "AspNetUsers",
                newName: "DOB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "AspNetUsers",
                newName: "Birthday");
        }
    }
}
