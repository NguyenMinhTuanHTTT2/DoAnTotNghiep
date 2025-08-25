using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

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
