﻿USE ShoeStore
-- tạo nhóm quyền
CREATE ROLE Adminitrator
CREATE ROLE NhanVien
-- cấp quyền cho nhóm
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.CHITIETHOADON TO Adminitrator WITH GRANT OPTION
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.CHITIETNHAPKHO TO Adminitrator WITH GRANT OPTION
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.GIAY TO Adminitrator WITH GRANT OPTION
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.HANGGIAY TO Adminitrator WITH GRANT OPTION
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.HOADON TO Adminitrator WITH GRANT OPTION
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.KHACHHANG TO Adminitrator WITH GRANT OPTION
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.LOAIGIAY TO Adminitrator WITH GRANT OPTION
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.NHACUNgCAP TO Adminitrator WITH GRANT OPTION
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.NHANVIEN TO Adminitrator WITH GRANT OPTION
GRANT SELECT,INSERT,UPDATE,DELETE ON dbo.NHAPKHO TO Adminitrator WITH GRANT OPTION
Grant execute to Adminitrator
Grant Select to Adminitrator

GRANT SELECT ON dbo.KHACHHANG TO NhanVien WITH GRANT OPTION
GRANT SELECT ON dbo.GIAY TO NhanVien WITH GRANT OPTION
GRANT SELECT,INSERT ON dbo.HOADON TO NhanVien WITH GRANT OPTION
GRANT SELECT,INSERT ON dbo.CHITIETHOADON TO NhanVien WITH GRANT OPTION

-- thực thi các stored
-- tạo login
CREATE LOGIN admin2 WITH PASSWORD = '123'
CREATE LOGIN Nhanvien2 WITH PASSWORD = '123'
-- tạo user
CREATE USER  admin2 FOR LOGIN admin2
CREATE USER nhanvien2 FOR LOGIN Nhanvien2
-- phân quyền cho user
go
SP_addRoleMember 'Adminitrator','admin2'
go
SP_addRoleMember 'NhanVien','nhanvien2'
