using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartBookStore.Data.Model_Data.DT_DonHang
{
    public class ChiTietDonHang
    {
        [Key]
        public int MaChiTietDonHang { get; set; }

        // Khóa ngoại đến Đơn hàng
        public int MaDonHang { get; set; }
        public virtual DonHang DonHang { get; set; } = null!;

        // Khóa ngoại đến Sách
        public int MaSach { get; set; }
        public virtual DT_Sach.Sach Sach { get; set; } = null!;

        // Thuộc tính chi tiết
        public int SoLuong { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DonGia { get; set; }

        // 🔹 Các thuộc tính tiện lợi cho Razor
        [NotMapped]
        public string TenSach => Sach?.TenSach ?? "";

        [NotMapped]
        public string HinhAnh => Sach?.AnhBia ?? "/images/sample1.jpg";

        [NotMapped]
        public decimal Gia => DonGia;
    }
}
