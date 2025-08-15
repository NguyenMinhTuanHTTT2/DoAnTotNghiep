using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data.Model_Data.DT_Sach
{
    public class Sach
    {
        [Key]
        public int MaSach { get; set; }

        [Required]
        [MaxLength(200)]
        public string TenSach { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? MoTa { get; set; } // Mô tả ngắn

        public decimal Gia { get; set; }

        public int SoLuongTon { get; set; }

        [MaxLength(255)]
        public string? AnhBia { get; set; } // Đường dẫn ảnh bìa sách

        public DateTime NgayXuatBan { get; set; }

        public string? NhaXuatBan { get; set; }

        public double? DiemDanhGia { get; set; } // Điểm đánh giá trung bình (1-5)

        public bool TrangThai { get; set; } = true;
        public virtual ICollection<Sach_TacGia> Sach_TacGias { get; set; } = new List<Sach_TacGia>();
        public virtual ICollection<Sach_TheLoai> Sach_TheLoais { get; set; } = new List<Sach_TheLoai>();
        public virtual ICollection<DT_GioHang.ChiTietGioHang> ChiTietGioHangs { get; set; } = new List<DT_GioHang.ChiTietGioHang>();
        public virtual ICollection<DT_DonHang.ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<DT_DonHang.ChiTietDonHang>();
        public virtual ICollection<DT_KhuyenMai.KhuyenMai_Sach> KhuyenMai_Sachs { get; set; } = new List<DT_KhuyenMai.KhuyenMai_Sach>();
    }
}
