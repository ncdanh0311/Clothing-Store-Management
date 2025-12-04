using System.Drawing;
using System.Windows.Forms;

namespace ShopQuanAo.GUI.Admin.UserControls
{
    partial class UC_QuanLyHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        // --- Khai báo Controls ---
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpNgayLap_HD;
        private System.Windows.Forms.Label label25; // Ngày lập
        private System.Windows.Forms.TextBox txtMaKH_HD;
        private System.Windows.Forms.Label label24; // Mã KH
        private System.Windows.Forms.Label label23; // Mã NV
        private System.Windows.Forms.Button btnXoa_HD;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem_HD;

        private System.Windows.Forms.TableLayoutPanel tlpInfo_HD; // TableLayoutPanel cho controls
        private System.Windows.Forms.TableLayoutPanel tlpAction_HD; // TableLayoutPanel cho buttons
        private System.Windows.Forms.Label lblMaDH_Selected; // THÊM MỚI: Hiển thị Mã ĐH đang chọn

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMaDH_Selected = new System.Windows.Forms.Label();
            this.tlpAction_HD = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem_HD = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa_HD = new System.Windows.Forms.Button();
            this.tlpInfo_HD = new System.Windows.Forms.TableLayoutPanel();
            this.cboTenSP = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMaKH_HD = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dtpNgayLap_HD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.cboTenNhanVien = new System.Windows.Forms.ComboBox();
            this.cboLoaiKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tlpAction_HD.SuspendLayout();
            this.tlpInfo_HD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDH,
            this.MaLoaiKH,
            this.MaNV,
            this.MaKH,
            this.MaSP,
            this.NgayLap,
            this.TenNhanVien,
            this.TenKhachHang,
            this.TenSP,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien,
            this.TenLoaiKH});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.Location = new System.Drawing.Point(353, 10);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(719, 474);
            this.dgvHoaDon.TabIndex = 3;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // MaDH
            // 
            this.MaDH.DataPropertyName = "MaDH";
            this.MaDH.HeaderText = "MaDH";
            this.MaDH.Name = "MaDH";
            this.MaDH.Visible = false;
            // 
            // MaLoaiKH
            // 
            this.MaLoaiKH.DataPropertyName = "MaLoaiKH";
            this.MaLoaiKH.HeaderText = "MaLoaiKH";
            this.MaLoaiKH.Name = "MaLoaiKH";
            this.MaLoaiKH.Visible = false;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = false;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "MaKH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = false;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Visible = false;
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 89;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenNhanVien.Width = 117;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 127;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 114;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 86;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 79;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 96;
            // 
            // TenLoaiKH
            // 
            this.TenLoaiKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenLoaiKH.DataPropertyName = "TenLoaiKH";
            this.TenLoaiKH.HeaderText = "Loại Khách Hàng";
            this.TenLoaiKH.Name = "TenLoaiKH";
            this.TenLoaiKH.Width = 131;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.lblMaDH_Selected);
            this.groupBox3.Controls.Add(this.tlpAction_HD);
            this.groupBox3.Controls.Add(this.tlpInfo_HD);
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 474);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hóa đơn";
            // 
            // lblMaDH_Selected
            // 
            this.lblMaDH_Selected.AutoSize = true;
            this.lblMaDH_Selected.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaDH_Selected.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMaDH_Selected.Location = new System.Drawing.Point(6, 335);
            this.lblMaDH_Selected.Name = "lblMaDH_Selected";
            this.lblMaDH_Selected.Size = new System.Drawing.Size(196, 19);
            this.lblMaDH_Selected.TabIndex = 2;
            this.lblMaDH_Selected.Text = "Mã Đơn Hàng: CHƯA CHỌN";
            // 
            // tlpAction_HD
            // 
            this.tlpAction_HD.ColumnCount = 4;
            this.tlpAction_HD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction_HD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction_HD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction_HD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction_HD.Controls.Add(this.button1, 3, 0);
            this.tlpAction_HD.Controls.Add(this.btnThem_HD, 0, 0);
            this.tlpAction_HD.Controls.Add(this.btnLuu, 1, 0);
            this.tlpAction_HD.Controls.Add(this.btnXoa_HD, 2, 0);
            this.tlpAction_HD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpAction_HD.Location = new System.Drawing.Point(3, 420);
            this.tlpAction_HD.Name = "tlpAction_HD";
            this.tlpAction_HD.RowCount = 1;
            this.tlpAction_HD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpAction_HD.Size = new System.Drawing.Size(331, 51);
            this.tlpAction_HD.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(249, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sửa";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThem_HD
            // 
            this.btnThem_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem_HD.Location = new System.Drawing.Point(3, 3);
            this.btnThem_HD.Name = "btnThem_HD";
            this.btnThem_HD.Size = new System.Drawing.Size(76, 45);
            this.btnThem_HD.TabIndex = 0;
            this.btnThem_HD.Text = "Thêm";
            this.btnThem_HD.Click += new System.EventHandler(this.btnThem_HD_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.Location = new System.Drawing.Point(85, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(76, 45);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa_HD
            // 
            this.btnXoa_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa_HD.Location = new System.Drawing.Point(167, 3);
            this.btnXoa_HD.Name = "btnXoa_HD";
            this.btnXoa_HD.Size = new System.Drawing.Size(76, 45);
            this.btnXoa_HD.TabIndex = 2;
            this.btnXoa_HD.Text = "Xóa";
            this.btnXoa_HD.Click += new System.EventHandler(this.btnXoa_HD_Click);
            // 
            // tlpInfo_HD
            // 
            this.tlpInfo_HD.ColumnCount = 2;
            this.tlpInfo_HD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpInfo_HD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpInfo_HD.Controls.Add(this.cboTenSP, 1, 3);
            this.tlpInfo_HD.Controls.Add(this.label23, 0, 0);
            this.tlpInfo_HD.Controls.Add(this.label24, 0, 1);
            this.tlpInfo_HD.Controls.Add(this.txtMaKH_HD, 1, 1);
            this.tlpInfo_HD.Controls.Add(this.label25, 0, 2);
            this.tlpInfo_HD.Controls.Add(this.dtpNgayLap_HD, 1, 2);
            this.tlpInfo_HD.Controls.Add(this.label1, 0, 3);
            this.tlpInfo_HD.Controls.Add(this.label2, 0, 7);
            this.tlpInfo_HD.Controls.Add(this.label3, 0, 8);
            this.tlpInfo_HD.Controls.Add(this.label4, 0, 9);
            this.tlpInfo_HD.Controls.Add(this.label5, 0, 10);
            this.tlpInfo_HD.Controls.Add(this.txtSoLuong, 1, 7);
            this.tlpInfo_HD.Controls.Add(this.txtDonGia, 1, 8);
            this.tlpInfo_HD.Controls.Add(this.txtThanhTien, 1, 9);
            this.tlpInfo_HD.Controls.Add(this.cboTenNhanVien, 1, 0);
            this.tlpInfo_HD.Controls.Add(this.cboLoaiKH, 1, 10);
            this.tlpInfo_HD.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInfo_HD.Location = new System.Drawing.Point(3, 21);
            this.tlpInfo_HD.Name = "tlpInfo_HD";
            this.tlpInfo_HD.RowCount = 11;
            this.tlpInfo_HD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_HD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_HD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_HD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_HD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_HD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_HD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_HD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_HD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_HD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_HD.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_HD.Size = new System.Drawing.Size(331, 247);
            this.tlpInfo_HD.TabIndex = 0;
            // 
            // cboTenSP
            // 
            this.cboTenSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenSP.FormattingEnabled = true;
            this.cboTenSP.Location = new System.Drawing.Point(135, 96);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(193, 25);
            this.cboTenSP.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label23.Location = new System.Drawing.Point(3, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 23);
            this.label23.TabIndex = 0;
            this.label23.Text = "Tên nhân viên:";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label24.Location = new System.Drawing.Point(3, 35);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(105, 23);
            this.label24.TabIndex = 2;
            this.label24.Text = "Tên khách hàng:";
            // 
            // txtMaKH_HD
            // 
            this.txtMaKH_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaKH_HD.Location = new System.Drawing.Point(135, 34);
            this.txtMaKH_HD.Name = "txtMaKH_HD";
            this.txtMaKH_HD.Size = new System.Drawing.Size(193, 25);
            this.txtMaKH_HD.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label25.Location = new System.Drawing.Point(3, 66);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 23);
            this.label25.TabIndex = 4;
            this.label25.Text = "Ngày lập:";
            // 
            // dtpNgayLap_HD
            // 
            this.dtpNgayLap_HD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayLap_HD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap_HD.Location = new System.Drawing.Point(135, 65);
            this.dtpNgayLap_HD.Name = "dtpNgayLap_HD";
            this.dtpNgayLap_HD.Size = new System.Drawing.Size(193, 25);
            this.dtpNgayLap_HD.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Location = new System.Drawing.Point(3, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Location = new System.Drawing.Point(3, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thành tiền:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Location = new System.Drawing.Point(3, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Loại khách hàng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(135, 127);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(193, 25);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(135, 158);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(193, 25);
            this.txtDonGia.TabIndex = 6;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(135, 189);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(193, 25);
            this.txtThanhTien.TabIndex = 6;
            // 
            // cboTenNhanVien
            // 
            this.cboTenNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenNhanVien.FormattingEnabled = true;
            this.cboTenNhanVien.Location = new System.Drawing.Point(135, 3);
            this.cboTenNhanVien.Name = "cboTenNhanVien";
            this.cboTenNhanVien.Size = new System.Drawing.Size(193, 25);
            this.cboTenNhanVien.TabIndex = 7;
            // 
            // cboLoaiKH
            // 
            this.cboLoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKH.Enabled = false;
            this.cboLoaiKH.FormattingEnabled = true;
            this.cboLoaiKH.Location = new System.Drawing.Point(135, 220);
            this.cboLoaiKH.Name = "cboLoaiKH";
            this.cboLoaiKH.Size = new System.Drawing.Size(193, 25);
            this.cboLoaiKH.TabIndex = 8;
            // 
            // UC_QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_QuanLyHoaDon";
            this.Size = new System.Drawing.Size(1075, 494);
            this.Load += new System.EventHandler(this.UC_QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tlpAction_HD.ResumeLayout(false);
            this.tlpInfo_HD.ResumeLayout(false);
            this.tlpInfo_HD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private TextBox txtThanhTien;
        private ComboBox cboTenNhanVien;
        private ComboBox cboTenSP;
        private ComboBox cboLoaiKH;
        private DataGridViewTextBoxColumn MaDH;
        private DataGridViewTextBoxColumn MaLoaiKH;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewTextBoxColumn TenLoaiKH;
        private Button button1;
    }
}