using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Core.Models
{
    public class CartItem
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; } = string.Empty;
        public decimal Gia { get; set; }
        public string HinhAnh { get; set; } = string.Empty;
        public int SoLuong { get; set; } = 1;

        public decimal ThanhTien => Gia * SoLuong;
    }
}
