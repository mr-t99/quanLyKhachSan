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
using System.Collections;


namespace quanLyKhachSan.view.UserControll
{
   
    public partial class nhanvien : UserControl
    {
        private ConnectDatabase cnn;
        private int id = 0;
        public nhanvien()
        {
            InitializeComponent();
            
            cbQuyen.DataSource = quyen();
            cbQuyen.DisplayMember = "TenQuyen";
            cbQuyen.ValueMember = "Id";
            LoadDataTable();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (checkNoData() == 1)
            {
                User user = setUser();
                cnn = new ConnectDatabase();
                Console.WriteLine(user.T_khoan.Length);
                int id = cnn.insetGetId("insert into tai_khoan(t_khoan, m_khau, user_type) values ('" + user.T_khoan + "','" + user.Khau + "'," + user.User_type + ");SELECT CAST(scope_identity() AS int)");
                int row = cnn.RepairData("insert into nhan_vien(id_tKhoan, h_ten, gioi_tinh, q_quan, ngay_lam) values(" +
                    id + ",N'"
                    + txtHoTen.Text + "', " +
                    user.Gioi_tinh + ", N'" +
                    txtQueQuan.Text + "', GETDATE())");
                if (row == 0)
                {
                    MessageBox.Show("Lỗi thêm tài khoản");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thanh công");
                    LoadDataTable();
                }
            }
        }
        private ArrayList quyen()
        {
            ArrayList arrQuyen = new ArrayList();
            Quyen quanly = new Quyen();
            quanly.Id = 1;
            quanly.TenQuyen = "Quản lý";
            Quyen nhanvien = new Quyen();
            nhanvien.Id = 2;
            nhanvien.TenQuyen = "Nhân viên";
            arrQuyen.Add(quanly);
            arrQuyen.Add(nhanvien);
            return arrQuyen;
        }
        private void LoadDataTable()
        {
            cnn = new ConnectDatabase();
            DataTable data = cnn.getdata("select tai_khoan.id, t_khoan as N'Tên Tài Khoản', m_khau as N'Mật khẩu', quyen.t_quyen as 'Loại tài khoản', h_ten as N'Họ tên', nhan_vien.gioi_tinh as N'Giới tính', q_quan as N'Quê quán', ngay_lam as N'Ngày làm' from tai_khoan, nhan_vien, quyen where tai_khoan.id = nhan_vien.id_tKhoan and tai_khoan.user_type = quyen.id");
            tableDsNhanvien.DataSource = data;
            tableDsNhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tableDsNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 )
            {
                btSua.Enabled = true;
                btXoa.Enabled = true;
                dateNgayLam.Enabled = false;
                DataGridViewRow row = this.tableDsNhanvien.Rows[e.RowIndex];
                txtTenTaiKhoan.Text = row.Cells[1].Value.ToString();
                txtMatKhau.Text = row.Cells[2].Value.ToString();
                txtHoTen.Text = row.Cells[4].Value.ToString();
                txtQueQuan.Text = row.Cells[6].Value.ToString();
                if(row.Cells[5].Value is bool)
                {
                    bool vl = (bool)row.Cells[5].Value;
                    if(vl == true)
                    {
                        rbNam.Checked = true;
                    }
                    else
                    {
                        rbNu.Checked = true;
                    }
                }
                this.id = (int)row.Cells[0].Value;
                btThem.Enabled = false;
                cbQuyen.SelectedIndex = cbQuyen.FindStringExact(row.Cells[3].Value.ToString());
            }
        }
        private int checkNoData()
        {
            string mess = "";
            if (txtTenTaiKhoan.TextLength == 0)
            {
                mess += "Bạn phải nhập tài khoản\n";
            }
            if (txtMatKhau.TextLength == 0)
            {
                mess += "Bạn phải nhập mật khẩu\n";
            }
            if (txtHoTen.TextLength == 0)
            {
                mess += "Bạn phải nhập họ tên\n";
            }
            if (txtQueQuan.TextLength == 0)
            {
                mess += "Bạn phải nhập quê quán\n";
            }
            if (rbNam.Checked == false && rbNu.Checked == false)
            {
                mess += "Giới tính còn trống";
            }
            if (mess.Length == 0)
            {
                return 1;
            }
            else
            {
                MessageBox.Show(mess);
                return 0;
            }
        }
        private User setUser()
        {
            User user = new User();
            user.Id = this.id;
            user.T_khoan = txtTenTaiKhoan.Text;
            user.Khau = txtMatKhau.Text;
            Quyen a = new Quyen();
            a = (Quyen)cbQuyen.SelectedItem;
            user.User_type = a.Id;
            user.Gioi_tinh = 0;
            user.H_ten = txtHoTen.Text;
            user.Q_quan = txtQueQuan.Text;
            if (rbNam.Checked == true)
            {
                user.Gioi_tinh = 1;
            }
            return user;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            User user = setUser();
            int row = cnn.RepairData("update tai_khoan set t_khoan='"+
                user.T_khoan+"', m_khau='"+
                user.Khau+"', user_type="+user.User_type+ "where id="+user.Id+";");
            if(row != 0)
            {
                row = cnn.RepairData("update nhan_vien set h_ten=N'" +
                    user.H_ten + "', gioi_tinh=" +
                    user.Gioi_tinh + ", q_quan=N'" +
                    user.Q_quan + "' where id_tKhoan = (select id from tai_khoan where id=" + user.Id + ")");
                if (row != 0)
                {
                    MessageBox.Show("Thay đổi thông tin thành công");
                    LoadDataTable();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult rl = MessageBox.Show("Xóa nhân viên sẽ xóa hết cả lịch sử giao dịch. Bạn có trắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if(rl == DialogResult.Yes)
            {
                int row = cnn.RepairData("delete hoa_don where hoa_don.id_tKhoan=(select id from tai_khoan where id="+this.id+ ");delete nhan_vien where nhan_vien.id_tKhoan = (select id from tai_khoan where id = " + this.id + ");delete tai_khoan where id = " + this.id + "");
                if(row != 0)
                {
                    MessageBox.Show("Đã xóa thành công");
                    LoadDataTable();
                }
                
            }
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {

        }
    }
}
