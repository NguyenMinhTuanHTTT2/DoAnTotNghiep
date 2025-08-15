using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data.Model_Data.DT_HoTroAI
{
    public class PhanHoiHoTro
    {
        [Key]
        public int MaPhanHoi { get; set; }

        public int MaYeuCau { get; set; }
        public virtual YeuCauHoTro YeuCauHoTro { get; set; } = null!;

        public string NoiDung { get; set; } = string.Empty;
    }
}
