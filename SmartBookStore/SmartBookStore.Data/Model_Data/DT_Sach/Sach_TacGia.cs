namespace SmartBookStore.Data.Model_Data.DT_Sach
{
    public class Sach_TacGia
    {
        public int MaSach { get; set; }
        public virtual Sach Sach { get; set; } = null!;

        public int MaTacGia { get; set; }
        public virtual TacGia TacGia { get; set; } = null!;
    }
}
