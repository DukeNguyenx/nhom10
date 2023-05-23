using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNS.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Nhansu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nhansu_ChucVu_MaChucvu",
                table: "Nhansu");

            migrationBuilder.DropColumn(
                name: "ChucVu",
                table: "Nhansu");

            migrationBuilder.AlterColumn<string>(
                name: "MaChucvu",
                table: "Nhansu",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Nhansu_ChucVu_MaChucvu",
                table: "Nhansu",
                column: "MaChucvu",
                principalTable: "ChucVu",
                principalColumn: "MaChucvu",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nhansu_ChucVu_MaChucvu",
                table: "Nhansu");

            migrationBuilder.AlterColumn<string>(
                name: "MaChucvu",
                table: "Nhansu",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "ChucVu",
                table: "Nhansu",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Nhansu_ChucVu_MaChucvu",
                table: "Nhansu",
                column: "MaChucvu",
                principalTable: "ChucVu",
                principalColumn: "MaChucvu");
        }
    }
}
