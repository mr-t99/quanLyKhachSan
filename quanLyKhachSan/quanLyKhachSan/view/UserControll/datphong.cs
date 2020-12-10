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
    public partial class datphong : UserControl
    {
        class DichVu
        {
            string t_dvu;
            int id;

            public string T_dvu { get => t_dvu; set => t_dvu = value; }
            public int Id { get => id; set => id = value; }
        }
        class Tang
        {
            string t_tang;
            int id;

            public string T_tang { get => t_tang; set => t_tang = value; }
            public int Id { get => id; set => id = value; }
        }
        class Phong
        {
            string t_phong;
            int id;

            public string T_phong { get => t_phong; set => t_phong = value; }
            public int Id { get => id; set => id = value; }
        }
        private int selectOption, id_tkhoan;
        private ConnectDatabase cnn;
        private ArrayList arrDichVu, arrPhong, arrTang;
        private modelHoaDon hoaDon;
        public datphong()
        {
            InitializeComponent();
        }
        public void setOption(int a, int id)
        {
            this.selectOption = a;
            this.id_tkhoan = id;
            if (a == 1) {
                txtTenKhachHang.Clear();
                panelPhong.Enabled = false;
                panelThongTin.Enabled = false;
                btXacNhan.Text = "Trả Phòng";
                label1.Text = "Trả Phòng";
                loadDataGirlView();
            }
            if (a == 0)
            {
                txtTenKhachHang.Clear();
                panelPhong.Enabled = true;
                panelThongTin.Enabled = true;
                btXacNhan.Text = "Đặt phòng";
                label1.Text = "Đặt phòng";
                loadDataGirlView();
            }
        }

        private void loadDataGirlView()
        {
            cnn = new ConnectDatabase();
            dataGirl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (this.selectOption == 0)
            {
                dataGirl.DataSource = cnn.getdata("select t_phong as N'Phòng trống', ten as N'Tầng', trang_thai.t_tthai as N'Trạng thái' from phong, trang_thai,tang where phong.t_thai = trang_thai.id and tang.id = phong.id_tang and trang_thai.id =1;");   
            }
            else
            {
                dataGirl.DataSource = cnn.getdata("select tang.ten,phong.t_phong as N'Tên phòng', hoa_don.khach_hang as N'Khách hàng','Giờ vào'=concat(DATEPART(hh, gio_vao),':', DATEPART(mi, gio_vao)), 'Ngày vào'=concat(DATEPART(dd, gio_vao),'/', DATEPART(mm, gio_vao),'/', DATEPART(YY, gio_vao)), dich_vu.t_dvu as N'Dịch vụ' from phong, hoa_don, tang, dich_vu where tang.id = phong.id_tang and hoa_don.id_phong = phong.id and gio_ra is null and hoa_don.id_dvu = dich_vu.id;");
                dataGirl.Columns[0].Visible = false;
            }
        }

        private void cbTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tang tang = new Tang();
            tang = (Tang)cbTang.SelectedItem;

            arrPhong = new ArrayList();
            DataTable data;
            if(selectOption == 0)
            {
                data = cnn.getdata("select * from phong where t_thai = 1 and id_tang=" + tang.Id + "");
            }
            else
            {
                data = cnn.getdata("select * from phong where id_tang=" + tang.Id + "");
            }
            if (data != null)
            {
                foreach (DataRow dr in data.Rows)
                {
                    Phong dv = new Phong();
                    dv.Id = Int32.Parse(dr[0].ToString());
                    dv.T_phong = dr[1].ToString();
                    arrPhong.Add(dv);
                }
            }
            cbPhong.DataSource = this.arrPhong;
            cbPhong.DisplayMember = "t_phong";
            cbPhong.ValueMember = "id";
        }

        private void dataGirl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                if (this.selectOption == 1)
                {
                    //Tra phog
                    txtTenKhachHang.Text = dataGirl.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cbDichVu.SelectedIndex = cbDichVu.FindStringExact(dataGirl.Rows[e.RowIndex].Cells[5].Value.ToString());
                    cbTang.SelectedIndex = cbTang.FindStringExact(dataGirl.Rows[e.RowIndex].Cells[0].Value.ToString());
                    cbPhong.SelectedIndex = cbPhong.FindStringExact(dataGirl.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                if (this.selectOption == 0)
                {
                    //dat phong
                    cbTang.SelectedIndex = cbTang.FindStringExact(dataGirl.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cbPhong.SelectedIndex = cbPhong.FindStringExact(dataGirl.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void datphong_Load(object sender, EventArgs e)
        {
            loadAllDataCbBox();

            cbDichVu.DataSource = this.arrDichVu;
            cbDichVu.DisplayMember = "t_dvu";
            cbDichVu.ValueMember = "id";

            cbTang.DataSource = this.arrTang;
            cbTang.DisplayMember = "t_tang";
            cbTang.ValueMember = "id";
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            int row = 0;
            if(selectOption == 0)
            {
                //datphong
                setData();
                row = cnn.RepairData("insert into hoa_don(id_tKhoan,khach_hang, gio_vao, gio_ra, id_dvu, id_phong, t_tien) values (" +
                    this.hoaDon.Id_tkhoan + ",N'" +
                    this.hoaDon.T_khang+ "', GETDATE(), null, "+
                    this.hoaDon.Id_dichvu+", "+
                    hoaDon.Id_phong+", null)");
                if(row != 0)
                {
                    row = cnn.RepairData("update phong set t_thai=2 where id="+hoaDon.Id_phong+";");
                    if(row != 0)
                    {
                        MessageBox.Show("Đã đặt phòng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi đặt phòng");
                        Console.WriteLine("Phần thêm hóa đơn");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi đặt phòng");
                    Console.WriteLine("Phần thêm hóa đơn");
                }
                
                
            }
            else
            {
                //tra phong
            }
        }

        private void loadAllDataCbBox()
        {
            arrDichVu = new ArrayList();
            cnn = new ConnectDatabase();
            DataTable data;
            data = cnn.getdata("select * from dich_vu");
            if (data != null)
            {
                foreach(DataRow dr in data.Rows)
                {
                    DichVu dv = new DichVu();
                    dv.Id = Int32.Parse(dr[0].ToString());
                    dv.T_dvu = dr[1].ToString();
                    arrDichVu.Add(dv);
                }
            }

            arrTang = new ArrayList();
            data = cnn.getdata("select * from tang");
            if (data != null)
            {
                foreach (DataRow dr in data.Rows)
                {
                    Tang dv = new Tang();
                    dv.Id = Int32.Parse(dr[0].ToString());
                    dv.T_tang = dr[1].ToString();
                    arrTang.Add(dv);
                }
            }
        }
        private void setData()
        {
            hoaDon = new modelHoaDon();
            this.hoaDon.T_khang = txtTenKhachHang.Text;
            Tang tang = new Tang();
            tang = (Tang)cbTang.SelectedItem;
            this.hoaDon.Id_tang = tang.Id;

            Phong phong = new Phong();
            phong = (Phong)cbPhong.SelectedItem;
            this.hoaDon.Id_phong = phong.Id;

            DichVu dichVu = new DichVu();
            dichVu = (DichVu)cbDichVu.SelectedItem;
            this.hoaDon.Id_dichvu = dichVu.Id;

            hoaDon.Id_tkhoan = this.id_tkhoan;
        }
    }
}
