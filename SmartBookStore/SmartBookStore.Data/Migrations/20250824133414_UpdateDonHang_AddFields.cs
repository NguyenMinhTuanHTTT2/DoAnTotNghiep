using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartBookStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDonHang_AddFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiaChiGiaoHang",
                table: "DonHangs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "DonHangs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaChiGiaoHang",
                table: "DonHangs");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "DonHangs");
        }
    }
}
