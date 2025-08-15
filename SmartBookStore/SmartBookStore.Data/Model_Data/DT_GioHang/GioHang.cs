using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data.Model_Data.DT_GioHang
{
    public class GioHang
    {
        [Key]
        public int MaGioHang { get; set; }

        public int MaNguoiDung { get; set; }
        public virtual DT_NguoiDung.NguoiDung NguoiDung { get; set; } = null!;

        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; } = new List<ChiTietGioHang>();
    }
}
