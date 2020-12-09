create database quanLyKhachSan
go
use quanLyKhachSan
go

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
	id_tKhoan int foreign key references tai_khoan(id),
	gio_vao datetime,
	gio_ra datetime,
	id_khang int foreign key references khach_hang(id),
	id_dvu int foreign key references dich_vu(id),
	id_phong int foreign key references phong(id),
	t_tien int
)

insert into quyen(t_quyen) values(N'Quản lý'),(N'Nhân viên');
insert into trang_thai(t_tthai) values (N'Trống'),(N'Sử dụng'),(N'Đặt trước');
insert into tai_khoan(t_khoan, m_khau, user_type) values ('admin','admin',1), ('thang','1',2), ('cuong','1',2)
insert into nhan_vien(id_tKhoan, h_ten, gioi_tinh, q_quan, ngay_lam) values(1,N'Trần Ngọc Thăng', 0, N'Quỳnh Phụ - Thái Bình', GETDATE()), (2,N'Chung Thanh Huy', 1, N'Cái Bè - Tiền Giang', GETDATE()),(3,N'Hồ Văn Cường', 1, N'Quỳnh Phụ - Thái Bình', GETDATE())
insert into tang(ten) values (N'Tầng 1'),(N'Tầng 2'),(N'Tầng 3'),(N'Tầng 4');
insert into khach_hang(h_ten) values (N'Trần Ngọc Thăng'),(N'Trần Văn Cường'),(N'Chung Thanh Huy'),(N'Nguyễn Chí Tường')
insert into dich_vu(t_dvu, gia) values (N'Qua đêm', 300000),(N'Theo giờ', 70000)
insert into phong(t_phong, id_tang, t_thai) values ('PI1', 1, 1),('PI2', 1, 1),('PI3', 1, 1),('PI4', 1, 1),('PI5', 1, 2),('PII1', 2, 2),('PII2', 2, 2),('PII3', 2, 3),('PII4', 2, 1),('PII5', 2, 1),('PII5', 2, 1),('PIII1', 3, 1),('PIII2', 3, 1)
insert into thiet_bi(id_phong, t_tbi, gia, t_ttrang) values (1, N'Máy lạnh',5000000, N'Bình Thường'),(2, N'Tivi',5000000, N'Bình Thường'),(3, N'Máy giặt',5000000, N'Bình Thường'),(4, N'Máy lạnh',5000000, N'Bình Thường'),(5, N'Máy lạnh',5000000, N'Bình Thường')
insert into hoa_don(id_tKhoan, gio_vao, gio_ra, id_khang, id_dvu, id_phong, t_tien) values (1, GETDATE(), GETDATE(), 1, 1, 2, 400000),(1, GETDATE(), GETDATE(), 2, 1, 2, 400000),(1, GETDATE(), GETDATE(), 3, 1, 2, 400000),(1, GETDATE(), GETDATE(), 4, 1, 2, 400000),(1, GETDATE(), GETDATE(), 4, 1, 2, 400000),(1, GETDATE(), GETDATE(), 2, 1, 2, 400000)
select * from tai_khoan, nhan_vien where tai_khoan.id = nhan_vien.id_tKhoan and tai_khoan.t_khoan = 'admin' and tai_khoan.m_khau='admin'

--select hoa_don.id, khach_hang.h_ten as N'Họ tên khách hàng', phong.t_phong as N'Phòng', tang.ten as N'Tầng', hoa_don.gio_vao as N'Giờ vào', hoa_don.gio_ra as N'Giờ ra',dich_vu.t_dvu as N'Dịch vụ', hoa_don.t_tien as N'Thành tiền' from phong, hoa_don, dich_vu, khach_hang, tang  where hoa_don.id_phong = phong.id and dich_vu.id = hoa_don.id_dvu and hoa_don.id_khang = khach_hang.id and phong.id_tang = tang.id

--/*Lấy danh sách tài khoản:*/
--select tai_khoan.id, t_khoan as N'Tên Tài Khoản', m_khau as N'Mật khẩu', quyen.t_quyen as 'Loại tài khoản', h_ten as N'Họ tên', nhan_vien.gioi_tinh as N'Giới tính', q_quan as N'Quê quán', ngay_lam as N'Ngày làm' from tai_khoan, nhan_vien, quyen where tai_khoan.id = nhan_vien.id_tKhoan and tai_khoan.user_type = quyen.id
--/*thêm tài khoản*/
--insert into tai_khoan(t_khoan, m_khau, user_type) values ('aaa','aaa',1)
--/*Layas lai id khi them*/
--INSERT INTO tai_khoan(t_khoan, m_khau, user_type) VALUES ('abc', 'abc', 1);SELECT CAST(scope_identity() AS int)

--/*sua bang*/
--update tai_khoan set t_khoan='', m_khau='', user_type=1 where id=;
--update nhan_vien set h_ten='test doi', gioi_tinh=1, q_quan='abc' where id_tKhoan = (select id from tai_khoan where id=10)

--drop database quanLyKhachSan

--/*Xóa dong*/
--delete hoa_don where hoa_don.id_tKhoan=(select id from tai_khoan where id=1);
--delete nhan_vien where nhan_vien.id_tKhoan=(select id from tai_khoan where id=1);
--select * from tang
select * from phong, trang_thai where phong.t_thai = trang_thai.id
select phong.id, t_phong as N'Tên phòng', tang.ten as N'Tầng', trang_thai.t_tthai as N'Trạng thái' from phong, tang, trang_thai where phong.t_thai = trang_thai.id and phong.id_tang = tang.id;
select id, t_tbi as N'Tên thiết bị', gia as N'Giá', N'Trạng Thái' from thiet_bi where id_phong=1;

alter table hoa_don nocheck constraint all;alter table thu_nhap nocheck constraint all;alter table thiet_bi nocheck constraint all;delete from phong WHERE id=1;alter table hoa_don check constraint all;alter table thu_nhap check constraint all;alter table thiet_bi check constraint all 
insert into phong(t_phong, id_tang, t_thai) values ('dasd', 1,1)
select * from thiet_bi where id_phong =5
update thiet_bi set gia=40, t_tbi=N'Máy l?nh',t_ttrang=N'Không ho?t d?ng'  where id=2 and id_phong = 5