namespace quanLyKhachSan.view.UserControll
{
    partial class ThongKe
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
            this.lbNgayThang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableNhanVien = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.ThongTin = new System.Windows.Forms.Panel();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.tableGiaoDich = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableNhanVien)).BeginInit();
            this.ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGiaoDich)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNgayThang
            // 
            this.lbNgayThang.AutoSize = true;
            this.lbNgayThang.Location = new System.Drawing.Point(525, 20);
            this.lbNgayThang.Name = "lbNgayThang";
            this.lbNgayThang.Size = new System.Drawing.Size(107, 29);
            this.lbNgayThang.TabIndex = 0;
            this.lbNgayThang.Text = "Hôm nay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // tableNhanVien
            // 
            this.tableNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableNhanVien.Location = new System.Drawing.Point(9, 188);
            this.tableNhanVien.Name = "tableNhanVien";
            this.tableNhanVien.RowHeadersWidth = 51;
            this.tableNhanVien.RowTemplate.Height = 24;
            this.tableNhanVien.Size = new System.Drawing.Size(405, 406);
            this.tableNhanVien.TabIndex = 1;
            this.tableNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableNhanVien_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhân viên";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(267, 94);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(129, 29);
            this.lbTong.TabIndex = 0;
            this.lbTong.Text = "10.000.000";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(638, 20);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(131, 29);
            this.lbNgay.TabIndex = 0;
            this.lbNgay.Text = "12/12/2020";
            // 
            // ThongTin
            // 
            this.ThongTin.Controls.Add(this.lbThongBao);
            this.ThongTin.Controls.Add(this.tableGiaoDich);
            this.ThongTin.Controls.Add(this.label5);
            this.ThongTin.Controls.Add(this.lbDoanhThu);
            this.ThongTin.Controls.Add(this.label9);
            this.ThongTin.Controls.Add(this.lbTen);
            this.ThongTin.Controls.Add(this.label7);
            this.ThongTin.Location = new System.Drawing.Point(420, 188);
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Size = new System.Drawing.Size(838, 406);
            this.ThongTin.TabIndex = 2;
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Location = new System.Drawing.Point(302, 203);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(219, 29);
            this.lbThongBao.TabIndex = 9;
            this.lbThongBao.Text = "Không có giao dịch";
            // 
            // tableGiaoDich
            // 
            this.tableGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGiaoDich.Location = new System.Drawing.Point(15, 82);
            this.tableGiaoDich.Name = "tableGiaoDich";
            this.tableGiaoDich.RowHeadersWidth = 51;
            this.tableGiaoDich.RowTemplate.Height = 24;
            this.tableGiaoDich.Size = new System.Drawing.Size(814, 321);
            this.tableGiaoDich.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giao dịch";
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.Location = new System.Drawing.Point(644, 9);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(148, 29);
            this.lbDoanhThu.TabIndex = 4;
            this.lbDoanhThu.Text = "3.255.000.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Doanh thu:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(145, 9);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(167, 29);
            this.lbTen.TabIndex = 6;
            this.lbTen.Text = "NguyenCuong";
            this.lbTen.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nhân viên:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ThongTin);
            this.Controls.Add(this.tableNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.lbNgayThang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1258, 597);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableNhanVien)).EndInit();
            this.ThongTin.ResumeLayout(false);
            this.ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGiaoDich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNgayThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tableNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Panel ThongTin;
        private System.Windows.Forms.DataGridView tableGiaoDich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbThongBao;
    }
}
