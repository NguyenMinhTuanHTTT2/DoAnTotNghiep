using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
