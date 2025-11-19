using System.Drawing;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI.Admin.UserControls
{
    partial class UC_PhanCongCa
    {
        private System.ComponentModel.IContainer components = null;

        // --- Khai báo Controls ---
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSDT_PC;
        private System.Windows.Forms.Label label22; // SĐT
        private System.Windows.Forms.ComboBox cboMaCa_PC;
        private System.Windows.Forms.Label label27; // Mã Ca
        private System.Windows.Forms.DateTimePicker dtpNgayLam_PC;
        private System.Windows.Forms.Label label28; // Ngày làm
        private System.Windows.Forms.ComboBox cboMaNV_PC;
        private System.Windows.Forms.Label label30; // Mã NV
        private System.Windows.Forms.Button btnXoa_PC;
        private System.Windows.Forms.Button btnSua_PC;
        private System.Windows.Forms.Button btnThem_PC;

        private System.Windows.Forms.TableLayoutPanel tlpInfo_PC; // TableLayoutPanel cho controls
        private System.Windows.Forms.TableLayoutPanel tlpAction_PC; // TableLayoutPanel cho buttons

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
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tlpAction_PC = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem_PC = new System.Windows.Forms.Button();
            this.btnSua_PC = new System.Windows.Forms.Button();
            this.btnXoa_PC = new System.Windows.Forms.Button();
            this.tlpInfo_PC = new System.Windows.Forms.TableLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.cboMaNV_PC = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dtpNgayLam_PC = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.cboMaCa_PC = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSDT_PC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tlpAction_PC.SuspendLayout();
            this.tlpInfo_PC.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhanCong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhanCong.EnableHeadersVisualStyles = false;
            this.dgvPhanCong.Location = new System.Drawing.Point(300, 10);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.ReadOnly = true;
            this.dgvPhanCong.RowHeadersWidth = 51;
            this.dgvPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanCong.Size = new System.Drawing.Size(765, 474);
            this.dgvPhanCong.TabIndex = 3;
            this.dgvPhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanCong_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.tlpAction_PC);
            this.groupBox4.Controls.Add(this.tlpInfo_PC);
            this.groupBox4.Location = new System.Drawing.Point(10, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 474);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin phân công";
            // 
            // tlpAction_PC
            // 
            this.tlpAction_PC.ColumnCount = 3;
            this.tlpAction_PC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAction_PC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAction_PC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAction_PC.Controls.Add(this.btnThem_PC, 0, 0);
            this.tlpAction_PC.Controls.Add(this.btnSua_PC, 1, 0);
            this.tlpAction_PC.Controls.Add(this.btnXoa_PC, 2, 0);
            this.tlpAction_PC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpAction_PC.Location = new System.Drawing.Point(3, 420);
            this.tlpAction_PC.Name = "tlpAction_PC";
            this.tlpAction_PC.RowCount = 1;
            this.tlpAction_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpAction_PC.Size = new System.Drawing.Size(278, 51);
            this.tlpAction_PC.TabIndex = 1;
            // 
            // btnThem_PC
            // 
            this.btnThem_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem_PC.Location = new System.Drawing.Point(3, 3);
            this.btnThem_PC.Name = "btnThem_PC";
            this.btnThem_PC.Size = new System.Drawing.Size(86, 45);
            this.btnThem_PC.TabIndex = 0;
            this.btnThem_PC.Text = "Thêm";
            this.btnThem_PC.Click += new System.EventHandler(this.btnThem_PC_Click);
            // 
            // btnSua_PC
            // 
            this.btnSua_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua_PC.Location = new System.Drawing.Point(95, 3);
            this.btnSua_PC.Name = "btnSua_PC";
            this.btnSua_PC.Size = new System.Drawing.Size(86, 45);
            this.btnSua_PC.TabIndex = 1;
            this.btnSua_PC.Text = "Sửa";
            this.btnSua_PC.Click += new System.EventHandler(this.btnSua_PC_Click);
            // 
            // btnXoa_PC
            // 
            this.btnXoa_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa_PC.Location = new System.Drawing.Point(187, 3);
            this.btnXoa_PC.Name = "btnXoa_PC";
            this.btnXoa_PC.Size = new System.Drawing.Size(88, 45);
            this.btnXoa_PC.TabIndex = 2;
            this.btnXoa_PC.Text = "Xóa";
            this.btnXoa_PC.Click += new System.EventHandler(this.btnXoa_PC_Click);
            // 
            // tlpInfo_PC
            // 
            this.tlpInfo_PC.ColumnCount = 2;
            this.tlpInfo_PC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpInfo_PC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpInfo_PC.Controls.Add(this.label30, 0, 0);
            this.tlpInfo_PC.Controls.Add(this.cboMaNV_PC, 1, 0);
            this.tlpInfo_PC.Controls.Add(this.label28, 0, 1);
            this.tlpInfo_PC.Controls.Add(this.dtpNgayLam_PC, 1, 1);
            this.tlpInfo_PC.Controls.Add(this.label27, 0, 2);
            this.tlpInfo_PC.Controls.Add(this.cboMaCa_PC, 1, 2);
            this.tlpInfo_PC.Controls.Add(this.label22, 0, 3);
            this.tlpInfo_PC.Controls.Add(this.txtSDT_PC, 1, 3);
            this.tlpInfo_PC.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInfo_PC.Location = new System.Drawing.Point(3, 25);
            this.tlpInfo_PC.Name = "tlpInfo_PC";
            this.tlpInfo_PC.RowCount = 5;
            this.tlpInfo_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo_PC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo_PC.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo_PC.Size = new System.Drawing.Size(278, 150);
            this.tlpInfo_PC.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.Location = new System.Drawing.Point(3, 7);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 23);
            this.label30.TabIndex = 0;
            this.label30.Text = "Mã NV:";
            // 
            // cboMaNV_PC
            // 
            this.cboMaNV_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaNV_PC.Location = new System.Drawing.Point(114, 3);
            this.cboMaNV_PC.Name = "cboMaNV_PC";
            this.cboMaNV_PC.Size = new System.Drawing.Size(161, 29);
            this.cboMaNV_PC.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label28.Location = new System.Drawing.Point(3, 44);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 23);
            this.label28.TabIndex = 2;
            this.label28.Text = "Ngày làm:";
            // 
            // dtpNgayLam_PC
            // 
            this.dtpNgayLam_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayLam_PC.Location = new System.Drawing.Point(114, 40);
            this.dtpNgayLam_PC.Name = "dtpNgayLam_PC";
            this.dtpNgayLam_PC.Size = new System.Drawing.Size(161, 29);
            this.dtpNgayLam_PC.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.Location = new System.Drawing.Point(3, 81);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 23);
            this.label27.TabIndex = 4;
            this.label27.Text = "Mã ca:";
            // 
            // cboMaCa_PC
            // 
            this.cboMaCa_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaCa_PC.Location = new System.Drawing.Point(114, 77);
            this.cboMaCa_PC.Name = "cboMaCa_PC";
            this.cboMaCa_PC.Size = new System.Drawing.Size(161, 29);
            this.cboMaCa_PC.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label22.Location = new System.Drawing.Point(3, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 23);
            this.label22.TabIndex = 6;
            this.label22.Text = "SĐT:";
            // 
            // txtSDT_PC
            // 
            this.txtSDT_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT_PC.Location = new System.Drawing.Point(114, 114);
            this.txtSDT_PC.Name = "txtSDT_PC";
            this.txtSDT_PC.Size = new System.Drawing.Size(161, 29);
            this.txtSDT_PC.TabIndex = 7;
            // 
            // UC_PhanCongCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.dgvPhanCong);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_PhanCongCa";
            this.Size = new System.Drawing.Size(1075, 494);
            this.Load += new System.EventHandler(this.UC_PhanCongCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tlpAction_PC.ResumeLayout(false);
            this.tlpInfo_PC.ResumeLayout(false);
            this.tlpInfo_PC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}