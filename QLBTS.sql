Create database QuanLyBanTrangSuc
Use QuanLyBanTrangSuc

--Tạo bảng & khoá chính
Create table TaiKhoan (
	idTaiKhoan varchar(15) not null,
	matKhau varchar(12) not null,
	hoTen nvarchar(30),
	chucVu nvarchar(30),
	ngaySinh date,
	gioiTinh nvarchar(10),
	diaChi nvarchar(100),
	soDienThoai varchar(15),
	trangThai int
	constraint pkTaiKhoan primary key (idTaiKhoan)
)

Create table KhachHang (
	idKhachHang varchar(20),
	hoTen nvarchar(30),
	soDienThoai varchar(15),
	constraint pkKhachHang primary key (idKhachHang)
)

Create table DanhMuc (
	idDanhMuc varchar(10),
	tenDanhMuc nvarchar(30),
	constraint pkDanhMuc primary key (idDanhMuc)
)

Create table SanPham (
	idSanPham varchar(12),
	idDanhMuc varchar(10),
	tenSanPham nvarchar(40),
	constraint pkSanPham primary key (idSanPham)
)

Create table ChiTietSanPham (
	idSanPham varchar(12),
	size float,
	giaBan decimal(10),
	soLuong int,
	trangThai bit,
	constraint pkCTSP primary key (idSanPham,size)
)

Create table HDNhapHang (
	idHoaDon varchar(15),
	idTaiKhoan varchar(15),
	ngayNhap date,
	constraint pkHDNhapHang primary key (idHoaDon)
)

Create table CTHDNhapHang (
	idHoaDon varchar(15),
	idSanPham varchar(12),
	size float,
	soLuong int,
	giaNhap decimal(10),
	constraint pkCTHDNhapHang primary key (idHoaDon,idSanPham,size)
)

Create table HDBanHang (
	idHoaDon varchar(15),
	idTaiKhoan varchar(15),
	idKhachHang varchar(20),
	ngayBan date default getdate(),
	constraint pkHDBanHang primary key (idHoaDon)
)


Create table CTHDBanHang (
	idHoaDon varchar(15),
	idSanPham varchar(12),
	size float,
	soLuong int,
	constraint pkCTHDBanHang primary key (idHoaDon,idSanPham,size)
)

--Khoá ngoại
Alter table SanPham
Add constraint fkSanPham_DanhMuc foreign key (idDanhMuc) references DanhMuc (idDanhMuc)

Alter table ChiTietSanPham
Add constraint fkCTSP_SanPham foreign key (idSanPham) references SanPham (idSanPham)

Alter table HDNhapHang
Add constraint fkHDNhapHang_TaiKhoan foreign key (idTaiKhoan) references TaiKhoan (idTaiKhoan)

Alter table HDBanHang
Add constraint fkHDbanHang_TaiKhoan foreign key (idTaiKhoan) references TaiKhoan (idTaiKhoan)

Alter table HDBanHang
Add constraint fkHDBanHang_KhachHang foreign key (idKhachHang) references KhachHang (idKhachHang)

Alter table CTHDBanHang
Add constraint fkCTHDBanHang_HDBanHang foreign key (idHoaDon) references HDBanHang (idHoaDon)

Alter table CTHDNhapHang
Add constraint fkCTHDNhapHang_HDNhapHang foreign key (idHoaDon) references HDNhapHang (idHoaDon)

Alter table CTHDNhapHang
Add constraint fkCTHDNhapHang_CTSP foreign key (idSanPham,size) references ChiTietSanPham(idSanPham,size)

Alter table CTHDBanHang
Add constraint fkCTHDBanHang_CTSP foreign key (idSanPham,size) references ChiTietSanPham(idSanPham,size)


