using System.Drawing;
using System.Windows.Forms;

namespace ShopQuanAo.GUI.Admin.UserControls
{
    partial class UC_QuanLyNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        // --- Khai báo Controls ---
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam_NV;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh_NV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnXoa_NV;
        private System.Windows.Forms.Button btnSua_NV;
        private System.Windows.Forms.Button btnThem_NV;
        private System.Windows.Forms.TextBox txtDiaChi_NV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSDT_NV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboGioiTinh_NV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtHoTen_NV;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TableLayoutPanel tlpNhanVienInfo; // TableLayoutPanel cho Controls
        private System.Windows.Forms.TableLayoutPanel tlpAction; // TableLayoutPanel cho Buttons

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tlpAction = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem_NV = new System.Windows.Forms.Button();
            this.btnSua_NV = new System.Windows.Forms.Button();
            this.btnXoa_NV = new System.Windows.Forms.Button();
            this.tlpNhanVienInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHoTen_NV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpNgaySinh_NV = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.cboGioiTinh_NV = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSDT_NV = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDiaChi_NV = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam_NV = new System.Windows.Forms.DateTimePicker();
            this.label35 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVitriLamViec = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tlpAction.SuspendLayout();
            this.tlpNhanVienInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.Location = new System.Drawing.Point(363, 10);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(702, 474);
            this.dgvNhanVien.TabIndex = 3;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.tlpAction);
            this.groupBox2.Controls.Add(this.tlpNhanVienInfo);
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 474);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // tlpAction
            // 
            this.tlpAction.ColumnCount = 4;
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAction.Controls.Add(this.btnLuu, 3, 0);
            this.tlpAction.Controls.Add(this.btnThem_NV, 0, 0);
            this.tlpAction.Controls.Add(this.btnSua_NV, 1, 0);
            this.tlpAction.Controls.Add(this.btnXoa_NV, 2, 0);
            this.tlpAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpAction.Location = new System.Drawing.Point(3, 420);
            this.tlpAction.Name = "tlpAction";
            this.tlpAction.RowCount = 1;
            this.tlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpAction.Size = new System.Drawing.Size(341, 51);
            this.tlpAction.TabIndex = 1;
            // 
            // btnThem_NV
            // 
            this.btnThem_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem_NV.Location = new System.Drawing.Point(3, 3);
            this.btnThem_NV.Name = "btnThem_NV";
            this.btnThem_NV.Size = new System.Drawing.Size(79, 45);
            this.btnThem_NV.TabIndex = 0;
            this.btnThem_NV.Text = "Thêm";
            this.btnThem_NV.Click += new System.EventHandler(this.btnThem_NV_Click);
            // 
            // btnSua_NV
            // 
            this.btnSua_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua_NV.Location = new System.Drawing.Point(88, 3);
            this.btnSua_NV.Name = "btnSua_NV";
            this.btnSua_NV.Size = new System.Drawing.Size(79, 45);
            this.btnSua_NV.TabIndex = 1;
            this.btnSua_NV.Text = "Sửa";
            this.btnSua_NV.Click += new System.EventHandler(this.btnSua_NV_Click);
            // 
            // btnXoa_NV
            // 
            this.btnXoa_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa_NV.Location = new System.Drawing.Point(173, 3);
            this.btnXoa_NV.Name = "btnXoa_NV";
            this.btnXoa_NV.Size = new System.Drawing.Size(79, 45);
            this.btnXoa_NV.TabIndex = 2;
            this.btnXoa_NV.Text = "Xóa";
            this.btnXoa_NV.Click += new System.EventHandler(this.btnXoa_NV_Click);
            // 
            // tlpNhanVienInfo
            // 
            this.tlpNhanVienInfo.ColumnCount = 2;
            this.tlpNhanVienInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpNhanVienInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpNhanVienInfo.Controls.Add(this.label19, 0, 0);
            this.tlpNhanVienInfo.Controls.Add(this.txtHoTen_NV, 1, 0);
            this.tlpNhanVienInfo.Controls.Add(this.label15, 0, 1);
            this.tlpNhanVienInfo.Controls.Add(this.dtpNgaySinh_NV, 1, 1);
            this.tlpNhanVienInfo.Controls.Add(this.label18, 0, 2);
            this.tlpNhanVienInfo.Controls.Add(this.cboGioiTinh_NV, 1, 2);
            this.tlpNhanVienInfo.Controls.Add(this.label17, 0, 3);
            this.tlpNhanVienInfo.Controls.Add(this.txtSDT_NV, 1, 3);
            this.tlpNhanVienInfo.Controls.Add(this.label16, 0, 4);
            this.tlpNhanVienInfo.Controls.Add(this.txtDiaChi_NV, 1, 4);
            this.tlpNhanVienInfo.Controls.Add(this.label21, 0, 5);
            this.tlpNhanVienInfo.Controls.Add(this.dtpNgayVaoLam_NV, 1, 5);
            this.tlpNhanVienInfo.Controls.Add(this.label35, 0, 6);
            this.tlpNhanVienInfo.Controls.Add(this.txtLuong, 1, 6);
            this.tlpNhanVienInfo.Controls.Add(this.label20, 0, 7);
            this.tlpNhanVienInfo.Controls.Add(this.cboTrangThai, 1, 7);
            this.tlpNhanVienInfo.Controls.Add(this.label1, 0, 8);
            this.tlpNhanVienInfo.Controls.Add(this.txtVitriLamViec, 1, 8);
            this.tlpNhanVienInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpNhanVienInfo.Location = new System.Drawing.Point(3, 21);
            this.tlpNhanVienInfo.Name = "tlpNhanVienInfo";
            this.tlpNhanVienInfo.RowCount = 9;
            this.tlpNhanVienInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpNhanVienInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpNhanVienInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpNhanVienInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpNhanVienInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpNhanVienInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpNhanVienInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpNhanVienInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpNhanVienInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpNhanVienInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpNhanVienInfo.Size = new System.Drawing.Size(341, 257);
            this.tlpNhanVienInfo.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.Location = new System.Drawing.Point(3, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 0;
            this.label19.Text = "Họ tên:";
            // 
            // txtHoTen_NV
            // 
            this.txtHoTen_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHoTen_NV.Location = new System.Drawing.Point(139, 3);
            this.txtHoTen_NV.Name = "txtHoTen_NV";
            this.txtHoTen_NV.Size = new System.Drawing.Size(199, 25);
            this.txtHoTen_NV.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.Location = new System.Drawing.Point(3, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh_NV
            // 
            this.dtpNgaySinh_NV.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgaySinh_NV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh_NV.Location = new System.Drawing.Point(139, 31);
            this.dtpNgaySinh_NV.Name = "dtpNgaySinh_NV";
            this.dtpNgaySinh_NV.Size = new System.Drawing.Size(199, 25);
            this.dtpNgaySinh_NV.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.Location = new System.Drawing.Point(3, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 4;
            this.label18.Text = "Giới tính:";
            // 
            // cboGioiTinh_NV
            // 
            this.cboGioiTinh_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboGioiTinh_NV.Location = new System.Drawing.Point(139, 59);
            this.cboGioiTinh_NV.Name = "cboGioiTinh_NV";
            this.cboGioiTinh_NV.Size = new System.Drawing.Size(199, 25);
            this.cboGioiTinh_NV.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.Location = new System.Drawing.Point(3, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 6;
            this.label17.Text = "SĐT:";
            // 
            // txtSDT_NV
            // 
            this.txtSDT_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT_NV.Location = new System.Drawing.Point(139, 87);
            this.txtSDT_NV.Name = "txtSDT_NV";
            this.txtSDT_NV.Size = new System.Drawing.Size(199, 25);
            this.txtSDT_NV.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.Location = new System.Drawing.Point(3, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 8;
            this.label16.Text = "Địa chỉ:";
            // 
            // txtDiaChi_NV
            // 
            this.txtDiaChi_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiaChi_NV.Location = new System.Drawing.Point(139, 115);
            this.txtDiaChi_NV.Name = "txtDiaChi_NV";
            this.txtDiaChi_NV.Size = new System.Drawing.Size(199, 25);
            this.txtDiaChi_NV.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.Location = new System.Drawing.Point(3, 142);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 10;
            this.label21.Text = "Ngày vào làm:";
            // 
            // dtpNgayVaoLam_NV
            // 
            this.dtpNgayVaoLam_NV.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVaoLam_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayVaoLam_NV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVaoLam_NV.Location = new System.Drawing.Point(139, 143);
            this.dtpNgayVaoLam_NV.Name = "dtpNgayVaoLam_NV";
            this.dtpNgayVaoLam_NV.Size = new System.Drawing.Size(199, 25);
            this.dtpNgayVaoLam_NV.TabIndex = 11;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label35.Location = new System.Drawing.Point(3, 170);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(100, 23);
            this.label35.TabIndex = 12;
            this.label35.Text = "Lương:";
            // 
            // txtLuong
            // 
            this.txtLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLuong.Location = new System.Drawing.Point(139, 171);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(199, 25);
            this.txtLuong.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.Location = new System.Drawing.Point(3, 198);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 14;
            this.label20.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(139, 199);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(199, 25);
            this.cboTrangThai.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(3, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vị trí làm việc: ";
            // 
            // txtVitriLamViec
            // 
            this.txtVitriLamViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVitriLamViec.Location = new System.Drawing.Point(139, 227);
            this.txtVitriLamViec.Name = "txtVitriLamViec";
            this.txtVitriLamViec.Size = new System.Drawing.Size(199, 25);
            this.txtVitriLamViec.TabIndex = 16;
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.Location = new System.Drawing.Point(258, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 45);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // UC_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1075, 494);
            this.Load += new System.EventHandler(this.UC_QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tlpAction.ResumeLayout(false);
            this.tlpNhanVienInfo.ResumeLayout(false);
            this.tlpNhanVienInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cboTrangThai;
        private Label label1;
        private TextBox txtVitriLamViec;
        private Button btnLuu;
    }
}