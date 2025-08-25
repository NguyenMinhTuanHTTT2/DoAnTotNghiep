using SmartBookStore.Core.Models;

namespace SmartBookStore.Web.Service
{
    public class OrderService
    {
        private readonly List<Order> _orders = new();

        public List<Order> DanhSachDonHang => _orders;

        public Order TaoDonHang(int userId, List<CartItem> cartItems)
        {
            var order = new Order
            {
                UserId = userId,
                TotalAmount = cartItems.Sum(x => x.ThanhTien),
                OrderDetails = cartItems.Select(c => new OrderDetail
                {
                    BookId = c.MaSach,
                    Title = c.TenSach,
                    Price = c.Gia,
                    Quantity = c.SoLuong
                }).ToList()
            };

            _orders.Add(order);
            return order;
        }

        public List<Order> LayDonHangTheoUser(int userId)
        {
            return _orders.Where(o => o.UserId == userId).ToList();
        }
    }
}
