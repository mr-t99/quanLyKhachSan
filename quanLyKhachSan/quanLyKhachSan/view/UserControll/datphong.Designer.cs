namespace quanLyKhachSan.view.UserControll
{
    partial class datphong
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
            this.dataGirl = new System.Windows.Forms.DataGridView();
            this.panelDathong = new System.Windows.Forms.Panel();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.lableThanhtien = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.btKiemTra = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPhong = new System.Windows.Forms.Panel();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btThiemDichVu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirl)).BeginInit();
            this.panelDathong.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.panelPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt phòng";
            // 
            // dataGirl
            // 
            this.dataGirl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGirl.Location = new System.Drawing.Point(0, 65);
            this.dataGirl.Name = "dataGirl";
            this.dataGirl.RowHeadersWidth = 51;
            this.dataGirl.RowTemplate.Height = 24;
            this.dataGirl.Size = new System.Drawing.Size(909, 529);
            this.dataGirl.TabIndex = 1;
            this.dataGirl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGirl_CellClick);
            // 
            // panelDathong
            // 
            this.panelDathong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDathong.Controls.Add(this.btThiemDichVu);
            this.panelDathong.Controls.Add(this.btXacNhan);
            this.panelDathong.Controls.Add(this.lableThanhtien);
            this.panelDathong.Controls.Add(this.lbThanhTien);
            this.panelDathong.Controls.Add(this.panelThongTin);
            this.panelDathong.Controls.Add(this.panelPhong);
            this.panelDathong.Location = new System.Drawing.Point(912, 65);
            this.panelDathong.Name = "panelDathong";
            this.panelDathong.Size = new System.Drawing.Size(343, 529);
            this.panelDathong.TabIndex = 2;
            // 
            // btXacNhan
            // 
            this.btXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhan.Location = new System.Drawing.Point(221, 485);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(119, 41);
            this.btXacNhan.TabIndex = 6;
            this.btXacNhan.Text = "Đặt phòng";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // lableThanhtien
            // 
            this.lableThanhtien.AutoSize = true;
            this.lableThanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableThanhtien.Location = new System.Drawing.Point(122, 447);
            this.lableThanhtien.Name = "lableThanhtien";
            this.lableThanhtien.Size = new System.Drawing.Size(92, 18);
            this.lableThanhtien.TabIndex = 5;
            this.lableThanhtien.Text = "3.000.000,00";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.Location = new System.Drawing.Point(3, 447);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(85, 18);
            this.lbThanhTien.TabIndex = 5;
            this.lbThanhTien.Text = "Thành Tiền:";
            // 
            // panelThongTin
            // 
            this.panelThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelThongTin.Controls.Add(this.btKiemTra);
            this.panelThongTin.Controls.Add(this.label9);
            this.panelThongTin.Controls.Add(this.txtDiaChi);
            this.panelThongTin.Controls.Add(this.label8);
            this.panelThongTin.Controls.Add(this.label4);
            this.panelThongTin.Controls.Add(this.txtSdt);
            this.panelThongTin.Controls.Add(this.txtTenKhachHang);
            this.panelThongTin.Controls.Add(this.label3);
            this.panelThongTin.Controls.Add(this.txtCmnd);
            this.panelThongTin.Controls.Add(this.label2);
            this.panelThongTin.Location = new System.Drawing.Point(3, 2);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(337, 190);
            this.panelThongTin.TabIndex = 3;
            // 
            // btKiemTra
            // 
            this.btKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKiemTra.Location = new System.Drawing.Point(237, 37);
            this.btKiemTra.Name = "btKiemTra";
            this.btKiemTra.Size = new System.Drawing.Size(72, 23);
            this.btKiemTra.TabIndex = 6;
            this.btKiemTra.Text = "Kiểm tra";
            this.btKiemTra.UseVisualStyleBackColor = true;
            this.btKiemTra.Click += new System.EventHandler(this.btKiemTra_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(111, 152);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(198, 23);
            this.txtDiaChi.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sdt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cmnd:";
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(111, 114);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(198, 23);
            this.txtSdt.TabIndex = 7;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(111, 76);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(198, 23);
            this.txtTenKhachHang.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khách hàng:";
            // 
            // txtCmnd
            // 
            this.txtCmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmnd.Location = new System.Drawing.Point(111, 37);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(120, 23);
            this.txtCmnd.TabIndex = 7;
            this.txtCmnd.TextChanged += new System.EventHandler(this.txtCmnd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin";
            // 
            // panelPhong
            // 
            this.panelPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPhong.Controls.Add(this.cbPhong);
            this.panelPhong.Controls.Add(this.cbTang);
            this.panelPhong.Controls.Add(this.label7);
            this.panelPhong.Controls.Add(this.label6);
            this.panelPhong.Controls.Add(this.label5);
            this.panelPhong.Location = new System.Drawing.Point(3, 210);
            this.panelPhong.Name = "panelPhong";
            this.panelPhong.Size = new System.Drawing.Size(337, 210);
            this.panelPhong.TabIndex = 4;
            // 
            // cbPhong
            // 
            this.cbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(107, 128);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(194, 25);
            this.cbPhong.TabIndex = 10;
            // 
            // cbTang
            // 
            this.cbTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Location = new System.Drawing.Point(107, 70);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(194, 25);
            this.cbTang.TabIndex = 10;
            this.cbTang.SelectedIndexChanged += new System.EventHandler(this.cbTang_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tầng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phòng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btThiemDichVu
            // 
            this.btThiemDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThiemDichVu.Location = new System.Drawing.Point(90, 485);
            this.btThiemDichVu.Name = "btThiemDichVu";
            this.btThiemDichVu.Size = new System.Drawing.Size(119, 41);
            this.btThiemDichVu.TabIndex = 6;
            this.btThiemDichVu.Text = "Dịch vụ";
            this.btThiemDichVu.UseVisualStyleBackColor = true;
            this.btThiemDichVu.Click += new System.EventHandler(this.btThiemDichVu_Click);
            // 
            // datphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDathong);
            this.Controls.Add(this.dataGirl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "datphong";
            this.Size = new System.Drawing.Size(1258, 597);
            this.Load += new System.EventHandler(this.datphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGirl)).EndInit();
            this.panelDathong.ResumeLayout(false);
            this.panelDathong.PerformLayout();
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            this.panelPhong.ResumeLayout(false);
            this.panelPhong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGirl;
        private System.Windows.Forms.Panel panelDathong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.Label lableThanhtien;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelPhong;
        private System.Windows.Forms.ComboBox cbTang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btKiemTra;
        private System.Windows.Forms.Button btThiemDichVu;
    }
}
