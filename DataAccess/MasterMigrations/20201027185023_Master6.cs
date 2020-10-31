using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.MasterMigrations
{
    public partial class Master6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_databases_users_UserId",
                table: "databases");

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

            migrationBuilder.DropIndex(
                name: "IX_databases_UserId",
                table: "databases");

            migrationBuilder.DropColumn(
                name: "userClaimsId",
                table: "userOperationClaims");

            migrationBuilder.DropColumn(
                name: "usersId",
                table: "userOperationClaims");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "databases");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userClaimsId",
                table: "userOperationClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "usersId",
                table: "userOperationClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "databases",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_userOperationClaims_userClaimsId",
                table: "userOperationClaims",
                column: "userClaimsId");

            migrationBuilder.CreateIndex(
                name: "IX_userOperationClaims_usersId",
                table: "userOperationClaims",
                column: "usersId");

            migrationBuilder.CreateIndex(
                name: "IX_databases_UserId",
                table: "databases",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_databases_users_UserId",
                table: "databases",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
    }
}
