create database quanLyKhachSan
go
use quanLyKhachSan
go

create table khach_hang(
	
	t_khang nvarchar(50),
	cmnd varchar(9) primary key,
	sdt varchar(11),
	d_chi nvarchar(100),
	
)

create table quyen(
	id int identity(1, 1) primary key,
	t_quyen nvarchar(20) not null
)

create table trang_thai(
	id int identity(1, 1) primary key,
	t_tthai nvarchar(15) not null,
)

create table tai_khoan(
	id int identity(1, 1) primary key,
	t_khoan varchar(50) not null,
	m_khau varchar(50) not null,
	user_type int foreign key references quyen(id)
)
create table nhan_vien(
	id int identity(1,1) primary key,
	id_tKhoan int foreign key references tai_khoan(id),
	h_ten nvarchar(50) not null,
	gioi_tinh bit not null,
	q_quan nvarchar(100) not null,
	ngay_lam date not null
)
create table dich_vu(
	id int identity(1,1) primary key,
	t_dvu nvarchar(50) not null,
	gia int not null
)
create table tang(
	id int identity(1,1) primary key,
	ten nvarchar(10) not null
)
create table phong(
	id int identity(1,1) primary key,
	t_phong nvarchar(50) not null,
	id_tang int foreign key references tang(id),
	t_thai int foreign key references trang_thai(id),
)

create table thiet_bi(
	id int identity(1,1) primary key,
	id_phong int foreign key references phong(id),
	t_tbi nvarchar(50) not null,
	gia int not null,
	t_ttrang nvarchar(50)
)
create table thu_nhap(
	id int identity(1,1) primary key,
	id_phong int foreign key references phong(id),
	t_gian date not null
)
create table hoa_don(
	id int identity(1,1) primary key,
	id_tKhoan_vao int foreign key references tai_khoan(id),
	id_tKhoan_ra int foreign key references tai_khoan(id),
	cmnd varchar(9) foreign key references khach_hang(cmnd),
	gio_vao datetime,
	gio_ra datetime,
	id_phong int foreign key references phong(id),
	t_tien int
)

create table ds_dich_vu(
	id int identity(1,1) primary key,
	id_phong int foreign key references phong(id),
	id_dvu int foreign key references phong(id),
	s_luong int not null
)

insert into quyen(t_quyen) values(N'Quản lý'),(N'Nhân viên');
insert into trang_thai(t_tthai) values (N'Trống'),(N'Sử dụng'),(N'Đặt trước');
insert into tai_khoan(t_khoan, m_khau, user_type) values ('admin','admin',1), ('thang','1',2), ('cuong','1',2)
insert into nhan_vien(id_tKhoan, h_ten, gioi_tinh, q_quan, ngay_lam) values(1,N'Trần Ngọc Thăng', 0, N'Quỳnh Phụ - Thái Bình', GETDATE()), (2,N'Chung Thanh Huy', 1, N'Cái Bè - Tiền Giang', GETDATE()),(3,N'Hồ Văn Cường', 1, N'Quỳnh Phụ - Thái Bình', GETDATE())
insert into tang(ten) values (N'Tầng 1'),(N'Tầng 2'),(N'Tầng 3'),(N'Tầng 4');
insert into dich_vu(t_dvu, gia) values (N'Mát xa', 300000),(N'Karaoke', 500000),(N'Xông hơi', 70000),(N'Đấm bóp', 70000),(N'Thuê xe', 5000000),(N'Máy bay', 20000000)
insert into phong(t_phong, id_tang, t_thai) values ('PI1', 1, 1),('PI2', 1, 1),('PI3', 1, 1),('PI4', 1, 1),('PI5', 1, 1),('PII1', 2, 1),('PII2', 2, 1),('PII3', 2, 1),('PII4', 2, 1),('PII5', 2, 1),('PII6', 2, 1),('PIII1', 3, 1),('PIII2', 3, 1)
insert into thiet_bi(id_phong, t_tbi, gia, t_ttrang) values (1, N'Máy lạnh',5000000, N'Bình Thường'),(2, N'Tivi',5000000, N'Bình Thường'),(3, N'Máy giặt',5000000, N'Bình Thường'),(4, N'Máy lạnh',5000000, N'Bình Thường'),(5, N'Máy lạnh',5000000, N'Bình Thường')
select * from khach_hang

