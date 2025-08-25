using System.ComponentModel.DataAnnotations;

namespace SmartBookStore.Data.Model_Data.DT_GioHang
{
    public class ChiTietGioHang
    {
        [Key]
        public int MaChiTietGioHang { get; set; }

        public int MaGioHang { get; set; }
        public virtual GioHang GioHang { get; set; } = null!;

        public int MaSach { get; set; }
        public virtual DT_Sach.Sach Sach { get; set; } = null!;

        public int SoLuong { get; set; }
    }
}
