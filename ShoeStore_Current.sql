create database ShoeStore
go 

use ShoeStore
go

create table dbo.HANGGIAY
(
	idHangGiay int identity(1,1) primary key,
	tenHangGiay nvarchar(150) not null,
	status int not null default 1,
)
go

insert into HANGGIAY (tenHangGiay) values (N'Nike');
insert into HANGGIAY (tenHangGiay) values (N'Addidas');
insert into HANGGIAY (tenHangGiay) values (N'Vans');
insert into HANGGIAY (tenHangGiay) values (N'Converse');
insert into HANGGIAY (tenHangGiay) values (N'Fila');
go

create table dbo.LOAIGIAY
(
	idLoaiGiay int identity(1,1) primary key,
	maLoaiGiay varchar(50) null,
	tenLoaiGiay nvarchar(150) not null,
	idHangGiay int foreign key references dbo.HANGGIAY(idHangGiay),
	soLuongLoaiGiay int not null default 0,
	linkImage varchar(500) null,
	status int not null  default 1,
)
go

insert into LOAIGIAY (tenLoaiGiay, idHangGiay) values (N'Nike Air Max 90 Premium', 1); /* https://www.nike.com/vn/t/air-max-90-shoe-gFtKdr/DC7856-100 */
insert into LOAIGIAY (tenLoaiGiay, idHangGiay) values (N'Nike Air Max Tailwind V SP', 1); /* https://www.nike.com/vn/t/air-max-tailwind-v-sp-shoe-KLqjDl/CQ8713-001 */
insert into LOAIGIAY (tenLoaiGiay, idHangGiay) values (N'ULTRA 4D', 2); /* https://www.adidas.com.vn/vi/article/FX7753.html */
insert into LOAIGIAY (tenLoaiGiay, idHangGiay) values (N'ULTRABOOST', 2); /* https://www.adidas.com.vn/vi/ultraboost/FX8932.html */
go

create table dbo.GIAY
(
	idGiay int identity(1,1) primary key,
	maGiay varchar(50) null,
	idLoaiGiay int foreign key references dbo.LOAIGIAY(idLoaiGiay),
	mauSac nvarchar(20) not null,
	size int not null, /* thiet lap tu 34 -> 45 */
	soLuongGiay int not null default 0,
	giaBan float not null default 0,
	status int not null default 1,
)
go
ALTER TABLE dbo.GIAY ADD CONSTRAINT unique_Giay UNIQUE(idLoaiGiay, mauSac, size);
go

insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Trắng', 35);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Trắng', 36);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Trắng', 37);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Trắng', 38);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Trắng', 39);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Trắng', 40);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Trắng', 41);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Trắng', 42);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Trắng', 43);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Trắng', 44);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Trắng', 45);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Đen', 35);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Đen', 36);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Đen', 37);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Đen', 38);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Đen', 39);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Đen', 40);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Đen', 41);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Đen', 42);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Đen', 43);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Đen', 44);
insert into GIAY(idLoaiGiay, mauSac, size) values('1', N'Đen', 45);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Trắng', 35);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Trắng', 36);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Trắng', 37);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Trắng', 38);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Trắng', 39);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Trắng', 40);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Trắng', 41);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Trắng', 42);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Trắng', 43);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Trắng', 44);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Trắng', 45);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Đen', 35);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Đen', 36);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Đen', 37);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Đen', 38);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Đen', 39);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Đen', 40);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Đen', 41);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Đen', 42);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Đen', 43);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Đen', 44);
insert into GIAY(idLoaiGiay, mauSac, size) values('2', N'Đen', 45);
go
create table dbo.NHACUNGCAP
(
	idNCC int identity(1,1) primary key,
	tenNCC nvarchar(150) not null,
	sdt varchar(20) not null,
	email varchar(150) not null,
	diaChi nvarchar(250) not null,
	status int not null default 1,
)
go

insert into NHACUNGCAP (tenNCC, sdt, email, diaChi) values(N'Hùng Hiệp Việt','0439743488', 'hunghiepviet@hhv.com.vn', N'Tầng 12, số 29 Nguyễn Đình Chiểu, Phường Lê Đại Hành, Quận Hai Bà Trưng, Hà Nội'); /* https://infodoanhnghiep.com/thong-tin/Cong-Ty-TNHH-Thuong-Mai-Hung-Hiep-Viet-03666.html */
insert into NHACUNGCAP (tenNCC, sdt, email, diaChi) values(N'ACFC', '84 (28) 3825 6523', 'do.bui@acfc.com.vn', N'Tầng 6, Tòa nhà Sài Gòn Royal, 91 Pasteur, P.Bến Nghé, Q.1, TP Hồ Chí Minh') /* https://www.acfc.com.vn/ */
insert into NHACUNGCAP (tenNCC, sdt, email, diaChi) values(N'Drake', '1800.0080', 'support@drake.vn', N'879 Nguyễn Kiệm, P.3, Gò Vấp, HCM') /* https://drake.vn/store */
insert into NHACUNGCAP (tenNCC, sdt, email, diaChi) values(N'Fila Việt Nam', '0898 516 156', 'filavietnam.vn@gmail.com', N'TP Hồ Chí Minh') /* https://filavietnam.vn/ */
go

create table dbo.NHANVIEN
(
	idNV int identity(1,1) primary key,
	tenNV nvarchar(150) not null,
	username varchar(50) not null,
	password varchar(500) not null,
	sdt varchar(20) not null,
	email varchar(150) not null,
	phanQuyen int not null,
	status int not null default 1,
)
go

