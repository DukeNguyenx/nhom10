using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNS.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_ChucVu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TenPhong",
                table: "Phongban",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "MaChucvu",
                table: "Nhansu",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaChucvu = table.Column<string>(type: "TEXT", nullable: false),
                    TenChucvu = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.MaChucvu);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nhansu_MaChucvu",
                table: "Nhansu",
                column: "MaChucvu");

            migrationBuilder.AddForeignKey(
                name: "FK_Nhansu_ChucVu_MaChucvu",
                table: "Nhansu",
                column: "MaChucvu",
                principalTable: "ChucVu",
                principalColumn: "MaChucvu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nhansu_ChucVu_MaChucvu",
                table: "Nhansu");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropIndex(
                name: "IX_Nhansu_MaChucvu",
                table: "Nhansu");

            migrationBuilder.DropColumn(
                name: "MaChucvu",
                table: "Nhansu");

            migrationBuilder.AlterColumn<string>(
                name: "TenPhong",
                table: "Phongban",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
