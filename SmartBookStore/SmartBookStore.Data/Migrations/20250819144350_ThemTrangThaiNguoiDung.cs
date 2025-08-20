using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartBookStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThemTrangThaiNguoiDung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "NguoiDungs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "MaNguoiDung",
                keyValue: 1,
                columns: new[] { "HoTen", "TrangThai" },
                values: new object[] { "nguyễn Minh Tuân", false });

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "MaNguoiDung",
                keyValue: 2,
                column: "TrangThai",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "NguoiDungs");

            migrationBuilder.UpdateData(
                table: "NguoiDungs",
                keyColumn: "MaNguoiDung",
                keyValue: 1,
                column: "HoTen",
                value: "Quản trị viên");
        }
    }
}
