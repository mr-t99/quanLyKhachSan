create database quanLyKhachSan
go
use quanLyKhachSan
go

create table tai_khoan(
	id int identity(1, 1) primary key,
	t_khoan char(50) not null,
	m_khau char(50) not null,
	user_type int not null
)
create table nhan_vien(
	id int identity(1,1) primary key,
	id_tKhoan int foreign key references tai_khoan(id),
	h_ten nvarchar(50) not null,
	q_quan nvarchar(100) not null,
	ngay_lam date not null
)
create table khach_hang(
	id int identity(1,1) primary key,
	h_ten nvarchar(50) not null,
	s_lan int not null
)
create table dich_vu(
	id int identity(1,1) primary key,
	t_dvu nvarchar(50) not null,
	gia int not null
)
create table phong(
	id int identity(1,1) primary key,
	t_phong nvarchar(50) not null,
	tang int not null
)
create table thiet_bi(
	id int identity(1,1) primary key,
	id_phong int foreign key references phong(id),
	t_tbi nvarchar(50) not null,
	t_ttrang nvarchar(50)
)
create table thu_nhap(
	id int identity(1,1) primary key,
	id_phong int foreign key references phong(id),
	t_gian date not null
)
create table hoa_don(
	id int identity(1,1) primary key,
	id_tKhoan int foreign key references tai_khoan(id),
	gio_vao datetime not null,
	gio_ra datetime not null,
	id_khang int foreign key references khach_hang(id),
	id_dvu int foreign key references dich_vu(id),
	id_phong int foreign key references phong(id),
	t_tien int not null
)

insert into tai_khoan(t_khoan, m_khau, user_type) values ('admin','admin',1), ('thang','1',2), ('cuong','1',2)
insert into nhan_vien(id_tKhoan, h_ten, q_quan, ngay_lam) values(1,N'Trần Ngọc Thăng', N'Quỳnh Phụ - Thái Bình', GETDATE()), (2,N'Chung Thanh Huy', N'Cái Bè - Tiền Giang', GETDATE()),(3,N'Hồ Văn Cường', N'Quỳnh Phụ - Thái Bình', GETDATE())
select * from tai_khoan, nhan_vien where tai_khoan.id = nhan_vien.id_tKhoan and tai_khoan.t_khoan = 'admin' and tai_khoan.m_khau='admin'