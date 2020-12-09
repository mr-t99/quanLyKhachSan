namespace quanLyKhachSan.view.UserControll
{
    partial class phong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGirlPhong = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btPhongXoa = new System.Windows.Forms.Button();
            this.btPhongSua = new System.Windows.Forms.Button();
            this.btPhongThem = new System.Windows.Forms.Button();
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btThietBiXoa = new System.Windows.Forms.Button();
            this.btThietBiSua = new System.Windows.Forms.Button();
            this.btThietBiThem = new System.Windows.Forms.Button();
            this.rbKhongHoatDong = new System.Windows.Forms.RadioButton();
            this.rbHoatDong = new System.Windows.Forms.RadioButton();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenThietBi = new System.Windows.Forms.TextBox();
            this.dataGirlThietBi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.plThietBi = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirlPhong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirlThietBi)).BeginInit();
            this.plThietBi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phòng";
            // 
            // dataGirlPhong
            // 
            this.dataGirlPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGirlPhong.Location = new System.Drawing.Point(3, 54);
            this.dataGirlPhong.Name = "dataGirlPhong";
            this.dataGirlPhong.RowHeadersWidth = 51;
            this.dataGirlPhong.RowTemplate.Height = 24;
            this.dataGirlPhong.Size = new System.Drawing.Size(413, 540);
            this.dataGirlPhong.TabIndex = 1;
            this.dataGirlPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGirlPhong_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(422, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 543);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btPhongXoa);
            this.panel2.Controls.Add(this.btPhongSua);
            this.panel2.Controls.Add(this.btPhongThem);
            this.panel2.Controls.Add(this.cbTang);
            this.panel2.Controls.Add(this.txtMaPhong);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(69, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 229);
            this.panel2.TabIndex = 10;
            // 
            // btPhongXoa
            // 
            this.btPhongXoa.Location = new System.Drawing.Point(511, 157);
            this.btPhongXoa.Name = "btPhongXoa";
            this.btPhongXoa.Size = new System.Drawing.Size(101, 43);
            this.btPhongXoa.TabIndex = 14;
            this.btPhongXoa.Text = "Xóa";
            this.btPhongXoa.UseVisualStyleBackColor = true;
            this.btPhongXoa.Click += new System.EventHandler(this.btPhongXoa_Click);
            // 
            // btPhongSua
            // 
            this.btPhongSua.Location = new System.Drawing.Point(511, 96);
            this.btPhongSua.Name = "btPhongSua";
            this.btPhongSua.Size = new System.Drawing.Size(101, 43);
            this.btPhongSua.TabIndex = 15;
            this.btPhongSua.Text = "Sửa";
            this.btPhongSua.UseVisualStyleBackColor = true;
            this.btPhongSua.Click += new System.EventHandler(this.btPhongSua_Click);
            // 
            // btPhongThem
            // 
            this.btPhongThem.Location = new System.Drawing.Point(511, 30);
            this.btPhongThem.Name = "btPhongThem";
            this.btPhongThem.Size = new System.Drawing.Size(101, 43);
            this.btPhongThem.TabIndex = 16;
            this.btPhongThem.Text = "Thêm";
            this.btPhongThem.UseVisualStyleBackColor = true;
            this.btPhongThem.Click += new System.EventHandler(this.btPhongThem_Click);
            // 
            // cbTang
            // 
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Location = new System.Drawing.Point(196, 136);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(238, 37);
            this.cbTang.TabIndex = 13;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(86, 80);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(348, 34);
            this.txtMaPhong.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã phòng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tầng:";
            // 
            // btThietBiXoa
            // 
            this.btThietBiXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThietBiXoa.Location = new System.Drawing.Point(747, 229);
            this.btThietBiXoa.Name = "btThietBiXoa";
            this.btThietBiXoa.Size = new System.Drawing.Size(75, 33);
            this.btThietBiXoa.TabIndex = 5;
            this.btThietBiXoa.Text = "Xóa";
            this.btThietBiXoa.UseVisualStyleBackColor = true;
            this.btThietBiXoa.Click += new System.EventHandler(this.btThietBiXoa_Click);
            // 
            // btThietBiSua
            // 
            this.btThietBiSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThietBiSua.Location = new System.Drawing.Point(666, 229);
            this.btThietBiSua.Name = "btThietBiSua";
            this.btThietBiSua.Size = new System.Drawing.Size(75, 33);
            this.btThietBiSua.TabIndex = 5;
            this.btThietBiSua.Text = "Sửa";
            this.btThietBiSua.UseVisualStyleBackColor = true;
            this.btThietBiSua.Click += new System.EventHandler(this.btThietBiSua_Click);
            // 
            // btThietBiThem
            // 
            this.btThietBiThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThietBiThem.Location = new System.Drawing.Point(585, 229);
            this.btThietBiThem.Name = "btThietBiThem";
            this.btThietBiThem.Size = new System.Drawing.Size(75, 33);
            this.btThietBiThem.TabIndex = 5;
            this.btThietBiThem.Text = "Thêm";
            this.btThietBiThem.UseVisualStyleBackColor = true;
            this.btThietBiThem.Click += new System.EventHandler(this.btThietBiThem_Click);
            // 
            // rbKhongHoatDong
            // 
            this.rbKhongHoatDong.AutoSize = true;
            this.rbKhongHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKhongHoatDong.Location = new System.Drawing.Point(553, 134);
            this.rbKhongHoatDong.Name = "rbKhongHoatDong";
            this.rbKhongHoatDong.Size = new System.Drawing.Size(178, 28);
            this.rbKhongHoatDong.TabIndex = 4;
            this.rbKhongHoatDong.TabStop = true;
            this.rbKhongHoatDong.Text = "Không hoạt động";
            this.rbKhongHoatDong.UseVisualStyleBackColor = true;
            // 
            // rbHoatDong
            // 
            this.rbHoatDong.AutoSize = true;
            this.rbHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHoatDong.Location = new System.Drawing.Point(553, 100);
            this.rbHoatDong.Name = "rbHoatDong";
            this.rbHoatDong.Size = new System.Drawing.Size(120, 28);
            this.rbHoatDong.TabIndex = 4;
            this.rbHoatDong.TabStop = true;
            this.rbHoatDong.Text = "Hoạt động";
            this.rbHoatDong.UseVisualStyleBackColor = true;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(553, 180);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(250, 28);
            this.txtGia.TabIndex = 2;
            this.txtGia.Text = "0";
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThietBi.Location = new System.Drawing.Point(553, 54);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(250, 28);
            this.txtTenThietBi.TabIndex = 2;
            // 
            // dataGirlThietBi
            // 
            this.dataGirlThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGirlThietBi.Location = new System.Drawing.Point(8, 40);
            this.dataGirlThietBi.Name = "dataGirlThietBi";
            this.dataGirlThietBi.RowHeadersWidth = 51;
            this.dataGirlThietBi.RowTemplate.Height = 24;
            this.dataGirlThietBi.Size = new System.Drawing.Size(391, 233);
            this.dataGirlThietBi.TabIndex = 1;
            this.dataGirlThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGirlThietBi_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tình trạng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên thiết bị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách thiết bị";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // plThietBi
            // 
            this.plThietBi.Controls.Add(this.dataGirlThietBi);
            this.plThietBi.Controls.Add(this.btThietBiXoa);
            this.plThietBi.Controls.Add(this.label2);
            this.plThietBi.Controls.Add(this.btThietBiSua);
            this.plThietBi.Controls.Add(this.label3);
            this.plThietBi.Controls.Add(this.btThietBiThem);
            this.plThietBi.Controls.Add(this.label5);
            this.plThietBi.Controls.Add(this.rbKhongHoatDong);
            this.plThietBi.Controls.Add(this.txtTenThietBi);
            this.plThietBi.Controls.Add(this.rbHoatDong);
            this.plThietBi.Controls.Add(this.txtGia);
            this.plThietBi.Location = new System.Drawing.Point(422, 54);
            this.plThietBi.Name = "plThietBi";
            this.plThietBi.Size = new System.Drawing.Size(833, 291);
            this.plThietBi.TabIndex = 3;
            // 
            // phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plThietBi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGirlPhong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "phong";
            this.Size = new System.Drawing.Size(1258, 597);
            this.Load += new System.EventHandler(this.phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGirlPhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirlThietBi)).EndInit();
            this.plThietBi.ResumeLayout(false);
            this.plThietBi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGirlPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGirlThietBi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbKhongHoatDong;
        private System.Windows.Forms.RadioButton rbHoatDong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenThietBi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btThietBiXoa;
        private System.Windows.Forms.Button btThietBiSua;
        private System.Windows.Forms.Button btThietBiThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btPhongXoa;
        private System.Windows.Forms.Button btPhongSua;
        private System.Windows.Forms.Button btPhongThem;
        private System.Windows.Forms.ComboBox cbTang;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel plThietBi;
    }
}
