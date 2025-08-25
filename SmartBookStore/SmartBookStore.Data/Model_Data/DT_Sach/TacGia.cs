using System.ComponentModel.DataAnnotations;

namespace SmartBookStore.Data.Model_Data.DT_Sach
{
    public class TacGia
    {
        [Key]
        public int MaTacGia { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenTacGia { get; set; } = string.Empty;

        public virtual ICollection<Sach_TacGia> Sach_TacGias { get; set; } = new List<Sach_TacGia>();
    }
}
