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

insert into khach_hang(t_khang, cmnd,sdt, d_chi) values(N'Nguyễn Tùng Sơn', '147781028','014785448',N'Việt Nam'),(N'Trần Đức Bo', '145214562','0257895665',N'Việt Nam'),(N'Huấn Hoa Hồng', '257741026','025864224',N'Việt Nam'),(N'Huy Quần Hoa', '154478236','02141102114',N'Việt Nam')
insert into quyen(t_quyen) values(N'Quản lý'),(N'Nhân viên');
insert into trang_thai(t_tthai) values (N'Trống'),(N'Sử dụng'),(N'Đặt trước');
insert into tai_khoan(t_khoan, m_khau, user_type) values ('admin','admin',1), ('thang','1',2), ('cuong','1',2)
insert into nhan_vien(id_tKhoan, h_ten, gioi_tinh, q_quan, ngay_lam) values(1,N'Trần Ngọc Thăng', 0, N'Quỳnh Phụ - Thái Bình', GETDATE()), (2,N'Chung Thanh Huy', 1, N'Cái Bè - Tiền Giang', GETDATE()),(3,N'Hồ Văn Cường', 1, N'Quỳnh Phụ - Thái Bình', GETDATE())
insert into tang(ten) values (N'Tầng 1'),(N'Tầng 2'),(N'Tầng 3'),(N'Tầng 4');
insert into dich_vu(t_dvu, gia) values (N'Mát xa', 300000),(N'Karaoke', 500000),(N'Xông hơi', 70000),(N'Đấm bóp', 70000),(N'Thuê xe', 5000000),(N'Máy bay', 20000000)
insert into phong(t_phong, id_tang, t_thai) values ('PI1', 1, 1),('PI2', 1, 1),('PI3', 1, 1),('PI4', 1, 1),('PI5', 1, 1),('PII1', 2, 1),('PII2', 2, 1),('PII3', 2, 1),('PII4', 2, 1),('PII5', 2, 1),('PII6', 2, 1),('PIII1', 3, 1),('PIII2', 3, 1)
insert into thiet_bi(id_phong, t_tbi, gia, t_ttrang) values (1, N'Máy lạnh',5000000, N'Bình Thường'),(2, N'Tivi',5000000, N'Bình Thường'),(3, N'Máy giặt',5000000, N'Bình Thường'),(4, N'Máy lạnh',5000000, N'Bình Thường'),(5, N'Máy lạnh',5000000, N'Bình Thường')
insert into hoa_don(id_tKhoan_vao ,cmnd, gio_vao, gio_ra, id_phong, t_tien) values (1,'147781028' , GETDATE(), null, 2, 400000),(1,'145214562', GETDATE(), GETDATE(), 2, 400000),(1,'257741026', GETDATE(), GETDATE(), 2, 400000),(1, '154478236',GETDATE(), GETDATE(), 2, 400000),(1, '154478236',GETDATE(), GETDATE(), 2, 400000),(1, '154478236',GETDATE(), GETDATE(), 2, 400000)
insert into ds_dich_vu values(1, 1, 2),(1, 2, 1),(1, 3, 1),(2, 1, 1),(2, 1, 1),(2, 1, 1),(3, 1, 1),(3, 1, 1)
select * from tai_khoan, nhan_vien where tai_khoan.id = nhan_vien.id_tKhoan and tai_khoan.t_khoan = 'admin' and tai_khoan.m_khau='admin'

drop database quanLyKhachSan
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
select * from phong where t_thai = 1 and id_tang
select * from dich_vu
update thiet_bi set gia=40, t_tbi=N'Máy l?nh',t_ttrang=N'Không ho?t d?ng'  where id=2 and id_phong = 5
select * from hoa_don, phong, khach_hang where phong.id = hoa_don.id_phong and hoa_don.id_khang = khach_hang.id
--câu này dùng
select tang.ten,phong.t_phong as N'Tên phòng', hoa_don.khach_hang as N'Khách hàng','Giờ vào'=concat(DATEPART(hh, gio_vao),':', DATEPART(mi, gio_vao)), 'Ngày vào'=concat(DATEPART(dd, gio_vao),'/', DATEPART(mm, gio_vao),'/', DATEPART(YY, gio_vao)), dich_vu.t_dvu as N'Dịch vụ' from phong, hoa_don, tang, dich_vu where tang.id = phong.id_tang and hoa_don.id_phong = phong.id and gio_ra is not null and hoa_don.id_dvu = dich_vu.id;

