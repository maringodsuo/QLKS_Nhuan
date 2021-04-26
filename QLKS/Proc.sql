create Proc TimLoaiPhong(@id nvarchar(20))
as
begin
Select * from LoaiPhong  
where ID like '%'+@id+'%' or Ten like '%'+@id+'%' or Gia like '%'+@id+'%' 
or SoGiuong like '%'+@id+'%' or SoNguoiToiDaTrenGiuong like '%'+@id+'%'
end


execute TimLoaiPhong t


create proc InsertLoaiPhong(@ID nvarchar(20), @Ten nvarchar(100), @Gia money, @Sogiuong int, @Songuoi int)
as
begin
insert into LoaiPhong(ID, Ten, Gia, SoGiuong, SoNguoiToiDaTrenGiuong) values(@ID, @Ten, @Gia, @Sogiuong, @Songuoi) 
end


create proc UpdateLoaiPhong(@Ten nvarchar(100), @Gia money, @Sogiuong int, @Songuoi int, @Id nvarchar(20))
as
begin
update LoaiPhong set Ten = @Ten, Gia =  @Gia , SoGiuong = @Sogiuong, SoNguoiToiDaTrenGiuong = @Songuoi
where ID = @ID  
end

create proc DeleteLoaiPhong(@ID nvarchar(20))
as
begin
Delete from LoaiPhong where ID = @ID
end


create proc LoadLoaiPhong
as
begin
select * from LoaiPhong
end

execute LoadLoaiPhong

select  Count(*) from LoaiPhong where ID = 1
----------------------------------------------------------------
create proc LoadTinhTrang
as
begin
select * from TinhTrangPhong
end

create Proc TimTinhTrangPhong(@id nvarchar(20))
as
begin
Select * from TinhTrangPhong  
where ID like '%'+@id+'%' or Ten like '%'+@id+'%'
end

create proc DeleteTinhTrang(@ID nvarchar(20))
as
begin
Delete from TinhTrangPhong where ID = @ID
end

create proc InserTinhTrang(@ID nvarchar(20), @Ten nvarchar(100))
as
begin
insert into TinhTrangPhong(ID, Ten) values(@ID, @Ten) 
end

create proc UpdateTinhTrang(@Ten nvarchar(100), @Id nvarchar(20))
as
begin
update TinhTrangPhong set Ten = @Ten where ID = @ID  
end
-------------------------------------------------------
create proc LoadDichVu
as
begin
select * from DichVu
end

create Proc TimDichVu(@id nvarchar(20))
as
begin
Select * from DichVu  
where ID like '%'+@id+'%' or Ten like '%'+@id+'%' or Gia like '%'+@id+'%'
end

create proc DeleteDichVu(@ID nvarchar(20))
as
begin
Delete from DichVu where ID = @ID
end

create proc InserDichVu(@ID nvarchar(20), @Ten nvarchar(100), @Gia money)
as
begin
insert into DichVu(ID, Ten, Gia) values(@ID, @Ten, @Gia) 
end

create proc UpdateDichVu(@Ten nvarchar(100), @Gia money,  @Id nvarchar(20))
as
begin
update DichVu set Ten = @Ten, Gia = @Gia where ID = @ID  
end
---------------------------------------------------------------
create proc LoadKhachHang
as
begin
select * from KhachHang
end

create Proc TimKhachHang(@id nvarchar(20))
as
begin
Select * from KhachHang  
where ID like '%'+@id+'%' or Ten like '%'+@id+'%' or GioiTinh like '%'+@id+'%' or Email like '%'+@id+'%'
or SDT like '%'+@id+'%' or CMND like '%'+@id+'%' or QuocTich like '%'+@id+'%' or GhiChu like '%'+@id+'%'
end

create proc DeleteKhachHang(@ID nvarchar(20))
as
begin
Delete from KhachHang where ID = @ID
end

create proc InsertKhachHang(@ID nvarchar(20), @Ten nvarchar(100), @NgaySinh date,
	@GioiTinh nvarchar(20),
	@Email nvarchar(500),
	@SDT nvarchar(15),
	@CMND int,
	@QuocTich nvarchar(50),
	@GhiChu nvarchar(20))
