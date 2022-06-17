Create database QuanLyBanTrangSuc
Use QuanLyBanTrangSuc

--Tạo bảng & khoá chính
Create table TaiKhoan (
	idTaiKhoan varchar(15) not null,
	matKhau varchar(12) not null,
	hoTen nvarchar(30),
	chucVu nvarchar(30),
	ngaySinh date,
	gioiTinh nvarchar(5),
	diaChi nvarchar(100),
	soDienThoai varchar(15),
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
	idCTHD varchar(10),
	idSanPham varchar(12),
	size float,
	soLuong int,
	giaNhap decimal(10),
	constraint pkCTHDNhapHang primary key (idHoaDon,idCTHD)
)

Create table HDBanHang (
	idHoaDon varchar(15),
	idTaiKhoan varchar(15),
	idKhachHang varchar(20),
	ngayBan date,
	constraint pkHDBanHang primary key (idHoaDon)
)

Create table CTHDBanHang (
	idHoaDon varchar(15),
	idCTHD varchar(10),
	idSanPham varchar(12),
	size float,
	soLuong int,
	constraint pkCTHDBanHang primary key (idHoaDon,idCTHD)
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
Create trigger insertImportInvoice on HDNhapHang for insert as
Begin
	if(Select count(*) from HDNhapHang)=1
	Begin
		Update HDNhapHang set idHoaDon ='HDN001' from HDNhapHang,inserted where HDNhapHang.ngayNhap=inserted.ngayNhap
	End
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
Create trigger insertSaleInvoice on HDBanHang for insert as
Begin
	if(Select count(*) from HDBanHang)=1
	Begin
		Update HDBanHang set idHoaDon ='HDB001' from HDBanHang,inserted where HDBanHang.ngayBan=inserted.ngayBan
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

-- Trigger for inserting CTHDNhapHang table
Go
Create trigger insertImportDetailInvoice on CTHDNhapHang for insert as
Begin
	if(Select count(*) from CTHDNhapHang,inserted where CTHDNhapHang.idHoaDon = inserted.idHoaDon) = 1
	Begin
		Update CTHDNhapHang set idCTHD = 'CTHDN001' from CTHDNhapHang,inserted where CTHDNhapHang.idHoaDon=inserted.idHoaDon
	End
	Else
	Begin
		declare @lasted int = (select top 1 right(CTHDNhapHang.idCTHD,3) from CTHDNhapHang,inserted where CTHDNhapHang.idHoaDon=inserted.idHoaDon order by CTHDNhapHang.idCTHD desc)
		if(@lasted > 0 and @lasted <9)
		update CTHDNhapHang set idCTHD='CTHDN00'+convert(varchar(10),@lasted+1) from CTHDNhapHang,inserted where CTHDNhapHang.idHoaDon=inserted.idHoaDon and CTHDNhapHang.idCTHD=''
		else if(@lasted >= 9 and @lasted <99)
		update CTHDNhapHang set idCTHD='CTHDN0'+convert(varchar(10),@lasted+1) from CTHDNhapHang,inserted where CTHDNhapHang.idHoaDon=inserted.idHoaDon and CTHDNhapHang.idCTHD=''
		else if(@lasted >= 99 and @lasted <999)
		update CTHDNhapHang set idCTHD='CTHDN'+convert(varchar(10),@lasted+1) from CTHDNhapHang,inserted where CTHDNhapHang.idHoaDon=inserted.idHoaDon and CTHDNhapHang.idCTHD=''
	End
End

Insert into CTHDNhapHang values ('HDN003','','SP001',29,10,1500000)

-- Trigger for inserting CTHDBanHang table
Go
Alter trigger insertSaleDetailInvoice on CTHDBanHang for insert as
Begin
	if(Select count(*) from CTHDBanHang,inserted where CTHDBanHang.idHoaDon= inserted.idHoaDon) = 1
	Begin
		Update CTHDBanHang set idCTHD = 'CTHDN001' from CTHDBanHang,inserted where CTHDBanHang.idHoaDon=inserted.idHoaDon
	End
	Else
	Begin
		declare @lasted int = (select top 1 right(CTHDBanHang.idCTHD,3) from CTHDBanHang,inserted where CTHDBanHang.idHoaDon=inserted.idHoaDon order by CTHDBanHang.idCTHD desc)
		if(@lasted > 0 and @lasted <9)
		update CTHDBanHang set idCTHD='CTHDN00'+convert(varchar(10),@lasted+1) from CTHDBanHang,inserted where CTHDBanHang.idHoaDon=inserted.idHoaDon and CTHDBanHang.idCTHD=''
		else if(@lasted >= 9 and @lasted <99)
		update CTHDBanHang set idCTHD='CTHDN0'+convert(varchar(10),@lasted+1) from CTHDBanHang,inserted where CTHDBanHang.idHoaDon=inserted.idHoaDon and CTHDBanHang.idCTHD=''
		else if(@lasted >= 99 and @lasted <999)
		update CTHDBanHang set idCTHD='CTHDN'+convert(varchar(10),@lasted+1) from CTHDBanHang,inserted where CTHDBanHang.idHoaDon=inserted.idHoaDon and CTHDBanHang.idCTHD=''
	End
End



Insert into TaiKhoan values ('stf01','123a','Davolio Nancy','staff','1948-12-08','female','507 - 20th Ave. E.  Apt. 2A Seattle','(206) 555-9857'),
('mng01','123a','Fuller Andrew','manage','1952-02-19','male','908 W. Capital Way Tacoma','(206) 555-9482'),
('stf02','123a','Leverling Janet','staff','1963-08-30','female','722 Moss Bay Blvd. Kirkland','(206) 555-3412'),
('mng02','123a','Peacock	Margaret','manage','1937-09-19','male','4110 Old Redmond Rd. Redmond','(206) 555-8122'),
('stf03','123a','Buchanan Steven','staff','1955-03-04','male','14 Garrett Hill London','(71) 555-4848')

Insert into DanhMuc values ('','Ring')
Insert into DanhMuc values('','Necklace')
Insert into DanhMuc values('','Bracelet')
Insert into DanhMuc values('','Earring')

Insert into SanPham values ('','DM001','Daily Stacker Ring')
Insert into SanPham values ('','DM001','Duet Ring')
Insert into SanPham values ('','DM003','Coastal Green Aventurine Bracelet')
Insert into SanPham values ('','DM003','Round Topaz Bracelet')
Insert into SanPham values ('','DM004','Block Large Hoops')
Select * from SanPham

Insert into ChiTietSanPham values ('SP001',28,2500000,20,1)
Insert into ChiTietSanPham values ('SP001',29,2500000,10,1)
Insert into ChiTietSanPham values ('SP001',27,2500000,10,1)
Insert into ChiTietSanPham values ('SP003',30,3000000,15,1)
Insert into ChiTietSanPham values ('SP003',31,3500000,16,1)
Select * from ChiTietSanPham
Select SP.idSanPham,SP.tenSanPham,CTSP.size,CTSP.giaBan,SP.idDanhMuc,CTSP.soLuong,CTSP.TrangThai from SanPham SP,ChiTietSanPham CTSP where SP.idSanPham=CTSP.idSanPham and trangThai=1
Insert into HDNhapHang(idHoaDon,idTaiKhoan) values ('','stf01')
Insert into HDNhapHang(idHoaDon,idTaiKhoan) values ('','stf03')
select * from HDNhapHang

Insert into CTHDNhapHang values ('HDN001','','SP001',27,20,400000)
Insert into CTHDNhapHang values ('HDN001','','SP001',28,10,450000)
Insert into CTHDNhapHang values ('HDN001','','SP001',29,15,490000)
Insert into CTHDNhapHang values ('HDN003','','SP003',30,10,300000)
Insert into CTHDNhapHang values ('HDN003','','SP003',31,20,450000)
Select * from CTHDNhapHang

Insert into KhachHang values ('','Alfreds Futterkiste','030-0074321')
Insert into KhachHang values ('','Ana Trujillo Emparedados','(5) 555-4729')
Insert into KhachHang values ('','Antonio Moreno Taquería','(5) 555-3932')
Insert into KhachHang values ('','Around the Horn','(171) 555-7788')	
Insert into KhachHang values ('','Berglunds snabbköp','0921-12 34 65')
Select * from KhachHang

Insert into HDBanHang(idHoaDon,idTaiKhoan,idKhachHang) values ('','stf01','KH001')
Insert into HDBanHang(idHoaDon,idTaiKhoan,idKhachHang) values ('','stf01','KH002')
Insert into HDBanHang(idHoaDon,idTaiKhoan,idKhachHang) values ('','stf02','KH003')
Insert into HDBanHang(idHoaDon,idTaiKhoan,idKhachHang) values ('','stf02','KH004')
Insert into HDBanHang(idHoaDon,idTaiKhoan,idKhachHang) values ('','stf03','KH005')
Select * from HDBanHang

Insert into CTHDBanHang values ('HDB001','','SP001',27,2)
Insert into CTHDBanHang values ('HDB002','','SP001',27,1)
Insert into CTHDBanHang values ('HDB003','','SP003',30,1)
Insert into CTHDBanHang values ('HDB004','','SP003',31,2)
Insert into CTHDBanHang values ('HDB004','','SP001',29,2)
Select * from CTHDBanHang

-- Query for DataGridView
select sp.idSanPham,tenSanPham,size,giaBan,soLuong from SanPham sp, ChiTietSanPham ctsp
where sp.idSanPham = ctsp.idSanPham
--Cart
select sp.idSanPham,tenSanPham,size,giaBan,soLuong from SanPham sp, ChiTietSanPham ctsp
where sp.idSanPham = ctsp.idSanPham
--Order
select hdbh.idHoaDon,sp.tenSanPham,ctsp.size,tk.hoTen,kh.hoTen,ctsp.soLuong,giaBan,ngayBan
from HDBanHang hdbh, KhachHang kh,CTHDBanHang ctbh, SanPham sp, TaiKhoan tk,ChiTietSanPham ctsp
where tk.idTaiKhoan = hdbh.idTaiKhoan and hdbh.idKhachHang = kh.idKhachHang and hdbh.idHoaDon = ctbh.idHoaDon
and ctbh.size = ctsp.size and ctsp.idSanPham = sp.idSanPham
--Manager Staff
select *from TaiKhoan
--Manager Product
select sp.idSanPham,sp.tenSanPham,ctsp.size,ctnh.giaNhap,ctsp.giaBan,ctsp.soLuong,tenDanhMuc,ngayNhap
from SanPham sp, ChiTietSanPham ctsp, CTHDNhapHang ctnh, DanhMuc dm, HDNhapHang hdnh
where sp.idSanPham = ctsp.idSanPham and sp.idDanhMuc = dm.idDanhMuc and ctsp.size = ctnh.size and ctsp.idSanPham = ctnh.idSanPham
and ctnh.idHoaDon = hdnh.idHoaDon
--Manager Product(Danh muc)
select * from DanhMuc
--Analytics
select hdbh.idHoaDon, ctbh.idCTHD, tenSanPham,ctbh.size,ctbh.soLuong, ctsp.giaBan
from HDBanHang hdbh, CTHDBanHang ctbh, ChiTietSanPham ctsp, SanPham sp
where hdbh.idHoaDon = ctbh.idHoaDon and ctbh.size = ctsp.size and ctsp.idSanPham = sp.idSanPham
