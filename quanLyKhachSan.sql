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
	gioi_tinh bit not null,
	q_quan nvarchar(100) not null,
	ngay_lam date not null
)
create table khach_hang(
	id int identity(1,1) primary key,
	h_ten nvarchar(50) not null
)
create table dich_vu(
	id int identity(1,1) primary key,
	t_dvu nvarchar(50) not null,
	gia int not null
)
create table tang(
	id int identity(1,1) primary key,
	ten int not null
)
create table phong(
	id int identity(1,1) primary key,
	t_phong nvarchar(50) not null,
	id_tang int foreign key references tang(id),
	t_thai bit not null
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
	id_tKhoan int foreign key references tai_khoan(id),
	gio_vao datetime,
	gio_ra datetime,
	id_khang int foreign key references khach_hang(id),
	id_dvu int foreign key references dich_vu(id),
	id_phong int foreign key references phong(id),
	t_tien int
)


insert into tai_khoan(t_khoan, m_khau, user_type) values ('admin','admin',1), ('thang','1',2), ('cuong','1',2)
insert into nhan_vien(id_tKhoan, h_ten, gioi_tinh, q_quan, ngay_lam) values(1,N'Trần Ngọc Thăng', 1, N'Quỳnh Phụ - Thái Bình', GETDATE()), (2,N'Chung Thanh Huy', 1, N'Cái Bè - Tiền Giang', GETDATE()),(3,N'Hồ Văn Cường', 1, N'Quỳnh Phụ - Thái Bình', GETDATE())
insert into tang(ten) values (1),(2),(3),(4);
insert into khach_hang(h_ten) values (N'Trần Ngọc Thăng'),(N'Trần Văn Cường'),(N'Chung Thanh Huy'),(N'Nguyễn Chí Tường')
insert into dich_vu(t_dvu, gia) values (N'Qua đêm', 300000),(N'Theo giờ', 70000)
insert into phong(t_phong, id_tang, t_thai) values ('PI1', 1, 0),('PI2', 1, 0),('PI3', 1, 0),('PI4', 1, 0),('PI5', 1, 0),('PII1', 2, 0),('PII2', 2, 0),('PII3', 2, 0),('PII4', 2, 0),('PII5', 2, 0),('PII5', 2, 0),('PIII1', 3, 0),('PIII2', 3, 0)
insert into thiet_bi(id_phong, t_tbi, gia, t_ttrang) values (1, N'Máy lạnh',5000000, N'Bình Thường'),(2, N'Tivi',5000000, N'Bình Thường'),(3, N'Máy giặt',5000000, N'Bình Thường'),(4, N'Máy lạnh',5000000, N'Bình Thường'),(5, N'Máy lạnh',5000000, N'Bình Thường')
insert into hoa_don(id_tKhoan, gio_vao, gio_ra, id_khang, id_dvu, id_phong, t_tien) values (1, GETDATE(), GETDATE(), 1, 1, 2, 400000),(1, GETDATE(), GETDATE(), 2, 1, 2, 400000),(1, GETDATE(), GETDATE(), 3, 1, 2, 400000),(1, GETDATE(), GETDATE(), 4, 1, 2, 400000),(1, GETDATE(), GETDATE(), 4, 1, 2, 400000),(1, GETDATE(), GETDATE(), 2, 1, 2, 400000)
select * from tai_khoan, nhan_vien where tai_khoan.id = nhan_vien.id_tKhoan and tai_khoan.t_khoan = 'admin' and tai_khoan.m_khau='admin'

select hoa_don.id, khach_hang.h_ten as N'Họ tên khách hàng', phong.t_phong as N'Phòng', tang.ten as N'Tầng', hoa_don.gio_vao as N'Giờ vào', hoa_don.gio_ra as N'Giờ ra',dich_vu.t_dvu as N'Dịch vụ', hoa_don.t_tien as N'Thành tiền' from phong, hoa_don, dich_vu, khach_hang, tang  where hoa_don.id_phong = phong.id and dich_vu.id = hoa_don.id_dvu and hoa_don.id_khang = khach_hang.id and phong.id_tang = tang.id

