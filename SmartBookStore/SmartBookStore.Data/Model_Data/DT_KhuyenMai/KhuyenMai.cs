using System.ComponentModel.DataAnnotations;

namespace SmartBookStore.Data.Model_Data.DT_KhuyenMai
{
    public class KhuyenMai
    {
        [Key]
        public int MaKhuyenMai { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenKhuyenMai { get; set; } = string.Empty;

        public decimal GiaTri { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public virtual ICollection<KhuyenMai_Sach> KhuyenMai_Sachs { get; set; } = new List<KhuyenMai_Sach>();
        public virtual ICollection<KhuyenMai_DonHang> KhuyenMai_DonHangs { get; set; } = new List<KhuyenMai_DonHang>();
    }
}
