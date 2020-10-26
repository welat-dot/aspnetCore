using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.MasterMigrations
{
    public partial class Master5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserClaimId",
                table: "userOperationClaims");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "userOperationClaims");

            migrationBuilder.AddColumn<int>(
                name: "UserClaimRefId",
                table: "userOperationClaims",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserRefId",
                table: "userOperationClaims",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserClaimRefId",
                table: "userOperationClaims");

            migrationBuilder.DropColumn(
                name: "UserRefId",
                table: "userOperationClaims");

            migrationBuilder.AddColumn<int>(
                name: "UserClaimId",
                table: "userOperationClaims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "userOperationClaims",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
