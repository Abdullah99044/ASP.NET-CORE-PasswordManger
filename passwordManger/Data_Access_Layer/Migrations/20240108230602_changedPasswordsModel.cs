using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class changedPasswordsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "passwords",
                newName: "key");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "passwords",
                newName: "iv");

            migrationBuilder.AddColumn<byte[]>(
                name: "CryptedPassWord",
                table: "passwords",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CryptedPassWord",
                table: "passwords");

            migrationBuilder.RenameColumn(
                name: "key",
                table: "passwords",
                newName: "PasswordSalt");

            migrationBuilder.RenameColumn(
                name: "iv",
                table: "passwords",
                newName: "PasswordHash");
        }
    }
}