as
begin
insert into KhachHang(ID, Ten, NgaySinh, GioiTinh, Email, SDT, CMND, QuocTich, GhiChu) 
values(@ID, @Ten, @NgaySinh, @GioiTinh, @Email, @SDT, @CMND, @QuocTich, @GhiChu) 
end

create proc UpdateKhachHang(@Ten nvarchar(100), @NgaySinh date,
	@GioiTinh nvarchar(20),
	@Email nvarchar(500),
	@SDT nvarchar(15),
	@CMND int,
	@QuocTich nvarchar(50),
	@GhiChu nvarchar(20),
	@ID nvarchar(20))
as
begin
update dbo.KhachHang set Ten = @Ten, NgaySinh = @NgaySinh, GioiTinh=@GioiTinh, Email=@Email,
SDT=@SDT, CMND=@CMND, QuocTich=@QuocTich, GhiChu=@GhiChu where ID = @ID  
end
--------------------------------------------------------------
create proc LoadChucDanh
as
begin
select * from dbo.ChucDanh
end

create Proc TimChucDanh(@id nvarchar(20))
as
begin
Select * from ChucDanh  
where ID like '%'+@id+'%' or Ten like '%'+@id+'%' or Roles like '%'+@id+'%'
end

create proc DeleteChucDanh(@ID nvarchar(20))
as
begin
Delete from ChucDanh where ID = @ID
end

create proc InserChucDanh(@ID nvarchar(20), @Ten nvarchar(100), @Roles int)
as
begin
insert into ChucDanh(ID, Ten, Roles) values(@ID, @Ten, @Roles) 
end

create proc UpdateChucDanh(@Ten nvarchar(100), @Roles int,  @Id nvarchar(20))
as
begin
update ChucDanh set Ten = @Ten, Roles = @Roles where ID = @ID  
END
-------------------------------------------
create proc LoadNhanVien
as
begin
select * from NhanVien
end

create Proc TimNhanVien(@id nvarchar(20))
as
begin
Select * from NhanVien  
where ID like '%'+@id+'%' or Ten like '%'+@id+'%' or GioiTinh like '%'+@id+'%' or NgaySinh like '%'+@id+'%'
or SDT like '%'+@id+'%' or DiaChi like '%'+@id+'%' or IDChucDanh like '%'+@id+'%'
end

create proc DeleteNhanVien(@ID nvarchar(20))
as
begin
Delete from NhanVien where ID = @ID
end

create proc InsertNhanVien(@ID nvarchar(20), @Ten nvarchar(100), @NgaySinh date,
	@GioiTinh nvarchar(20),
	@DiaChi nvarchar(500),
	@SDT nvarchar(15),
	@Matkhau nvarchar(100),
	@IDChucDanh nvarchar(20))
as
begin
insert into NhanVien(ID, Ten, NgaySinh, GioiTinh, DiaChi, SDT, Matkhau, IDChucDanh) 
values(@ID, @Ten, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @Matkhau, @IDChucDanh) 
end

create proc UpdateNhanVien(@Ten nvarchar(100), @NgaySinh date,
	@GioiTinh nvarchar(20),
	@DiaChi nvarchar(500),
	@SDT nvarchar(15),
	@Matkhau nvarchar(100),
	@IDChucDanh nvarchar(20),
	@ID nvarchar(20))
as
begin
update dbo.NhanVien set Ten = @Ten, NgaySinh = @NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi,
SDT=@SDT, Matkhau=@Matkhau, IDChucDanh=@IDChucDanh where ID = @ID  
END
---------------------------------
create proc LoadPhong
as
begin
select Phong.ID, Phong.Ten AS TenPhong, LoaiPhong.Ten AS LoaiPhong, TinhTrangPhong.Ten AS TinhTrang FROM dbo.Phong, dbo.LoaiPhong, dbo.TinhTrangPhong
WHERE IDLoai=LoaiPhong.ID AND IDTinhTrang=TinhTrangPhong.ID 
end

create Proc TimPhong(@id nvarchar(20))
as
begin
select Phong.ID, Phong.Ten AS TenPhong, LoaiPhong.Ten AS LoaiPhong, TinhTrangPhong.Ten AS TinhTrang FROM dbo.Phong, dbo.LoaiPhong, dbo.TinhTrangPhong
WHERE IDLoai=LoaiPhong.ID AND IDTinhTrang=TinhTrangPhong.ID
AND (Phong.ID like '%'+@id+'%' or Phong.Ten like '%'+@id+'%' or LoaiPhong.Ten like '%'+@id+'%' or TinhTrangPhong.Ten like '%'+@id+'%')
END

