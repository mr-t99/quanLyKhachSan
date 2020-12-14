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
    public partial class FromHoaDon : Form
    {
        private HoaDon hd;
        public delegate void SendStatus(int status);
        public event SendStatus gui;
        public FromHoaDon()
        {
            InitializeComponent();
        }
        public FromHoaDon(HoaDon hoaDon)
        {
            InitializeComponent();
            this.hd = hoaDon;
        }


        private void FromHoaDon_Load(object sender, EventArgs e)
        {
            Console.WriteLine(richTextBox1.Text.Length);
            if (hd != null)
            {
                richTextBox1.AppendText("\n\n\n             Khách Hàng: " + this.hd.T_khang);
                richTextBox1.AppendText("\n             --------------------------------------------");
                richTextBox1.AppendText("\n             Thông tin phòng: ");
                richTextBox1.AppendText("\n\n                       Phòng: " + this.hd.T_phong);
                richTextBox1.AppendText("\n                         Tầng: " + this.hd.T_tang);
                richTextBox1.AppendText("\n             --------------------------------------------");
                richTextBox1.AppendText("\n             Thông tin vào: ");
                richTextBox1.AppendText("\n\n                       Ngày: " + this.hd.N_vao);
                richTextBox1.AppendText("\n                         Giờ: " + this.hd.G_vao);
                richTextBox1.AppendText("\n\n             Thông tin ra: ");
                richTextBox1.AppendText("\n\n                         Ngày: " + "4/12/2020");
                richTextBox1.AppendText("\n                         Giờ: " + "12:45 pm");
                richTextBox1.AppendText("\n             --------------------------------------------");
                richTextBox1.AppendText("\n             Thông tin sử dụng: ");
                richTextBox1.AppendText("\n                         Số giờ sử dụng: " + this.hd.S_gio);
                richTextBox1.AppendText("\n                         Dịch vụ: " + this.hd.D_vu);
                richTextBox1.AppendText("\n                         Thành tiền: " + this.hd.S_tien);
                richTextBox1.AppendText("\n\n\n                                                                                        Nhân viên");
                richTextBox1.AppendText("\n\n                                                                                 " + this.hd.T_nv);
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            ConnectDatabase cnn = new ConnectDatabase();
            int row = 1;
            if (cnn.RepairData("update hoa_don set id_tKhoan_ra = " + hd.Id_tkhoan + ", gio_ra = GETDATE(), t_tien =" + hd.S_tien + " where id=" + hd.Id_hoaDon + ";") != 0)
            {
                if (cnn.RepairData("update phong set t_thai = 1 where id =" + hd.Id_phong + ";") != 0)
                {
                    row = 1;
                    MessageBox.Show("In hóa đơn thành công");
                    this.gui += FromHoaDon_gui;
            if (gui != null)
            {
                gui(row);
            }
            this.Dispose();
                }
                else
                {
                    row = 0;
                }
            }
            else
            {
                row = 0;
            }
        }

        private void FromHoaDon_gui(int status)
        {
            Home home = new Home();
            home.getStatus(status);
        }
    }
}
