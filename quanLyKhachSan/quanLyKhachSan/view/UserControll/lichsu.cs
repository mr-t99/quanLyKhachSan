using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyKhachSan.module;

namespace quanLyKhachSan.view.UserControll
{
    public partial class lichsu : UserControl
    {
        public lichsu()
        {
            InitializeComponent();
        }

        private void lichsu_Load(object sender, EventArgs e)
        {
            ConnectDatabase cnn = new ConnectDatabase();
            dataGridView1.DataSource = cnn.getdata("select 'Nhân viên nhận phòng' = (select h_ten from nhan_vien where id = hoa_don.id_tKhoan_vao),'Nhân viên trả phòng' = (select h_ten from nhan_vien where id = hoa_don.id_tKhoan_ra),khach_hang, 'Giờ vào'=concat(DATEPART(hh, gio_vao),':', DATEPART(mi, gio_vao)), 'Ngày vào'=concat(DATEPART(dd, gio_vao),'/', DATEPART(mm, gio_vao),'/', DATEPART(YY, gio_vao)), 'Giờ ra'=concat(DATEPART(hh, gio_ra),':', DATEPART(mi, gio_ra)), 'Ngày ra'=concat(DATEPART(dd, gio_ra),'/', DATEPART(mm, gio_ra),'/', DATEPART(YY, gio_ra)), dich_vu.t_dvu as 'Dịch vụ', phong.t_phong as 'Phòng', t_tien as 'Số tiền'   from hoa_don, phong, dich_vu where  hoa_don.id_phong = phong.id and hoa_don.id_dvu = dich_vu.id order by hoa_don.id desc");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ConnectDatabase cnn = new ConnectDatabase();
            dataGridView1.DataSource = cnn.getdata("select 'Nhân viên nhận phòng' = (select h_ten from nhan_vien where id = hoa_don.id_tKhoan_vao),'Nhân viên trả phòng' = (select h_ten from nhan_vien where id = hoa_don.id_tKhoan_ra),khach_hang, 'Giờ vào'=concat(DATEPART(hh, gio_vao),':', DATEPART(mi, gio_vao)), 'Ngày vào'=concat(DATEPART(dd, gio_vao),'/', DATEPART(mm, gio_vao),'/', DATEPART(YY, gio_vao)), 'Giờ ra'=concat(DATEPART(hh, gio_ra),':', DATEPART(mi, gio_ra)), 'Ngày ra'=concat(DATEPART(dd, gio_ra),'/', DATEPART(mm, gio_ra),'/', DATEPART(YY, gio_ra)), dich_vu.t_dvu as 'Dịch vụ', phong.t_phong as 'Phòng', t_tien as 'Số tiền'   from hoa_don, phong, dich_vu where  hoa_don.id_phong = phong.id and hoa_don.id_dvu = dich_vu.id order by hoa_don.id desc");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