select * from hoa_don where gio_ra is not null

select phong.id, phong.id_tang,  t_phong as N'Phòng', ten as N'Tầng', trang_thai.t_tthai as N'Trạng thái' from phong, trang_thai,tang where phong.t_thai = trang_thai.id and tang.id = phong.id_tang and trang_thai.id =1;


--select
select * from tai_khoan, nhan_vien where tai_khoan.id = nhan_vien.id and tai_khoan.id = 1
--UPDATE DATA
update phong set t_thai=1 where id=2;
--INSERT
select * from hoa_don
select 'Nhân viên nhận phòng' = (select h_ten from nhan_vien where id = hoa_don.id_tKhoan_vao),'Nhân viên trả phòng' = (select h_ten from nhan_vien where id = hoa_don.id_tKhoan_ra),khach_hang, 'Giờ vào'=concat(DATEPART(hh, gio_vao),':', DATEPART(mi, gio_vao)), 'Ngày vào'=concat(DATEPART(dd, gio_vao),'/', DATEPART(mm, gio_vao),'/', DATEPART(YY, gio_vao)), 'Giờ ra'=concat(DATEPART(hh, gio_ra),':', DATEPART(mi, gio_ra)), 'Ngày ra'=concat(DATEPART(dd, gio_ra),'/', DATEPART(mm, gio_ra),'/', DATEPART(YY, gio_ra)), dich_vu.t_dvu as 'Dịch vụ', phong.t_phong as 'Phòng', t_tien as 'Số tiền'   from hoa_don, phong, dich_vu where  hoa_don.id_phong = phong.id and hoa_don.id_dvu = dich_vu.id 
order by hoa_don.id desc

select * from hoa_don where DATEPART(dd, gio_vao) = '14'

--thong ke theo ngay
select khach_hang as 'Khách hàng', dich_vu.t_dvu as 'Dịch vụ', t_tien as 'Chi phí' from hoa_don, phong, dich_vu where  hoa_don.id_phong = phong.id and hoa_don.id_dvu = dich_vu.id and hoa_don.id_tKhoan_ra is not null and t_tien is not null and DATEPART(dd, gio_vao) = DATEPART(dd, GETDATE()) and DATEPART(mm, gio_vao) = DATEPART(mm, GETDATE()) and id_tKhoan_ra = 2
select sum(hoa_don.t_tien) as 'tong' from hoa_don, phong, dich_vu where  hoa_don.id_phong = phong.id and hoa_don.id_dvu = dich_vu.id and hoa_don.id_tKhoan_ra is not null and t_tien is not null and DATEPART(dd, gio_vao) = DATEPART(dd, GETDATE()) and DATEPART(mm, gio_vao) = DATEPART(mm, GETDATE())
select tang.ten,phong.t_phong as N'Tên phòng', khach_hang.t_khang as N'Khách hàng',khach_hang.cmnd as 'CMND','Giờ vào'=concat(DATEPART(hh, gio_vao),':', DATEPART(mi, gio_vao)), 'Ngày vào'=concat(DATEPART(dd, gio_vao),'/', DATEPART(mm, gio_vao),'/', DATEPART(YY, gio_vao)), id_phong, hoa_don.id, khach_hang.cmnd, khach_hang.sdt, khach_hang.d_chi from phong, hoa_don, tang, khach_hang where tang.id = phong.id_tang and hoa_don.id_phong = phong.id and gio_ra is null and hoa_don.cmnd = khach_hang.cmnd;
select * from phong

