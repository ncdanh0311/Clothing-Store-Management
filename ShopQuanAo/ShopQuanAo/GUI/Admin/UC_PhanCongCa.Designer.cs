using System.Drawing;
using System.Windows.Forms;

namespace ShopQuanAo.GUI.Admin.UserControls
{
    partial class UC_PhanCongCa
    {
        private System.ComponentModel.IContainer components = null;

        // --- Khai báo Controls ---
        private System.Windows.Forms.DataGridView dgvPhanCong;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.MaPhanCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tlpAction_PC = new System.Windows.Forms.TableLayoutPanel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem_PC = new System.Windows.Forms.Button();
            this.btnSua_PC = new System.Windows.Forms.Button();
            this.btnXoa_PC = new System.Windows.Forms.Button();
            this.tlpInfo_PC = new System.Windows.Forms.TableLayoutPanel();
            this.txtViTriLamViec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.cboMaNV_PC = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dtpNgayLam_PC = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.cboMaCa_PC = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSDT_PC = new System.Windows.Forms.TextBox();
            this.dgvCaLam = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtp_LocTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboLocTheoCa = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tlpAction_PC.SuspendLayout();
            this.tlpInfo_PC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLam)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.AllowUserToAddRows = false;
            this.dgvPhanCong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvPhanCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhanCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhanCong.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhanCong,
            this.MaNV,
            this.MaCa,
            this.NgayLam,
            this.TenCa,
            this.HoTen});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhanCong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhanCong.EnableHeadersVisualStyles = false;
            this.dgvPhanCong.Location = new System.Drawing.Point(540, 49);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.ReadOnly = true;
            this.dgvPhanCong.RowHeadersWidth = 51;
            this.dgvPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanCong.Size = new System.Drawing.Size(532, 442);
            this.dgvPhanCong.TabIndex = 3;
            this.dgvPhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanCong_CellClick);
            // 
            // MaPhanCong
            // 
            this.MaPhanCong.DataPropertyName = "MaPhanCong";
            this.MaPhanCong.HeaderText = "MaPhanCong";
            this.MaPhanCong.MinimumWidth = 6;
            this.MaPhanCong.Name = "MaPhanCong";
            this.MaPhanCong.ReadOnly = true;
            this.MaPhanCong.Visible = false;
            this.MaPhanCong.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Visible = false;
            this.MaNV.Width = 125;
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "MaCa";
            this.MaCa.MinimumWidth = 6;
            this.MaCa.Name = "MaCa";
            this.MaCa.ReadOnly = true;
            this.MaCa.Visible = false;
            this.MaCa.Width = 125;
            // 
            // NgayLam
            // 
            this.NgayLam.DataPropertyName = "NgayLam";
            this.NgayLam.HeaderText = "Ngày Làm";
            this.NgayLam.MinimumWidth = 6;
            this.NgayLam.Name = "NgayLam";
            this.NgayLam.ReadOnly = true;
            this.NgayLam.Width = 125;
            // 
            // TenCa
            // 
            this.TenCa.DataPropertyName = "TenCa";
            this.TenCa.HeaderText = "Ca";
            this.TenCa.MinimumWidth = 6;
            this.TenCa.Name = "TenCa";
            this.TenCa.ReadOnly = true;
            this.TenCa.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên Nhân Viên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvPhanCong, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.311741F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.68826F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 494);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tlpAction_PC);
            this.groupBox4.Controls.Add(this.tlpInfo_PC);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox4, 2);
            this.groupBox4.Size = new System.Drawing.Size(531, 488);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin phân công";
            // 
            // tlpAction_PC
            // 
            this.tlpAction_PC.ColumnCount = 4;
            this.tlpAction_PC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction_PC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction_PC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction_PC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction_PC.Controls.Add(this.btnLuu, 3, 0);
            this.tlpAction_PC.Controls.Add(this.btnThem_PC, 0, 0);
            this.tlpAction_PC.Controls.Add(this.btnSua_PC, 1, 0);
            this.tlpAction_PC.Controls.Add(this.btnXoa_PC, 2, 0);
            this.tlpAction_PC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpAction_PC.Location = new System.Drawing.Point(3, 434);
            this.tlpAction_PC.Name = "tlpAction_PC";
            this.tlpAction_PC.RowCount = 1;
            this.tlpAction_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpAction_PC.Size = new System.Drawing.Size(525, 51);
            this.tlpAction_PC.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.Location = new System.Drawing.Point(396, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(126, 45);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            // 
            // btnThem_PC
            // 
            this.btnThem_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem_PC.Location = new System.Drawing.Point(3, 3);
            this.btnThem_PC.Name = "btnThem_PC";
            this.btnThem_PC.Size = new System.Drawing.Size(125, 45);
            this.btnThem_PC.TabIndex = 0;
            this.btnThem_PC.Text = "Thêm";
            // 
            // btnSua_PC
            // 
            this.btnSua_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua_PC.Location = new System.Drawing.Point(134, 3);
            this.btnSua_PC.Name = "btnSua_PC";
            this.btnSua_PC.Size = new System.Drawing.Size(125, 45);
            this.btnSua_PC.TabIndex = 1;
            this.btnSua_PC.Text = "Sửa";
            // 
            // btnXoa_PC
            // 
            this.btnXoa_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa_PC.Location = new System.Drawing.Point(265, 3);
            this.btnXoa_PC.Name = "btnXoa_PC";
            this.btnXoa_PC.Size = new System.Drawing.Size(125, 45);
            this.btnXoa_PC.TabIndex = 2;
            this.btnXoa_PC.Text = "Xóa";
            // 
            // tlpInfo_PC
            // 
            this.tlpInfo_PC.ColumnCount = 2;
            this.tlpInfo_PC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpInfo_PC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpInfo_PC.Controls.Add(this.txtViTriLamViec, 1, 4);
            this.tlpInfo_PC.Controls.Add(this.label1, 0, 4);
            this.tlpInfo_PC.Controls.Add(this.label30, 0, 0);
            this.tlpInfo_PC.Controls.Add(this.cboMaNV_PC, 1, 0);
            this.tlpInfo_PC.Controls.Add(this.label28, 0, 1);
            this.tlpInfo_PC.Controls.Add(this.dtpNgayLam_PC, 1, 1);
            this.tlpInfo_PC.Controls.Add(this.label27, 0, 2);
            this.tlpInfo_PC.Controls.Add(this.cboMaCa_PC, 1, 2);
            this.tlpInfo_PC.Controls.Add(this.label22, 0, 3);
            this.tlpInfo_PC.Controls.Add(this.txtSDT_PC, 1, 3);
            this.tlpInfo_PC.Controls.Add(this.dgvCaLam, 0, 5);
            this.tlpInfo_PC.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInfo_PC.Location = new System.Drawing.Point(3, 25);
            this.tlpInfo_PC.Name = "tlpInfo_PC";
            this.tlpInfo_PC.RowCount = 6;
            this.tlpInfo_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpInfo_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpInfo_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpInfo_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpInfo_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpInfo_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo_PC.Size = new System.Drawing.Size(525, 292);
            this.tlpInfo_PC.TabIndex = 0;
            // 
            // txtViTriLamViec
            // 
            this.txtViTriLamViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtViTriLamViec.Location = new System.Drawing.Point(213, 119);
            this.txtViTriLamViec.Name = "txtViTriLamViec";
            this.txtViTriLamViec.Size = new System.Drawing.Size(309, 29);
            this.txtViTriLamViec.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(3, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vị Trí Làm Việc:";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.Location = new System.Drawing.Point(3, 3);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 23);
            this.label30.TabIndex = 0;
            this.label30.Text = "Mã NV:";
            // 
            // cboMaNV_PC
            // 
            this.cboMaNV_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaNV_PC.Location = new System.Drawing.Point(213, 3);
            this.cboMaNV_PC.Name = "cboMaNV_PC";
            this.cboMaNV_PC.Size = new System.Drawing.Size(309, 29);
            this.cboMaNV_PC.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label28.Location = new System.Drawing.Point(3, 32);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 23);
            this.label28.TabIndex = 2;
            this.label28.Text = "Ngày làm:";
            // 
            // dtpNgayLam_PC
            // 
            this.dtpNgayLam_PC.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLam_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayLam_PC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLam_PC.Location = new System.Drawing.Point(213, 32);
            this.dtpNgayLam_PC.Name = "dtpNgayLam_PC";
            this.dtpNgayLam_PC.Size = new System.Drawing.Size(309, 29);
            this.dtpNgayLam_PC.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.Location = new System.Drawing.Point(3, 61);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 23);
            this.label27.TabIndex = 4;
            this.label27.Text = "Mã ca:";
            // 
            // cboMaCa_PC
            // 
            this.cboMaCa_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaCa_PC.Location = new System.Drawing.Point(213, 61);
            this.cboMaCa_PC.Name = "cboMaCa_PC";
            this.cboMaCa_PC.Size = new System.Drawing.Size(309, 29);
            this.cboMaCa_PC.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label22.Location = new System.Drawing.Point(3, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 23);
            this.label22.TabIndex = 6;
            this.label22.Text = "SĐT:";
            // 
            // txtSDT_PC
            // 
            this.txtSDT_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT_PC.Location = new System.Drawing.Point(213, 90);
            this.txtSDT_PC.Name = "txtSDT_PC";
            this.txtSDT_PC.Size = new System.Drawing.Size(309, 29);
            this.txtSDT_PC.TabIndex = 7;
            // 
            // dgvCaLam
            // 
            this.dgvCaLam.AllowUserToAddRows = false;
            this.dgvCaLam.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvCaLam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCaLam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaLam.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvCaLam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaLam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.GioBatDau,
            this.GioKetThuc});
            this.tlpInfo_PC.SetColumnSpan(this.dgvCaLam, 2);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaLam.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCaLam.EnableHeadersVisualStyles = false;
            this.dgvCaLam.Location = new System.Drawing.Point(3, 148);
            this.dgvCaLam.Name = "dgvCaLam";
            this.dgvCaLam.ReadOnly = true;
            this.dgvCaLam.RowHeadersWidth = 51;
            this.dgvCaLam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaLam.Size = new System.Drawing.Size(519, 141);
            this.dgvCaLam.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaCa";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaCa";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenCa";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ca";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // GioBatDau
            // 
            this.GioBatDau.DataPropertyName = "GioBatDau";
            this.GioBatDau.HeaderText = "Giờ Bắt Đầu";
            this.GioBatDau.MinimumWidth = 6;
            this.GioBatDau.Name = "GioBatDau";
            this.GioBatDau.ReadOnly = true;
            this.GioBatDau.Width = 125;
            // 
            // GioKetThuc
            // 
            this.GioKetThuc.DataPropertyName = "GioKetThuc";
            this.GioKetThuc.HeaderText = "Giờ Kết Thúc";
            this.GioKetThuc.MinimumWidth = 6;
            this.GioKetThuc.Name = "GioKetThuc";
            this.GioKetThuc.ReadOnly = true;
            this.GioKetThuc.Width = 125;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnReset, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtp_LocTheoNgay, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboLocTheoCa, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLoc, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(540, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(532, 40);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(427, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 34);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtp_LocTheoNgay
            // 
            this.dtp_LocTheoNgay.CustomFormat = "yyyy/MM/dd";
            this.dtp_LocTheoNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_LocTheoNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_LocTheoNgay.Location = new System.Drawing.Point(109, 3);
            this.dtp_LocTheoNgay.Name = "dtp_LocTheoNgay";
            this.dtp_LocTheoNgay.ShowCheckBox = true;
            this.dtp_LocTheoNgay.Size = new System.Drawing.Size(100, 29);
            this.dtp_LocTheoNgay.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 29);
            this.txtSearch.TabIndex = 6;
            // 
            // cboLocTheoCa
            // 
            this.cboLocTheoCa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLocTheoCa.FormattingEnabled = true;
            this.cboLocTheoCa.Location = new System.Drawing.Point(215, 3);
            this.cboLocTheoCa.Name = "cboLocTheoCa";
            this.cboLocTheoCa.Size = new System.Drawing.Size(100, 29);
            this.cboLocTheoCa.TabIndex = 7;
            // 
            // btnLoc
            // 
            this.btnLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoc.Location = new System.Drawing.Point(321, 3);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(100, 34);
            this.btnLoc.TabIndex = 8;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // UC_PhanCongCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_PhanCongCa";
            this.Size = new System.Drawing.Size(1075, 494);
            this.Load += new System.EventHandler(this.UC_PhanCongCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tlpAction_PC.ResumeLayout(false);
            this.tlpInfo_PC.ResumeLayout(false);
            this.tlpInfo_PC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLam)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn MaPhanCong;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn MaCa;
        private DataGridViewTextBoxColumn NgayLam;
        private DataGridViewTextBoxColumn TenCa;
        private DataGridViewTextBoxColumn HoTen;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox4;
        private TableLayoutPanel tlpAction_PC;
        private Button btnLuu;
        private Button btnThem_PC;
        private Button btnSua_PC;
        private Button btnXoa_PC;
        private TableLayoutPanel tlpInfo_PC;
        private TextBox txtViTriLamViec;
        private Label label1;
        private Label label30;
        private ComboBox cboMaNV_PC;
        private Label label28;
        private DateTimePicker dtpNgayLam_PC;
        private Label label27;
        private ComboBox cboMaCa_PC;
        private Label label22;
        private TextBox txtSDT_PC;
        private DataGridView dgvCaLam;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn GioBatDau;
        private DataGridViewTextBoxColumn GioKetThuc;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtSearch;
        private ComboBox cboLocTheoCa;
        private Button btnLoc;
        private Button btnReset;
        private DateTimePicker dtp_LocTheoNgay;
    }
}