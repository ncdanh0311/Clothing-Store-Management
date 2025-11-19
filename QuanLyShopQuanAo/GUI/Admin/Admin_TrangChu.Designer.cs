using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyShopQuanAo.GUI.Admin
{
    partial class Admin_TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // CÁC CONTROLS CHÍNH ĐƯỢC GIỮ LẠI
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;

        // MENU ITEMS
        private System.Windows.Forms.ToolStripMenuItem MenuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem MenuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_HoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_PhanCong;
        private System.Windows.Forms.ToolStripMenuItem MenuKhoHang;
        private System.Windows.Forms.ToolStripMenuItem mnuKho_HangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuKho_NhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem MenuThongKe;
        private System.Windows.Forms.ToolStripMenuItem MenuTaiKhoan;

        // PANEL MỚI THAY THẾ CHO TAB CONTROL
        private System.Windows.Forms.Panel panelMainContent;

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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_PhanCong = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKhoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKho_HangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKho_NhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(117)))), ((int)(((byte)(186)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 28);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1444, 52);
            this.panelHeader.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1444, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANG CHỦ - QUẢN LÝ CỬA HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHeThong,
            this.MenuQuanLy,
            this.MenuKhoHang,
            this.MenuThongKe,
            this.MenuTaiKhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1444, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuHeThong
            // 
            this.MenuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnuThoat});
            this.MenuHeThong.Name = "MenuHeThong";
            this.MenuHeThong.Size = new System.Drawing.Size(85, 24);
            this.MenuHeThong.Text = "Hệ thống";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(160, 26);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(160, 26);
            this.mnuThoat.Text = "Thoát";
            // 
            // MenuQuanLy
            // 
            this.MenuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQL_KhachHang,
            this.mnuQL_NhanVien,
            this.mnuQL_HoaDon,
            this.mnuQL_PhanCong});
            this.MenuQuanLy.Name = "MenuQuanLy";
            this.MenuQuanLy.Size = new System.Drawing.Size(73, 24);
            this.MenuQuanLy.Text = "Quản lý";
            // 
            // mnuQL_KhachHang
            // 
            this.mnuQL_KhachHang.Name = "mnuQL_KhachHang";
            this.mnuQL_KhachHang.Size = new System.Drawing.Size(226, 26);
            this.mnuQL_KhachHang.Text = "Quản lý Khách Hàng";
            // 
            // mnuQL_NhanVien
            // 
            this.mnuQL_NhanVien.Name = "mnuQL_NhanVien";
            this.mnuQL_NhanVien.Size = new System.Drawing.Size(226, 26);
            this.mnuQL_NhanVien.Text = "Quản lý Nhân Viên";
            // 
            // mnuQL_HoaDon
            // 
            this.mnuQL_HoaDon.Name = "mnuQL_HoaDon";
            this.mnuQL_HoaDon.Size = new System.Drawing.Size(226, 26);
            this.mnuQL_HoaDon.Text = "Quản lý Hóa Đơn";
            // 
            // mnuQL_PhanCong
            // 
            this.mnuQL_PhanCong.Name = "mnuQL_PhanCong";
            this.mnuQL_PhanCong.Size = new System.Drawing.Size(226, 26);
            this.mnuQL_PhanCong.Text = "Phân Công Ca";
            // 
            // MenuKhoHang
            // 
            this.MenuKhoHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKho_HangHoa,
            this.mnuKho_NhaCungCap});
            this.MenuKhoHang.Name = "MenuKhoHang";
            this.MenuKhoHang.Size = new System.Drawing.Size(86, 24);
            this.MenuKhoHang.Text = "Kho hàng";
            // 
            // mnuKho_HangHoa
            // 
            this.mnuKho_HangHoa.Name = "mnuKho_HangHoa";
            this.mnuKho_HangHoa.Size = new System.Drawing.Size(183, 26);
            this.mnuKho_HangHoa.Text = "Hàng hóa";
            this.mnuKho_HangHoa.Click += new System.EventHandler(this.mnuKho_HangHoa_Click);
            // 
            // mnuKho_NhaCungCap
            // 
            this.mnuKho_NhaCungCap.Name = "mnuKho_NhaCungCap";
            this.mnuKho_NhaCungCap.Size = new System.Drawing.Size(183, 26);
            this.mnuKho_NhaCungCap.Text = "Nhà cung cấp";
            this.mnuKho_NhaCungCap.Click += new System.EventHandler(this.mnuKho_NhaCungCap_Click);
            // 
            // MenuThongKe
            // 
            this.MenuThongKe.Name = "MenuThongKe";
            this.MenuThongKe.Size = new System.Drawing.Size(84, 24);
            this.MenuThongKe.Text = "Thống kê";
            // 
            // MenuTaiKhoan
            // 
            this.MenuTaiKhoan.Name = "MenuTaiKhoan";
            this.MenuTaiKhoan.Size = new System.Drawing.Size(85, 24);
            this.MenuTaiKhoan.Text = "Tài khoản";
            // 
            // panelMainContent
            // 
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 80);
            this.panelMainContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1444, 646);
            this.panelMainContent.TabIndex = 4;
            // 
            // Admin_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 726);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_TrangChu";
            this.Text = "Trang Quản Lý Hệ Thống";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}