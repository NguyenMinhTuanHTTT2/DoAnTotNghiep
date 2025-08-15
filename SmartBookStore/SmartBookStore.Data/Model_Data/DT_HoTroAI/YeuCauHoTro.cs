using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data.Model_Data.DT_HoTroAI
{
    public class YeuCauHoTro
    {
        [Key]
        public int MaYeuCau { get; set; }

        public int MaNguoiDung { get; set; }
        public virtual DT_NguoiDung.NguoiDung NguoiDung { get; set; } = null!;

        [Required]
        public string NoiDung { get; set; } = string.Empty;

        public virtual ICollection<PhanHoiHoTro> PhanHoiHoTros { get; set; } = new List<PhanHoiHoTro>();
    }
}