create proc DeletePhong(@ID nvarchar(20))
as
begin
Delete from Phong where ID = @ID
end

create proc InserPhong(@ID nvarchar(20), @Ten nvarchar(100), @IDLoai nvarchar(20), @IDTinhTrang nvarchar(20))
as
begin
insert into Phong(ID, Ten, IDLoai, IDTinhTrang) values(@ID, @Ten, @IDLoai, @IDTinhTrang) 
end

create proc UpdatePhong(@Ten nvarchar(100), @IDLoai nvarchar(20), @IDTinhTrang nvarchar(20), @ID nvarchar(20))
as
begin
update dbo.Phong set Ten = @Ten, IDLoai = @IDLoai, IDTinhTrang= @IDTinhTrang WHERE ID = @ID  
END
-------------------------------------
CREATE PROC LoadThuePhong
AS
BEGIN
select Phong.ID, Phong.Ten AS TenPhong, SoGiuong, SoNguoiToiDaTrenGiuong,LoaiPhong.Ten AS LoaiPhong,dbo.LoaiPhong.Gia, TinhTrangPhong.Ten AS TinhTrang 
FROM dbo.Phong, dbo.LoaiPhong, dbo.TinhTrangPhong
WHERE IDLoai=LoaiPhong.ID AND IDTinhTrang=TinhTrangPhong.ID
END

EXECUTE  LoadThuePhong

create proc TimRole(@ID nvarchar(100), @Pass nvarchar(100) )
as 
begin
select Roles from  NhanVien, ChucDanh 
where  NhanVien.IDChucDanh = ChucDanh.ID and dbo.NhanVien.ID = @ID and dbo.NhanVien.Matkhau = @Pass
end
GO
create proc TimTenNV(@ID nvarchar(100), @Pass nvarchar(100) )
as 
begin
SELECT * FROM dbo.NhanVien WHERE ID = @ID AND Matkhau = @Pass
end
GO
EXECUTE TimTenNV 1,1
----------------------------------------------------------
create proc LoadPhieuThue
as
begin
select PhieuThuePhong.ID, dbo.KhachHang.Ten AS TenKhachHang, Phong.Ten AS TenPhong, NgayThue, NgayKetThuc, TienCoc, TinhTrang, NhanVien.Ten AS TenNhanVien
FROM dbo.PhieuThuePhong, dbo.Phong, dbo.NhanVien, dbo.KhachHang
WHERE PhieuThuePhong.IDPhong = dbo.Phong.ID AND dbo.PhieuThuePhong.IDNhanVien = dbo.NhanVien.ID AND KhachHang.ID = dbo.PhieuThuePhong.IDKhachHang
end

create Proc TimPhieuThue(@id nvarchar(20))
as
begin
select PhieuThuePhong.ID, dbo.KhachHang.Ten AS TenKhachHang, Phong.Ten AS TenPhong, NgayThue, NgayKetThuc, TienCoc, TinhTrang, NhanVien.Ten AS TenNhanVien
FROM dbo.PhieuThuePhong, dbo.Phong, dbo.NhanVien, dbo.KhachHang
WHERE PhieuThuePhong.IDPhong = dbo.Phong.ID AND dbo.PhieuThuePhong.IDNhanVien = dbo.NhanVien.ID AND KhachHang.ID = dbo.PhieuThuePhong.IDKhachHang
AND (dbo.PhieuThuePhong.ID like '%'+@id+'%' or dbo.Phong.Ten like '%'+@id+'%' OR dbo.KhachHang.Ten like '%'+@id+'%'
		OR TienCoc like '%'+@id+'%' OR TinhTrang like '%'+@id+'%' OR dbo.NhanVien.Ten like '%'+@id+'%')
END


create proc DeletePhieuThue(@ID nvarchar(20))
as
begin
Delete from dbo.PhieuThuePhong where ID = @ID
end

