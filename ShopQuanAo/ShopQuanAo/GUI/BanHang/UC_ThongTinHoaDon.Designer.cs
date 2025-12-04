using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Windows.Forms;

namespace ShopQuanAo.GUI
{
    partial class UC_ThongTinHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TblPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.DgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInDH = new System.Windows.Forms.Button();
            this.TblPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHoaDon)).BeginInit();
            this.PanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblPanelMain
            // 
            this.TblPanelMain.BackColor = System.Drawing.Color.White;
            this.TblPanelMain.ColumnCount = 1;
            this.TblPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblPanelMain.Controls.Add(this.LblTitle, 0, 0);
            this.TblPanelMain.Controls.Add(this.DgvHoaDon, 0, 1);
            this.TblPanelMain.Controls.Add(this.PanelButton, 0, 2);
            this.TblPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblPanelMain.Location = new System.Drawing.Point(0, 0);
            this.TblPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.TblPanelMain.Name = "TblPanelMain";
            this.TblPanelMain.RowCount = 3;
            this.TblPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TblPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TblPanelMain.Size = new System.Drawing.Size(823, 341);
            this.TblPanelMain.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblTitle.Location = new System.Drawing.Point(2, 0);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.LblTitle.Size = new System.Drawing.Size(819, 41);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "THÔNG TIN HÓA ĐƠN";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DgvHoaDon
            // 
            this.DgvHoaDon.AllowUserToAddRows = false;
            this.DgvHoaDon.AllowUserToDeleteRows = false;
            this.DgvHoaDon.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.DgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvHoaDon.ColumnHeadersHeight = 35;
            this.DgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDH,
            this.NgayLap,
            this.MaNV,
            this.TenNV,
            this.MaKH,
            this.TenKH,
            this.TongTien});
            this.DgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvHoaDon.EnableHeadersVisualStyles = false;
            this.DgvHoaDon.GridColor = System.Drawing.Color.Silver;
            this.DgvHoaDon.Location = new System.Drawing.Point(4, 43);
            this.DgvHoaDon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.DgvHoaDon.MultiSelect = false;
            this.DgvHoaDon.Name = "DgvHoaDon";
            this.DgvHoaDon.ReadOnly = true;
            this.DgvHoaDon.RowHeadersVisible = false;
            this.DgvHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvHoaDon.RowTemplate.Height = 28;
            this.DgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHoaDon.Size = new System.Drawing.Size(815, 254);
            this.DgvHoaDon.TabIndex = 1;
            this.DgvHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHoaDon_CellDoubleClick);
            // 
            // MaDH
            // 
            this.MaDH.DataPropertyName = "MaDH";
            this.MaDH.HeaderText = "Mã ĐH";
            this.MaDH.MinimumWidth = 6;
            this.MaDH.Name = "MaDH";
            this.MaDH.ReadOnly = true;
            this.MaDH.Visible = false;
            this.MaDH.Width = 125;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Visible = false;
            this.MaNV.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Visible = false;
            this.MaKH.Width = 125;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 180;
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.btnInDH);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelButton.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelButton.Location = new System.Drawing.Point(0, 301);
            this.PanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(823, 40);
            this.PanelButton.TabIndex = 2;
            // 
            // btnInDH
            // 
            this.btnInDH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btnInDH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInDH.ForeColor = System.Drawing.Color.White;
            this.btnInDH.Location = new System.Drawing.Point(703, 3);
            this.btnInDH.Name = "btnInDH";
            this.btnInDH.Size = new System.Drawing.Size(117, 37);
            this.btnInDH.TabIndex = 1;
            this.btnInDH.Text = "IN HÓA ĐƠN";
            this.btnInDH.UseVisualStyleBackColor = false;
            this.btnInDH.Click += new System.EventHandler(this.btnInDH_Click);
            // 
            // UC_ThongTinHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TblPanelMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_ThongTinHoaDon";
            this.Size = new System.Drawing.Size(823, 341);
            this.Load += new System.EventHandler(this.ThongTinHoaDon_Load);
            this.TblPanelMain.ResumeLayout(false);
            this.TblPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHoaDon)).EndInit();
            this.PanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblPanelMain;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.DataGridView DgvHoaDon;
        private DataGridViewTextBoxColumn MaDH;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.FlowLayoutPanel PanelButton; // Khai báo
        private Button btnInDH;
    }
}