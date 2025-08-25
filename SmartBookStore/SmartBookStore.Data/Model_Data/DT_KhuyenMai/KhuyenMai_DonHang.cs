namespace SmartBookStore.Data.Model_Data.DT_KhuyenMai
{
    public class KhuyenMai_DonHang
    {
        public int MaKhuyenMai { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; } = null!;

        public int MaDonHang { get; set; }
        public virtual DT_DonHang.DonHang DonHang { get; set; } = null!;
    }
}