create proc InsertPhieuThue(@ID nvarchar(20), @IDKhachHang nvarchar(20), @IDPhong nvarchar(20), @NgayThue DATE, @NgayKetThuc DATE, @TienCoc MONEY, @TinhTrang NVARCHAR(20), @IDNhanVien NVARCHAR(20))
as
begin
insert into PhieuThuePhong(ID,IDKhachHang, IDPhong, NgayThue, NgayKetThuc, TienCoc, TinhTrang, IDNhanVien ) 
		VALUES(@ID, @IDKhachHang, @IDPhong, @NgayThue, @NgayKetThuc, @TienCoc, @TinhTrang, @IDNhanVien) 
end

create proc UpdatePhieuThue(@ID nvarchar(20), @IDKhachHang nvarchar(20), @IDPhong nvarchar(20), @NgayThue DATE, @NgayKetThuc DATE, @TienCoc MONEY, @TinhTrang NVARCHAR(20), @IDNhanVien NVARCHAR(20))
as
begin
update dbo.PhieuThuePhong set IDKhachHang=@IDKhachHang,IDPhong=@IDPhong, NgayThue=@NgayThue, NgayKetThuc=@NgayKetThuc, 
		TienCoc=@TienCoc, TinhTrang=@TinhTrang, IDNhanVien=@IDNhanVien WHERE ID = @ID  
END
------------------------------
CREATE PROC ThongKe(@tu date, @den date)
AS
begin
select PhieuThuePhong.ID, dbo.KhachHang.Ten AS TenKhachHang, Phong.Ten AS TenPhong, NgayThue, NgayKetThuc, TienCoc, TinhTrang, NhanVien.Ten AS TenNhanVien
FROM dbo.PhieuThuePhong, dbo.Phong, dbo.NhanVien, dbo.KhachHang 
WHERE PhieuThuePhong.IDPhong = dbo.Phong.ID AND dbo.PhieuThuePhong.IDNhanVien = dbo.NhanVien.ID AND KhachHang.ID = dbo.PhieuThuePhong.IDKhachHang
AND  NgayThue >= @tu AND NgayThue <= @den
END

CREATE PROC LoadTheoIDThue(@id nvarchar(20))
AS
BEGIN
select PhieuThuePhong.ID, dbo.KhachHang.Ten AS TenKhachHang, Phong.Ten AS TenPhong, NgayThue, NgayKetThuc, TienCoc, TinhTrang, NhanVien.Ten AS TenNhanVien
FROM dbo.PhieuThuePhong, dbo.Phong, dbo.NhanVien, dbo.KhachHang
WHERE PhieuThuePhong.IDPhong = dbo.Phong.ID AND dbo.PhieuThuePhong.IDNhanVien = dbo.NhanVien.ID AND KhachHang.ID = dbo.PhieuThuePhong.IDKhachHang 
AND PhieuThuePhong.ID = @id
END

--------------------
CREATE PROC TimNVXoa(@id nvarchar(20))
AS
BEGIN
SELECT * FROM dbo.NhanVien WHERE IDChucDanh = @id
END 

CREATE PROC TimLPXoa(@id nvarchar(20))
AS
BEGIN
SELECT * FROM dbo.LoaiPhong WHERE ID = @id
END
CREATE PROC MaxID
AS
begin
SELECT MAX(ID) FROM dbo.PhieuThuePhong
end

CREATE PROC InsertPDV(@TongTien money, @NgayLap date, @GhiChu nvarchar(500), @IDPhieuThue nvarchar(20), @IDNhanVien nvarchar(20))
AS
BEGIN
INSERT INTO dbo.PhieuDichvu
(
    TongTien,
    NgayLap,
    GhiChu,
    IDPhieuThue,
	IDNhanVien
)
VALUES
(@TongTien,@NgayLap,@GhiChu,@IDPhieuThue, @IDNhanVien)
END

CREATE PROC LoadPDV
AS
BEGIN
SELECT dbo.PhieuDichvu.ID, IDPhieuThue, TongTien, NgayLap, Ten, GhiChu AS GhiChu1 FROM dbo.PhieuDichvu, dbo.NhanVien WHERE dbo.NhanVien.ID = IDNhanVien
END



CREATE PROC XoaPDV(@id int)
AS
BEGIN
DELETE FROM dbo.PhieuDichvu WHERE id = @id
end

