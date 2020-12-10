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
            this.label9 = new System.Windows.Forms.Label();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.cbDichVu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(123, 29);
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
            this.dataGirl.Size = new System.Drawing.Size(900, 529);
            this.dataGirl.TabIndex = 1;
            this.dataGirl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGirl_CellClick);
            // 
            // panelDathong
            // 
            this.panelDathong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDathong.Controls.Add(this.btXacNhan);
            this.panelDathong.Controls.Add(this.lableThanhtien);
            this.panelDathong.Controls.Add(this.label9);
            this.panelDathong.Controls.Add(this.panelThongTin);
            this.panelDathong.Controls.Add(this.panelPhong);
            this.panelDathong.Location = new System.Drawing.Point(906, 65);
            this.panelDathong.Name = "panelDathong";
            this.panelDathong.Size = new System.Drawing.Size(349, 529);
            this.panelDathong.TabIndex = 2;
            // 
            // btXacNhan
            // 
            this.btXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhan.Location = new System.Drawing.Point(227, 476);
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
            this.lableThanhtien.Location = new System.Drawing.Point(122, 434);
            this.lableThanhtien.Name = "lableThanhtien";
            this.lableThanhtien.Size = new System.Drawing.Size(115, 24);
            this.lableThanhtien.TabIndex = 5;
            this.lableThanhtien.Text = "3.000.000,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Thành Tiền:";
            // 
            // panelThongTin
            // 
            this.panelThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelThongTin.Controls.Add(this.cbDichVu);
            this.panelThongTin.Controls.Add(this.label4);
            this.panelThongTin.Controls.Add(this.txtTenKhachHang);
            this.panelThongTin.Controls.Add(this.label3);
            this.panelThongTin.Controls.Add(this.label2);
            this.panelThongTin.Location = new System.Drawing.Point(7, 3);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(339, 152);
            this.panelThongTin.TabIndex = 3;
            // 
            // cbDichVu
            // 
            this.cbDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDichVu.FormattingEnabled = true;
            this.cbDichVu.Location = new System.Drawing.Point(111, 110);
            this.cbDichVu.Name = "cbDichVu";
            this.cbDichVu.Size = new System.Drawing.Size(154, 28);
            this.cbDichVu.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dịch vụ:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(111, 66);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(225, 27);
            this.txtTenKhachHang.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
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
            this.panelPhong.Location = new System.Drawing.Point(7, 161);
            this.panelPhong.Name = "panelPhong";
            this.panelPhong.Size = new System.Drawing.Size(339, 248);
            this.panelPhong.TabIndex = 4;
            // 
            // cbPhong
            // 
            this.cbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(88, 138);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(194, 28);
            this.cbPhong.TabIndex = 10;
            // 
            // cbTang
            // 
            this.cbTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Location = new System.Drawing.Point(88, 80);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(194, 28);
            this.cbTang.TabIndex = 10;
            this.cbTang.SelectedIndexChanged += new System.EventHandler(this.cbTang_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tầng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phòng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // datphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.ComboBox cbDichVu;
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
    }
}
