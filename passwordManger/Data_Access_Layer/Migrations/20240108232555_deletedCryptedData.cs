using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class deletedCryptedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CryptedPassWord",
                table: "passwords");

            migrationBuilder.DropColumn(
                name: "iv",
                table: "passwords");

            migrationBuilder.DropColumn(
                name: "key",
                table: "passwords");

            migrationBuilder.AddColumn<string>(
                name: "PassWord",
                table: "passwords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassWord",
                table: "passwords");

            migrationBuilder.AddColumn<byte[]>(
                name: "CryptedPassWord",
                table: "passwords",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "iv",
                table: "passwords",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "key",
                table: "passwords",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
