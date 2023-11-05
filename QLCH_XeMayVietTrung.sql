Create Database QLCH_XeMayVietTrung

use QLCH_XeMayVietTrung

--Tạo bảng 
--Menu
create table Menu(
MaMenu INT IDENTITY(1,1) PRIMARY KEY,
TenMenu	nvarchar(250),
MoTa nvarchar(250),
TrangThai bit
)
--NhaCungCap
create table NhaCungCap(
MaNhaCungCap int identity(1,1) primary key,
TenNhaCungCap nvarchar(250),
DiaChi nvarchar(250),
SoDienThoai char(20),
Email nvarchar(200)
)
--NhaSanXuat
create table NhaSanXuat(
MaNhaSanXuat int identity(1,1) primary key,
TenNhaSanXuat nvarchar(250),
MoTa nvarchar(500)
)
--NguoiDung
create table NguoiDung(
ManguoiDung int identity(1,1) primary key,
HoTen nvarchar(250),
NgaySinh datetime,
GioiTinh nvarchar(20),
AnhDaiDien nvarchar(max),
DiaChi nvarchar(250),
Email nvarchar(250),
DienThoai char(20),
TrangThai bit
)
--TaiKhoan
create table TaiKhoan(
MaTaiKhoan int identity(1,1) primary key,
MaNguoiDung int,
TenDangNhap nvarchar(100),
MatKhau nvarchar(100),
TrangThai bit,
foreign key(MaNguoiDung) references NguoiDung(MaNguoiDung),
)
--Slide
create table Slide(
MaSlide int identity(1,1) primary key,
TenSlide nvarchar(250),
Anh nvarchar(max),
Link nvarchar(max)
)
--DanhMuc
create table DanhMuc(
MaDanhMuc int identity(1,1) primary key,
TenDanhMuc nvarchar(250),
TrangThai bit,
STT int
)
--SanPham
create table SanPham(
MaSanPham int identity(1,1) primary key,
MaDanhMuc int,
foreign key(MaDanhMuc) references DanhMuc(MaDanhMuc),
TenSanPham nvarchar(250),
MoTa nvarchar(500),
AnhDaiDien nvarchar(max),
MaNhaSanXuat int,
foreign key (MaNhaSanXuat) references NhaSanXuat(MaNhaSanXuat),
NgayTao datetime,
SoLuong int,
LuotXem int
)
--ChiTietAnhSanPham
create table ChiTietAnhSanPham(
MaAnhChiTiet int identity(1,1) primary key,
MaSanPham int,
foreign key(MaSanPham) references SanPham(MaSanPham),
Anh nvarchar(max),
TenAnh nvarchar(250)
)
--ThongSoKyThuat
create table ThongSoKyThuat(
MaThongSo int identity(1,1) primary key,
MaSanPham int,
foreign key(MaSanPham) references SanPham(MaSanPham),
TenThongSo nvarchar(250),
MoTa nvarchar(500)
)
--HoaDonNhap
create table HoaDonNhap(
MaHoaDonNhap int identity(1,1) primary key,
SoHoaDonNhap nchar(50),
NgayNhap datetime,
MaNguoiDung int,
foreign key(MaNguoiDung) references NguoiDung(MaNguoiDung),
MaNhaCungCap int,
foreign key(MaNhaCungCap) references NhaCungCap(MaNhaCungCap),
)
--ChiTietHoaDonNhap
create table ChiTietHoaDonNhap(
MaChiTietHoaDonNhap int identity(1,1) primary key,
MaHoaDonNhap int,
foreign key(MaHoaDonNhap) references HoaDonNhap(MaHoaDonNhap),
MaSanPham int,
foreign key(MaSanPham) references SanPham(MaSanPham),
SoLuongNhap int,
DonGiaNhap float
)
--KhachHang
create table KhachHang(
MaKhachHang int identity(1,1) primary key,
TenKhachHang nvarchar(250),
DiaChi nvarchar(250),
DienThoai char(20),
Email nvarchar(250)
)
--DonHang
create table DonHang(
MaDonHang int identity(1,1) primary key,
NgayDat datetime,
TrangThaiDonhang int
)

ALTER TABLE DonHang
ADD MaKhachHang int;

ALTER TABLE DonHang
ADD CONSTRAINT FK_MaKhachHang
FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang);

--ChiTietDonHang
create table ChiTietDonHang(
MaChiTietDonHang int identity(1,1) primary key,
MaDonHang int,
foreign key (MaDonHang) references DonHang(MaDonHang),
MaSanPham int,
foreign key (MaSanPham) references SanPham(MaSanPham),
SoLuongDat int, 
GiaMua float
)
--HoaDonXuat
create table HoaDonXuat(
MaHoaDonXuat int identity(1,1) primary key,
SoHoaDonXuat nchar(50),
NgayXuat datetime,
MaNguoiDung int,
foreign key (MaNguoiDung) references NguoiDung(MaNguoiDung)
)
--ChiTietHoaDonXuat
create table ChiTietHoaDonXuat(
MaChiTietHoaDonXuat int identity(1,1) primary key,
MaHoaDonXuat int,
foreign key (MaHoaDonXuat) references HoaDonXuat(MaHoaDonXuat),
MaSanPham int,
foreign key (MaSanPham) references SanPham(MaSanPham),
SoLuongBan int,
GiaBan float
)