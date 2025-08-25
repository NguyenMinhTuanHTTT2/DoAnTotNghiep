using System.ComponentModel.DataAnnotations;

namespace SmartBookStore.Data.Model_Data.DT_Sach
{
    public class TheLoai
    {
        [Key]
        public int MaTheLoai { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenTheLoai { get; set; } = string.Empty;

        public int MaDanhMuc { get; set; }

        // Navigation property
        public virtual DanhMuc DanhMuc { get; set; } = null!;
        public virtual ICollection<Sach_TheLoai> Sach_TheLoais { get; set; } = new List<Sach_TheLoai>();
        // ===== Quan hệ 1-N với DanhMuc =====
        
    }
}