-- Trigger for inserting DanhMuc table
Go
Create trigger insertCategory on DanhMuc for insert as
Begin
	if(Select count(*) from DanhMuc)=1
	Begin
		Update DanhMuc set idDanhMuc='DM001' from DanhMuc,inserted where DanhMuc.tenDanhMuc=inserted.tenDanhMuc
	End
	else
	Begin
		declare @lasted int = (select top 1 right(idDanhMuc,3) from DanhMuc order by idDanhMuc desc)
		if(@lasted > 0 and @lasted <9)
		update DanhMuc set idDanhMuc='DM00'+convert(varchar(10),@lasted+1) where idDanhMuc =''
		else if(@lasted >= 9 and @lasted <99)
		update DanhMuc set idDanhMuc='DM0'+convert(varchar(10),@lasted+1) where idDanhMuc =''
		else if(@lasted >= 99 and @lasted <999)
		update DanhMuc set idDanhMuc='DM'+convert(varchar(10),@lasted+1) where idDanhMuc =''
	End
End

Insert into DanhMuc values ('','Ring')
Insert into DanhMuc values ('','Necklace')
Insert into DanhMuc values ('','Earring')
Insert into DanhMuc values ('','Bracelet')
Select * from DanhMuc

-- Trigger for inserting Product table
Go
Create trigger insertProduct on SanPham for insert as
Begin
	if(Select count(*) from SanPham)=1
	Begin
		Update SanPham set idSanPham='SP001' from SanPham,inserted where SanPham.tenSanPham=inserted.tenSanPham
	End
	else
	Begin
		declare @lasted int = (select top 1 right(idSanPham,3) from SanPham order by idSanPham desc)
		if(@lasted > 0 and @lasted <9)
		update SanPham set idSanPham='SP00'+convert(varchar(10),@lasted+1) where idSanPham =''
		else if(@lasted >= 9 and @lasted <99)
		update SanPham set idSanPham='SP0'+convert(varchar(10),@lasted+1) where idSanPham =''
		else if(@lasted >= 99 and @lasted <999)
		update SanPham set idSanPham='SP'+convert(varchar(10),@lasted+1) where idSanPham =''
	End
End

-- Trigger for inserting KhachHang table
Go
Create trigger insertCustomer on KhachHang for insert as
Begin
	if(Select count(*) from KhachHang)=1
	Begin
		Update KhachHang set idKhachHang ='KH001' from KhachHang,inserted where KhachHang.hoTen=inserted.hoTen
	End
	else
	Begin
		declare @lasted int = (select top 1 right(idKhachHang,3) from KhachHang order by idKhachHang desc)
		if(@lasted > 0 and @lasted <9)
		update KhachHang set idKhachHang='KH00'+convert(varchar(10),@lasted+1) where idKhachHang =''
		else if(@lasted >= 9 and @lasted <99)
		update KhachHang set idKhachHang='KH0'+convert(varchar(10),@lasted+1) where idKhachHang =''
		else if(@lasted >= 99 and @lasted <999)
		update KhachHang set idKhachHang='KH'+convert(varchar(10),@lasted+1) where idKhachHang =''
	End
End

-- Trigger for inserting HDNhapHang table
Go
alter trigger insertImportInvoice on HDNhapHang for insert as
Begin
	if(Select count(*) from HDNhapHang)=1
	Begin
		Update HDNhapHang set idHoaDon ='HDN001'
	End
	 --from HDNhapHang,inserted where HDNhapHang.ngayNhap=inserted.ngayNhap
	else
	Begin
		declare @lasted int = (select top 1 right(idHoaDon,3) from HDNhapHang order by idHoaDon desc)
		if(@lasted > 0 and @lasted <9)
		update HDNhapHang set idHoaDon='HDN00'+convert(varchar(10),@lasted+1) where idHoaDon =''
		else if(@lasted >= 9 and @lasted <99)
		update HDNhapHang set idHoaDon='HDN0'+convert(varchar(10),@lasted+1) where idHoaDon =''
		else if(@lasted >= 99 and @lasted <999)
		update HDNhapHang set idHoaDon='HDN'+convert(varchar(10),@lasted+1) where idHoaDon =''
	End
End 

