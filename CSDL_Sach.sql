create database QLSach
go
use QLSach

CREATE TABLE VaiTro (
    MaVaiTro INT PRIMARY KEY IDENTITY(1,1),
    TenVaiTro NVARCHAR(50) NOT NULL
);

-- Bang nguoi dung
CREATE TABLE NguoiDung (
    MaNguoiDung INT PRIMARY KEY IDENTITY(1,1),
    Ten NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    MatKhau NVARCHAR(100) NOT NULL,
    MaVaiTro INT NOT NULL,
    FOREIGN KEY (MaVaiTro) REFERENCES VaiTro(MaVaiTro)
);

-- Bang the loai
CREATE TABLE TheLoai (
    MaTheLoai INT PRIMARY KEY IDENTITY(1,1),
    TenTheLoai NVARCHAR(100) NOT NULL
);

-- Bang tac gia
CREATE TABLE TacGia (
    MaTacGia INT PRIMARY KEY IDENTITY(1,1),
    TenTacGia NVARCHAR(100) NOT NULL
);

-- Bang sach
CREATE TABLE Sach (
    MaSach INT PRIMARY KEY IDENTITY(1,1),
    TieuDe NVARCHAR(200) NOT NULL,
    MoTa NVARCHAR(MAX),
    GiaBan DECIMAL(18,2) NOT NULL,
    SoLuongTon INT NOT NULL,
    MaTheLoai INT NOT NULL,
    MaTacGia INT NOT NULL,
    FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai),
    FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia)
);

-- Bang khuyen mai
CREATE TABLE KhuyenMai (
    MaKhuyenMai INT PRIMARY KEY IDENTITY(1,1),
    MaGiamGia NVARCHAR(50),
    PhanTramGiam INT,
    NgayBatDau DATE,
    NgayKetThuc DATE
);

-- Bang don hang
CREATE TABLE DonHang (
    MaDonHang INT PRIMARY KEY IDENTITY(1,1),
    MaNguoiDung INT NOT NULL,
    MaKhuyenMai INT,
    NgayDatHang DATETIME NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai)
);

-- Bang chi tiet don hang
CREATE TABLE ChiTietDonHang (
    MaChiTiet INT PRIMARY KEY IDENTITY(1,1),
    MaDonHang INT NOT NULL,
    MaSach INT NOT NULL,
    SoLuong INT NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);

-- Bang gio hang
CREATE TABLE GioHang (
    MaGioHang INT PRIMARY KEY IDENTITY(1,1),
    MaNguoiDung INT NOT NULL,
    MaSach INT NOT NULL,
    SoLuong INT NOT NULL,
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);

-- Bang goi y AI
CREATE TABLE GoiYAI (
    MaGoiY INT PRIMARY KEY IDENTITY(1,1),
    MaNguoiDung INT NOT NULL,
    MaSach INT NOT NULL,
    DiemGoiY FLOAT NOT NULL,
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);














