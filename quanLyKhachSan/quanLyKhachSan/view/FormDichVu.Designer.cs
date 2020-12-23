namespace quanLyKhachSan.view
{
    partial class FormDichVu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataDichVu = new System.Windows.Forms.DataGridView();
            this.lb1 = new System.Windows.Forms.Label();
            this.dataDichVuSuDung = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btThemDs = new System.Windows.Forms.Button();
            this.btSuaDs = new System.Windows.Forms.Button();
            this.btXoaDs = new System.Windows.Forms.Button();
            this.btThemDv = new System.Windows.Forms.Button();
            this.Dich = new System.Windows.Forms.Label();
            this.cbSl = new System.Windows.Forms.ComboBox();
            this.btXoaDv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVuSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDichVu
            // 
            this.dataDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDichVu.Location = new System.Drawing.Point(12, 36);
            this.dataDichVu.Name = "dataDichVu";
            this.dataDichVu.Size = new System.Drawing.Size(774, 272);
            this.dataDichVu.TabIndex = 1;
            this.dataDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDichVu_CellClick);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(316, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(166, 24);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Danh sách dịch vụ";
            // 
            // dataDichVuSuDung
            // 
            this.dataDichVuSuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDichVuSuDung.Location = new System.Drawing.Point(12, 338);
            this.dataDichVuSuDung.Name = "dataDichVuSuDung";
            this.dataDichVuSuDung.Size = new System.Drawing.Size(774, 213);
            this.dataDichVuSuDung.TabIndex = 1;
            this.dataDichVuSuDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDichVuSuDung_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dịch vụ đã sửa dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên dịch vụ:";
            // 
            // txtDv
            // 
            this.txtDv.Location = new System.Drawing.Point(796, 101);
            this.txtDv.Name = "txtDv";
            this.txtDv.Size = new System.Drawing.Size(278, 29);
            this.txtDv.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(792, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(796, 177);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(275, 29);
            this.txtGia.TabIndex = 3;
            // 
            // btThemDs
            // 
            this.btThemDs.Location = new System.Drawing.Point(855, 239);
            this.btThemDs.Name = "btThemDs";
            this.btThemDs.Size = new System.Drawing.Size(68, 35);
            this.btThemDs.TabIndex = 5;
            this.btThemDs.Text = "Thêm";
            this.btThemDs.UseVisualStyleBackColor = true;
            this.btThemDs.Click += new System.EventHandler(this.btThemDs_Click);
            // 
            // btSuaDs
            // 
            this.btSuaDs.Location = new System.Drawing.Point(929, 239);
            this.btSuaDs.Name = "btSuaDs";
            this.btSuaDs.Size = new System.Drawing.Size(68, 35);
            this.btSuaDs.TabIndex = 5;
            this.btSuaDs.Text = "Sửa";
            this.btSuaDs.UseVisualStyleBackColor = true;
            this.btSuaDs.Click += new System.EventHandler(this.btSuaDs_Click);
            // 
            // btXoaDs
            // 
            this.btXoaDs.Location = new System.Drawing.Point(1003, 239);
            this.btXoaDs.Name = "btXoaDs";
            this.btXoaDs.Size = new System.Drawing.Size(68, 35);
            this.btXoaDs.TabIndex = 5;
            this.btXoaDs.Text = "Xóa";
            this.btXoaDs.UseVisualStyleBackColor = true;
            this.btXoaDs.Click += new System.EventHandler(this.btXoaDs_Click);
            // 
            // btThemDv
            // 
            this.btThemDv.Location = new System.Drawing.Point(930, 412);
            this.btThemDv.Name = "btThemDv";
            this.btThemDv.Size = new System.Drawing.Size(68, 35);
            this.btThemDv.TabIndex = 5;
            this.btThemDv.Text = "Thêm";
            this.btThemDv.UseVisualStyleBackColor = true;
            this.btThemDv.Click += new System.EventHandler(this.btThemDv_Click);
            // 
            // Dich
            // 
            this.Dich.AutoSize = true;
            this.Dich.Location = new System.Drawing.Point(789, 387);
            this.Dich.Name = "Dich";
            this.Dich.Size = new System.Drawing.Size(91, 24);
            this.Dich.TabIndex = 2;
            this.Dich.Text = "Số lượng:";
            // 
            // cbSl
            // 
            this.cbSl.FormattingEnabled = true;
            this.cbSl.Location = new System.Drawing.Point(796, 414);
            this.cbSl.Name = "cbSl";
            this.cbSl.Size = new System.Drawing.Size(128, 32);
            this.cbSl.TabIndex = 6;
            // 
            // btXoaDv
            // 
            this.btXoaDv.Location = new System.Drawing.Point(1004, 412);
            this.btXoaDv.Name = "btXoaDv";
            this.btXoaDv.Size = new System.Drawing.Size(68, 35);
            this.btXoaDv.TabIndex = 5;
            this.btXoaDv.Text = "Xóa";
            this.btXoaDv.UseVisualStyleBackColor = true;
            this.btXoaDv.Click += new System.EventHandler(this.btXoaDv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(789, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng số tiền:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(915, 469);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(20, 24);
            this.lbTongTien.TabIndex = 2;
            this.lbTongTien.Text = "0";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(796, 516);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(111, 35);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // FormDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 563);
            this.Controls.Add(this.cbSl);
            this.Controls.Add(this.btThemDv);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoaDv);
            this.Controls.Add(this.btXoaDs);
            this.Controls.Add(this.btSuaDs);
            this.Controls.Add(this.btThemDs);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtDv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dataDichVuSuDung);
            this.Controls.Add(this.dataDichVu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDichVu";
            this.Text = "DichVu";
            this.Load += new System.EventHandler(this.DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVuSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDichVu;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView dataDichVuSuDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btThemDs;
        private System.Windows.Forms.Button btSuaDs;
        private System.Windows.Forms.Button btXoaDs;
        private System.Windows.Forms.Button btThemDv;
        private System.Windows.Forms.Label Dich;
        private System.Windows.Forms.ComboBox cbSl;
        private System.Windows.Forms.Button btXoaDv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Button btThoat;
    }
}