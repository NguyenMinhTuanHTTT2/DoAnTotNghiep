using System.ComponentModel.DataAnnotations;

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
