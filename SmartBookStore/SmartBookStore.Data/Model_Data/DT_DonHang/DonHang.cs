using System.ComponentModel.DataAnnotations;

namespace SmartBookStore.Data.Model_Data.DT_DonHang
{
    public class DonHang
    {
        [Key]
        public int MaDonHang { get; set; }

        public int MaNguoiDung { get; set; }
        public virtual DT_NguoiDung.NguoiDung NguoiDung { get; set; } = null!;

        public DateTime NgayDat { get; set; }
        public decimal TongTien { get; set; }

        // ✅ Mới thêm
        public string TrangThai { get; set; } = "Chờ xử lý";
        public string? DiaChiGiaoHang { get; set; }

        // 🔹 Thêm 2 thuộc tính để lưu thông tin người nhận
        public string? TenNguoiNhan { get; set; }
        public string? SoDienThoai { get; set; }

        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();
        public virtual ICollection<DT_KhuyenMai.KhuyenMai_DonHang> KhuyenMai_DonHangs { get; set; } = new List<DT_KhuyenMai.KhuyenMai_DonHang>();
    }
}