insert into NHANVIEN (tenNV, username, password, sdt, email, phanQuyen) values (N'Nguyễn Tuấn Vũ', 'admin01', 'admin01', '01231312125', 'admin01@shoestore.com', 0);
insert into NHANVIEN (tenNV, username, password, sdt, email, phanQuyen) values (N'Nguyễn Xuân Hiệu', 'admin02', 'admin02', '01231312122', 'admin02@shoestore.com', 0);
insert into NHANVIEN (tenNV, username, password, sdt, email, phanQuyen) values (N'Trần Thị Lệ Xuân', 'user01', 'user01', '01231312120', 'user01@shoestore.com', 1);
insert into NHANVIEN (tenNV, username, password, sdt, email, phanQuyen) values (N'Trương Hùng Anh', 'user02', 'user02', '01231312920', 'user02@shoestore.com', 1);
go

create table dbo.NHAPKHO
(
	idNhapKho int identity(1,1) primary key,
	idNV int foreign key references dbo.NHANVIEN (idNV),
	idNCC int foreign key references dbo.NHACUNGCAP(idNCC),
	ngayNhapKho date not null,
	soLuong int not null default 0,
	thanhTien float not null default 0,
	status int not null default 1,
)
go

insert into NHAPKHO (idNV, idNCC, ngayNhapKho, soLuong, thanhTien) values(1, 1, '11/30/2020', '200', '190000000');
go

create table dbo.CHITIETNHAPKHO
(
	idChiTietPNK int identity(1,1) primary key,
	idNhapKho int foreign key references dbo.NHAPKHO(idNhapKho),
	idGiay int foreign key references dbo.GIAY (idGiay),
	soLuong int not null,
	donGia float not null,
	thanhTien float not null, /*  Trigger đảm bảo sumThanhTien trong ChiTiet = thanhTien trong NhapKho C#*/
	status int not null default 1,
)
go

insert into CHITIETNHAPKHO (idNhapKho, idGiay, soLuong, donGia, thanhTien) values(1, 1, '20', '1000000', '20000000');
insert into CHITIETNHAPKHO (idNhapKho, idGiay, soLuong, donGia, thanhTien) values(1, 2, '20', '1000000', '20000000');
insert into CHITIETNHAPKHO (idNhapKho, idGiay, soLuong, donGia, thanhTien) values(1, 3, '20', '1000000', '20000000');
insert into CHITIETNHAPKHO (idNhapKho, idGiay, soLuong, donGia, thanhTien) values(1, 4, '20', '1000000', '20000000');
insert into CHITIETNHAPKHO (idNhapKho, idGiay, soLuong, donGia, thanhTien) values(1, 5, '20', '1000000', '20000000');
insert into CHITIETNHAPKHO (idNhapKho, idGiay, soLuong, donGia, thanhTien) values(1, 12, '20', '900000', '18000000');
insert into CHITIETNHAPKHO (idNhapKho, idGiay, soLuong, donGia, thanhTien) values(1, 13, '20', '900000', '18000000');
insert into CHITIETNHAPKHO (idNhapKho, idGiay, soLuong, donGia, thanhTien) values(1, 14, '20', '900000', '18000000');
insert into CHITIETNHAPKHO (idNhapKho, idGiay, soLuong, donGia, thanhTien) values(1, 15, '20', '900000', '18000000');
insert into CHITIETNHAPKHO (idNhapKho, idGiay, soLuong, donGia, thanhTien) values(1, 16, '20', '900000', '18000000');
go

create table dbo.KHACHHANG
(
	idKH int identity(1,1) primary key,
	tenKH nvarchar(150) not null,
	sdt varchar(20) not null,
	tongTien float not null default 0,
	status int not null default 1,
)
go

insert into KHACHHANG(tenKH, sdt) values(N'Nguyễn Văn A', '0326526984');
insert into KHACHHANG(tenKH, sdt) values(N'Nguyễn Thị B', '0962333621');
insert into KHACHHANG(tenKH, sdt) values(N'Trần Văn C', '0946312497');
insert into KHACHHANG(tenKH, sdt) values(N'Lý Hiển Long', '0389421573');
go

create table dbo.HOADON
(
	idHoaDon int identity(1,1) primary key,
	idNV int foreign key references dbo.NHANVIEN (idNV),
	idKH int foreign key references dbo.KHACHHANG (idKH),
	ngayInHoaDon date not null,
	soLuong int not null default 0,
	thanhTien float not null default 0,
	status int not null default 1,
)
go

insert into HOADON(idNV, idKH, ngayInHoaDon) values(1, 1, '12/18/2020');
go

create table dbo.CHITIETHOADON
(
	idChiTietHoaDon int identity(1,1) primary key,
	idHoaDon int foreign key references dbo.HOADON(idHoaDon),
	idGiay int foreign key references dbo.GIAY (idGiay),
	donGia float not null,
	soLuong int not null,
	thanhTien float not null,
	status int not null default 1,
)
go

insert into CHITIETHOADON(idHoaDon, idGiay, donGia, soLuong, thanhTien) values(1, 1, '1000000', 2, '2000000');
insert into CHITIETHOADON(idHoaDon, idGiay, donGia, soLuong, thanhTien) values(1, 12, '900000', 2, '1800000');
