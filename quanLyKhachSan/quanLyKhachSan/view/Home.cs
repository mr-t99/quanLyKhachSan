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
    public partial class Home : Form
    {
        private int type, id_nvien;
        private string t_nv;
        public delegate void load(int i);
        public event load loadTable;
        public Home()
        {
            InitializeComponent();
        }

        public void getType(string h_ten, int User_type, int id_nvien)
        {
            this.t_nv = h_ten;
            this.type = User_type;
            this.id_nvien = id_nvien;
            hoten.Text = "Nhân viên: " + h_ten;
            DateTime dt = DateTime.Now;
            ngayThang.Text = "Hôm nay: " + dt.ToString("dd/M/yyyy");
            if (this.type != 1)
            {
                quanly.Enabled = false;
                thongke.Enabled = false;
                datphong1.setOption(1, this.id_nvien, h_ten);
                datphong1.Visible = true;
                nhanvien1.Visible = false;
                lichsu1.Visible = false;
                phong1.Visible = false;
                thong_tin1.Visible = false;
                thongKe1.Visible = false;
            }
            else
            {
                datphong1.Visible = false;
                nhanvien1.Visible = false;
                lichsu1.Visible = false;
                phong1.Visible = true;
                thong_tin1.Visible = false;
                thongKe1.Visible = false;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            datphong1.Visible = false;
            nhanvien1.Visible = true;
            lichsu1.Visible = false;
            phong1.Visible = false;
            thong_tin1.Visible = false;
            thongKe1.Visible = false;
            //xl nhan vien


        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            datphong1.Visible = false;
            nhanvien1.Visible = false;
            lichsu1.Visible = false;
            phong1.Visible = true;
            thong_tin1.Visible = false;
            thongKe1.Visible = false;
        }

        private void lịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {

            datphong1.Visible = false;
            nhanvien1.Visible = false;
            lichsu1.Visible = true;
            phong1.Visible = false;
            thong_tin1.Visible = false;
            thongKe1.Visible = false;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datphong1.Visible = false;
            nhanvien1.Visible = false;
            lichsu1.Visible = false;
            phong1.Visible = false;
            thong_tin1.Visible = true;
            thong_tin1.setId(this.id_nvien);
            thongKe1.Visible = false;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if(dl == DialogResult.Yes)
            {
                this.Dispose();
                DangNhap dn = new DangNhap();
                dn.Visible = true;
            }
        }

        private void btDatPhon_Click(object sender, EventArgs e)
        {
            datphong1.setOption(0, this.id_nvien, t_nv);
            datphong1.Visible = true;
            nhanvien1.Visible = false;
            lichsu1.Visible = false;
            phong1.Visible = false;
            thong_tin1.Visible = false;
            thongKe1.Visible = false;
        }

        private void btTraPhong_Click(object sender, EventArgs e)
        {
            //TraPhong---------------------
            datphong1.setOption(1, this.id_nvien, t_nv);
            datphong1.Visible = true;
            nhanvien1.Visible = false;
            lichsu1.Visible = false;
            phong1.Visible = false;
            thong_tin1.Visible = false;
            thongKe1.Visible = false;
        }

        public void getStatus(int a)
        {
            if (a == 1)
            {
                loadTable += Home_loadTable;
                if (loadTable != null)
                {
                    loadTable(a);
                }
            }
            
        }

        private void thángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datphong1.Visible = false;
            nhanvien1.Visible = false;
            lichsu1.Visible = false;
            phong1.Visible = false;
            thong_tin1.Visible = false;
            thongKe1.Visible = true;
            thongKe1.setLoai(1);

        }

        private void hômNayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datphong1.Visible = false;
            nhanvien1.Visible = false;
            lichsu1.Visible = false;
            phong1.Visible = false;
            thong_tin1.Visible = false;
            thongKe1.Visible = true;
            thongKe1.setLoai(0);
        }

        private void Home_loadTable(int i)
        {
            this.datphong1.loadData(i);
        }
    }
}
