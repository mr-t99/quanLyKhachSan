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
using System.Globalization;

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
        private HoaDon hd = new HoaDon();
        private string t_nv;

        public datphong()
        {
            InitializeComponent();
        }
        public void setOption(int a, int id, string t_nv)
        {
            this.selectOption = a;
            this.id_tkhoan = id;
            this.t_nv = t_nv;
            if (a == 1)
            {
                txtTenKhachHang.Clear();
                panelPhong.Enabled = false;
                panelThongTin.Enabled = false;
                btXacNhan.Text = "Trả Phòng";
                label1.Text = "Trả Phòng";
                loadDataGirlView();
                btXacNhan.Enabled = false;
            }
            if (a == 0)
            {
                txtTenKhachHang.Clear();
                panelPhong.Enabled = true;
                panelThongTin.Enabled = true;
                btXacNhan.Text = "Đặt phòng";
                label1.Text = "Đặt phòng";
                loadDataGirlView();
                btXacNhan.Enabled = true;
            }
        }

        public void loadDataGirlView()
        {
            cnn = new ConnectDatabase();
            dataGirl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (this.selectOption == 1)
            {
                dataGirl.DataSource = cnn.getdata("select tang.ten,phong.t_phong as N'Tên phòng', hoa_don.khach_hang as N'Khách hàng','Giờ vào'=concat(DATEPART(hh, gio_vao),':', DATEPART(mi, gio_vao)), 'Ngày vào'=concat(DATEPART(dd, gio_vao),'/', DATEPART(mm, gio_vao),'/', DATEPART(YY, gio_vao)), dich_vu.t_dvu as N'Dịch vụ', id_phong, hoa_don.id from phong, hoa_don, tang, dich_vu where tang.id = phong.id_tang and hoa_don.id_phong = phong.id and gio_ra is null and hoa_don.id_dvu = dich_vu.id;");
                dataGirl.Columns[0].Visible = false;
                dataGirl.Columns[6].Visible = false;
                dataGirl.Columns[7].Visible = false;
            }
            else
            {
                dataGirl.DataSource = cnn.getdata("select t_phong as N'Phòng trống', ten as N'Tầng', trang_thai.t_tthai as N'Trạng thái' from phong, trang_thai,tang where phong.t_thai = trang_thai.id and tang.id = phong.id_tang and trang_thai.id =1;");
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
                    btXacNhan.Enabled = true;
                    txtTenKhachHang.Text = dataGirl.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cbDichVu.SelectedIndex = cbDichVu.FindStringExact(dataGirl.Rows[e.RowIndex].Cells[5].Value.ToString());
                    cbTang.SelectedIndex = cbTang.FindStringExact(dataGirl.Rows[e.RowIndex].Cells[0].Value.ToString());
                    cbPhong.SelectedIndex = cbPhong.FindStringExact(dataGirl.Rows[e.RowIndex].Cells[1].Value.ToString());

                    //gan gia tri cho đối tượng hóa đơn
                    this.hd.G_vao = dataGirl.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.hd.N_vao = dataGirl.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.hd.T_khang = dataGirl.Rows[e.RowIndex].Cells[2].Value.ToString();
                    this.hd.T_nv = this.t_nv;
                    this.hd.T_phong = dataGirl.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.hd.T_tang = dataGirl.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.hd.D_vu = dataGirl.Rows[e.RowIndex].Cells[5].Value.ToString();
                    this.hd.Id_phong = dataGirl.Rows[e.RowIndex].Cells[6].Value.ToString();
                    this.hd.Id_tkhoan = this.id_tkhoan.ToString();
                    this.hd.Id_hoaDon = dataGirl.Rows[e.RowIndex].Cells[7].Value.ToString();

                    //đoạn này là sử lý cộng trừ ngày
                    string stNgayVao = dataGirl.Rows[e.RowIndex].Cells[4].Value.ToString() + " " + dataGirl.Rows[e.RowIndex].Cells[3].Value.ToString();
                    stNgayVao = DateTime.ParseExact(stNgayVao, "dd/MM/yyyy H:m", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);
                    DateTime dateNgayVao = DateTime.Parse(stNgayVao);
                    //Lấy id dịch vụ
                    DichVu dv = new DichVu();
                    dv = (DichVu)cbDichVu.SelectedItem;
                    //gọi hàm tính tiền
                    tinhTien(dateNgayVao, dv.Id);
                    
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
                row = cnn.RepairData("insert into hoa_don(id_tKhoan_vao,khach_hang, gio_vao, gio_ra, id_dvu, id_phong, t_tien) values (" +
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
                        dataGirl.DataSource = cnn.getdata("select t_phong as N'Phòng trống', ten as N'Tầng', trang_thai.t_tthai as N'Trạng thái' from phong, trang_thai,tang where phong.t_thai = trang_thai.id and tang.id = phong.id_tang and trang_thai.id =1;");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi đặt phòng");
                        Console.WriteLine("Sua phong");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi đặt phòng");
                    Console.WriteLine("Them Hoa don");
                }
                
                
            }
            else
            {
                //tra phong
                FromHoaDon fromHoaDon = new FromHoaDon(this.hd);
                fromHoaDon.Show();
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
        private void tinhTien(DateTime tgVao, int idDichVu)
        {
            int giaDv = 0, thanhTien = 0;
            //xử lấy giá tiền trong database
            DataTable dichVu = cnn.getdata("select * from dich_vu where id = "+idDichVu+";");
            if(dichVu.Rows.Count != 0)
            {
                DataRow dr = dichVu.Rows[0];
                giaDv = (int)dr["gia"];
            }
            else
            {
                MessageBox.Show("Lỗi không tìm thấy dịch vụ");
                giaDv = 0;
            }
            //xử lý thời gian sử dung
            TimeSpan time = DateTime.Now.Subtract(tgVao);
            this.hd.S_gio = time.Days+ " ngày " + time.Hours.ToString() +" giờ "+ time.Minutes.ToString()+" phút";
            int phut = (time.Days * 24 * 60) + (time.Hours * 60) + time.Minutes;
            if(phut > 30)
            {
                if (idDichVu == 1)
                {
                    /* Hàm tính tiền theo dịch vụ theo ngày
                     * Cách tính: (giá một ngày X số ngày) + (giá theo giờ X số giờ lẻ)
                    */
                    int gia1Gio = 70000;
                    thanhTien = (giaDv * time.Days) + (gia1Gio * time.Hours + time.Minutes * (gia1Gio / 60));
                }
                else
                {
                    //tinh tien theo gio
                    thanhTien = (time.Days * 24 * giaDv) + (giaDv * time.Hours + time.Minutes * (giaDv / 60));
                    
                }
                lableThanhtien.Text = String.Format("{0:#,##0.00}", thanhTien);
                this.hd.S_tien = String.Format("{0:#,##0.00}", thanhTien);
            }
            else
            {
                lableThanhtien.Text = "Khác hàng mới dùng: "+phut+" phút";
                this.hd.S_tien = "0";
            }
        }
        public void loadData(int i)
        {
            this.selectOption = i;
            dataGirl.DataSource = null;
        }
    }
}
