-- Tạo cơ sở dữ liệu QLBH
CREATE DATABASE QLBHC#;

-- Sử dụng cơ sở dữ liệu QLBH
USE QLBH;

-- Tạo bảng Khách hàng (Customers)
CREATE TABLE KhachHang (
  MaKhachHang INT PRIMARY KEY,
  Ho VARCHAR(50),
  Ten VARCHAR(50),
  Email VARCHAR(100),
  DienThoai VARCHAR(20),
  DiaChi VARCHAR(200)
);

-- Tạo bảng Sản phẩm (Products)


-- Tạo bảng Đơn hàng (Orders)
CREATE TABLE DonHang (
  MaDonHang INT PRIMARY KEY,
  MaKhachHang INT,
  NgayDatHang DATE,
  TongTien DECIMAL(10, 2),
  FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

-- Tạo bảng Nhà cung cấp (Suppliers)
CREATE TABLE NhaCungCap (
  MaNhaCungCap INT PRIMARY KEY,
  TenNhaCungCap VARCHAR(100),
  TenNguoiLienHe VARCHAR(100),
  Email VARCHAR(100),
  DienThoai VARCHAR(20),
  DiaChi VARCHAR(200)
);
CREATE TABLE NguoiDung (
   UserID  INT PRIMARY  KEY  IDENTITY(1,1),
   Username VARCHAR(50) UNIQUE NOT NULL,
   Password VARCHAR(100) NOT NULL,
   HoTen VARCHAR(100),
   Email VARCHAR(100),

);


CREATE TABLE NguoiDung (
  Username VARCHAR(50) PRIMARY KEY,
  Password VARCHAR(100) NOT NULL,
  HoTen VARCHAR(100) NOT NULL,
  Email VARCHAR(100) UNIQUE NOT NULL,
  Role VARCHAR(50) NOT NULL
);

INSERT INTO NguoiDung (Username, Password, HoTen, Email, Role)
VALUES
  ('user1', '1', 'Nguyen Van A', 'user1@example.com', 'User'),
  ('admin1', '1', 'Tran Thi B', 'admin1@example.com', 'Admin'),
  ('user2', '1', 'Le Van C', 'user2@example.com', 'User');


  select * from NguoiDung

  select * from KhachHang

INSERT INTO KhachHang (MaKhachHang, Ho, Ten, Email, DienThoai, DiaChi)
VALUES
  (1, 'Nguyễn', 'Văn A', 'nguyenvana@example.com', '0901234567', '123 Đường ABC, Quận XYZ'),
  (2, 'Trần', 'Thị B', 'tranthib@example.com', '0912345678', '456 Đường XYZ, Quận ABC');
INSERT INTO SanPham (MaSanPham, TenSanPham, DonGia, SoLuongTrongKho)
VALUES
  (1, 'Laptop Dell', 1500.00, 50),
  (2, 'Điện thoại iPhone', 1000.00, 100),
  (3, 'Máy tính bảng Samsung', 800.00, 75);
INSERT INTO DonHang (MaDonHang, MaKhachHang, NgayDatHang, TongTien)
VALUES
  (101, 1, '2023-07-31', 1500.00),
  (102, 2, '2023-07-31', 2000.00),
  (103, 1, '2023-07-30', 800.00);
INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, TenNguoiLienHe, Email, DienThoai, DiaChi)
VALUES
  (1, 'ABC Electronics', 'John Doe', 'contact@abc.com', '555-1111', '123 Oak St'),
  (2, 'XYZ Tech', 'Jane Smith', 'contact@xyztech.com', '555-2222', '456 Pine Ave');



   ALTER TABLE Orders
ADD CONSTRAINT FK_Orders_KhachHang FOREIGN KEY (NhaCungCap) REFERENCES KhachHang(MaKhachHang
);

  ALTER TABLE SanPham
ADD DonGiaBanChatLieu DECIMAL(10, 2),
  ;

ALTER TABLE SanPham
ADD   GhiChu VARCHAR(255)

CREATE TABLE SanPham (
  MaSanPham INT IDENTITY(1,1) PRIMARY KEY,
  TenSanPham VARCHAR(100),
  DonGia DECIMAL(10, 2),
  Dongiaban DECIMAL(10, 2),
  SoLuongTrongKho INT,
  Image VARCHAR(255),
  GhiChu VARCHAR(255)
);



ALTER TABLE SanPham


ALTER COLUMN GhiChu NVARCHAR(255);

DROP TABLE NguoiDung;


INSERT INTO SanPham (TenSanPham, DonGia, SoLuongTrongKho, Image)
VALUES ('Product 1', 25.99, 100, 'image1.jpg');

