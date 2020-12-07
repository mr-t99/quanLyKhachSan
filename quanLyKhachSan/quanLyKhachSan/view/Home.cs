using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyKhachSan.view
{
    public partial class Home : Form
    {
        private int type;
        public Home()
        {
            InitializeComponent();
        }

        public void getType(int type)
        {
            this.type = type;
            if(this.type != 1)
            {
                quanly.Enabled = false;
                thongke.Enabled = false;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            datphong1.Visible = false;
            nhanvien1.Visible = false;
            lichsu1.Visible = false;
            phong1.Visible = true;
            thong_tin1.Visible = false;
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            datphong1.Visible = false;
            nhanvien1.Visible = true;
            lichsu1.Visible = false;
            phong1.Visible = false;
            thong_tin1.Visible = false;
            //xl nhan vien


        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            datphong1.Visible = false;
            nhanvien1.Visible = false;
            lichsu1.Visible = false;
            phong1.Visible = true;
            thong_tin1.Visible = false;
        }

        private void lịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            datphong1.Visible = false;
            nhanvien1.Visible = false;
            lichsu1.Visible = true;
            phong1.Visible = false;
            thong_tin1.Visible = false;
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datphong1.setOption(0);
            datphong1.Visible = true;
            nhanvien1.Visible = false;
            lichsu1.Visible = false;
            phong1.Visible = false;
            thong_tin1.Visible = false;
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datphong1.setOption(1);
            datphong1.Visible = true;
            nhanvien1.Visible = false;
            lichsu1.Visible = false;
            phong1.Visible = false;
            thong_tin1.Visible = false;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datphong1.Visible = false;
            nhanvien1.Visible = false;
            lichsu1.Visible = false;
            phong1.Visible = false;
            thong_tin1.Visible = true;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if(dl == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        
    }
}
