using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyKhachSan.view.UserControll
{
    public partial class datphong : UserControl
    {
        private int selectOption;

        public datphong()
        {
            InitializeComponent();
        }
        public void setOption(int a)
        {
            this.selectOption = a;
            if (a == 1) {
                panelPhong.Enabled = false;
                panelThongTin.Enabled = false;
                btXacNhan.Text = "Trả Phòng";
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
