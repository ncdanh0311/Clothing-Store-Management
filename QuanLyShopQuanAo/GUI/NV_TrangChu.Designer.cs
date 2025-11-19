using System.Drawing;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    partial class NV_TrangChu
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNhanVien = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCaLam = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tabControlCustomer = new System.Windows.Forms.TabControl();
            this.tabCaNhan = new System.Windows.Forms.TabPage();
            this.txtDiaChi_CaNhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT_CaNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen_CaNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDoanhNghiep = new System.Windows.Forms.TabPage();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.lblTienThoi = new System.Windows.Forms.Label();
            this.txtTienKhachDua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTamTinh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.lbGiaSP = new System.Windows.Forms.Label();
            this.lblHangSX = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.btnLuuIn = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.crownMenuStrip1 = new ReaLTaiizor.Controls.CrownMenuStrip();
            this.hệThốngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtLậpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbBaoHanh = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.picAnhSP = new System.Windows.Forms.PictureBox();
            this.lbAnhSP = new System.Windows.Forms.Label();
            this.txtTenCty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSDT_KHDN = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHoTen_KHDN = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmail_KHDN = new System.Windows.Forms.TextBox();
            this.txtDiaChi_KHDN = new System.Windows.Forms.TextBox();
            this.txtMSThue = new System.Windows.Forms.TextBox();
            this.cbo_SoLuong_KHDN = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbo_SoLuong = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.tabControlCustomer.SuspendLayout();
            this.tabCaNhan.SuspendLayout();
            this.tabDoanhNghiep.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.grpThanhToan.SuspendLayout();
            this.grpKhachHang.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.crownMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(117)))), ((int)(((byte)(186)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 24);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1097, 42);
            this.panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1097, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "POS BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNhanVien,
            this.lblCaLam,
            this.lblThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1097, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(110, 17);
            this.lblNhanVien.Text = "NV: Nguyen Van A |";
            // 
            // lblCaLam
            // 
            this.lblCaLam.Name = "lblCaLam";
            this.lblCaLam.Size = new System.Drawing.Size(99, 17);
            this.lblCaLam.Text = "Ca: Sáng 8h-12h |";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(875, 17);
            this.lblThoiGian.Spring = true;
            this.lblThoiGian.Text = "18/10/2025 09:30:15";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.tabControlCustomer);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 66);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(4);
            this.panelLeft.Size = new System.Drawing.Size(283, 494);
            this.panelLeft.TabIndex = 3;
            // 
            // tabControlCustomer
            // 
            this.tabControlCustomer.Controls.Add(this.tabCaNhan);
            this.tabControlCustomer.Controls.Add(this.tabDoanhNghiep);
            this.tabControlCustomer.Location = new System.Drawing.Point(4, 4);
            this.tabControlCustomer.Name = "tabControlCustomer";
            this.tabControlCustomer.SelectedIndex = 0;
            this.tabControlCustomer.Size = new System.Drawing.Size(275, 240);
            this.tabControlCustomer.TabIndex = 0;
            // 
            // tabCaNhan
            // 
            this.tabCaNhan.Controls.Add(this.cbo_SoLuong);
            this.tabCaNhan.Controls.Add(this.label21);
            this.tabCaNhan.Controls.Add(this.txtDiaChi_CaNhan);
            this.tabCaNhan.Controls.Add(this.label4);
            this.tabCaNhan.Controls.Add(this.txtSDT_CaNhan);
            this.tabCaNhan.Controls.Add(this.label3);
            this.tabCaNhan.Controls.Add(this.txtHoTen_CaNhan);
            this.tabCaNhan.Controls.Add(this.label2);
            this.tabCaNhan.Location = new System.Drawing.Point(4, 22);
            this.tabCaNhan.Name = "tabCaNhan";
            this.tabCaNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaNhan.Size = new System.Drawing.Size(267, 214);
            this.tabCaNhan.TabIndex = 0;
            this.tabCaNhan.Text = "Khách hàng cá nhân";
            this.tabCaNhan.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi_CaNhan
            // 
            this.txtDiaChi_CaNhan.Location = new System.Drawing.Point(91, 76);
            this.txtDiaChi_CaNhan.Name = "txtDiaChi_CaNhan";
            this.txtDiaChi_CaNhan.Size = new System.Drawing.Size(162, 20);
            this.txtDiaChi_CaNhan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtSDT_CaNhan
            // 
            this.txtSDT_CaNhan.Location = new System.Drawing.Point(91, 51);
            this.txtSDT_CaNhan.Name = "txtSDT_CaNhan";
            this.txtSDT_CaNhan.Size = new System.Drawing.Size(162, 20);
            this.txtSDT_CaNhan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // txtHoTen_CaNhan
            // 
            this.txtHoTen_CaNhan.Location = new System.Drawing.Point(91, 26);
            this.txtHoTen_CaNhan.Name = "txtHoTen_CaNhan";
            this.txtHoTen_CaNhan.Size = new System.Drawing.Size(162, 20);
            this.txtHoTen_CaNhan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên:";
            // 
            // tabDoanhNghiep
            // 
            this.tabDoanhNghiep.Controls.Add(this.cbo_SoLuong_KHDN);
            this.tabDoanhNghiep.Controls.Add(this.txtMSThue);
            this.tabDoanhNghiep.Controls.Add(this.txtDiaChi_KHDN);
            this.tabDoanhNghiep.Controls.Add(this.txtEmail_KHDN);
            this.tabDoanhNghiep.Controls.Add(this.txtTenCty);
            this.tabDoanhNghiep.Controls.Add(this.label18);
            this.tabDoanhNghiep.Controls.Add(this.label17);
            this.tabDoanhNghiep.Controls.Add(this.label20);
            this.tabDoanhNghiep.Controls.Add(this.label19);
            this.tabDoanhNghiep.Controls.Add(this.label14);
            this.tabDoanhNghiep.Controls.Add(this.txtSDT_KHDN);
            this.tabDoanhNghiep.Controls.Add(this.label15);
            this.tabDoanhNghiep.Controls.Add(this.txtHoTen_KHDN);
            this.tabDoanhNghiep.Controls.Add(this.label16);
            this.tabDoanhNghiep.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabDoanhNghiep.Location = new System.Drawing.Point(4, 22);
            this.tabDoanhNghiep.Name = "tabDoanhNghiep";
            this.tabDoanhNghiep.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhNghiep.Size = new System.Drawing.Size(267, 214);
            this.tabDoanhNghiep.TabIndex = 1;
            this.tabDoanhNghiep.Text = "Khách hàng doanh nghiệp";
            this.tabDoanhNghiep.UseVisualStyleBackColor = true;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.grpThanhToan);
            this.panelRight.Controls.Add(this.grpKhachHang);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(762, 66);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(4);
            this.panelRight.Size = new System.Drawing.Size(335, 494);
            this.panelRight.TabIndex = 5;
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Controls.Add(this.lblTienThoi);
            this.grpThanhToan.Controls.Add(this.txtTienKhachDua);
            this.grpThanhToan.Controls.Add(this.label11);
            this.grpThanhToan.Controls.Add(this.label12);
            this.grpThanhToan.Controls.Add(this.lblTongCong);
            this.grpThanhToan.Controls.Add(this.txtChietKhau);
            this.grpThanhToan.Controls.Add(this.label9);
            this.grpThanhToan.Controls.Add(this.label8);
            this.grpThanhToan.Controls.Add(this.lblTamTinh);
            this.grpThanhToan.Controls.Add(this.label6);
            this.grpThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpThanhToan.Location = new System.Drawing.Point(4, 246);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(327, 244);
            this.grpThanhToan.TabIndex = 1;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Thanh Toán";
            // 
            // lblTienThoi
            // 
            this.lblTienThoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTienThoi.ForeColor = System.Drawing.Color.Blue;
            this.lblTienThoi.Location = new System.Drawing.Point(127, 162);
            this.lblTienThoi.Name = "lblTienThoi";
            this.lblTienThoi.Size = new System.Drawing.Size(187, 18);
            this.lblTienThoi.TabIndex = 9;
            this.lblTienThoi.Text = "0";
            this.lblTienThoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTienKhachDua.Location = new System.Drawing.Point(130, 126);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Size = new System.Drawing.Size(184, 29);
            this.txtTienKhachDua.TabIndex = 8;
            this.txtTienKhachDua.Text = "0";
            this.txtTienKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(13, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Tiền thối:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.Location = new System.Drawing.Point(13, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tiền khách đưa:";
            // 
            // lblTongCong
            // 
            this.lblTongCong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTongCong.ForeColor = System.Drawing.Color.Red;
            this.lblTongCong.Location = new System.Drawing.Point(184, 88);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(130, 28);
            this.lblTongCong.TabIndex = 5;
            this.lblTongCong.Text = "0";
            this.lblTongCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(130, 60);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(184, 20);
            this.txtChietKhau.TabIndex = 4;
            this.txtChietKhau.Text = "0";
            this.txtChietKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(10, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "TỔNG CỘNG:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Chiết khấu (%):";
            // 
            // lblTamTinh
            // 
            this.lblTamTinh.Location = new System.Drawing.Point(130, 33);
            this.lblTamTinh.Name = "lblTamTinh";
            this.lblTamTinh.Size = new System.Drawing.Size(183, 13);
            this.lblTamTinh.TabIndex = 1;
            this.lblTamTinh.Text = "0";
            this.lblTamTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tạm tính:";
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.Controls.Add(this.lbAnhSP);
            this.grpKhachHang.Controls.Add(this.picAnhSP);
            this.grpKhachHang.Controls.Add(this.lbSoLuong);
            this.grpKhachHang.Controls.Add(this.lbBaoHanh);
            this.grpKhachHang.Controls.Add(this.lbGiaSP);
            this.grpKhachHang.Controls.Add(this.lblHangSX);
            this.grpKhachHang.Controls.Add(this.lbTenSP);
            this.grpKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKhachHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpKhachHang.Location = new System.Drawing.Point(4, 4);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Size = new System.Drawing.Size(327, 240);
            this.grpKhachHang.TabIndex = 0;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "Thông tin sản phẩm";
            // 
            // lbGiaSP
            // 
            this.lbGiaSP.AutoSize = true;
            this.lbGiaSP.Location = new System.Drawing.Point(13, 78);
            this.lbGiaSP.Name = "lbGiaSP";
            this.lbGiaSP.Size = new System.Drawing.Size(30, 15);
            this.lbGiaSP.TabIndex = 3;
            this.lbGiaSP.Text = "Giá: ";
            // 
            // lblHangSX
            // 
            this.lblHangSX.AutoSize = true;
            this.lblHangSX.Location = new System.Drawing.Point(13, 51);
            this.lblHangSX.Name = "lblHangSX";
            this.lblHangSX.Size = new System.Drawing.Size(89, 15);
            this.lblHangSX.TabIndex = 2;
            this.lblHangSX.Text = "Hãng sản xuất: ";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(13, 22);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(85, 15);
            this.lbTenSP.TabIndex = 0;
            this.lbTenSP.Text = "Tên sản phẩm:";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnHuyDon);
            this.panelFooter.Controls.Add(this.btnLuuIn);
            this.panelFooter.Controls.Add(this.btnThanhToan);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(283, 477);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(479, 83);
            this.panelFooter.TabIndex = 6;
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnHuyDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuyDon.ForeColor = System.Drawing.Color.White;
            this.btnHuyDon.Location = new System.Drawing.Point(353, 10);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(117, 62);
            this.btnHuyDon.TabIndex = 2;
            this.btnHuyDon.Text = "HỦY ĐƠN\r\n(F4)";
            this.btnHuyDon.UseVisualStyleBackColor = false;
            // 
            // btnLuuIn
            // 
            this.btnLuuIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btnLuuIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuuIn.ForeColor = System.Drawing.Color.White;
            this.btnLuuIn.Location = new System.Drawing.Point(231, 10);
            this.btnLuuIn.Name = "btnLuuIn";
            this.btnLuuIn.Size = new System.Drawing.Size(117, 62);
            this.btnLuuIn.TabIndex = 1;
            this.btnLuuIn.Text = "LƯU IN\r\n(F10)";
            this.btnLuuIn.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(109, 10);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(117, 62);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "THANH TOÁN\r\n(F12)";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // crownMenuStrip1
            // 
            this.crownMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.crownMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem1,
            this.thiếtLậpToolStripMenuItem1,
            this.tàiKhoảnToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
            this.crownMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.crownMenuStrip1.Name = "crownMenuStrip1";
            this.crownMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.crownMenuStrip1.Size = new System.Drawing.Size(1097, 24);
            this.crownMenuStrip1.TabIndex = 7;
            this.crownMenuStrip1.Text = "crownMenuStrip1";
            // 
            // hệThốngToolStripMenuItem1
            // 
            this.hệThốngToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.hệThốngToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.hệThốngToolStripMenuItem1.Name = "hệThốngToolStripMenuItem1";
            this.hệThốngToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem1.Text = "Hệ thống";
            // 
            // thiếtLậpToolStripMenuItem1
            // 
            this.thiếtLậpToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.thiếtLậpToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.thiếtLậpToolStripMenuItem1.Name = "thiếtLậpToolStripMenuItem1";
            this.thiếtLậpToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.thiếtLậpToolStripMenuItem1.Text = "Thiết lập";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.hóaĐơnToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvOrderList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(283, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 411);
            this.panel1.TabIndex = 9;
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.GiaBan,
            this.SoLuongTon});
            this.dgvOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderList.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.Size = new System.Drawing.Size(479, 411);
            this.dgvOrderList.TabIndex = 0;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá";
            this.GiaBan.Name = "GiaBan";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.HeaderText = "Số lượng tồn";
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // lbBaoHanh
            // 
            this.lbBaoHanh.AutoSize = true;
            this.lbBaoHanh.Location = new System.Drawing.Point(222, 22);
            this.lbBaoHanh.Name = "lbBaoHanh";
            this.lbBaoHanh.Size = new System.Drawing.Size(64, 15);
            this.lbBaoHanh.TabIndex = 6;
            this.lbBaoHanh.Text = "Bảo hành: ";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(222, 51);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(61, 15);
            this.lbSoLuong.TabIndex = 6;
            this.lbSoLuong.Text = "Số lượng: ";
            // 
            // picAnhSP
            // 
            this.picAnhSP.Location = new System.Drawing.Point(110, 101);
            this.picAnhSP.Name = "picAnhSP";
            this.picAnhSP.Size = new System.Drawing.Size(217, 133);
            this.picAnhSP.TabIndex = 7;
            this.picAnhSP.TabStop = false;
            // 
            // lbAnhSP
            // 
            this.lbAnhSP.AutoSize = true;
            this.lbAnhSP.Location = new System.Drawing.Point(13, 103);
            this.lbAnhSP.Name = "lbAnhSP";
            this.lbAnhSP.Size = new System.Drawing.Size(89, 15);
            this.lbAnhSP.TabIndex = 8;
            this.lbAnhSP.Text = "Ảnh Sản Phẩm:";
            // 
            // txtTenCty
            // 
            this.txtTenCty.Location = new System.Drawing.Point(91, 70);
            this.txtTenCty.Name = "txtTenCty";
            this.txtTenCty.Size = new System.Drawing.Size(162, 22);
            this.txtTenCty.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "Địa chỉ:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtSDT_KHDN
            // 
            this.txtSDT_KHDN.Location = new System.Drawing.Point(91, 43);
            this.txtSDT_KHDN.Name = "txtSDT_KHDN";
            this.txtSDT_KHDN.Size = new System.Drawing.Size(162, 22);
            this.txtSDT_KHDN.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "Số điện thoại:";
            // 
            // txtHoTen_KHDN
            // 
            this.txtHoTen_KHDN.Location = new System.Drawing.Point(91, 14);
            this.txtHoTen_KHDN.Name = "txtHoTen_KHDN";
            this.txtHoTen_KHDN.Size = new System.Drawing.Size(162, 22);
            this.txtHoTen_KHDN.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Họ Tên:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 15);
            this.label17.TabIndex = 10;
            this.label17.Text = "Email:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 15);
            this.label18.TabIndex = 10;
            this.label18.Text = "Tên Công Ty:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 15);
            this.label19.TabIndex = 10;
            this.label19.Text = "Mã số thuế:";
            this.label19.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtEmail_KHDN
            // 
            this.txtEmail_KHDN.Location = new System.Drawing.Point(91, 99);
            this.txtEmail_KHDN.Name = "txtEmail_KHDN";
            this.txtEmail_KHDN.Size = new System.Drawing.Size(162, 22);
            this.txtEmail_KHDN.TabIndex = 11;
            // 
            // txtDiaChi_KHDN
            // 
            this.txtDiaChi_KHDN.Location = new System.Drawing.Point(91, 125);
            this.txtDiaChi_KHDN.Name = "txtDiaChi_KHDN";
            this.txtDiaChi_KHDN.Size = new System.Drawing.Size(162, 22);
            this.txtDiaChi_KHDN.TabIndex = 11;
            // 
            // txtMSThue
            // 
            this.txtMSThue.Location = new System.Drawing.Point(91, 151);
            this.txtMSThue.Name = "txtMSThue";
            this.txtMSThue.Size = new System.Drawing.Size(162, 22);
            this.txtMSThue.TabIndex = 11;
            // 
            // cbo_SoLuong_KHDN
            // 
            this.cbo_SoLuong_KHDN.FormattingEnabled = true;
            this.cbo_SoLuong_KHDN.Location = new System.Drawing.Point(91, 180);
            this.cbo_SoLuong_KHDN.Name = "cbo_SoLuong_KHDN";
            this.cbo_SoLuong_KHDN.Size = new System.Drawing.Size(47, 23);
            this.cbo_SoLuong_KHDN.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 183);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 15);
            this.label20.TabIndex = 10;
            this.label20.Text = "Số lượng:";
            this.label20.Click += new System.EventHandler(this.label14_Click);
            // 
            // cbo_SoLuong
            // 
            this.cbo_SoLuong.FormattingEnabled = true;
            this.cbo_SoLuong.Location = new System.Drawing.Point(91, 102);
            this.cbo_SoLuong.Name = "cbo_SoLuong";
            this.cbo_SoLuong.Size = new System.Drawing.Size(47, 21);
            this.cbo_SoLuong.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Số lượng:";
            // 
            // NV_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.crownMenuStrip1);
            this.Name = "NV_TrangChu";
            this.Text = "Trang Chủ Nhân Viên - Bán Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.tabControlCustomer.ResumeLayout(false);
            this.tabCaNhan.ResumeLayout(false);
            this.tabCaNhan.PerformLayout();
            this.tabDoanhNghiep.ResumeLayout(false);
            this.tabDoanhNghiep.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.crownMenuStrip1.ResumeLayout(false);
            this.crownMenuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panelHeader;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblNhanVien;
        private ToolStripStatusLabel lblCaLam;
        private ToolStripStatusLabel lblThoiGian;
        private Panel panelLeft;
        private TabControl tabControlCustomer;
        private TabPage tabCaNhan;
        private TextBox txtDiaChi_CaNhan;
        private Label label4;
        private TextBox txtSDT_CaNhan;
        private Label label3;
        private TextBox txtHoTen_CaNhan;
        private Label label2;
        private TabPage tabDoanhNghiep;
        private Panel panelRight;
        private GroupBox grpKhachHang;
        private Label lbGiaSP;
        private Label lblHangSX;
        private Label lbTenSP;
        private GroupBox grpThanhToan;
        private Label lblTienThoi;
        private TextBox txtTienKhachDua;
        private Label label11;
        private Label label12;
        private Label lblTongCong;
        private TextBox txtChietKhau;
        private Label label9;
        private Label label8;
        private Label lblTamTinh;
        private Label label6;
        private Panel panelFooter;
        private Button btnHuyDon;
        private Button btnLuuIn;
        private Button btnThanhToan;
        private ReaLTaiizor.Controls.CrownMenuStrip crownMenuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem1;
        private ToolStripMenuItem thiếtLậpToolStripMenuItem1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private Panel panel1;
        private DataGridView dgvOrderList;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn SoLuongTon;
        private PictureBox picAnhSP;
        private Label lbSoLuong;
        private Label lbBaoHanh;
        private Label lbAnhSP;
        private TextBox txtTenCty;
        private Label label18;
        private Label label17;
        private Label label14;
        private TextBox txtSDT_KHDN;
        private Label label15;
        private TextBox txtHoTen_KHDN;
        private Label label16;
        private Label label19;
        private TextBox txtMSThue;
        private TextBox txtDiaChi_KHDN;
        private TextBox txtEmail_KHDN;
        private ComboBox cbo_SoLuong_KHDN;
        private Label label20;
        private ComboBox cbo_SoLuong;
        private Label label21;
    }
}