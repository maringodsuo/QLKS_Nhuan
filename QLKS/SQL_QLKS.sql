create database QLKS
go

use QLKS
go

create table ChucDanh
(
	ID nvarchar(20) primary key,
	Ten nvarchar(100),
	Roles int
)
go

create table NhanVien
(
	ID nvarchar(20) primary key,
	Ten nvarchar(500),
	NgaySinh date,
	GioiTinh bit,
	DiaChi nvarchar(500),
	SDT nvarchar(15),
	Matkhau nvarchar(100),
	IDChucDanh nvarchar(20) not null,
	foreign key (IDChucDanh) references ChucDanh(ID),
)
go
ALTER TABLE dbo.NhanVien ALTER COLUMN GioiTinh NVARCHAR(20)
create table DichVu
(
	ID nvarchar(20) primary key,
	Ten nvarchar(500),
	Gia money
)
GO

create table LoaiPhong
(
	ID nvarchar(20) primary key,
	Ten nvarchar(100),
	Gia money,
	SoGiuong int,
	SoNguoiToiDaTrenGiuong int
)

GO




create table TinhTrangPhong
(
	ID nvarchar(20) primary key,
	Ten nvarchar(100)
)
go

create table Phong
(
	ID nvarchar(20) primary key,
	Ten nvarchar(500),
	IDLoai nvarchar(20) not null,
	IDTinhTrang nvarchar(20) not null,
	foreign key (IDLoai) references LoaiPhong(ID),
	foreign key (IDTinhTrang) references TinhTrangPhong(ID)
	
)
go
create table KhachHang
(
	ID nvarchar(20) primary key,
	Ten nvarchar(500),
	NgaySinh date,
	GioiTinh bit,
	Email nvarchar(500),
	SDT nvarchar(15),
	CMND int,
	QuocTich nvarchar(50),
	GhiChu nvarchar(20)
)
go

CREATE TABLE PhieuThuePhong
(
	ID nvarchar(20) primary key,
	NgayThue DATE,
	NgayKetThuc DATE,
	TienCoc MONEY,
	TinhTrang NVARCHAR(100),
	IDNhanVien NVARCHAR(20),
	IDPhong nvarchar(20),
	FOREIGN KEY (IDNhanVien) REFERENCES dbo.NhanVien(ID),
	FOREIGN KEY (IDPhong) REFERENCES dbo.Phong(ID)
)
go

ALTER TABLE dbo.PhieuThuePhong ADD IDKhachHang NVARCHAR(20)
ALTER TABLE dbo.PhieuThuePhong ADD CONSTRAINT pk_Phieu_KH FOREIGN KEY (IDKhachHang) REFERENCES dbo.KhachHang(ID)

CREATE TABLE PhieuDichvu
(
	ID INT PRIMARY KEY IDENTITY,
	TongTien MONEY,
	NgayLap DATE,
	GhiChu NVARCHAR(500),
	IDPhieuThue NVARCHAR(20),
	FOREIGN KEY (IDPhieuThue) REFERENCES dbo.PhieuThuePhong(ID)
)
ALTER TABLE dbo.PhieuDichvu ADD IDNhanVien NVARCHAR(20)
ALTER TABLE dbo.PhieuDichvu ADD CONSTRAINT pk_PDV_NV FOREIGN KEY (IDNhanVien) REFERENCES dbo.NhanVien(ID)

CREATE TABLE HoaDon
(
	ID INT PRIMARY KEY IDENTITY,
	TongTien MONEY,
	NgayThanhToan DATE,
	IDThue NVARCHAR(20),
	IDDichVu INT,
	IDNhanVien NVARCHAR(20),
	FOREIGN KEY (IDThue) REFERENCES dbo.PhieuThuePhong(ID),
	FOREIGN KEY (IDDichVu) REFERENCES dbo.PhieuDichvu(ID),
	FOREIGN KEY (IDNhanVien) REFERENCES dbo.NhanVien(ID)
)






