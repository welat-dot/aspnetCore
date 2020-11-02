using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.MasterMigrations
{
    public partial class Master14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DatabaseName",
                table: "databases",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50) CHARACTER SET utf8mb4",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_userOperationClaims_UserClaimRefId",
                table: "userOperationClaims",
                column: "UserClaimRefId");

            migrationBuilder.CreateIndex(
                name: "IX_userOperationClaims_UserRefId",
                table: "userOperationClaims",
                column: "UserRefId");

            migrationBuilder.CreateIndex(
                name: "IX_databases_UsersRefId",
                table: "databases",
                column: "UsersRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_databases_users_UsersRefId",
                table: "databases",
                column: "UsersRefId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userOperationClaims_userClaims_UserClaimRefId",
                table: "userOperationClaims",
                column: "UserClaimRefId",
                principalTable: "userClaims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userOperationClaims_users_UserRefId",
                table: "userOperationClaims",
                column: "UserRefId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_databases_users_UsersRefId",
                table: "databases");

            migrationBuilder.DropForeignKey(
                name: "FK_userOperationClaims_userClaims_UserClaimRefId",
                table: "userOperationClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_userOperationClaims_users_UserRefId",
                table: "userOperationClaims");

            migrationBuilder.DropIndex(
                name: "IX_userOperationClaims_UserClaimRefId",
                table: "userOperationClaims");

            migrationBuilder.DropIndex(
                name: "IX_userOperationClaims_UserRefId",
                table: "userOperationClaims");

            migrationBuilder.DropIndex(
                name: "IX_databases_UsersRefId",
                table: "databases");

            migrationBuilder.AlterColumn<string>(
                name: "DatabaseName",
                table: "databases",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}
