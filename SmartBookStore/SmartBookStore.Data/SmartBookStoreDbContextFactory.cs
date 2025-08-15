using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data
{
    public class SmartBookStoreDbContextFactory : IDesignTimeDbContextFactory<SmartBookStoreDbContext>
    {
        public SmartBookStoreDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SmartBookStoreDbContext>();

            // 🔹 Kết nối SQL Server, bạn thay chuỗi kết nối cho đúng
            optionsBuilder.UseSqlServer(
                "Server=.;Database=SmartBookStoreDb;Trusted_Connection=True;TrustServerCertificate=True");

            return new SmartBookStoreDbContext(optionsBuilder.Options);
        }
    }
}
