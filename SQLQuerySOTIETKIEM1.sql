create database Saving_Money1
GO
use Saving_Money1
GO
Create table SoTietKiem (
	MaSo			int				not null,
	CMND			nvarchar(12)	not null,
	KhachHang		nvarchar(20)	not null,
	DiaChi			nvarchar(50)	not null,
	LoaiTK			nvarchar(20)	not null,
	SoTienGui		int				not null,
	NgayMoSo		date			not null,
	Primary Key(MaSo),
);
GO
insert into SoTietKiem values
(001, 092202020234, N'HOÀNG ANH', N'Xã an thới đông, Huyện Cần Giời , TP.HCM' , N'Kỳ hạn 3 tháng', 1000000, '2021-07-30'),
(002, 092545454655, N'Trần Hoàng Nam', N'Phường 4, Quận 12 , TP.HCM' , N'Kỳ hạn 6 tháng', 5000000, '2021-05-30'),
(003, 092653455422, N'Nguyễn Tấn Tài', N'Phường 12 , Quận Bình Thạnh , TP.HCM' , N'Kỳ hạn 12 tháng', 4000000, '2021-04-10'),
(004, 092567444334, N'Trần Anh Hoàng', N'Xã an bình, Huyện Cần Giời , TP.HCM' , N'Kỳ hạn 6 tháng', 500000, '2021-06-23'),
(005, 092579607655, N'Võ Anh Tuấn', N'Xã an hòa, Huyện Cần Giời , TP.HCM' , N'Không kỳ hạn', 200000, '2021-09-10'),
(006, 092677007543, N'Đõ Hoàng Long', N'Phường 5, Quận Thủ Đức , TP.Đồng Nai' , N'Kỳ hạn 12 tháng', 800000, '2021-01-26'),
(007, 092576895430, N'Nguyễn Tuẫn', N'Xã an thới đông, Huyện Cần Giời , TP.HCM' , N'Kỳ hạn 6 tháng', 2000000, '2021-07-23')
GO
Create table PhieuGuiTien(
	MaSo			int				not null,
	KhachHang		nvarchar(20)	not null,
	NgayGui			date			not null,
	SoTienGui		int				not null,
	Foreign Key (MaSo) References SoTietKiem(MaSo),
);
GO
insert into PhieuGuiTien values
(001, N'HOÀNG ANH', '2021-08-23', 200000),
(002, N'Trần Hoàng Nam', '2021-09-12', 300000)

GO
Create table PhieuRutTien(
	MaSo			int				not null,
	KhachHang		nvarchar(20)	not null,
	NgayRut			date			not null,
	SoTienGui		int				not null,
	Foreign Key (MaSo) References SoTietKiem(MaSo),
);
Go
insert into PhieuRutTien values
(001, N'HOÀNG ANH', '2021-12-25', 100000),
(002, N'Trần Hoàng Nam', '2021-11-22', 300000)
Go


Create table BCDanhSachHDNgay
(
	LoaiTietKiem	nvarchar(20)	,
	Ngay			date			 null,
	TongThu			int				 null,
	TongChi			int			     null,
	Chechlech		int				 null,
);

go
insert into BCDanhSachHDNgay values
(N'Kỳ hạn 3 tháng', '2021-12-25', 20000, 1000, 1000),
(N'Kỳ hạn 6 tháng', '2021-12-25', 40000, 1000, 3000),
(N'Kỳ hạn 12 tháng', '2021-12-25', 40000, 2000, 2000)

Create table BCDanhSachHDThang(
	LoaiTietKiem	nvarchar(20)	not null,	
	Ngay			date			not null,
	SoMo			int				not null,
	SoDong			int				not null,
	Chenhlech		int				not null,
	--Foreign Key (LoaiTietKiem) References DanhSachSTK(LoaiTietKiem),
)
CREATE TABLE DANGNHAP
(
      Dangnhap NVARCHAR(100) primary key,
	  MatKhau NVARCHAR (50),
	  LoaiTK NVARCHAR(20),
)

insert into DANGNHAP values
('Anh' , 123, N'Quản Lí'),
('Tuan' , 147, N'Nhân Viên')

CREATE TABLE LOAITK
(
	MaSo int primary key,
	LoaiTk nvarchar(20),
	PhanTr float,	
)
go
CREATE TABLE BaoCaothu
(
	MaSo int primary key,
	LoaiTietKiem	nvarchar(20)	,
	Ngay			date			 null,
	TongThu			int				 null,		
)

CREATE TABLE BaoCaochi
(
	MaSo int primary key,
	LoaiTietKiem	nvarchar(20)	,
	Ngay			date			 null,
	Tongchi			int				 null,		
)
CREATE TABLE ThoiGian
(
	MaSo int,
	Ngay int
)

CREATE TABLE SoTien
(
	SoTienTt NVARCHAR(20)
)
drop table BaoCaothu

insert into  LOAITK values
(1,N'Kỳ hạn 3 tháng' , 0.5),
(2,N'Kỳ hạn 6 tháng' , 0.55)




create procedure LOAITK_SET
@MaSo int
as
	begin 
			SELECT [MaSo]
				,[LoaiTk]
				,[PhanTr]
			From LOAITK
			WHERE MaSo=@MaSo
	end
