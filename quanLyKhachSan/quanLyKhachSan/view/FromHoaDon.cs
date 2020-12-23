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
using System.Collections;

namespace quanLyKhachSan.view
{
    public partial class FromHoaDon : Form
    {
        private HoaDon hd;
        private ArrayList dichVu;
        public FromHoaDon()
        {
            InitializeComponent();
        }
        public FromHoaDon(HoaDon hoaDon, ArrayList dv)
        {
            InitializeComponent();
            this.hd = hoaDon;
            this.dichVu = dv;
        }



        private void FromHoaDon_Load(object sender, EventArgs e)
        {
            Console.WriteLine(richTextBox1.Text.Length);
            if (hd != null)
            {
                richTextBox1.AppendText("\n\n\n             Khách Hàng: " + this.hd.T_khang);
                richTextBox1.AppendText("\n             CMND: " + this.hd.Cmnd);
                richTextBox1.AppendText("\n             Sdt: " + this.hd.Sdt);
                richTextBox1.AppendText("\n             Địa chỉ: " + this.hd.Dia_chi);
                richTextBox1.AppendText("\n             --------------------------------------------");
                richTextBox1.AppendText("\n             Thông tin phòng: ");
                richTextBox1.AppendText("\n\n                       Phòng: " + this.hd.T_phong);
                richTextBox1.AppendText("\n                       Tầng: " + this.hd.T_tang);
                richTextBox1.AppendText("\n             --------------------------------------------");
                richTextBox1.AppendText("\n             Thông tin dịch vụ: ");
                foreach(DichVu dv in this.dichVu)
                {
                    richTextBox1.AppendText("\n                       Dịch vụ: " + dv.T_dvu + "   Số lượng: " + dv.S_luong+"   Thành tiền: "+ String.Format("{0:#,##0.00}", dv.T_tien));
                }
                richTextBox1.AppendText("\n             --------------------------------------------");
                richTextBox1.AppendText("\n             Thông tin vào: ");
                richTextBox1.AppendText("\n                       Ngày: " + this.hd.N_vao);
                richTextBox1.AppendText("\n                        Giờ: " + this.hd.G_vao);
                richTextBox1.AppendText("\n\n             Thông tin ra: ");
                richTextBox1.AppendText("\n                         Ngày: " + "4/12/2020");
                richTextBox1.AppendText("\n                        Giờ: " + "12:45 pm");
                richTextBox1.AppendText("\n             --------------------------------------------");
                richTextBox1.AppendText("\n             Thông tin sử dụng: ");
                richTextBox1.AppendText("\n                         Số giờ sử dụng: " + this.hd.S_gio);
                richTextBox1.AppendText("\n                         Dịch vụ: " + this.hd.D_vu);
                richTextBox1.AppendText("\n                         Thành tiền: " + String.Format("{0:#,##0.00}", Int32.Parse(this.hd.S_tien)));
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
                if (cnn.RepairData("update phong set t_thai = 1 where id =" + hd.Id_phong + ";") != 0 && cnn.RepairData("delete from ds_dich_vu where id_phong ="+hd.Id_phong+"") != 0)
                {

                    row = 1;
                    MessageBox.Show("In hóa đơn thành công");
                    this.Dispose();
                }
                else
                {
                    Console.WriteLine("Lỗi phần phòng");
                    row = 0;
                }
            }
            else
            {
                Console.WriteLine("Lỗi phần hóa đơn");
                row = 0;
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
