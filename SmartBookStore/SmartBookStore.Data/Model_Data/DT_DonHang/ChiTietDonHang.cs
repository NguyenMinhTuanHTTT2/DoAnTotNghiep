using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data.Model_Data.DT_DonHang
{
    public class ChiTietDonHang
    {
        [Key]
        public int MaChiTietDonHang { get; set; }

        public int MaDonHang { get; set; }
        public virtual DonHang DonHang { get; set; } = null!;

        public int MaSach { get; set; }
        public virtual DT_Sach.Sach Sach { get; set; } = null!;

        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}
