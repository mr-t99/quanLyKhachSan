namespace quanLyKhachSan.view.UserControll
{
    partial class thong_tin
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.lbNgayLam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbQuyen = new System.Windows.Forms.Label();
            this.tableDoanhThu = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ads = new System.Windows.Forms.Label();
            this.lbGiaoDich = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Location = new System.Drawing.Point(182, 25);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(164, 29);
            this.lbTaiKhoan.TabIndex = 1;
            this.lbTaiKhoan.Text = "Tên tài khoản:";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(182, 90);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(115, 29);
            this.lbMatKhau.TabIndex = 1;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(182, 24);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(119, 29);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ và tên:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(182, 89);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(107, 29);
            this.lbGioiTinh.TabIndex = 1;
            this.lbGioiTinh.Text = "Giới tính:";
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.Location = new System.Drawing.Point(182, 151);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(124, 29);
            this.lbQueQuan.TabIndex = 1;
            this.lbQueQuan.Text = "Quê quán:";
            // 
            // lbNgayLam
            // 
            this.lbNgayLam.AutoSize = true;
            this.lbNgayLam.Location = new System.Drawing.Point(182, 212);
            this.lbNgayLam.Name = "lbNgayLam";
            this.lbNgayLam.Size = new System.Drawing.Size(164, 29);
            this.lbNgayLam.TabIndex = 1;
            this.lbNgayLam.Text = "Ngày vào làm:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.ads);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbNgayLam);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbHoTen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbGioiTinh);
            this.panel1.Controls.Add(this.lbQueQuan);
            this.panel1.Location = new System.Drawing.Point(18, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 264);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbTaiKhoan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbMatKhau);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbQuyen);
            this.panel2.Location = new System.Drawing.Point(18, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 197);
            this.panel2.TabIndex = 2;
            // 
            // lbQuyen
            // 
            this.lbQuyen.AutoSize = true;
            this.lbQuyen.Location = new System.Drawing.Point(182, 154);
            this.lbQuyen.Name = "lbQuyen";
            this.lbQuyen.Size = new System.Drawing.Size(89, 29);
            this.lbQuyen.TabIndex = 1;
            this.lbQuyen.Text = "Quyền:";
            // 
            // tableDoanhThu
            // 
            this.tableDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDoanhThu.Location = new System.Drawing.Point(654, 133);
            this.tableDoanhThu.Name = "tableDoanhThu";
            this.tableDoanhThu.RowHeadersWidth = 51;
            this.tableDoanhThu.RowTemplate.Height = 24;
            this.tableDoanhThu.Size = new System.Drawing.Size(587, 438);
            this.tableDoanhThu.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(852, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "Doanh thu cá nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quyền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên tài khoản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quê quán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Giới tính:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Họ và tên:";
            // 
            // ads
            // 
            this.ads.AutoSize = true;
            this.ads.Location = new System.Drawing.Point(12, 212);
            this.ads.Name = "ads";
            this.ads.Size = new System.Drawing.Size(164, 29);
            this.ads.TabIndex = 1;
            this.ads.Text = "Ngày vào làm:";
            // 
            // lbGiaoDich
            // 
            this.lbGiaoDich.AutoSize = true;
            this.lbGiaoDich.Location = new System.Drawing.Point(766, 307);
            this.lbGiaoDich.Name = "lbGiaoDich";
            this.lbGiaoDich.Size = new System.Drawing.Size(398, 29);
            this.lbGiaoDich.TabIndex = 5;
            this.lbGiaoDich.Text = "Bạn chưa có nhận một giao dịch nào";
            // 
            // thong_tin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbGiaoDich);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tableDoanhThu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "thong_tin";
            this.Size = new System.Drawing.Size(1258, 597);
            this.Load += new System.EventHandler(this.thong_tin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbNgayLam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableDoanhThu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbQuyen;
        private System.Windows.Forms.Label ads;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGiaoDich;
    }
}
