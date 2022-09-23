CREATE DATABASE DATAQUANLYVETAU
go
use DATAQUANLYVETAU
go
create table Quyen
(
	MaQuyen int identity(1,1) primary key,
	TenQuyen nvarchar(100) not null,
	MoTa nvarchar(100) null,
)
go
insert into Quyen(TenQuyen, MoTa) values (N'Ban Quản Trị', N'Người quản lý hệ thống');
go
create table NguoiDung
(
	TaiKhoan varchar(50) primary key,
	MatKhau varchar(50) not null,
	SDT varchar(12) null,
	Email varchar(50) not null,
	DiaChi nvarchar(200) null, 
	MaQuyen int,

	foreign key(MaQuyen)references Quyen(MaQuyen)
)
go
insert into NguoiDung(TaiKhoan, MatKhau, SDT, Email, DiaChi, MaQuyen) values ('Admin', 'Admin', '0931010101', 'admin@gmail.com', N'Hà Nội',1);
insert into NguoiDung(TaiKhoan, MatKhau, SDT, Email, DiaChi, MaQuyen) values ('abc', 'abc', '0971234567', 'admin2@gmail.com', N'Hà Nội',1);
go
create table NhaGa
(
	MaNhaGa int identity(1,1) primary key,
	TenNhaGa nvarchar(100) not null,
	DiaChi nvarchar(255) null,
	MoTa nvarchar(255) null,
)
go
insert into NhaGa(TenNhaGa, DiaChi) values (N'Ga Hà Nội', N'120 Đ. Lê Duẩn, Khâm Thiên, Hoàn Kiếm, Hà Nội');
insert into NhaGa(TenNhaGa, DiaChi) values (N'Ga Hải Phòng', N'75 P. Lương Khánh Thiện, Lương Khá Thien, Ngô Quyền, Hải Phòng, Việt Nam');
insert into NhaGa(TenNhaGa, DiaChi) values (N'Ga Thái Nguyên', N'330 Phố, Ga Thái Nguyên, Tp. Thái Nguyên, Thái Nguyên, Việt Nam');
insert into NhaGa(TenNhaGa, DiaChi) values (N'Ga Huế', N'Sunny B. Hotel, Nguyễn Tri Phương, Street, Thành phố Huế, Thừa Thiên Huế, Việt Nam');
insert into NhaGa(TenNhaGa, DiaChi) values (N'Ga Đà Nẵng', N'791 Hải Phòng, Tam Thuận, Thanh Khê, Đà Nẵng 550000, Việt Nam');
insert into NhaGa(TenNhaGa, DiaChi) values (N'Ga Sài Gòn', N'Phường 10, Quận 3, Thành phố Hồ Chí Minh, Việt Nam');
go
create table Tau
(
	MaTau int identity(1,1) primary key,
	TenTau nvarchar(100) not null,
	SoToa int null,
	MoTa nvarchar(255) null,
)
go
insert into Tau (TenTau, SoToa, MoTa) values (N'SE1', 3, N'Tàu chở khách SE1');
insert into Tau (TenTau, SoToa, MoTa) values (N'SE2', 4, N'Tàu chở khách SE2');
insert into Tau (TenTau, SoToa, MoTa) values (N'SE3', 3, N'Tàu chở khách SE3');
insert into Tau (TenTau, SoToa, MoTa) values (N'SE4', 3, N'Tàu chở khách SE4');
insert into Tau (TenTau, SoToa, MoTa) values (N'SE5', 4, N'Tàu chở khách SE5');
go
create table LichTrinh
(
	MaLichTrinh int identity(1,1) primary key,
	NgayDi datetime default(getdate()) not null,
	GaDen nvarchar(100) not null,
	NgayDuKienDen datetime default(getdate()) not null,
	MaTau int,
	MaNhaGa int,
	foreign key(MaTau)references Tau(MaTau),
	foreign key(MaNhaGa)references NhaGa(MaNhaGa),
)
go
insert into LichTrinh (NgayDi, GaDen, NgayDuKienDen, MaTau, MaNhaGa) values (default, N'Ga Hà Nội', default, 1, 2);
insert into LichTrinh (NgayDi, GaDen, NgayDuKienDen, MaTau, MaNhaGa) values (default, N'Ga Hải Phòng', default, 2, 3);
insert into LichTrinh (NgayDi, GaDen, NgayDuKienDen, MaTau, MaNhaGa) values (default, N'Ga Thái Nguyên', default, 3, 4);
insert into LichTrinh (NgayDi, GaDen, NgayDuKienDen, MaTau, MaNhaGa) values (default, N'Ga Huế', default, 4, 5);
insert into LichTrinh (NgayDi, GaDen, NgayDuKienDen, MaTau, MaNhaGa) values (default, N'Ga Đà Nẵng', default, 5, 6);
go
create table Toa
(
	MaToa int identity(1,1) primary key,
	TenToa nvarchar(100) not null,
	SoGhe int not null,
	MaTau int,
	foreign key(MaTau)references Tau(MaTau),
)
go
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 1 (VIP)', 20, 1);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 2', 20, 1);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 3', 20, 1);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 1 (VIP)', 20, 2);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 2', 20, 2);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 3', 20, 2);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 1 (VIP)', 20, 3);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 2', 20, 3);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 3', 20, 3);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 1 (VIP)', 20, 4);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 2', 20, 4);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 3', 20, 4);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 1 (VIP)', 20, 5);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 2', 20, 5);
insert into Toa (TenToa, SoGhe, maTau) values (N'Toa 3', 20, 5);
go
create table KieuGhe
(
	MaKieuGhe int identity(1,1) primary key,
	TenKieuGhe nvarchar(100) null,
	ViTriGhe int not null,
	LePhi int null,
	TrangThai int null,
	MaToa int,
	foreign key(MaToa)references Toa(MaToa),
)
go
insert into KieuGhe (TenKieuGhe, ViTriGhe, LePhi, TrangThai, MaToa) values (N'Ghế 1', 1, 20, 0, 1);
insert into KieuGhe (TenKieuGhe, ViTriGhe, LePhi, TrangThai, MaToa) values (N'Ghế 2', 2, 0, 0, 1);
insert into KieuGhe (TenKieuGhe, ViTriGhe, LePhi, TrangThai, MaToa) values (N'Ghế 3', 3, 0, 0, 1);
insert into KieuGhe (TenKieuGhe, ViTriGhe, LePhi, TrangThai, MaToa) values (N'Ghế 4', 4, 0, 0, 1);
insert into KieuGhe (TenKieuGhe, ViTriGhe, LePhi, TrangThai, MaToa) values (N'Ghế 5', 5, 20, 0, 1);
insert into KieuGhe (TenKieuGhe, ViTriGhe, LePhi, TrangThai, MaToa) values (N'Ghế 6', 6, 20, 0, 1);
go
create table VeTau
(
	MaVeTau int identity(1,1) primary key,
	TenVeTau nvarchar(50) null,
	GiaVe float default(50000) not null,
	TrangThai int null,
	MaKieuGhe int,
	MaLichTrinh int,
	foreign key(MaKieuGhe)references KieuGhe(MaKieuGhe),
	foreign key(MaLichTrinh)references LichTrinh(MaLichTrinh)
)
go
insert into VeTau (TenVeTau, GiaVe, TrangThai, MaKieuGhe, MaLichTrinh) values (N'Vé Tàu SE', 50000, 0, 1, 1);
insert into VeTau (TenVeTau, GiaVe, TrangThai, MaKieuGhe, MaLichTrinh) values (N'Vé Tàu SE', 50000, 0, 2, 1);
insert into VeTau (TenVeTau, GiaVe, TrangThai, MaKieuGhe, MaLichTrinh) values (N'Vé Tàu SE', 50000, 0, 3, 1);
insert into VeTau (TenVeTau, GiaVe, TrangThai, MaKieuGhe, MaLichTrinh) values (N'Vé Tàu SE', 50000, 0, 4, 1);
insert into VeTau (TenVeTau, GiaVe, TrangThai, MaKieuGhe, MaLichTrinh) values (N'Vé Tàu SE', 50000, 0, 5, 1);
insert into VeTau (TenVeTau, GiaVe, TrangThai, MaKieuGhe, MaLichTrinh) values (N'Vé Tàu SE', 50000, 0, 6, 1);
go
create table PhieuDatVe
(
	MaPhieuDatve int identity(1,1) primary key,
	HoTen nvarchar(100) not null,
	CCCD varchar(20) null,
	NgayDat datetime default(getdate()) null,
	HinhThucThanhToan int default(0) null, -- 0: thanh toán khi nhận vé tại quầy ga
	TrangThai int default(0) null, -- 0: đã thanh toán, 1: chưa thanh toán
	GaDi nvarchar(100) null,
	GaDen nvarchar(100) null,
	TongTien float null,
	TaiKhoan varchar(50), 
)
go
insert into PhieuDatVe (HoTen, CCCD, NgayDat, HinhThucThanhToan, TrangThai, GaDi, GaDen, TongTien, TaiKhoan)
values (N'Nhật Minh', '1234567890', default, 0, 0, 1, 2, 50000, 'Admin');
insert into PhieuDatVe (HoTen, CCCD, NgayDat, HinhThucThanhToan, TrangThai, GaDi, GaDen, TongTien, TaiKhoan)
values (N'Thu Huyền', '0123456789', default, 0, 0, 1, 2, 50000, 'Admin');
go
create table CTPhieuDatVe
(
	MaCTPhieuDatVe int identity(1,1) primary key,
	DoiTuong int null, -- 0 trẻ em, 1: người lớn, 2: người già/ khuyết tật
	ThanhTien float null,
	MaVeTau int,
	MaPhieuDatve int,
	foreign key(MaVeTau)references VeTau(MaVeTau),
	foreign key(MaPhieuDatve)references PhieuDatVe(MaPhieuDatve)
)
go
insert into CTPhieuDatVe (DoiTuong, ThanhTien, MaVeTau, MaPhieuDatve) values (1, 50000, 1, 1);
insert into CTPhieuDatVe (DoiTuong, ThanhTien, MaVeTau, MaPhieuDatve) values (1, 50000, 2, 2);