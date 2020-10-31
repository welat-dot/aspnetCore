using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.MasterMigrations
{
    public partial class Master8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserPasswordSalt",
                table: "users",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(8) CHARACTER SET utf8mb4",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserPasswordHash",
                table: "users",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(8) CHARACTER SET utf8mb4",
                oldMaxLength: 8,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserPasswordSalt",
                table: "users",
                type: "varchar(8) CHARACTER SET utf8mb4",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserPasswordHash",
                table: "users",
                type: "varchar(8) CHARACTER SET utf8mb4",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
