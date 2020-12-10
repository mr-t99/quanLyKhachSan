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
    public partial class phong : UserControl
    {
        ConnectDatabase cnn;
        ArrayList arrTang;
        int id_phong, id_thietBi;
        class tang
        {
            string t_tang;
            int id;

            public string T_tang { get => t_tang; set => t_tang = value; }
            public int Id { get => id; set => id = value; }
        }
        public phong()
        {
            InitializeComponent();
        }

        private void phong_Load(object sender, EventArgs e)
        {
            loadDataPhong();
            getValueCbTang();
            btPhongSua.Enabled = false;
            btPhongXoa.Enabled = false;
            plThietBi.Enabled = false;
        }
        private void loadDataPhong()
        {
            cnn = new ConnectDatabase();
            DataTable data = cnn.getdata("select phong.id, t_phong as N'Tên phòng', tang.ten as N'Tầng', trang_thai.t_tthai as N'Trạng thái' from phong, tang, trang_thai where phong.t_thai = trang_thai.id and phong.id_tang = tang.id;");
            dataGirlPhong.DataSource = data;
            dataGirlPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGirlPhong.Columns["id"].Visible = false;
            
        }
        private void LoadDataThietBi()
        {
            cnn = new ConnectDatabase();
            dataGirlThietBi.DataSource = cnn.getdata("select id, t_tbi as N'Thiết bị', gia as N'Giá',t_ttrang as N'Trạng Thái' from thiet_bi where id_phong=" + this.id_phong + "");
            dataGirlThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGirlThietBi.Columns["id"].Visible = false;
            btThietBiSua.Enabled = false;
            btThietBiXoa.Enabled = false;
        }

        private void getValueCbTang()
        {
            cnn = new ConnectDatabase();
            arrTang = new ArrayList();
            DataTable data = cnn.getdata("select * from tang;");
            if(data != null)
            {
                foreach(DataRow dr in data.Rows)
                {
                    tang t = new tang();
                    t.T_tang = dr["ten"].ToString();
                    t.Id = (int)dr["id"];
                    arrTang.Add(t);
                }
                cbTang.DataSource = arrTang;
                cbTang.DisplayMember = "t_tang";
                cbTang.ValueMember = "id";
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu tầng");
            }
        }

        private void btPhongThem_Click(object sender, EventArgs e)
        {
            string mess = "";
            if (txtMaPhong.TextLength == 0)
            {
                mess += "Bạn chưa nhập tên thiết bị";
            }
            if (mess.Length == 0)
            {
                addPhong();
            }
            else
            {
                MessageBox.Show(mess);
            }
            
        }

        private void dataGirlThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                this.id_thietBi = (int)dataGirlThietBi.Rows[e.RowIndex].Cells[0].Value;
                btThietBiXoa.Enabled = true;
                btThietBiSua.Enabled = true;
                btThietBiThem.Enabled = false;
                txtTenThietBi.Text = dataGirlThietBi.Rows[e.RowIndex].Cells[1].Value.ToString();
               
                if (dataGirlThietBi.Rows[e.RowIndex].Cells[3].Value.ToString() == "Hoạt động")
                {
                    rbHoatDong.Checked = true;
                }
                else
                {
                    rbKhongHoatDong.Checked = true;
                }
                txtGia.Text = dataGirlThietBi.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void dataGirlPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1 )
            {
                this.id_phong = (int)dataGirlPhong.Rows[e.RowIndex].Cells["id"].Value;
                LoadDataThietBi();
                plThietBi.Enabled = true;
                btPhongSua.Enabled = true;
                btPhongXoa.Enabled = true;
                txtMaPhong.Text = dataGirlPhong.Rows[e.RowIndex].Cells["Tên phòng"].Value.ToString();
                cbTang.SelectedIndex = cbTang.FindStringExact(dataGirlPhong.Rows[e.RowIndex].Cells[2].Value.ToString());
                btPhongThem.Enabled = false;
                btThietBiThem.Enabled = true;
            }
        }
        private void addThietBi()
        {
            int row = 0;
            cnn = new ConnectDatabase();
            ModelPhong modelPhong = getValue();
            row = cnn.RepairData("insert into thiet_bi(id_phong, t_tbi, gia, t_ttrang) values (" + modelPhong.Id_phong + ", N'"+
                modelPhong.T_thietBi+"',"+
                modelPhong.Gia+", N'"+
                modelPhong.T_thaiTb+"')");
            if (row != 0)
            {
                MessageBox.Show("Thêm thiết bị thành công");
                LoadDataThietBi();
            }
            else
            {
                MessageBox.Show("Lỗi phần thêm thiết bị");
            }
        }
        private void addPhong()
        {
            int row = 0;
            cnn = new ConnectDatabase();
            ModelPhong modelPhong = getValue();
            row = cnn.RepairData("insert into phong(t_phong, id_tang, t_thai) values ('" +
                modelPhong.T_phong + "', " +
                modelPhong.Id_tang + ",1)");
            if (row != 0)
            {
                MessageBox.Show("Thêm thiết bị thành công");
                loadDataPhong();
            }
            else
            {
                MessageBox.Show("Lỗi phần thêm thiết bị");
            }
        }

        private void SuaPhong()
        {
            Console.WriteLine(this.id_phong);
            int row = 0;
            cnn = new ConnectDatabase();
            ModelPhong modelPhong = getValue();
            row = cnn.RepairData("update phong set t_phong='"+modelPhong.T_phong+"', id_tang="+modelPhong.Id_tang+" where id="+this.id_phong+"");
            if (row != 0)
            {
                MessageBox.Show("Sửa phòng thành công");
                loadDataPhong();
            }
            else
            {
                MessageBox.Show("Lỗi phần sửa phòng");
            }
        }
        private void SuaThietBi()
        {
            int row = 0;
            cnn = new ConnectDatabase();
            ModelPhong modelPhong = getValue();
            row = cnn.RepairData("update thiet_bi set gia="
                +modelPhong.Gia+ ", t_tbi=N'"
                + modelPhong.T_thietBi + "',t_ttrang=N'"
                + modelPhong.T_thaiTb+"'  where id="+modelPhong.Id_thietBi+" and id_phong = "+this.id_phong+"");
            if (row != 0)
            {
                MessageBox.Show("Sửa thiết bị thành công");
                LoadDataThietBi();
            }
            else
            {
                MessageBox.Show("Lỗi phần sửa thiết bị");
            }
        }
        private void XoaThietBi()
        {
            int row = 0;
            cnn = new ConnectDatabase();
            ModelPhong modelPhong = getValue();
            row = cnn.RepairData("delete thiet_bi where id="+modelPhong.Id_thietBi+"");
            if (row != 0)
            {
                MessageBox.Show("Xóa bị thành công");
                LoadDataThietBi();
            }
            else
            {
                MessageBox.Show("Lỗi phần Xóa thiết bị");
            }
        }
        private void XoaPhong()
        {
            int row = 0;
            cnn = new ConnectDatabase();
            ModelPhong modelPhong = getValue();
            row = cnn.RepairData("alter table hoa_don nocheck constraint all;alter table thu_nhap nocheck constraint all;alter table thiet_bi nocheck constraint all;delete from phong WHERE id="+modelPhong.Id_phong+";alter table hoa_don check constraint all;alter table thu_nhap check constraint all;alter table thiet_bi check constraint all ");
            if (row != 0)
            {
                MessageBox.Show("Xóa phòng thành công");
                loadDataPhong();
            }
            else
            {
                MessageBox.Show("Lỗi phần xóa thiết bị");
            }
        }

        private void btPhongSua_Click(object sender, EventArgs e)
        {
            string mess = "";
            if (txtMaPhong.TextLength == 0)
            {
                mess += "Bạn chưa nhập tên thiết bị";
            }
            if (mess.Length == 0)
            {
                SuaPhong();
            }
            else
            {
                MessageBox.Show(mess);
            }
            
            
        }

        private void btPhongXoa_Click(object sender, EventArgs e)
        {
            DialogResult rl = MessageBox.Show("Bạn xóa phòng có thể gây một số lỗi trong database. Bạn có trắc muốn xóa!", "Thông báo", MessageBoxButtons.YesNo);
            if(rl == DialogResult.Yes)
            {
                XoaPhong();
            }
        }

        private void btThietBiThem_Click(object sender, EventArgs e)
        {
            string mess = "";
            if (txtTenThietBi.TextLength == 0)
            {
                mess += "Bạn chưa nhập tên thiết bị\n";
            }
            if(rbHoatDong.Checked ==false && rbKhongHoatDong.Checked == false)
            {
                mess += "Trạng thái thiết bị trống!";
            }
            if (mess.Length == 0)
            {
                addThietBi();
            }
            else
            {
                MessageBox.Show(mess);
            }
        }

        private void btThietBiSua_Click(object sender, EventArgs e)
        {
            SuaThietBi();
        }

        private void btThietBiXoa_Click(object sender, EventArgs e)
        {
            XoaThietBi();
        }

        private ModelPhong getValue()
        {
            ModelPhong modelPhong = new ModelPhong();
            modelPhong.Gia = Int32.Parse(txtGia.Text);
            modelPhong.Id_phong = this.id_phong;
            tang t = new tang();
            t = (tang)cbTang.SelectedItem;
            modelPhong.Id_tang = t.Id;
            modelPhong.Id_thietBi = this.id_thietBi;
            modelPhong.T_phong = txtMaPhong.Text;
            string statusThietBi = rbHoatDong.Text;
            if(rbHoatDong.Checked == false)
            {
                statusThietBi = rbKhongHoatDong.Text;
            }
            modelPhong.T_thaiTb = statusThietBi;
            modelPhong.T_thietBi = txtTenThietBi.Text;
            return modelPhong;
        }
        private int checkTextBox()
        {
            string mess = "";
            if(txtTenThietBi.TextLength == 0)
            {
                mess += "Bạn chưa nhập tên thiết bị";
            }
            if(mess.Length == 0)
            {
                return 1;
            }
            else
            {
                MessageBox.Show(mess);
                return 0;
            }
        }
    }

}
