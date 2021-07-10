using Microsoft.EntityFrameworkCore.Migrations;

namespace Unitas.Data.Migrations
{
    public partial class addcouncils : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CouncilMembershipCouncilNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Councils",
                columns: table => new
                {
                    CouncilNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouncilName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Councils", x => x.CouncilNumber);
                    table.ForeignKey(
                        name: "FK_Councils_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CouncilMembershipCouncilNumber",
                table: "AspNetUsers",
                column: "CouncilMembershipCouncilNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Councils_AddressId",
                table: "Councils",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Councils_CouncilMembershipCouncilNumber",
                table: "AspNetUsers",
                column: "CouncilMembershipCouncilNumber",
                principalTable: "Councils",
                principalColumn: "CouncilNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Councils_CouncilMembershipCouncilNumber",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Councils");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CouncilMembershipCouncilNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CouncilMembershipCouncilNumber",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
