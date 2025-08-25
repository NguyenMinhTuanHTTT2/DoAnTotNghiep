using SmartBookStore.Core.Models;

namespace SmartBookStore.Core.Service
{
    public class CartService
    {
        private readonly List<CartItem> _items = new();
        public IReadOnlyList<CartItem> Items => _items;

        public void Add(int maSach, string tenSach, decimal gia, string? hinhAnh, int soLuong = 1)
        {
            var exist = _items.FirstOrDefault(x => x.MaSach == maSach);
            if (exist != null) exist.SoLuong += soLuong;
            else _items.Add(new CartItem { MaSach = maSach, TenSach = tenSach, Gia = gia, HinhAnh = hinhAnh ?? "", SoLuong = soLuong });
        }

        public void Update(int maSach, int soLuong)
        {
            var item = _items.FirstOrDefault(x => x.MaSach == maSach);
            if (item == null) return;
            if (soLuong <= 0) _items.Remove(item);
            else item.SoLuong = soLuong;
        }

        public void Remove(int maSach) => _items.RemoveAll(x => x.MaSach == maSach);

        public decimal Total => _items.Sum(x => x.ThanhTien);

        public void Clear() => _items.Clear();
    }
}
