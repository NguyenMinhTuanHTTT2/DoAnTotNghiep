using SmartBookStore.Data.Model_Data.DT_NguoiDung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
