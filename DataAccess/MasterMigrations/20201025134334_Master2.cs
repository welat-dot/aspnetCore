using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.MasterMigrations
{
    public partial class Master2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserPassword",
                table: "users",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "databases",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_databases_users_UserId",
                table: "databases");

            migrationBuilder.DropIndex(
                name: "IX_databases_UserId",
                table: "databases");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "databases");

            migrationBuilder.AlterColumn<string>(
                name: "UserPassword",
                table: "users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8,
                oldNullable: true);
        }
    }
}
