using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.MasterMigrations
{
    public partial class Master4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserOperationClaimId",
                table: "userOperationClaims");

            migrationBuilder.AddColumn<int>(
                name: "UserClaimId",
                table: "userOperationClaims",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "userClaimsId",
                table: "userOperationClaims",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "usersId",
                table: "userOperationClaims",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_userOperationClaims_userClaimsId",
                table: "userOperationClaims",
                column: "userClaimsId");

            migrationBuilder.CreateIndex(
                name: "IX_userOperationClaims_usersId",
                table: "userOperationClaims",
                column: "usersId");

            migrationBuilder.AddForeignKey(
                name: "FK_userOperationClaims_userClaims_userClaimsId",
                table: "userOperationClaims",
                column: "userClaimsId",
                principalTable: "userClaims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_userOperationClaims_users_usersId",
                table: "userOperationClaims",
                column: "usersId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userOperationClaims_userClaims_userClaimsId",
                table: "userOperationClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_userOperationClaims_users_usersId",
                table: "userOperationClaims");

            migrationBuilder.DropIndex(
                name: "IX_userOperationClaims_userClaimsId",
                table: "userOperationClaims");

            migrationBuilder.DropIndex(
                name: "IX_userOperationClaims_usersId",
                table: "userOperationClaims");

            migrationBuilder.DropColumn(
                name: "UserClaimId",
                table: "userOperationClaims");

            migrationBuilder.DropColumn(
                name: "userClaimsId",
                table: "userOperationClaims");

            migrationBuilder.DropColumn(
                name: "usersId",
                table: "userOperationClaims");

            migrationBuilder.AddColumn<int>(
                name: "UserOperationClaimId",
                table: "userOperationClaims",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
