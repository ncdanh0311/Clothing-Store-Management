using System.Drawing;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI.Admin.UserControls
{
    partial class UC_QuanLyKhachHang
    {
        private System.ComponentModel.IContainer components = null;

        // --- Khai báo Controls ---
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa_KH;
        private System.Windows.Forms.Button btnSua_KH;
        private System.Windows.Forms.Button btnThem_KH;
        private System.Windows.Forms.TextBox txtTenCongTy_KH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaSoThue_KH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi_KH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail_KH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT_KH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLoaiKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem_KH;
        private System.Windows.Forms.Button btnTimKiem_KH;
        private System.Windows.Forms.TableLayoutPanel tlpInfo; // TableLayoutPanel cho controls
        private System.Windows.Forms.TableLayoutPanel tlpAction; // TableLayoutPanel cho buttons

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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tlpAction = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem_KH = new System.Windows.Forms.Button();
            this.btnSua_KH = new System.Windows.Forms.Button();
            this.btnXoa_KH = new System.Windows.Forms.Button();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiKH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT_KH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail_KH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi_KH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSoThue_KH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenCongTy_KH = new System.Windows.Forms.TextBox();
            this.txtTimKiem_KH = new System.Windows.Forms.TextBox();
            this.btnTimKiem_KH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tlpAction.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.Location = new System.Drawing.Point(413, 43);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 29;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(904, 677);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tlpAction);
            this.groupBox1.Controls.Add(this.tlpInfo);
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(392, 677);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý Thông tin Khách Hàng";
            // 
            // tlpAction
            // 
            this.tlpAction.ColumnCount = 3;
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAction.Controls.Add(this.btnThem_KH, 0, 0);
            this.tlpAction.Controls.Add(this.btnSua_KH, 1, 0);
            this.tlpAction.Controls.Add(this.btnXoa_KH, 2, 0);
            this.tlpAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpAction.Location = new System.Drawing.Point(4, 615);
            this.tlpAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpAction.Name = "tlpAction";
            this.tlpAction.RowCount = 1;
            this.tlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpAction.Size = new System.Drawing.Size(384, 58);
            this.tlpAction.TabIndex = 21;
            // 
            // btnThem_KH
            // 
            this.btnThem_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem_KH.Location = new System.Drawing.Point(4, 4);
            this.btnThem_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem_KH.Name = "btnThem_KH";
            this.btnThem_KH.Size = new System.Drawing.Size(120, 50);
            this.btnThem_KH.TabIndex = 0;
            this.btnThem_KH.Text = "Thêm";
            this.btnThem_KH.Click += new System.EventHandler(this.btnThem_KH_Click);
            // 
            // btnSua_KH
            // 
            this.btnSua_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua_KH.Location = new System.Drawing.Point(132, 4);
            this.btnSua_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua_KH.Name = "btnSua_KH";
            this.btnSua_KH.Size = new System.Drawing.Size(120, 50);
            this.btnSua_KH.TabIndex = 1;
            this.btnSua_KH.Text = "Sửa";
            this.btnSua_KH.Click += new System.EventHandler(this.btnSua_KH_Click);
            // 
            // btnXoa_KH
            // 
            this.btnXoa_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa_KH.Location = new System.Drawing.Point(260, 4);
            this.btnXoa_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa_KH.Name = "btnXoa_KH";
            this.btnXoa_KH.Size = new System.Drawing.Size(120, 50);
            this.btnXoa_KH.TabIndex = 2;
            this.btnXoa_KH.Text = "Xóa";
            this.btnXoa_KH.Click += new System.EventHandler(this.btnXoa_KH_Click);
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 2;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpInfo.Controls.Add(this.label2, 0, 0);
            this.tlpInfo.Controls.Add(this.txtMaKH, 1, 0);
            this.tlpInfo.Controls.Add(this.label3, 0, 1);
            this.tlpInfo.Controls.Add(this.txtTenKH, 1, 1);
            this.tlpInfo.Controls.Add(this.label4, 0, 2);
            this.tlpInfo.Controls.Add(this.cboLoaiKH, 1, 2);
            this.tlpInfo.Controls.Add(this.label5, 0, 3);
            this.tlpInfo.Controls.Add(this.txtSDT_KH, 1, 3);
            this.tlpInfo.Controls.Add(this.label6, 0, 4);
            this.tlpInfo.Controls.Add(this.txtEmail_KH, 1, 4);
            this.tlpInfo.Controls.Add(this.label7, 0, 5);
            this.tlpInfo.Controls.Add(this.txtDiaChi_KH, 1, 5);
            this.tlpInfo.Controls.Add(this.label8, 0, 6);
            this.tlpInfo.Controls.Add(this.txtMaSoThue_KH, 1, 6);
            this.tlpInfo.Controls.Add(this.label9, 0, 7);
            this.tlpInfo.Controls.Add(this.txtTenCongTy_KH, 1, 7);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInfo.Location = new System.Drawing.Point(4, 19);
            this.tlpInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 9;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo.Size = new System.Drawing.Size(384, 320);
            this.tlpInfo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaKH.Location = new System.Drawing.Point(157, 4);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(223, 22);
            this.txtMaKH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên KH:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenKH.Location = new System.Drawing.Point(157, 44);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(223, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Location = new System.Drawing.Point(4, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại KH:";
            // 
            // cboLoaiKH
            // 
            this.cboLoaiKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLoaiKH.Location = new System.Drawing.Point(157, 84);
            this.cboLoaiKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLoaiKH.Name = "cboLoaiKH";
            this.cboLoaiKH.Size = new System.Drawing.Size(223, 24);
            this.cboLoaiKH.TabIndex = 3;
            this.cboLoaiKH.SelectedIndexChanged += new System.EventHandler(this.cboLoaiKH_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Location = new System.Drawing.Point(4, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "SĐT:";
            // 
            // txtSDT_KH
            // 
            this.txtSDT_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT_KH.Location = new System.Drawing.Point(157, 124);
            this.txtSDT_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT_KH.Name = "txtSDT_KH";
            this.txtSDT_KH.Size = new System.Drawing.Size(223, 22);
            this.txtSDT_KH.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.Location = new System.Drawing.Point(4, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // txtEmail_KH
            // 
            this.txtEmail_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail_KH.Location = new System.Drawing.Point(157, 164);
            this.txtEmail_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail_KH.Name = "txtEmail_KH";
            this.txtEmail_KH.Size = new System.Drawing.Size(223, 22);
            this.txtEmail_KH.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.Location = new System.Drawing.Point(4, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa Chỉ:";
            // 
            // txtDiaChi_KH
            // 
            this.txtDiaChi_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiaChi_KH.Location = new System.Drawing.Point(157, 204);
            this.txtDiaChi_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi_KH.Name = "txtDiaChi_KH";
            this.txtDiaChi_KH.Size = new System.Drawing.Size(223, 22);
            this.txtDiaChi_KH.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.Location = new System.Drawing.Point(4, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã Số Thuế:";
            // 
            // txtMaSoThue_KH
            // 
            this.txtMaSoThue_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaSoThue_KH.Location = new System.Drawing.Point(157, 244);
            this.txtMaSoThue_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSoThue_KH.Name = "txtMaSoThue_KH";
            this.txtMaSoThue_KH.Size = new System.Drawing.Size(223, 22);
            this.txtMaSoThue_KH.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.Location = new System.Drawing.Point(4, 286);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên Công Ty:";
            // 
            // txtTenCongTy_KH
            // 
            this.txtTenCongTy_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenCongTy_KH.Location = new System.Drawing.Point(157, 284);
            this.txtTenCongTy_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenCongTy_KH.Name = "txtTenCongTy_KH";
            this.txtTenCongTy_KH.Size = new System.Drawing.Size(223, 22);
            this.txtTenCongTy_KH.TabIndex = 8;
            // 
            // txtTimKiem_KH
            // 
            this.txtTimKiem_KH.Location = new System.Drawing.Point(413, 7);
            this.txtTimKiem_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem_KH.Name = "txtTimKiem_KH";
            this.txtTimKiem_KH.Size = new System.Drawing.Size(279, 22);
            this.txtTimKiem_KH.TabIndex = 9;
            // 
            // btnTimKiem_KH
            // 
            this.btnTimKiem_KH.Location = new System.Drawing.Point(700, 6);
            this.btnTimKiem_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem_KH.Name = "btnTimKiem_KH";
            this.btnTimKiem_KH.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem_KH.TabIndex = 10;
            this.btnTimKiem_KH.Text = "Tìm kiếm";
            this.btnTimKiem_KH.Click += new System.EventHandler(this.btnTimKiem_KH_Click);
            // 
            // UC_QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.btnTimKiem_KH);
            this.Controls.Add(this.txtTimKiem_KH);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_QuanLyKhachHang";
            this.Size = new System.Drawing.Size(1333, 738);
            this.Load += new System.EventHandler(this.UC_QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tlpAction.ResumeLayout(false);
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}