using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartBookStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThemBangDanhMucAndUpdateBangTheLoai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaDanhMuc",
                table: "TheLoais",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DanhMucs",
                columns: table => new
                {
                    MaDanhMuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucs", x => x.MaDanhMuc);
                });

            migrationBuilder.InsertData(
                table: "DanhMucs",
                columns: new[] { "MaDanhMuc", "MoTa", "TenDanhMuc" },
                values: new object[,]
                {
                    { 1, null, "Khoa học & Văn học" },
                    { 2, null, "Công nghệ" },
                    { 3, null, "Thiếu nhi" },
                    { 4, null, "Truyện tranh" }
                });

            migrationBuilder.UpdateData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 1,
                column: "MaDanhMuc",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 2,
                column: "MaDanhMuc",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 3,
                column: "MaDanhMuc",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 4,
                column: "MaDanhMuc",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_TheLoais_MaDanhMuc",
                table: "TheLoais",
                column: "MaDanhMuc");

            migrationBuilder.AddForeignKey(
                name: "FK_TheLoais_DanhMucs_MaDanhMuc",
                table: "TheLoais",
                column: "MaDanhMuc",
                principalTable: "DanhMucs",
                principalColumn: "MaDanhMuc",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TheLoais_DanhMucs_MaDanhMuc",
                table: "TheLoais");

            migrationBuilder.DropTable(
                name: "DanhMucs");

            migrationBuilder.DropIndex(
                name: "IX_TheLoais_MaDanhMuc",
                table: "TheLoais");

            migrationBuilder.DropColumn(
                name: "MaDanhMuc",
                table: "TheLoais");
        }
    }
}
