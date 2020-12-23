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
        private int selectOption, id_tkhoan, id_phong;
        private ConnectDatabase cnn;
        private ArrayList arrDichVu, arrPhong, arrTang;
        private modelHoaDon hoaDon;
        private KhachHang khachHang;
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
            lbThanhTien.Visible = false;
            lableThanhtien.Visible = false;
            if (a == 1)
            {
                //Tra phong
                txtTenKhachHang.Clear();
                panelPhong.Enabled = false;
                panelThongTin.Enabled = false;
                btXacNhan.Text = "Trả Phòng";
                label1.Text = "Trả Phòng";
                loadDataGirlView();
                btXacNhan.Enabled = false;
                lbThanhTien.Visible = true;
                lableThanhtien.Visible = true;
                btThiemDichVu.Visible = true;
                btThiemDichVu.Enabled = false;
            }
            if (a == 0)
            {
                //dat phong
                txtTenKhachHang.Clear();
                panelPhong.Enabled = true;
                panelThongTin.Enabled = true;
                btXacNhan.Text = "Đặt phòng";
                label1.Text = "Đặt phòng";
                loadDataGirlView();
                btXacNhan.Enabled = false;
                lbThanhTien.Visible = false;
                lableThanhtien.Visible = false;
                //trang thai chi doc cho text box
                txtTenKhachHang.ReadOnly = true;
                txtSdt.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                btThiemDichVu.Visible = false;
            }
        }

        public void loadDataGirlView()
        {
            cnn = new ConnectDatabase();
            dataGirl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (this.selectOption == 1)
            {
                dataGirl.DataSource = cnn.getdata("select tang.ten,phong.t_phong as N'Tên phòng', khach_hang.t_khang as N'Khách hàng',khach_hang.cmnd as 'CMND','Giờ vào'=concat(DATEPART(hh, gio_vao),':', DATEPART(mi, gio_vao)), 'Ngày vào'=concat(DATEPART(dd, gio_vao),'/', DATEPART(mm, gio_vao),'/', DATEPART(YY, gio_vao)), id_phong, hoa_don.id, khach_hang.cmnd, khach_hang.sdt, khach_hang.d_chi from phong, hoa_don, tang, khach_hang where tang.id = phong.id_tang and hoa_don.id_phong = phong.id and gio_ra is null and hoa_don.cmnd = khach_hang.cmnd;");
                dataGirl.Columns[0].Visible = false;
                dataGirl.Columns[6].Visible = false;
                dataGirl.Columns[7].Visible = false;
                dataGirl.Columns[8].Visible = false;
                dataGirl.Columns[9].Visible = false;
                dataGirl.Columns[10].Visible = false;
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
                    btThiemDichVu.Enabled = true;
                    //đay du lieu vao text box
                    txtTenKhachHang.Text = dataGirl.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtCmnd.Text = dataGirl.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtDiaChi.Text = dataGirl.Rows[e.RowIndex].Cells[10].Value.ToString();
                    txtSdt.Text = dataGirl.Rows[e.RowIndex].Cells[9].Value.ToString();

                    cbTang.SelectedIndex = cbTang.FindStringExact(dataGirl.Rows[e.RowIndex].Cells[0].Value.ToString());
                    cbPhong.SelectedIndex = cbPhong.FindStringExact(dataGirl.Rows[e.RowIndex].Cells[1].Value.ToString());

                    //gan gia tri cho đối tượng hóa đơn
                    this.hd.G_vao = dataGirl.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.hd.N_vao = dataGirl.Rows[e.RowIndex].Cells[5].Value.ToString();
                    this.hd.T_khang = dataGirl.Rows[e.RowIndex].Cells[2].Value.ToString();
                    this.hd.T_nv = this.t_nv;
                    this.hd.T_phong = dataGirl.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.hd.T_tang = dataGirl.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.hd.Id_phong = dataGirl.Rows[e.RowIndex].Cells[6].Value.ToString();
                    id_phong = (int)dataGirl.Rows[e.RowIndex].Cells[6].Value;
                    this.hd.Id_tkhoan = this.id_tkhoan.ToString();
                    this.hd.Id_hoaDon = dataGirl.Rows[e.RowIndex].Cells[7].Value.ToString();
                    this.hd.Cmnd = dataGirl.Rows[e.RowIndex].Cells[8].Value.ToString();
                    this.hd.Sdt = dataGirl.Rows[e.RowIndex].Cells[9].Value.ToString();
                    this.hd.Dia_chi = dataGirl.Rows[e.RowIndex].Cells[10].Value.ToString();

                    //đoạn này là sử lý cộng trừ ngày
                    string stNgayVao = dataGirl.Rows[e.RowIndex].Cells[5].Value.ToString() + " " + dataGirl.Rows[e.RowIndex].Cells[4].Value.ToString();
                    stNgayVao = DateTime.ParseExact(stNgayVao, "dd/MM/yyyy H:m", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);
                    DateTime dateNgayVao = DateTime.Parse(stNgayVao);

                    //gọi hàm tính tiền
                    tinhTien(dateNgayVao);
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
                if (setData() == true)
                {
                    try
                    {
                        row = cnn.RepairData("insert into hoa_don(id_tKhoan_vao,cmnd, gio_vao, id_phong) values (" +
                        this.hoaDon.Id_tkhoan + ",'" +
                        txtCmnd.Text + "', GETDATE(), " +
                        hoaDon.Id_phong + ")");
                        row = cnn.RepairData("update khach_hang set t_khang ='" +
                                khachHang.T_khang + "', sdt='" +
                                khachHang.Sdt + "', d_chi='" +
                                khachHang.D_chi + "' where cmnd='" + txtCmnd.Text + "'");
                    }
                    catch
                    {
                        Console.WriteLine("Lỗi thêm phòng");
                        row = 0;
                    }
                    if (row != 0)
                    {
                        row = cnn.RepairData("update phong set t_thai=2 where id=" + hoaDon.Id_phong + ";");
                        if (row != 0)
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
            }
            else
            {
                //tra phong
                Console.WriteLine(hd.G_vao);
                LayDanhSachDv();
                FromHoaDon fromHoaDon = new FromHoaDon(this.hd, this.arrDichVu);
                fromHoaDon.Show();
            }
        }

        private void loadAllDataCbBox()
        {
            arrDichVu = new ArrayList();
            cnn = new ConnectDatabase();
            DataTable data;

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
        private bool setData()
        {
            string mess = "";
            if (txtDiaChi.TextLength == 0)
            {
                mess += "Địa chỉ trống\n";
            }
            if (txtSdt.TextLength == 0)
            {
                mess += "Số điện thoại trống\n";
            }
            if (txtTenKhachHang.TextLength == 0)
            {
                mess += "Tên khách hàng trống";
            }
            
            if (mess.Length == 0)
            {
                hoaDon = new modelHoaDon();
                this.hoaDon.T_khang = txtTenKhachHang.Text;
                Tang tang = new Tang();
                tang = (Tang)cbTang.SelectedItem;
                this.hoaDon.Id_tang = tang.Id;
                Phong phong = new Phong();
                phong = (Phong)cbPhong.SelectedItem;
                this.hoaDon.Id_phong = phong.Id;
                hoaDon.Id_tkhoan = this.id_tkhoan;

                khachHang = new KhachHang();
                khachHang.T_khang = txtTenKhachHang.Text;
                khachHang.Cmnd = txtCmnd.Text;
                khachHang.D_chi = txtDiaChi.Text;
                khachHang.Sdt = txtSdt.Text;
                return true;
            }
            else
            {
                MessageBox.Show(mess);
                return false;
            }
        }

        private void btKiemTra_Click(object sender, EventArgs e)
        {
            if (txtCmnd.TextLength != 9 || Int32.TryParse(txtCmnd.Text, out int a) ==false)
            {
                MessageBox.Show("Số chứng minh không hợp lệ");
            }
            else
            {
                btXacNhan.Enabled = true;
                if (checkCmnd() == true)
                {
                    
                }
                else
                {
                    cnn.RepairData("insert into khach_hang(cmnd) values(" + txtCmnd.Text + ")");
                    MessageBox.Show("Khách hàng mới");
                }
            }
            
        }

        private void tinhTien(DateTime tgVao)
        {
            int tien_dvu = getTien(), thanhTien = 0;
            lableThanhtien.Visible = true;
            lbThanhTien.Visible = true;
            
            //xử lý thời gian sử dung
            TimeSpan time = DateTime.Now.Subtract(tgVao);
            this.hd.S_gio = time.Days + " ngày " + time.Hours.ToString() + " giờ " + time.Minutes.ToString() + " phút";
            int phut = (time.Days * 24 * 60) + (time.Hours * 60) + time.Minutes;
            
            //tính tiền
            if (phut > 30)
            {
                thanhTien = time.Hours * 120000 + tien_dvu;
                lableThanhtien.Text = String.Format("{0:#,##0.00}", thanhTien);
                this.hd.S_tien = thanhTien.ToString();
            }
            else
            {
                lableThanhtien.Text = "Khác hàng mới dùng: " + phut + " phút";
                this.hd.S_tien = "0";
                this.hd.S_tien = tien_dvu.ToString();
            }
        }

        int getTien()
        {
            int tien = 0;
            DataTable t = cnn.getdata("select sum(gia*s_luong) as'tong' from phong, dich_vu, ds_dich_vu where phong.id = ds_dich_vu.id_phong and dich_vu.id = ds_dich_vu.id_dvu and phong.id = " + id_phong + "");
            Console.WriteLine();
            if (t.Rows.Count != 0 && t.Rows[0]["tong"].ToString().Length != 0)
            {
                tien = (int)t.Rows[0]["tong"];
            }
            return tien;
        }
        void LayDanhSachDv()
        {
            arrDichVu = new ArrayList();
            DataTable dv = cnn.getdata("select t_phong , t_dvu , (gia*s_luong) as 'gia' , s_luong  from phong, dich_vu, ds_dich_vu where phong.id = ds_dich_vu.id_phong and dich_vu.id = ds_dich_vu.id_dvu and phong.id = "+id_phong+"");
            if (dv != null)
            {
                foreach(DataRow dr in dv.Rows)
                {
                    DichVu dichVu = new DichVu();
                    dichVu.T_dvu = dr["t_dvu"].ToString();
                    dichVu.T_tien = (int)dr["gia"];
                    dichVu.S_luong = (int)dr["s_luong"];
                    arrDichVu.Add(dichVu);
                }
            }
        }

        private void txtCmnd_TextChanged(object sender, EventArgs e)
        {
            btXacNhan.Enabled = false;
        }

        private void btThiemDichVu_Click(object sender, EventArgs e)
        {
            FormDichVu formDichVu = new FormDichVu(id_phong);
            formDichVu.Show();
        }

        private bool checkCmnd()
        {
            
            DataTable kh = cnn.getdata("select * from khach_hang where cmnd = '" + txtCmnd.Text + "'");
            if (kh.Rows.Count > 0)
            {
                txtTenKhachHang.Text = kh.Rows[0]["t_khang"].ToString();
                txtDiaChi.Text = kh.Rows[0]["d_chi"].ToString();
                txtSdt.Text = kh.Rows[0]["sdt"].ToString();
                
                return true;
            }
            else
            {
                txtTenKhachHang.ReadOnly = false;
                txtSdt.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                clearData();
                return false;
            }
        }
        void clearData()
        {
            txtDiaChi.Clear();
            txtSdt.Clear();
            txtTenKhachHang.Clear();
        }
        public void loadData(int i)
        {
            this.selectOption = i;
            dataGirl.DataSource = null;
        }
    }
}
