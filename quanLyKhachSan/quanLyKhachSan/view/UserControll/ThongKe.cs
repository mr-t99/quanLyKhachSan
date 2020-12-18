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
    public partial class ThongKe : UserControl
    {
        int id_nvien, loai;
        ConnectDatabase cnn;
        public ThongKe()
        {
            InitializeComponent();
            
        }
        public void setLoai(int loai)
        {
            this.loai = loai;
            Console.WriteLine(loai);
            cnn = new ConnectDatabase();
            tableNhanVien.DataSource = cnn.getdata("select id_tKhoan, h_ten as 'Họ tên' from nhan_vien");
            tableNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Console.WriteLine(DateTime.Now);
            ThongTin.Visible = false;
            lbThongBao.Visible = false;

            //tùy chọn hiển thị giao diện
            cnn = new ConnectDatabase();
            DataTable data = new DataTable();
            if (loai == 1)
            {
                //hiện thị giao diện theo tháng
                lbNgayThang.Text = "Tháng này: ";
                lbNgay.Text = DateTime.Now.ToString("MM");
                data = cnn.getdata("select sum(t_tien) as 'tong' from hoa_don where DATEPART(mm, gio_vao) = '"+lbNgay.Text+"'");
                if (data.Rows[0]["tong"].ToString().Length != 0)
                {
                    lbTong.Text = String.Format("{0:#,##0.00}", Int32.Parse(data.Rows[0]["tong"].ToString())) + " VND";
                }
                else
                {
                    lbTong.Text = 0 + "VND";
                }

            }
            else
            {
                //hiển thị giao diện theo ngày
                lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lbNgayThang.Text = "Hôm nay:";
                data = cnn.getdata("select sum(hoa_don.t_tien) as 'tong' from hoa_don, phong, dich_vu where  hoa_don.id_phong = phong.id and hoa_don.id_dvu = dich_vu.id and hoa_don.id_tKhoan_ra is not null and t_tien is not null and DATEPART(dd, gio_vao) = DATEPART(dd, GETDATE()) and DATEPART(mm, gio_vao) = DATEPART(mm, GETDATE())");
                if (data.Rows[0]["tong"].ToString().Length != 0)
                {
                    lbTong.Text = String.Format("{0:#,##0.00}", Int32.Parse(data.Rows[0]["tong"].ToString())) + " VND";
                }
                else
                {
                    lbTong.Text = 0 + "VND";
                }
            }
        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tableNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.id_nvien = (int)tableNhanVien.Rows[e.RowIndex].Cells[0].Value;
                ThongTin.Visible = true;
                if (loai == 0)
                {
                    LayThongTinGiaoDich("select khach_hang as 'Khách hàng', dich_vu.t_dvu as 'Dịch vụ', t_tien as 'Chi phí' from hoa_don, phong, dich_vu where  hoa_don.id_phong = phong.id and hoa_don.id_dvu = dich_vu.id and hoa_don.id_tKhoan_ra is not null and t_tien is not null and DATEPART(dd, gio_vao) = DATEPART(dd, GETDATE()) and DATEPART(mm, gio_vao) = DATEPART(mm, GETDATE()) and id_tKhoan_ra =" + this.id_nvien + " ");
                    LayTongTien("select sum(t_tien) as tong from hoa_don, phong, dich_vu where  hoa_don.id_phong = phong.id and hoa_don.id_dvu = dich_vu.id and hoa_don.id_tKhoan_ra is not null and t_tien is not null and DATEPART(dd, gio_vao) = DATEPART(dd, GETDATE()) and DATEPART(mm, gio_vao) = DATEPART(mm, GETDATE()) and id_tKhoan_ra ="+id_nvien+" ");
                }
                else
                {
                    LayThongTinGiaoDich("select khach_hang as 'Khách hàng', dich_vu.t_dvu as 'Dịch vụ', t_tien as 'Chi phí' from hoa_don, phong, dich_vu where  hoa_don.id_phong = phong.id and hoa_don.id_dvu = dich_vu.id and hoa_don.id_tKhoan_ra is not null and t_tien is not null and DATEPART(mm, gio_vao) = "+DateTime.Now.ToString("MM")+" and id_tKhoan_ra = "+id_nvien+"");
                    LayTongTien("select sum(t_tien) as tong from hoa_don, phong, dich_vu where  hoa_don.id_phong = phong.id and hoa_don.id_dvu = dich_vu.id and hoa_don.id_tKhoan_ra is not null and t_tien is not null and DATEPART(mm, gio_vao) = " + DateTime.Now.ToString("MM") + " and id_tKhoan_ra = " + id_nvien+"");
                }
            }
        }
      
        private void LayThongTinGiaoDich(string sql)
        {
           if(this.id_nvien != 0)
            {
                cnn = new ConnectDatabase();
                DataTable data = cnn.getdata(sql);
                if (data.Rows.Count != 0)
                {
                    tableGiaoDich.DataSource = data;
                    tableGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    lbThongBao.Visible = false;
                    tableGiaoDich.Visible = true;
                }
                else
                {
                    lbThongBao.Visible = true;
                    tableGiaoDich.Visible = false;
                }
            }
        }
        private void LayTongTien(string sql)
        {
            if (this.id_nvien != 0)
            {
                cnn = new ConnectDatabase();
                DataTable data = cnn.getdata(sql);
                if (data.Rows[0]["tong"].ToString().Length != 0)
                {
                    lbDoanhThu.Text = String.Format("{0:#,##0.00}", Int32.Parse(data.Rows[0]["tong"].ToString())) + " VND";
                }
                else
                {
                    lbDoanhThu.Text = "0";
                }
            }
        }
    }
}
