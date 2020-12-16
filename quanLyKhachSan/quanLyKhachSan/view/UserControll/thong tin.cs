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
    public partial class thong_tin : UserControl
    {
        private int id_nvien;
        public thong_tin()
        {
            InitializeComponent();
        }
        public void setId(int id)
        {
            this.id_nvien = id;
            lbGiaoDich.Visible = false;
            LayThongTinNv();
            LayDoanhThu();
        }
        private void LayDoanhThu()
        {
            if (id_nvien != 0)
            {
                //Lấy dữ liệu nhân viên đẩy vào các lable
                ConnectDatabase conn = new ConnectDatabase();
                DataTable dataTable = conn.getdata("select khach_hang as 'Khách hàng', dich_vu.t_dvu as 'Dịch vụ', t_tien as 'Chi phí' from hoa_don, phong, dich_vu where  hoa_don.id_phong = phong.id and hoa_don.id_dvu = dich_vu.id and hoa_don.id_tKhoan_ra is not null and t_tien is not null and hoa_don.id_tKhoan_ra = "+this.id_nvien+ " order by hoa_don.id desc");
                if (dataTable.Rows.Count != 0 && dataTable != null)
                {
                    tableDoanhThu.DataSource = dataTable;
                    tableDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    lbGiaoDich.Visible = true;
                    tableDoanhThu.Visible = false;
                }
            }
        }
        private void LayThongTinNv()
        {
            if (id_nvien != 0)
            {
                //Lấy dữ liệu nhân viên đẩy vào các lable
                ConnectDatabase conn = new ConnectDatabase();
                DataTable dataTable = conn.getdata("select * from tai_khoan, nhan_vien where tai_khoan.id = nhan_vien.id and tai_khoan.id = " + this.id_nvien + "");
                if (dataTable.Rows.Count != 0 && dataTable!=null)
                {
                    lbTaiKhoan.Text = dataTable.Rows[0]["t_khoan"].ToString();
                    lbMatKhau.Text = dataTable.Rows[0]["m_khau"].ToString();
                    lbQuyen.Text = "Nhân viên";
                    if (dataTable.Rows[0]["user_type"].ToString() == "1")
                    {
                        lbQuyen.Text = "Quản lý";
                    }
                    lbHoTen.Text = dataTable.Rows[0]["h_ten"].ToString();
                    lbGioiTinh.Text = "Nam";
                    if (dataTable.Rows[0]["gioi_tinh"].ToString() == "1")
                    {
                        lbGioiTinh.Text = "Nữ";
                    }
                    lbQueQuan.Text = dataTable.Rows[0]["q_quan"].ToString();
                    lbNgayLam.Text = dataTable.Rows[0]["ngay_lam"].ToString();
                    DateTime date = DateTime.Parse(lbNgayLam.Text);
                    lbNgayLam.Text =  date.ToString("dd/MM/yyyy");
                }
            }
            
        }
        private void thong_tin_Load(object sender, EventArgs e)
        {

        }
    }
}
