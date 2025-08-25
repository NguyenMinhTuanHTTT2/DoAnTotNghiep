using System.ComponentModel.DataAnnotations;

namespace SmartBookStore.Data.Model_Data.DT_NguoiDung
{
    public class VaiTro
    {
        [Key]
        public int MaVaiTro { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenVaiTro { get; set; } = string.Empty;

        public virtual ICollection<NguoiDung> NguoiDungs { get; set; } = new List<NguoiDung>();
    }
}
