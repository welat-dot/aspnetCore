using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.MasterMigrations
{
    public partial class Master7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserPassword",
                table: "users");

            migrationBuilder.AddColumn<string>(
                name: "UserPasswordHash",
                table: "users",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserPasswordSalt",
                table: "users",
                maxLength: 8,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserPasswordHash",
                table: "users");

            migrationBuilder.DropColumn(
                name: "UserPasswordSalt",
                table: "users");

            migrationBuilder.AddColumn<string>(
                name: "UserPassword",
                table: "users",
                type: "varchar(8) CHARACTER SET utf8mb4",
                maxLength: 8,
                nullable: true);
        }
    }
}
