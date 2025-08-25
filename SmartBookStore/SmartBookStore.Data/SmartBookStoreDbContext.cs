using Microsoft.EntityFrameworkCore;
using SmartBookStore.Data.Model_Data.DT_DonHang;
using SmartBookStore.Data.Model_Data.DT_GioHang;
using SmartBookStore.Data.Model_Data.DT_HoTroAI;
using SmartBookStore.Data.Model_Data.DT_KhuyenMai;
// Entities
using SmartBookStore.Data.Model_Data.DT_NguoiDung;
using SmartBookStore.Data.Model_Data.DT_Sach;


namespace SmartBookStore.Data
{
    public class SmartBookStoreDbContext : DbContext
    {
        public SmartBookStoreDbContext(DbContextOptions<SmartBookStoreDbContext> options)
            : base(options) { }

        // DbSet
        public DbSet<VaiTro> VaiTros { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }

        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<ChiTietGioHang> ChiTietGioHangs { get; set; }

        public DbSet<Sach> Sachs { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        
        public DbSet<Sach_TacGia> Sach_TacGias { get; set; }
        public DbSet<Sach_TheLoai> Sach_TheLoais { get; set; }

        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<KhuyenMai_Sach> KhuyenMai_Sachs { get; set; }
        public DbSet<KhuyenMai_DonHang> KhuyenMai_DonHangs { get; set; }
       
        public DbSet<GoiYAI> GoiYAIs { get; set; }
        public DbSet<YeuCauHoTro> YeuCauHoTros { get; set; }
        public DbSet<PhanHoiHoTro> PhanHoiHoTros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ====== NguoiDung - VaiTro (1-N)
            modelBuilder.Entity<NguoiDung>()
                .HasOne(u => u.VaiTro)
                .WithMany(r => r.NguoiDungs)
                .HasForeignKey(u => u.MaVaiTro)
                .OnDelete(DeleteBehavior.Restrict);

            // ====== GioHang - NguoiDung (N-1)
            modelBuilder.Entity<GioHang>()
                .HasOne(g => g.NguoiDung)
                .WithMany(u => u.GioHangs)
                .HasForeignKey(g => g.MaNguoiDung)
                .OnDelete(DeleteBehavior.Cascade);

            // ====== ChiTietGioHang
            modelBuilder.Entity<ChiTietGioHang>()
                .HasOne(ct => ct.GioHang)
                .WithMany(g => g.ChiTietGioHangs)
                .HasForeignKey(ct => ct.MaGioHang)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChiTietGioHang>()
                .HasOne(ct => ct.Sach)
                .WithMany(s => s.ChiTietGioHangs)
                .HasForeignKey(ct => ct.MaSach)
                .OnDelete(DeleteBehavior.Cascade);

            // ====== DonHang - NguoiDung (N-1)
            modelBuilder.Entity<DonHang>()
                .HasOne(d => d.NguoiDung)
                .WithMany(u => u.DonHangs)
                .HasForeignKey(d => d.MaNguoiDung)
                .OnDelete(DeleteBehavior.Restrict);

            // ====== ChiTietDonHang
            modelBuilder.Entity<ChiTietDonHang>()
                .HasOne(ct => ct.DonHang)
                .WithMany(d => d.ChiTietDonHangs)
                .HasForeignKey(ct => ct.MaDonHang)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChiTietDonHang>()
                .HasOne(ct => ct.Sach)
                .WithMany(s => s.ChiTietDonHangs)
                .HasForeignKey(ct => ct.MaSach)
                .OnDelete(DeleteBehavior.Restrict);

            // ====== Sach - TacGia (N-N qua bảng nối)
            modelBuilder.Entity<Sach_TacGia>()
                .HasKey(st => new { st.MaSach, st.MaTacGia });

            modelBuilder.Entity<Sach_TacGia>()
                .HasOne(st => st.Sach)
                .WithMany(s => s.Sach_TacGias)
                .HasForeignKey(st => st.MaSach)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Sach_TacGia>()
                .HasOne(st => st.TacGia)
                .WithMany(t => t.Sach_TacGias)
                .HasForeignKey(st => st.MaTacGia)
                .OnDelete(DeleteBehavior.Cascade);

            // ====== Sach - TheLoai (N-N qua bảng nối)
            modelBuilder.Entity<Sach_TheLoai>()
                .HasKey(sl => new { sl.MaSach, sl.MaTheLoai });

            modelBuilder.Entity<Sach_TheLoai>()
                .HasOne(sl => sl.Sach)
                .WithMany(s => s.Sach_TheLoais)
                .HasForeignKey(sl => sl.MaSach)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Sach_TheLoai>()
                .HasOne(sl => sl.TheLoai)
                .WithMany(tl => tl.Sach_TheLoais)
                .HasForeignKey(sl => sl.MaTheLoai)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TheLoai>()
                .HasOne(tl => tl.DanhMuc)
                .WithMany(dm => dm.TheLoais)
                .HasForeignKey(tl => tl.MaDanhMuc)
                .OnDelete(DeleteBehavior.Cascade);

            // ====== KhuyenMai - Sach (N-N qua bảng nối)
            modelBuilder.Entity<KhuyenMai_Sach>()
                .HasKey(ks => new { ks.MaKhuyenMai, ks.MaSach });

            modelBuilder.Entity<KhuyenMai_Sach>()
                .HasOne(ks => ks.KhuyenMai)
                .WithMany(km => km.KhuyenMai_Sachs)
                .HasForeignKey(ks => ks.MaKhuyenMai)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<KhuyenMai_Sach>()
                .HasOne(ks => ks.Sach)
                .WithMany(s => s.KhuyenMai_Sachs)
                .HasForeignKey(ks => ks.MaSach)
                .OnDelete(DeleteBehavior.Cascade);

            // ====== KhuyenMai - DonHang (N-N qua bảng nối)
            modelBuilder.Entity<KhuyenMai_DonHang>()
                .HasKey(kd => new { kd.MaKhuyenMai, kd.MaDonHang });

            modelBuilder.Entity<KhuyenMai_DonHang>()
                .HasOne(kd => kd.KhuyenMai)
                .WithMany(km => km.KhuyenMai_DonHangs)
                .HasForeignKey(kd => kd.MaKhuyenMai)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<KhuyenMai_DonHang>()
                .HasOne(kd => kd.DonHang)
                .WithMany(d => d.KhuyenMai_DonHangs)
                .HasForeignKey(kd => kd.MaDonHang)
                .OnDelete(DeleteBehavior.Cascade);

            // ====== GoiYAI (N-1 tới NguoiDung/Sach)
            modelBuilder.Entity<GoiYAI>()
                .HasOne(g => g.NguoiDung)
                .WithMany() // không khai báo collection trong NguoiDung
                .HasForeignKey(g => g.MaNguoiDung)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<GoiYAI>()
                .HasOne(g => g.Sach)
                .WithMany()
                .HasForeignKey(g => g.MaSach)
                .OnDelete(DeleteBehavior.Cascade);

            // ====== HoTro: YeuCauHoTro - NguoiDung (N-1), PhanHoiHoTro - YeuCauHoTro (N-1)
            modelBuilder.Entity<YeuCauHoTro>()
                .HasOne(y => y.NguoiDung)
                .WithMany(u => u.YeuCauHoTros)
                .HasForeignKey(y => y.MaNguoiDung)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PhanHoiHoTro>()
                .HasOne(p => p.YeuCauHoTro)
                .WithMany(y => y.PhanHoiHoTros)
                .HasForeignKey(p => p.MaYeuCau)
                .OnDelete(DeleteBehavior.Cascade);

            // ====== Decimal precision
            modelBuilder.Entity<Sach>()
                .Property(s => s.Gia)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(c => c.DonGia)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<DonHang>()
                .Property(d => d.TongTien)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<KhuyenMai>()
                .Property(k => k.GiaTri)
                .HasColumnType("decimal(18,2)");

            // Tạo seed dữ liệu mặc định cho một số bảng mặc định

            // ====== (Tùy chọn) Seed dữ liệu VaiTro
            modelBuilder.Entity<VaiTro>().HasData(
                new VaiTro { MaVaiTro = 1, TenVaiTro = "Admin" },
                new VaiTro { MaVaiTro = 2, TenVaiTro = "KhachHang" }
            );
            // 2.Seed bảng NguoiDung(tạo sẵn 1 Admin và 1 Khách hàng test)
            // Lưu ý: Mật khẩu ở đây chưa mã hóa để dễ test, thực tế nên mã hóa.
            modelBuilder.Entity<NguoiDung>().HasData(
                new NguoiDung
                {
                    MaNguoiDung = 1,
                    HoTen = "nguyễn Minh Tuân",
                    Email = "admin0@gmail.com",
                    MatKhau = "123456",
                    MaVaiTro = 1
                },
                new NguoiDung
                {
                    MaNguoiDung = 2,
                    HoTen = "Nguyễn Văn A",
                    Email = "admin1@gmail.com",
                    MatKhau = "123456",
                    MaVaiTro = 2
                }
            );

            // Thêm bảng danh mục và seed bảng danh mục
            modelBuilder.Entity<DanhMuc>().HasData(
                new DanhMuc { MaDanhMuc = 1, TenDanhMuc = "Khoa học & Văn học" },
                new DanhMuc { MaDanhMuc = 2, TenDanhMuc = "Công nghệ" },
                new DanhMuc { MaDanhMuc = 3, TenDanhMuc = "Thiếu nhi" },
                new DanhMuc { MaDanhMuc = 4, TenDanhMuc = "Truyện tranh" }
            );

            // 3. Seed bảng TheLoai (các thể loại sách cơ bản)
            modelBuilder.Entity<TheLoai>().HasData(
                new TheLoai { MaTheLoai = 1, TenTheLoai = "Khoa học",MaDanhMuc= 1 },
                new TheLoai { MaTheLoai = 2, TenTheLoai = "Văn học", MaDanhMuc = 2},
                new TheLoai { MaTheLoai = 3, TenTheLoai = "Công nghệ", MaDanhMuc = 3 },
                new TheLoai { MaTheLoai = 4, TenTheLoai = "Thiếu nhi", MaDanhMuc = 4 }
                );
            // 4. Seed bảng TacGia (một số tác giả nổi tiếng)

            modelBuilder.Entity<TacGia>().HasData(
                new TacGia { MaTacGia = 1, TenTacGia = "Nguyễn Minh Tuân" },
                new TacGia { MaTacGia = 2, TenTacGia = "Nguyễn Thị Lan" },
                new TacGia { MaTacGia = 3, TenTacGia = "Tố Hữu" }
                );
            // 5. Seed bảng Sach (sách mẫu để test giao diện)
            // Lưu ý: Giá và Số lượng tồn kho chỉ mang tính minh họa
            modelBuilder.Entity<Sach>().HasData(
        new Sach
        {
            MaSach = 1,
            TenSach = "Lập Trình C# Cơ Bản",
            Gia = 150000,
            SoLuongTon = 50,
            MoTa = "Sách hướng dẫn lập trình C# cho người mới bắt đầu."
        },
        new Sach
        {
            MaSach = 2,
            TenSach = "Vũ Trụ Trong Vỏ Hạt Dẻ",
            Gia = 200000,
            SoLuongTon = 30,
            MoTa = "Khám phá vũ trụ qua góc nhìn vật lý của Stephen Hawking."
        },
        new Sach
            {
            MaSach = 3,
            TenSach = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh",
            Gia = 120000,
            SoLuongTon = 40,
            MoTa = "Tiểu thuyết nổi tiếng của Nguyễn Nhật Ánh."
            });
            


            base.OnModelCreating(modelBuilder);
        }

    }

}