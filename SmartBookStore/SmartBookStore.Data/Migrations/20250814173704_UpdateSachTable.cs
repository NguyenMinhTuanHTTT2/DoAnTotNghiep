using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBookStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSachTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnhBia",
                table: "Sachs",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DiemDanhGia",
                table: "Sachs",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "Sachs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXuatBan",
                table: "Sachs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NhaXuatBan",
                table: "Sachs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "Sachs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "NguoiDungs",
                columns: new[] { "MaNguoiDung", "Email", "MaVaiTro", "MatKhau", "Ten" },
                values: new object[,]
                {
                    { 1, "admin0@gmail.com", 1, "123456", "Quản trị viên" },
                    { 2, "admin1@gmail.com", 2, "123456", "Nguyễn Văn A" }
                });

            migrationBuilder.InsertData(
                table: "Sachs",
                columns: new[] { "MaSach", "AnhBia", "DiemDanhGia", "Gia", "MoTa", "NgayXuatBan", "NhaXuatBan", "SoLuongTon", "TenSach", "TrangThai" },
                values: new object[,]
                {
                    { 1, null, null, 120000m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, "Lập trình C# cơ bản", true },
                    { 2, null, null, 150000m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, "Học ASP.NET Core MVC", true }
                });

            migrationBuilder.InsertData(
                table: "TacGias",
                columns: new[] { "MaTacGia", "TenTacGia" },
                values: new object[,]
                {
                    { 1, "Nguyễn Minh Tuân" },
                    { 2, "Nguyễn Thị Lan" },
                    { 3, "Tố Hữu" }
                });

            migrationBuilder.InsertData(
                table: "TheLoais",
                columns: new[] { "MaTheLoai", "TenTheLoai" },
                values: new object[,]
                {
                    { 1, "Khoa học" },
                    { 2, "Văn học" },
                    { 3, "Công nghệ" },
                    { 4, "Thiếu nhi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NguoiDungs",
                keyColumn: "MaNguoiDung",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NguoiDungs",
                keyColumn: "MaNguoiDung",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sachs",
                keyColumn: "MaSach",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sachs",
                keyColumn: "MaSach",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TacGias",
                keyColumn: "MaTacGia",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TacGias",
                keyColumn: "MaTacGia",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TacGias",
                keyColumn: "MaTacGia",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "AnhBia",
                table: "Sachs");

            migrationBuilder.DropColumn(
                name: "DiemDanhGia",
                table: "Sachs");

            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "Sachs");

            migrationBuilder.DropColumn(
                name: "NgayXuatBan",
                table: "Sachs");

            migrationBuilder.DropColumn(
                name: "NhaXuatBan",
                table: "Sachs");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "Sachs");
        }
    }
}
