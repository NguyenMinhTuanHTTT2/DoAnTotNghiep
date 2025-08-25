using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartBookStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBangDonHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SoDienThoai",
                table: "DonHangs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenNguoiNhan",
                table: "DonHangs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoDienThoai",
                table: "DonHangs");

            migrationBuilder.DropColumn(
                name: "TenNguoiNhan",
                table: "DonHangs");
        }
    }
}