--Dịch vụ
select * from ds_dich_vu
select id, t_dvu as 'Tên dịch vụ', gia as 'Giá' from dich_vu
select t_phong , t_dvu , (gia*s_luong) as 'gia' , s_luong  from phong, dich_vu, ds_dich_vu where phong.id = ds_dich_vu.id_phong and dich_vu.id = ds_dich_vu.id_dvu and phong.id = 1
select sum(gia*s_luong) as'tong' from phong, dich_vu, ds_dich_vu where phong.id = ds_dich_vu.id_phong and dich_vu.id = ds_dich_vu.id_dvu and phong.id = 1
update khach_hang set t_khang ='', sdt=1, d_chi='' where cmnd=''

select tang.ten,phong.t_phong as N'Tên phòng', khach_hang.t_khang as N'Khách hàng',khach_hang.cmnd as 'CMND','Gi? vào'=concat(DATEPART(hh, gio_vao),':', DATEPART(mi, gio_vao)), 'Ngày vào'=concat(DATEPART(dd, gio_vao),'/', DATEPART(mm, gio_vao),'/', DATEPART(YY, gio_vao)), id_phong, hoa_don.id, khach_hang.cmnd, khach_hang.sdt, khach_hang.d_chi from phong, hoa_don, tang, khach_hang where tang.id = phong.id_tang and hoa_don.id_phong = phong.id and gio_ra is null and hoa_don.cmnd = khach_hang.cmnd;
insert into hoa_don(id_tKhoan_vao,cmnd, gio_vao, id_phong) values (1,'123456789', GETDATE(), 3)
insert into khach_hang(t_khang, cmnd,sdt, d_chi) values(N'Cuong', '123456789','0346313717',N'Thái bình')
select sum(gia*s_luong) as'tong' from phong, dich_vu, ds_dich_vu where phong.id = ds_dich_vu.id_phong and dich_vu.id = ds_dich_vu.id_dvu and phong.id = 12
update phong set t_thai = 1 where id =12;
select * from khach_hang
select khach_hang.t_khang as 'Khách hàng','Ngày ra'=concat(DATEPART(dd, gio_ra),'/', DATEPART(mm, gio_ra),'/', DATEPART(YY, gio_ra)), phong.t_phong as 'Phòng', t_tien as 'Chi phí' from hoa_don, phong, khach_hang where  hoa_don.id_phong = phong.id and hoa_don.id_tKhoan_ra is not null and t_tien is not null and DATEPART(dd, gio_vao) = DATEPART(dd, GETDATE()) and DATEPART(mm, gio_vao) = DATEPART(mm, GETDATE()) and hoa_don.cmnd = khach_hang.cmnd and id_tKhoan_ra =1 
select khach_hang.t_khang as 'Khách hàng','Ngày ra'=concat(DATEPART(dd, gio_ra),'/', DATEPART(mm, gio_ra),'/', DATEPART(YY, gio_ra)), phong.t_phong as 'Phòng', t_tien as 'Chi phí' from hoa_don, phong, khach_hang where  hoa_don.id_phong = phong.id and hoa_don.cmnd = khach_hang.cmnd and hoa_don.id_tKhoan_ra is not null and t_tien is not null and DATEPART(mm, gio_vao) = 12 and id_tKhoan_ra = 1
select 'Nhân viên nhận phòng' = (select h_ten from nhan_vien where id = hoa_don.id_tKhoan_vao),'Nhân viên trả phòng' = (select h_ten from nhan_vien where id = hoa_don.id_tKhoan_ra),khach_hang.t_khang as 'Khách hàng', 'Giờ vào'=concat(DATEPART(hh, gio_vao),':', DATEPART(mi, gio_vao)), 'Ngày vào'=concat(DATEPART(dd, gio_vao),'/', DATEPART(mm, gio_vao),'/', DATEPART(YY, gio_vao)), 'Giờ ra'=concat(DATEPART(hh, gio_ra),':', DATEPART(mi, gio_ra)), 'Ngày ra'=concat(DATEPART(dd, gio_ra),'/', DATEPART(mm, gio_ra),'/', DATEPART(YY, gio_ra)), phong.t_phong as 'Phòng', t_tien as 'Số tiền'   from hoa_don, phong, khach_hang where  hoa_don.id_phong = phong.id and hoa_don.cmnd = khach_hang.cmnd order by hoa_don.id desc
insert into khach_hang(cmnd) values(123456788)