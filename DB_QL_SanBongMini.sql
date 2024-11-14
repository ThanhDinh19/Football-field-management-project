use master
go
CREATE DATABASE QL_SanBongMini
go
use QL_SanBongMini
go

CREATE TABLE SanBong 
(
    MaSan Varchar(10) PRIMARY KEY,
    TenSan NVARCHAR(200) NOT NULL,
    GiaThue DECIMAL(18, 2) NOT NULL,
    TrangThai NVARCHAR(50), -- 'Trống', 'Đã đặt', 'Bảo trì'
	LoaiSan NVARCHAR(50)
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
	TenCV NVARCHAR(50)
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
	TrangThai NVARCHAR(50) DEFAULT 'Active', -- 'Active', 'Locked', 'Suspended'
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

-- insert dữ liệu
insert into ChucVu
values
	(1, 'Administrator'),
	(2, 'Staff');
go

-- Giả sử có dữ liệu 
INSERT INTO SanBong (MaSan, TenSan, GiaThue, TrangThai, LoaiSan)
VALUES 
('SB001', N'Sân bóng 1', 500000, N'Trống', N'Cỏ nhân tạo'),
('SB002', N'Sân bóng 2', 600000, N'Bảo trì', N'Cỏ tự nhiên'),
('SB003', N'Sân bóng 3', 700000, N'Đã đặt', N'Cỏ nhân tạo'),
('SB004', N'Sân bóng 4', 550000, N'Trống', N'Cỏ nhân tạo'),
('SB005', N'Sân bóng 5', 650000, N'Bảo trì', N'Cỏ tự nhiên'),
('SB006', N'Sân bóng 6', 750000, N'Trống', N'Cỏ nhân tạo'),
('SB007', N'Sân bóng 7', 800000, N'Đã đặt', N'Cỏ tự nhiên'),
('SB008', N'Sân bóng 8', 720000, N'Trống', N'Cỏ nhân tạo'),
('SB009', N'Sân bóng 9', 850000, N'Bảo trì', N'Cỏ tự nhiên'),
('SB010', N'Sân bóng 10', 900000, N'Đã đặt', N'Cỏ nhân tạo');

select * from SanBong

-- Giả sử có dữ liệu 
INSERT INTO DatSan (MaDatSan, MaSan, NgayDat, ThoiGianBatDau, ThoiGianKetThuc, TongTien, TrangThai)
VALUES
('DS001', 'SB001', '2024-11-15', '08:00', '09:30', 500000, N'Đã đặt'),
('DS002', 'SB002', '2024-11-16', '09:00', '10:30', 600000, N'Đã thanh toán'),
('DS003', 'SB003', '2024-11-17', '10:00', '11:30', 700000, N'Đã đặt'),
('DS004', 'SB004', '2024-11-18', '11:00', '12:30', 550000, N'Hủy'),
('DS005', 'SB005', '2024-11-19', '12:00', '13:30', 650000, N'Đã thanh toán'),
('DS006', 'SB006', '2024-11-20', '13:00', '14:30', 750000, N'Đã đặt'),
('DS007', 'SB007', '2024-11-21', '14:00', '15:30', 800000, N'Hủy'),
('DS008', 'SB008', '2024-11-22', '15:00', '16:30', 720000, N'Đã đặt'),
('DS009', 'SB009', '2024-11-23', '16:00', '17:30', 850000, N'Đã thanh toán'),
('DS010', 'SB010', '2024-11-24', '17:00', '18:30', 900000, N'Đã đặt');
select * from DatSan
-- Giả sử có dữ liệu
INSERT INTO DichVu (MaDichVu, TenDichVu, GiaDichVu) VALUES 
('DV01', N'Nước uống', 10000.00),
('DV02', N'Bánh ngọt', 15000.00),
('DV03', N'Thuê giày', 20000.00),
('DV04', N'Thuê bóng', 25000.00),
('DV05', N'Thuê áo đấu', 30000.00),
('DV06', N'Thuê sân mini', 50000.00),
('DV07', N'Thuê sân lớn', 100000.00),
('DV08', N'Đèn chiếu sáng', 15000.00),
('DV09', N'Âm thanh', 20000.00),
('DV10', N'Vệ sinh sân', 30000.00);
select * from DichVu

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

-- Lấy tất cả khách hàng
create proc proc_getAllCustomers
as
begin
	select * from KhachHang
end

exec proc_getAllCustomers

-- Lấy tất cả dịch vụ
create proc proc_getAllServices
as
begin
	select * from DichVu
end

exec proc_getAllServices

-- Lấy lịch đặt sân
CREATE FUNCTION func_getTable_bookingSchedule 
()
RETURNS @getBookingSchedule TABLE (
    MaSan VARCHAR(10),
    TenSan NVARCHAR(200),
    GiaThue DECIMAL(18, 2),
    LoaiSan NVARCHAR(50),
    NgayDat NVARCHAR(50), 
    ThoiGianBatDau NVARCHAR(50), 
    ThoiGianKetThuc NVARCHAR(50), 
    TrangThai NVARCHAR(50)
)
AS
BEGIN
    INSERT INTO @getBookingSchedule
    SELECT 
        sb.MaSan,
        sb.TenSan,
        sb.GiaThue,
        sb.LoaiSan,
        CASE 
            WHEN sb.TrangThai = N'Trống' THEN NULL
            WHEN sb.TrangThai = N'Bảo trì' THEN N'Bảo trì'
            WHEN sb.TrangThai = N'Đã đặt' THEN CONVERT(NVARCHAR(50), ds.NgayDat)
            ELSE NULL
        END AS NgayDat,
        CASE 
            WHEN sb.TrangThai = N'Trống' THEN NULL
            WHEN sb.TrangThai = N'Bảo trì' THEN N'Bảo trì'
            WHEN sb.TrangThai = N'Đã đặt' THEN CONVERT(NVARCHAR(50), ds.ThoiGianBatDau)
            ELSE NULL
        END AS ThoiGianBatDau,
        CASE 
            WHEN sb.TrangThai = N'Trống' THEN NULL
            WHEN sb.TrangThai = N'Bảo trì' THEN N'Bảo trì'
            WHEN sb.TrangThai = N'Đã đặt' THEN CONVERT(NVARCHAR(50), ds.ThoiGianKetThuc)
            ELSE NULL
        END AS ThoiGianKetThuc,
        sb.TrangThai
    FROM SanBong sb
    LEFT JOIN DatSan ds 
        ON sb.MaSan = ds.MaSan
    RETURN;
END;


create proc proc_getAllBookingSchedule
as
begin
	select * from func_getTable_bookingSchedule()
end

exec proc_getAllBookingSchedule