EXEC XoaPDV 2
CREATE PROC LoadHoaDon
AS
BEGIN
SELECT HoaDon.ID, KhachHang.Ten AS TenKhachHang, IDThue,IDDichVu, TongTien, NgayThanhToan, NhanVien.Ten AS TenNhanVien FROM dbo.HoaDon,dbo.NhanVien, dbo.KhachHang, dbo.PhieuThuePhong
WHERE dbo.PhieuThuePhong.IDNhanVien=NhanVien.ID AND dbo.PhieuThuePhong.IDKhachHang = dbo.KhachHang.ID AND IDThue = dbo.PhieuThuePhong.ID
END


CREATE PROC InsertHoaDon(@TongTien money,
    @NgayThanhToan date,
    @IDThue nvarchar(20),
    @IDDichVu int,
    @IDNhanVien nvarchar(20))
AS
BEGIN
INSERT INTO dbo.HoaDon(TongTien,NgayThanhToan,IDThue,IDDichVu,IDNhanVien) VALUES(@TongTien,@NgayThanhToan,@IDThue,@IDDichVu,@IDNhanVien)
END

CREATE PROC ThemHoaDon(@TongTien money,
    @NgayThanhToan date,
    @IDThue nvarchar(20),
    @IDNhanVien nvarchar(20))
AS
BEGIN
INSERT INTO dbo.HoaDon(TongTien,NgayThanhToan,IDThue,IDNhanVien) VALUES(@TongTien,@NgayThanhToan,@IDThue,@IDNhanVien)
END

CREATE PROC DeleteHoaDon(@id int)
AS
BEGIN
DELETE FROM dbo.HoaDon WHERE ID=@id
END

CREATE PROC SuaPhong(@id nvarchar(100))
AS
BEGIN
UPDATE dbo.Phong SET IDTinhTrang=2 WHERE ID = @id
END

CREATE PROC TimHoaDon(@id nvarchar(100))
AS
BEGIN
SELECT HoaDon.ID, KhachHang.Ten AS TenKhachHang, IDThue,IDDichVu, TongTien, NgayThanhToan, NhanVien.Ten AS TenNhanVien FROM dbo.HoaDon,dbo.NhanVien, dbo.KhachHang, dbo.PhieuThuePhong
WHERE dbo.PhieuThuePhong.IDNhanVien=NhanVien.ID AND dbo.PhieuThuePhong.IDKhachHang = dbo.KhachHang.ID AND IDThue = dbo.PhieuThuePhong.ID
AND (dbo.HoaDon.ID like '%'+@id+'%' OR dbo.KhachHang.Ten like '%'+@id+'%' OR IDThue like '%'+@id+'%' 
OR TongTien like '%'+@id+'%' OR dbo.NhanVien.Ten like '%'+@id+'%' OR IDDichVu like '%'+@id+'%')
end


CREATE PROC ThongKeHoaDon(@tu date, @den date)
AS
begin
SELECT HoaDon.ID, KhachHang.Ten AS TenKhachHang, IDThue,IDDichVu, TongTien, NgayThanhToan, NhanVien.Ten AS TenNhanVien FROM dbo.HoaDon,dbo.NhanVien, dbo.KhachHang, dbo.PhieuThuePhong
WHERE dbo.PhieuThuePhong.IDNhanVien=NhanVien.ID AND dbo.PhieuThuePhong.IDKhachHang = dbo.KhachHang.ID AND IDThue = dbo.PhieuThuePhong.ID
AND  NgayThanhToan >= @tu AND NgayThanhToan <= @den
ENd

EXEC ThongKeHoaDon '2020/12/01', '2020/12/30' 

CREATE PROC LoadRp(@id int)
AS
BEGIN
SELECT HoaDon.ID, KhachHang.Ten AS TenKhachHang,dbo.PhieuDichvu.TongTien AS TienDichVu, NgayThue, NgayKetThuc,IDPhong, dbo.HoaDon.TongTien, NgayThanhToan, NhanVien.Ten AS TenNhanVien 
FROM dbo.HoaDon,dbo.NhanVien, dbo.KhachHang, dbo.PhieuThuePhong, dbo.PhieuDichvu
WHERE dbo.PhieuThuePhong.IDNhanVien=NhanVien.ID AND dbo.PhieuThuePhong.IDKhachHang = dbo.KhachHang.ID AND IDThue = dbo.PhieuThuePhong.ID AND dbo.HoaDon.ID = @id
END