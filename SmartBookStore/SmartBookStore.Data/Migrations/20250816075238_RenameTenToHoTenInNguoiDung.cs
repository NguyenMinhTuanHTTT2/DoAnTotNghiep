using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartBookStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameTenToHoTenInNguoiDung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ten",
                table: "NguoiDungs",
                newName: "HoTen");

            migrationBuilder.UpdateData(
                table: "Sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                columns: new[] { "Gia", "MoTa", "TenSach" },
                values: new object[] { 150000m, "Sách hướng dẫn lập trình C# cho người mới bắt đầu.", "Lập Trình C# Cơ Bản" });

            migrationBuilder.UpdateData(
                table: "Sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                columns: new[] { "Gia", "MoTa", "TenSach" },
                values: new object[] { 200000m, "Khám phá vũ trụ qua góc nhìn vật lý của Stephen Hawking.", "Vũ Trụ Trong Vỏ Hạt Dẻ" });

            migrationBuilder.InsertData(
                table: "Sachs",
                columns: new[] { "MaSach", "AnhBia", "DiemDanhGia", "Gia", "MoTa", "NgayXuatBan", "NhaXuatBan", "SoLuongTon", "TenSach", "TrangThai" },
                values: new object[] { 3, null, null, 120000m, "Tiểu thuyết nổi tiếng của Nguyễn Nhật Ánh.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, "Tôi Thấy Hoa Vàng Trên Cỏ Xanh", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sachs",
                keyColumn: "MaSach",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "HoTen",
                table: "NguoiDungs",
                newName: "Ten");

            migrationBuilder.UpdateData(
                table: "Sachs",
                keyColumn: "MaSach",
                keyValue: 1,
                columns: new[] { "Gia", "MoTa", "TenSach" },
                values: new object[] { 120000m, null, "Lập trình C# cơ bản" });

            migrationBuilder.UpdateData(
                table: "Sachs",
                keyColumn: "MaSach",
                keyValue: 2,
                columns: new[] { "Gia", "MoTa", "TenSach" },
                values: new object[] { 150000m, null, "Học ASP.NET Core MVC" });
        }
    }
}
