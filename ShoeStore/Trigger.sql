--Trigger:
-- 1.Kiểm tra ràng buộc email--
create trigger tg_kiemtraemail ON NHANVIEN
For insert, update
AS
DECLARE @email varchar (50)
SELECT @email = ne.email
From inserted ne
if (@email not like '%@%')
BEGIN
Print (N'Nhập sai email. 
		Vui lòng nhập lại ')
Rollback
END

--2.Trigger thêm chi tiết nhập kho
create trigger tr_insertCTNK on CHITIETNHAPKHO
for insert
as
begin 
	declare @soluong int, 
	@dongia float,
	@idgiay int, 
	@idChiTietPNK int,
	@idNhapKho int

	select @soluong=ne.soLuong,
		@dongia=ne.donGia,
		@idgiay = ne.idGiay,
		@idChiTietPNK=idChiTietPNK,
		@idNhapKho=idNhapKho
	from inserted ne

	update GIAY
	set soLuongGiay = soLuongGiay + @soluong
	where idGiay = @idgiay

	update CHITIETNHAPKHO
	set thanhTien=@soluong*@dongia
	where idChiTietPNK=@idChiTietPNK

	update NHAPKHO
	set soLuong=soluong+@soluong,
		thanhTien = thanhtien+(@soluong*@dongia)
	where idNhapKho=@idNhapKho
end

--3.Trigger cập nhật/xoá chi tiết nhập kho
go
create trigger tr_updateCTNK on CHITIETNHAPKHO
for update
as
declare @statusne int, @statusol int,
	@soluongthaydoi int,
	@idgiay int,
	@idNhapKho int,
	@idChiTietPNK int,
	@dongia float,
	@soluongChiTietM int
select  @statusne =ne.status, @statusol =ol.status, 
	@soluongthaydoi=ne.soLuong - ol.soLuong,
	@dongia=ne.dongia,
	@soluongChiTietM=ne.soluong,
	@idgiay =ne.idGiay,
	@idNhapKho =ne.idNhapKho, 
	@idChiTietPNK=ne.idChiTietPNK
from deleted ol ,inserted ne
where ol.idChiTietPNK=ne.idChiTietPNK
if(@statusne=1 and @statusol=1) --update
	begin

	update CHITIETNHAPKHO
	set thanhTien = thanhTien + @dongia*@soluongthaydoi
	where idChiTietPNK=@idChiTietPNK

	update NHAPKHO
	set soLuong = soLuong + @soluongthaydoi ,
		thanhTien = thanhTien + @dongia*@soluongthaydoi
	where idNhapKho = @idNhapKho
	
	update GIAY
	set soLuongGiay = soLuongGiay + @soluongthaydoi
	where idGiay=@idgiay
	end
else if(@statusol=1 and @statusne=0) --xoa
	begin
	update CHITIETNHAPKHO
	set thanhTien = 0,
	soLuong = 0,
	donGia = 0,
	status = 0
	where idChiTietPNK=@idChiTietPNK

	update NHAPKHO
	set soLuong = soLuong - @soluongChiTietM ,
		thanhTien = thanhTien - @dongia*@soluongChiTietM
	where idNhapKho = @idNhapKho

	update GIAY
	set soLuongGiay = soLuongGiay - @soluongChiTietM
	where idGiay=@idgiay
	end
else if(@statusol=0 and @statusne=1) --Không cho khôi phục
begin
	update CHITIETNHAPKHO
	set thanhTien = 0,
	soLuong = 0,
	donGia = 0,
	status = 0
	where idChiTietPNK=@idChiTietPNK
end
else if(@statusol=0 and @statusne=0) --Không cho tác động khi đã xoá
begin
	update CHITIETNHAPKHO
	set thanhTien = 0,
	soLuong = 0,
	donGia = 0,
	status = 0
	where idChiTietPNK=@idChiTietPNK
end
--4.Trigger thêm chi tiết hoá đơn
go
create trigger tr_insertCTHD on CHITIETHOADON
for insert
as
begin 
	declare @soluong int, 
	@dongia float,
	@idgiay int, 
	@idChiTietHoaDon int,
	@idHoaDon int,
	@soluongthaydoi int

	select @soluong=ne.soLuong,
		@dongia=ne.donGia,
		@idgiay = ne.idGiay,
		@idChiTietHoaDon=idChiTietHoaDon,
		@idHoaDon=idHoaDon
	from inserted ne

	update GIAY
	set soLuongGiay = soLuongGiay - @soluong
	where idGiay = @idgiay

	update CHITIETHOADON
	set thanhTien=@soluong*@dongia
	where idChiTietHoaDon=@idchiTietHoaDon

	update HOADON
	set soLuong=soluong+@soluong,
		thanhTien = thanhtien+(@soluong*@dongia)
	where idHoaDon=@idHoaDon
end
--5.Trigger cập nhật/xoá chi tiết hoá đơn
go
create trigger tr_updateCTHD on CHITIETHOADON
for update
as
declare @statusne int, @statusol int,
	@soluongthaydoi int,
	@idgiay int,
	@idhoadon int,
	@idChiTietHoaDon int,
	@dongia float,
	@soluongChiTietM int
select @statusne =ne.status, @statusol =ol.status, 
	@soluongthaydoi=ne.soLuong - ol.soLuong,
	@dongia=ne.dongia,
	@soluongChiTietM=ne.soluong,
	@idgiay =ne.idGiay,
	@idhoadon =ne.idHoaDon, 
	@idChiTietHoaDon=ne.idChiTietHoaDon
from deleted ol ,inserted ne
where ol.idChiTietHoaDon=ne.idChiTietHoaDon
if(@statusne=1 and @statusol=1) --update
	begin
	update CHITIETHOADON
	set thanhTien = thanhTien + @dongia*@soluongthaydoi
	where idChiTietHoaDon=@idChiTietHoaDon

	update HOADON
	set soLuong = soLuong + @soluongthaydoi ,
		thanhTien = thanhTien + @dongia*@soluongthaydoi
	where idHoaDon = @idhoadon

	update GIAY
	set soLuongGiay = soLuongGiay - @soluongthaydoi
	where idGiay=@idgiay
	end
else if(@statusol=1 and @statusne=0) --xoa
	begin
	update CHITIETHOADON
	set thanhTien = 0,
	soLuong = 0,
	donGia = 0
	where idChiTietHoaDon=@idChiTietHoaDon

	update HOADON
	set soLuong = soLuong - @soluongChiTietM ,
		thanhTien = thanhTien - @dongia*@soluongChiTietM
	where idHoaDon = @idhoadon

	update GIAY
	set soLuongGiay = soLuongGiay + @soluongChiTietM
	where idGiay=@idgiay
	end
else if(@statusol=0 and @statusne=1) --Không cho khôi phục
	begin
	update CHITIETHOADON
	set thanhTien = 0,
	soLuong = 0,
	donGia = 0
	where idChiTietHoaDon=@idChiTietHoaDon
	end
else if(@statusol=0 and @statusne=0) --Không cho tác động khi đã xoá
begin
	update CHITIETHOADON
	set thanhTien = 0,
	soLuong = 0,
	donGia = 0
	where idChiTietHoaDon=@idChiTietHoaDon
end

--6.Kiểm tra tên giày nhập có bị trùng với giày cũ không--
go
CREATE TRIGGER tg_kiemtratenloaigiay ON LOAIGIAY
for insert, update
AS
DECLARE @tenLoaiGiay varchar (50)
SET @tenLoaiGiay = (SELECT ne.tenLoaiGiay from inserted ne)
DECLARE @d int
SET @d = (SELECT count(tenLoaiGiay) FROM LOAIGIAY WHERE tenLoaiGiay = @tenLoaiGiay)
if (@d >1)
BEGIN 
print (N' sản phẩm đã tồn tại')
rollback
end

--Trigger cập nhật số lượng loại giày theo số lượng giày trong kho
go
create trigger tg_soluongloaigiay ON GIAY
for insert, update
as
begin
declare @idloaigiay int, @soluonggiay int, @soluongloagiay int

select @idloaigiay = ne.idLoaiGiay
from inserted ne

select @soluonggiay = sum(soLuongGiay)
from GIAY where idLoaiGiay = @idloaigiay
group by idLoaiGiay

update LOAIGIAY
set soLuongLoaiGiay = @soluonggiay
where idLoaiGiay = @idloaigiay
end
--Trigger cập nhật tổng tiền khách hàng đã mua ở cửa hàng
go
create trigger tg_tongtienkhachhang ON HOADON
for insert, update
as
begin 
declare @idkhachhang int, @thanhtien int

select @idkhachhang = ne.idKH
from inserted ne

select @thanhtien = sum(thanhTien)
from HOADON where @idkhachhang = idKH
group by idKH

update KHACHHANG
set tongTien = @thanhtien
where idKH = @idkhachhang
end