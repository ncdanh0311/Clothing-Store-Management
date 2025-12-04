namespace ShopQuanAo.GUI
{
    partial class FrmChiTietHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TblPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.DgvChiTiet = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // TblPanelMain
            // 
            this.TblPanelMain.BackColor = System.Drawing.Color.White;
            this.TblPanelMain.ColumnCount = 1;
            this.TblPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblPanelMain.Controls.Add(this.LblTitle, 0, 0);
            this.TblPanelMain.Controls.Add(this.DgvChiTiet, 0, 1);
            this.TblPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblPanelMain.Location = new System.Drawing.Point(0, 0);
            this.TblPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.TblPanelMain.Name = "TblPanelMain";
            this.TblPanelMain.RowCount = 2;
            this.TblPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TblPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblPanelMain.Size = new System.Drawing.Size(773, 366);
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
            this.LblTitle.Size = new System.Drawing.Size(769, 41);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "CHI TIẾT ĐƠN HÀNG [MA_DH]";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DgvChiTiet
            // 
            this.DgvChiTiet.AllowUserToAddRows = false;
            this.DgvChiTiet.AllowUserToDeleteRows = false;
            this.DgvChiTiet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DgvChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.DgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvChiTiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvChiTiet.ColumnHeadersHeight = 35;
            this.DgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.DgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvChiTiet.EnableHeadersVisualStyles = false;
            this.DgvChiTiet.GridColor = System.Drawing.Color.Silver;
            this.DgvChiTiet.Location = new System.Drawing.Point(4, 43);
            this.DgvChiTiet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.DgvChiTiet.MultiSelect = false;
            this.DgvChiTiet.Name = "DgvChiTiet";
            this.DgvChiTiet.ReadOnly = true;
            this.DgvChiTiet.RowHeadersVisible = false;
            this.DgvChiTiet.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.DgvChiTiet.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvChiTiet.RowTemplate.Height = 28;
            this.DgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvChiTiet.Size = new System.Drawing.Size(765, 319);
            this.DgvChiTiet.TabIndex = 1;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 80;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SL";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 60;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 120;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 140;
            // 
            // FrmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 366);
            this.Controls.Add(this.TblPanelMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết Hóa đơn";
            this.TblPanelMain.ResumeLayout(false);
            this.TblPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblPanelMain;
        private System.Windows.Forms.Label LblTitle;
        public System.Windows.Forms.DataGridView DgvChiTiet; // Dùng public để dễ dàng gán DataSource từ Form cha
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}