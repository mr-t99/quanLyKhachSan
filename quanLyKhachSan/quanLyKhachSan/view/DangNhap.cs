using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyKhachSan.module;

namespace quanLyKhachSan.view
{
    public partial class DangNhap : Form
    {
        private user User;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string status = "";
            if (txtTaiKhoan.Text.Length == 0)
            {
                status += "Bạn chưa nhập tên tài khoản\n";
                
            }
            if (txtTaiKhoan.Text.Length == 0)
            {
                status += "Bạn chưa nhập mật khẩu";

            }
            if (status.Length != 0)
            {
                MessageBox.Show(status);
            }
            else
            {
                handding();
            }
            
        }
        private void handding()
        {
            DataTable data;
            User = new user();
            ConnectDatabase cnn = new ConnectDatabase();
            data = cnn.getdata("select * from tai_khoan, nhan_vien where tai_khoan.id = nhan_vien.id_tKhoan and tai_khoan.t_khoan = '"+txtMatKhau.Text+"' and tai_khoan.m_khau='"+txtTaiKhoan.Text+"'");
            foreach(DataRow dr in data.Rows)
            {
                User.H_ten = dr["h_ten"].ToString();
                User.User_type = Int32.Parse(dr["User_type"].ToString());
            }
            if (User.H_ten == null)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
            else
            {
                MessageBox.Show("Xin chào " + User.H_ten);
            }
        }
    }
}
