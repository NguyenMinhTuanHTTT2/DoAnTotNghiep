namespace SmartBookStore.Data.Model_Data.DT_KhuyenMai
{
    public class KhuyenMai_Sach
    {
        public int MaKhuyenMai { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; } = null!;

        public int MaSach { get; set; }
        public virtual DT_Sach.Sach Sach { get; set; } = null!;
    }
}
