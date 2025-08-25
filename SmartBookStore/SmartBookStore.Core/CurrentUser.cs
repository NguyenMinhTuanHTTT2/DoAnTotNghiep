namespace SmartBookStore.Core
{
    public static class CurrentUser
    {
        public static string Email { get; set; }
        public static int VaiTro { get; set; } // 1 = Admin, 2 = Customer
        public static string HoTen { get; set; }

        public static bool IsLoggedIn { get; set; }
    }
}
