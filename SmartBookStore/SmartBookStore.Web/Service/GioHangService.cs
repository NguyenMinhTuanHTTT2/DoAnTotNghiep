using SmartBookStore.Core.Models;

namespace SmartBookStore.Web.Service
{
    public class GioHangService
    {
        // Danh sách sản phẩm trong giỏ
        private readonly List<CartItem> _items = new List<CartItem>();

        // ✅ Trùng tên với GioHang.razor
        public List<CartItem> DanhSach => _items;

        // ✅ Trùng tên với GioHang.razor
        public decimal TongTien => _items.Sum(x => x.ThanhTien);

        // Các chức năng cơ bản
        public void ThemVaoGio(CartItem item)
        {
            var existing = _items.FirstOrDefault(x => x.MaSach == item.MaSach);
            if (existing != null)
            {
                existing.SoLuong += item.SoLuong;
            }
            else
            {
                _items.Add(item);
            }
        }

        public void XoaKhoiGio(int maSach)
        {
            var existing = _items.FirstOrDefault(x => x.MaSach == maSach);
            if (existing != null)
            {
                _items.Remove(existing);
            }
        }

        public void CapNhatSoLuong(int maSach, int soLuong)
        {
            var existing = _items.FirstOrDefault(x => x.MaSach == maSach);
            if (existing != null)
            {
                existing.SoLuong = soLuong > 0 ? soLuong : 1;
            }
        }

        public void XoaGioHang()
        {
            _items.Clear();
        }
    }
}
