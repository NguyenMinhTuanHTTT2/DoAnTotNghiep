using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data.Model_Data.DT_Sach
{
    public class Sach_TheLoai
    {
        public int MaSach { get; set; }
        public virtual Sach Sach { get; set; } = null!;

        public int MaTheLoai { get; set; }
        public virtual TheLoai TheLoai { get; set; } = null!;
    }
}