INSERT INTO SanPham (TenSanPham, DonGia, SoLuongTrongKho, Image)
VALUES ('Product 2', 19.50, 50, 'image2.jpg');

INSERT INTO SanPham (TenSanPham, DonGia, SoLuongTrongKho, Image)
VALUES ('Product 3', 35.75, 75, 'image3.jpg');

INSERT INTO SanPham (TenSanPham, DonGia, SoLuongTrongKho, Image)
VALUES ('Product 4', 42.00, 200, 'image4.jpg');

INSERT INTO SanPham (TenSanPham, DonGia, SoLuongTrongKho, Image)
VALUES ('Product 5', 12.99, 30, 'image5.jpg');


select * from SanPham



SELECT * FROM NguoiDung WHERE Email IS NOT NULL AND Role <> 'Admin';

select * from NhanVien
CREATE TABLE NhanVien (
    MaNhanVien INT IDENTITY(1,1) PRIMARY KEY,
    TenNhanVien NVARCHAR(255),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    SoDienThoai NVARCHAR(15),
    DiaChi NVARCHAR(255)
);



INSERT INTO NhanVien (TenNhanVien, GioiTinh, NgaySinh, SoDienThoai, DiaChi)
VALUES
    ( 'Nguyen Van A', 'Nam', '1990-01-15', '123456789', '123 ABC Street'),
    ( 'Tran Thi B', 'Nữ', '1995-03-20', '987654321', '456 XYZ Street'),
    ( 'Le Van C', 'Nam', '1985-11-10', '555555555', '789 PQR Street'),
    ( 'Pham Thi D', 'Nữ', '1992-07-05', '777777777', '321 LMN Street');


	select * from NhanVien



	ALTER TABLE SanPham
  ADD ID_DANHMUC  int;;






CREATE TABLE DanhMuc (
    ID INT PRIMARY KEY,
    TenDanhMuc VARCHAR(255)
);

 ALTER TABLE SanPham
ADD CONSTRAINT fk_SanPham
FOREIGN KEY (ID_DANHMUC) REFERENCES DanhMuc(ID);



INSERT INTO DanhMuc (ID, TenDanhMuc)
VALUES
    (1, 'Điện thoại di động'),
    (2, 'Laptop'),
    (3, 'Thiết bị gia đình'),
    (4, 'Thời trang'),
    (5, 'Đồ dùng nhà bếp');

select *from DanhMuc




CREATE TABLE Orders (
    SoHoaDon VARCHAR(10) PRIMARY KEY,
    NgayNhap DATE,
    NgayXuat DATE,
  
    NhaCungCap VARCHAR(50),
    SoLuong INT,
    Gia DECIMAL(10, 2) 
    TongTien DECIMAL(10, 2)
);


select * from Orders


INSERT INTO Orders (SoHoaDon, NgayNhap, NgayXuat, NhaCungCap, SoLuong, Gia, TongTien)
VALUES
    ('HD001', '30-11-2003', '2023-08-05', 'Nha cung cap A', 100, 10.99, 1099.00),
    ('HD002', '2023-08-02', '2023-08-06', 'Nha cung cap B', 50, 5.50, 275.00),
    ('HD003', '2023-08-03', '2023-08-07' , 'Khach hang C', 30, 20.00, 600.00),
    ('HD004', '2023-08-04', '2023-08-08', 'Khach hang D', 75, 8.75, 656.25),
    ('HD005', '2023-08-05', '2023-08-09', 'Nha cung cap A', 120, 9.25, 1110.00);

DELETE  FROM Orders


ALTER TABLE Orders

ALTER COLUMN NgayXuat DATETIME;

SET DATEFORMAT dmy


ALTER TABLE KhachHang
ALTER COLUMN MaKhachHang NVARCHAR(10);


EXEC sp_helpconstraint 'KhachHang';

ALTER TABLE KhachHang
DROP CONSTRAINT PK_KhachHang;

ALTER TABLE KhachHang
ALTER COLUMN MaKhachHang VARCHAR(50) NOT NULL;


ALTER TABLE KhachHang
ADD CONSTRAINT PK_KhachHang PRIMARY KEY (MaKhachHang);


ALTER TABLE KhachHang
DROP COLUMN Email;


select * from KhachHang

 ALTER TABLE Orders
ADD CONSTRAINT fk_orders
FOREIGN KEY (NhaCungCap) REFERENCES KhachHang(MaKhachHang);


SELECT Orders.*, KhachHang.Ten
FROM Orders
INNER JOIN KhachHang ON Orders.NhaCungCap = KhachHang.MaKhachHang


SELECT Orders.*, KhachHang.Ten
FROM Orders

INNER JOIN KhachHang ON Orders.NhaCungCap = KhachHang.MaKhachHang