-- Trigger for inserting HDBanHang table
Go
alter trigger insertSaleInvoice on HDBanHang for insert as
Begin
	if(Select count(*) from HDBanHang)=1
	Begin
		Update HDBanHang set idHoaDon ='HDB001'
	End
	else
	Begin
		declare @lasted int = (select top 1 right(idHoaDon,3) from HDBanHang order by idHoaDon desc)
		if(@lasted > 0 and @lasted <9)
		update HDBanHang set idHoaDon='HDB00'+convert(varchar(10),@lasted+1) where idHoaDon =''
		else if(@lasted >= 9 and @lasted <99)
		update HDBanHang set idHoaDon='HDB0'+convert(varchar(10),@lasted+1) where idHoaDon =''
		else if(@lasted >= 99 and @lasted <999)
		update HDBanHang set idHoaDon='HDB'+convert(varchar(10),@lasted+1) where idHoaDon =''
	End
End

Insert into TaiKhoan values ('zando','123456','Van-Do Nguyen','Manager','2002/05/07','Male','Cho Moi, An Giang','0383259886',1)

Insert into DanhMuc values ('','Ring')
Insert into DanhMuc values('','Necklace')
Insert into DanhMuc values('','Bracelet')
Insert into DanhMuc values('','Earring')

Insert into SanPham values ('','DM001','Daily Stacker Ring')
Insert into SanPham values ('','DM001','Duet Ring')
Insert into SanPham values ('','DM003','Coastal Green Aventurine Bracelet')
Insert into SanPham values ('','DM003','Round Topaz Bracelet')
Insert into SanPham values ('','DM004','Block Large Hoops')

Insert into ChiTietSanPham values ('SP001',28,2500000,20,1)
Insert into ChiTietSanPham values ('SP001',29,2500000,10,1)
Insert into ChiTietSanPham values ('SP001',27,2500000,10,1)
Insert into ChiTietSanPham values ('SP003',30,3000000,15,1)
Insert into ChiTietSanPham values ('SP003',31,3500000,16,1)

Insert into HDNhapHang(idHoaDon,idTaiKhoan) values ('','zando')

Insert into CTHDNhapHang values ('HDN001','','SP001',27,20,400000)
Insert into CTHDNhapHang values ('HDN001','','SP001',28,10,450000)
Insert into CTHDNhapHang values ('HDN001','','SP001',29,15,490000)
Insert into CTHDNhapHang values ('HDN003','','SP002',30,10,300000)
Insert into CTHDNhapHang values ('HDN003','','SP003',3,20,450000)

Insert into KhachHang values ('','Alfreds Futterkiste','030-0074321')
Insert into KhachHang values ('','Ana Trujillo Emparedados','(5) 555-4729')
Insert into KhachHang values ('','Antonio Moreno Taquería','(5) 555-3932')
Insert into KhachHang values ('','Around the Horn','(171) 555-7788')	
Insert into KhachHang values ('','Berglunds snabbköp','0921-12 34 65')

Insert into HDBanHang(idHoaDon) values ('')
Insert into HDBanHang(idHoaDon,idTaiKhoan,idKhachHang) values ('','zando','KH001')
Insert into HDBanHang(idHoaDon,idTaiKhoan,idKhachHang) values ('','stf01','KH002')
Insert into HDBanHang(idHoaDon,idTaiKhoan,idKhachHang) values ('','stf02','KH003')
Insert into HDBanHang(idHoaDon,idTaiKhoan,idKhachHang) values ('','stf02','KH004')
Insert into HDBanHang(idHoaDon,idTaiKhoan,idKhachHang) values ('','stf03','KH005')

Insert into CTHDBanHang values ('HDB001','','SP001',27,2)
Insert into CTHDBanHang values ('HDB002','','SP001',27,1)
Insert into CTHDBanHang values ('HDB003','','SP003',30,1)
Insert into CTHDBanHang values ('HDB004','','SP003',31,2)
Insert into CTHDBanHang values ('HDB004','','SP001',29,2)

delete CTHDBanHang
delete CTHDNhapHang
delete HDBanHang
delete HDNhapHang
delete TaiKhoan
delete KhachHang
delete ChiTietSanPham
delete SanPham
delete DanhMuc