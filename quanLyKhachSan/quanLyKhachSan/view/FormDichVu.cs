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
    public partial class FormDichVu : Form
    {
        class DanhSachTieuDung
        {
            int id, gia;
            string t_dvu;

            public int Id { get => id; set => id = value; }
            public int Gia { get => gia; set => gia = value; }
            public string T_dvu { get => t_dvu; set => t_dvu = value; }
        }
        class DanhSachDichVuSuDung
        {
            int id_phong, id_dvu, s_luong, id;

            public int Id_phong { get => id_phong; set => id_phong = value; }
            public int Id_dvu { get => id_dvu; set => id_dvu = value; }
            public int S_luong { get => s_luong; set => s_luong = value; }
            public int Id { get => id; set => id = value; }
        }
        private ConnectDatabase conn;
        private int id_phong;
        private DanhSachDichVuSuDung dsdvsd;
        private DanhSachTieuDung dsdv;
        public FormDichVu(int id_phong)
        {
            InitializeComponent();
            conn = new ConnectDatabase();
            this.id_phong = id_phong;
            btXoaDs.Enabled = false;
            btSuaDs.Enabled = false;
            btXoaDv.Enabled = false;
            btThemDv.Enabled = false;
        }
        void loadDichVu()
        {
            //load bang dich vu
            DataTable dataDv = conn.getdata("select id, t_dvu as 'Tên dịch vụ', gia as 'Giá' from dich_vu");
            dataDichVu.DataSource = dataDv;
            dataDichVu.Columns[0].Visible = false;
            dataDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDichVu.ReadOnly = true;
        }
        void loadDichVuSuDung()
        {
            //load dang dich vu phong da su dung
            DataTable dataDvSD = conn.getdata("select t_phong as 'Tên phòng', t_dvu as 'Tên dv', gia as 'Giá', s_luong as 'Số lượng', ds_dich_vu.id from phong, dich_vu, ds_dich_vu where phong.id = ds_dich_vu.id_phong and dich_vu.id = ds_dich_vu.id_dvu and phong.id = " + id_phong + "");
            dataDichVuSuDung.DataSource = dataDvSD;
            dataDichVuSuDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDichVuSuDung.ReadOnly = true;
            dataDichVuSuDung.Columns[4].Visible = false;
            DataTable tong = conn.getdata("select sum(gia*s_luong) as'tong' from phong, dich_vu, ds_dich_vu where phong.id = ds_dich_vu.id_phong and dich_vu.id = ds_dich_vu.id_dvu and phong.id = " + this.id_phong + "");
            if (tong.Rows.Count != 0 && tong.Rows[0]["tong"].ToString().Length!=0)
            {
                lbTongTien.Text = String.Format("{0:#,##0.00}", (int)tong.Rows[0]["tong"]);
            }
        }
        private void DichVu_Load(object sender, EventArgs e)
        {
            loadDichVu();
            loadDichVuSuDung();
            //load combobox
            for(int i =1; i<=10; i++)
            {
                cbSl.Items.Add(i);
            }
        }
        private void setTextboxDv(DataGridViewRow row)
        {
            dsdv = new DanhSachTieuDung();
            txtDv.Text = row.Cells[1].Value.ToString();
            txtGia.Text = row.Cells[2].Value.ToString();
            dsdv.Id = (int)row.Cells[0].Value;
            dsdv.T_dvu = txtDv.Text;
            dsdv.Gia = Int32.Parse(txtGia.Text);
        }
        private void setTextboxDvSd(DataGridViewRow row)
        {
            dsdvsd = new DanhSachDichVuSuDung();
            cbSl.SelectedIndex = cbSl.FindString(row.Cells[3].Value.ToString());
            dsdvsd.Id = (int)row.Cells[4].Value;
            dsdvsd.S_luong = (int)row.Cells[3].Value;
        }
        private bool checkTextBox()
        {
            string mess = "";
            if (txtDv.TextLength == 0)
            {
                mess += "Tên dịch vụ trống\n";
            }
            if (txtDv.TextLength == 0||Int32.TryParse(txtGia.Text, out int a)==false)
            {
                mess += "Giá không hợp lệ";
            }
            if (mess.Length == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(mess);
                return false;
            }
        }
        private void dataDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                setTextboxDv(dataDichVu.Rows[e.RowIndex]);
                btSuaDs.Enabled = true;
                btXoaDs.Enabled = true;
                btThemDv.Enabled = true;
            }
        }

        private void dataDichVuSuDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                setTextboxDvSd(dataDichVuSuDung.Rows[e.RowIndex]);
                btXoaDv.Enabled = true;
            }
        }

        private void btThemDs_Click(object sender, EventArgs e)
        {
            if (checkTextBox() == true)
            {
                int row = conn.RepairData("insert into dich_vu(t_dvu, gia) values (N'" + txtDv.Text + "', " + txtGia.Text + ")");
                if (row != 0)
                {
                    MessageBox.Show("Thêm thành công");
                    loadDichVu();
                }
                else
                {
                    MessageBox.Show("Thêm lỗi");
                }
            }
        }

        private void btSuaDs_Click(object sender, EventArgs e)
        {
            if (checkTextBox() == true)
            {
                int row = conn.RepairData("update dich_vu set t_dvu ='"+txtDv.Text+"', gia=1 where id='"+dsdv.Id+"'");
                if (row != 0)
                {
                    MessageBox.Show("Sửa thành công");
                    loadDichVu();
                }
                else
                {
                    MessageBox.Show("Sửa lỗi");
                }
            }
        }

        private void btXoaDs_Click(object sender, EventArgs e)
        {
            if (checkTextBox() == true)
            {
                int row = conn.RepairData("delete from dich_vu where id ="+dsdv.Id+"");
                if (row != 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loadDichVu();
                }
                else
                {
                    MessageBox.Show("Xóa lỗi");
                }
            }
        }

        private void btXoaDv_Click(object sender, EventArgs e)
        {
                int row = conn.RepairData("delete from ds_dich_vu where id =" + dsdvsd.Id + "");
                if (row != 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loadDichVuSuDung();
                }
                else
                {
                    MessageBox.Show("Xóa lỗi");
                }
        }

        private void btThemDv_Click(object sender, EventArgs e)
        {
            string mess = "";
            if (txtDv.TextLength == 0)
            {
                mess += "Tên dịch vụ trống\n";
            }
            if (txtDv.TextLength == 0 || Int32.TryParse(txtGia.Text, out int a) == false)
            {
                mess += "Giá không hợp lệ";
            }
            if (mess.Length == 0)
            {
                if(cbSl.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn số lượng dịch vụ");
                }
                else
                {
                    int row = conn.RepairData("insert into ds_dich_vu values(" + id_phong + ", " + dsdv.Id + ", "+cbSl.SelectedItem+")");
                    if (row != 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        loadDichVuSuDung();
                    }
                    else
                    {
                        MessageBox.Show("Thêm lỗi");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Bạn phải chọn tiêu dùng trên danh sách tiêu dùng!");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
