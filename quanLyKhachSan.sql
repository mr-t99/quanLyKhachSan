create database quanLyKhachSan
go
use quanLyKhachSan
go

create table tai_khoan(
	id int identity(1, 1) primary key,
	t_khoan char(50) not null,
	m_khau char(50) not null
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