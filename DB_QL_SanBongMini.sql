use master
go
CREATE DATABASE QL_SanBongMini
go
use QL_SanBongMini
go

(
CREATE TABLE SanBong 
    MaSan Varchar(10) PRIMARY KEY,
    TenSan NVARCHAR(200) NOT NULL,
    GiaThue DECIMAL(18, 2) NOT NULL,
    TrangThai NVARCHAR(50), -- 'Trống', 'Đã đặt', 'Bảo trì'
	LoaiSan Varchar(10)
);
go

CREATE TABLE DichVu
(
	MaDichVu Varchar(10) PRIMARY KEY ,
	TenDichVu NVARCHAR(100) NOT NULL,
	GiaDichVu DECIMAL(18, 2) NOT NULL,
);
go

Create table ChucVu
(
	MaCV INT not null primary key,
	TenCV nvarchar(20)
);
go

CREATE TABLE NhanVien
(
	MaNhanVien VARCHAR(10) NOT NULL,
	MaCV INT not null,
	TenNhanVien NVARCHAR(50) NOT NULL,
	SoDienThoai INT,
	DiaChi NVARCHAR(100),
	GioiTinh NCHAR(5),
	Luong float NOT NULL,
	AnhThe varchar(200),
	CONSTRAINT PK_NhanVien PRIMARY KEY(MaNhanVien),
	constraint FK_NV_CV foreign key(MaCV) references ChucVu(MaCV)
);
go



CREATE TABLE Table_UserNV 
(
	ID INT IDENTITY(1,1) NOT NULL primary key, 
    TaiKhoanNV VARCHAR(30) unique,
	PasswordNV VARCHAR(255),
	MaNhanVien VARCHAR(10),
	TrangThai VARCHAR(20) DEFAULT 'Active', -- 'Active', 'Locked', 'Suspended'
	constraint FK_USNV foreign key(MaNhanVien) references NhanVien(MaNhanVien)
);
go


CREATE TABLE KhachHang
(
    MaKhachHang VARCHAR(200) NOT NULL,
    TenKhachHang NVARCHAR(200),
	SoDienThoai VARCHAR(10),
	Email VARCHAR(255),
	MaXacNhan varchar(10),
	constraint PK_KH primary key(MaKhachHang)
);
go

CREATE TABLE Table_UserKH
(
	ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    TaiKhoanKH VARCHAR(30) unique,
	PasswordKH VARCHAR(255),
	MaKhachHang VARCHAR(200),
	constraint FK_USKH foreign key(MaKhachHang) references KhachHang(MaKhachHang)
);
go


CREATE TABLE DatSan 
(
    MaDatSan varchar(10) NOT NULL primary key,
	MaSan Varchar(10) NOT NULL,
    NgayDat DATE NOT NULL,
    ThoiGianBatDau TIME NOT NULL,
    ThoiGianKetThuc TIME NOT NULL,
    TongTien float  NOT NULL,
    TrangThai NVARCHAR(50), -- 'Đã đặt', 'Đã thanh toán', 'Hủy'
	CONSTRAINT FK_MaSan_DS FOREIGN KEY(MaSan) REFERENCES SanBong(MaSan)
);
go

CREATE TABLE HoaDon
(
	MaHoaDon VARCHAR(10) NOT NULL,
    NgayLap DATE NOT NULL,
    TongTien float NOT NULL,
    HinhThucThanhToan NVARCHAR(50), -- 'Tiền mặt', 'Chuyển khoản'
	MaKhachHang VARCHAR(200),
	MaNhanVien VARCHAR(10),
	MaDatSan Varchar(10) NOT NULL,
	CONSTRAINT PK_MaHoaDon PRIMARY KEY(MaHoaDon),
	CONSTRAINT FK_MaNV_HD FOREIGN KEY(MaNhanVien) REFERENCES NhanVien(MaNhanVien), 
	CONSTRAINT FK_MaKhachHang_HD FOREIGN KEY(MaKhachHang) REFERENCES KhachHang(MaKhachHang),
	CONSTRAINT FK_MaSan_HD FOREIGN KEY(MaDatSan) REFERENCES DatSan(MaDatSan)
);
go

--Tinh toán thành tiền mỗi loại dịch vụ
Create table ChiTietHD
(
	MaHoaDon varchar(10) not null,
	MaDichVu varchar(10),
	SoLuong int,
	ThanhTienDV float NOT NULL,
	constraint FK_HDDV foreign key (MaHoaDon) references HoaDon,
	constraint FK_HDDV_DV foreign key (MaDichVu) references DichVu
)

insert into ChucVu
values
	(1, 'Administrator'),
	(2, 'Staff');
go



create proc proc_AddUser
@TaiKhoanNV VARCHAR(30), @PasswordNV VARCHAR(255), @MaNhanVien VARCHAR(10), @TrangThai NVARCHAR(20)
as
	begin
		insert into Table_UserNV values
			(@TaiKhoanNV, @PasswordNV, @MaNhanVien, @TrangThai)
	end

go

create proc proc_AddNhanVien
@MaNhanVien VARCHAR(10),
@MaCV INT,
@TenNhanVien NVARCHAR(50),
@SoDienThoai INT,
@DiaChi NVARCHAR(100),
@GioiTinh NCHAR(5),
@Luong float,
@AnhThe varchar(200)
as
	begin
		insert into NhanVien values
			(@MaNhanVien, @MaCV, @TenNhanVien, @SoDienThoai, @DiaChi, @GioiTinh, @Luong, @AnhThe)
	end
select * from Table_UserNV
