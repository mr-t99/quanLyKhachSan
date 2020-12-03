namespace quanLyKhachSan.view
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hômNayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.thong_tin1 = new quanLyKhachSan.view.UserControll.thong_tin();
            this.nhanvien1 = new quanLyKhachSan.view.UserControll.nhanvien();
            this.lichsu1 = new quanLyKhachSan.view.UserControll.lichsu();
            this.datphong1 = new quanLyKhachSan.view.UserControll.datphong();
            this.phong1 = new quanLyKhachSan.view.UserControll.phong();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanly,
            this.giaoPhòngToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanly
            // 
            this.quanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.phòngToolStripMenuItem,
            this.lịchSửToolStripMenuItem});
            this.quanly.Name = "quanly";
            this.quanly.Size = new System.Drawing.Size(73, 26);
            this.quanly.Text = "Quản lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.phòngToolStripMenuItem.Text = "Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // lịchSửToolStripMenuItem
            // 
            this.lịchSửToolStripMenuItem.Name = "lịchSửToolStripMenuItem";
            this.lịchSửToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.lịchSửToolStripMenuItem.Text = "Lịch sử";
            this.lịchSửToolStripMenuItem.Click += new System.EventHandler(this.lịchSửToolStripMenuItem_Click);
            // 
            // giaoPhòngToolStripMenuItem
            // 
            this.giaoPhòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtPhòngToolStripMenuItem,
            this.trảPhòngToolStripMenuItem});
            this.giaoPhòngToolStripMenuItem.Name = "giaoPhòngToolStripMenuItem";
            this.giaoPhòngToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.giaoPhòngToolStripMenuItem.Text = "Giao phòng";
            // 
            // đặtPhòngToolStripMenuItem
            // 
            this.đặtPhòngToolStripMenuItem.Name = "đặtPhòngToolStripMenuItem";
            this.đặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.đặtPhòngToolStripMenuItem.Text = "Đặt phòng";
            this.đặtPhòngToolStripMenuItem.Click += new System.EventHandler(this.đặtPhòngToolStripMenuItem_Click);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.trảPhòngToolStripMenuItem.Text = "Trả phòng";
            this.trảPhòngToolStripMenuItem.Click += new System.EventHandler(this.trảPhòngToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hômNayToolStripMenuItem,
            this.thángToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // hômNayToolStripMenuItem
            // 
            this.hômNayToolStripMenuItem.Name = "hômNayToolStripMenuItem";
            this.hômNayToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.hômNayToolStripMenuItem.Text = "Hôm nay";
            // 
            // thángToolStripMenuItem
            // 
            this.thángToolStripMenuItem.Name = "thángToolStripMenuItem";
            this.thángToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.thángToolStripMenuItem.Text = "Tháng";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.userToolStripMenuItem.Text = "User";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1282, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(195, 20);
            this.toolStripStatusLabel1.Text = "Nhân viên: Trần Ngọc Thăng";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(700, 4, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(152, 20);
            this.toolStripStatusLabel2.Text = "Hôm nay: 20/12/2020";
            // 
            // thong_tin1
            // 
            this.thong_tin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thong_tin1.Location = new System.Drawing.Point(13, 32);
            this.thong_tin1.Margin = new System.Windows.Forms.Padding(5);
            this.thong_tin1.Name = "thong_tin1";
            this.thong_tin1.Size = new System.Drawing.Size(1258, 597);
            this.thong_tin1.TabIndex = 6;
            // 
            // nhanvien1
            // 
            this.nhanvien1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhanvien1.Location = new System.Drawing.Point(13, 32);
            this.nhanvien1.Margin = new System.Windows.Forms.Padding(5);
            this.nhanvien1.Name = "nhanvien1";
            this.nhanvien1.Size = new System.Drawing.Size(1258, 597);
            this.nhanvien1.TabIndex = 5;
            // 
            // lichsu1
            // 
            this.lichsu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lichsu1.Location = new System.Drawing.Point(13, 32);
            this.lichsu1.Margin = new System.Windows.Forms.Padding(5);
            this.lichsu1.Name = "lichsu1";
            this.lichsu1.Size = new System.Drawing.Size(1258, 597);
            this.lichsu1.TabIndex = 4;
            // 
            // datphong1
            // 
            this.datphong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datphong1.Location = new System.Drawing.Point(13, 32);
            this.datphong1.Margin = new System.Windows.Forms.Padding(5);
            this.datphong1.Name = "datphong1";
            this.datphong1.Size = new System.Drawing.Size(1258, 597);
            this.datphong1.TabIndex = 3;
            // 
            // phong1
            // 
            this.phong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phong1.Location = new System.Drawing.Point(13, 32);
            this.phong1.Margin = new System.Windows.Forms.Padding(5);
            this.phong1.Name = "phong1";
            this.phong1.Size = new System.Drawing.Size(1258, 597);
            this.phong1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.thong_tin1);
            this.Controls.Add(this.nhanvien1);
            this.Controls.Add(this.lichsu1);
            this.Controls.Add(this.datphong1);
            this.Controls.Add(this.phong1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanly;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hômNayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private UserControll.phong phong1;
        private UserControll.datphong datphong1;
        private UserControll.lichsu lichsu1;
        private UserControll.nhanvien nhanvien1;
        private System.Windows.Forms.ToolStripMenuItem đặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private UserControll.thong_tin thong_tin1;
    }
}