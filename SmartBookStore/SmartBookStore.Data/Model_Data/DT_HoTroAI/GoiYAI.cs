using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data.Model_Data.DT_HoTroAI
{
    public class GoiYAI
    {
        [Key]
        public int MaGoiY { get; set; }

        public int MaNguoiDung { get; set; }
        public virtual DT_NguoiDung.NguoiDung NguoiDung { get; set; } = null!;

        public int MaSach { get; set; }
        public virtual DT_Sach.Sach Sach { get; set; } = null!;

        public double DiemGoiY { get; set; }
    }
}
