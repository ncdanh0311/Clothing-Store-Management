namespace ShopQuanAo.GUI
{
    partial class NVKho_TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lbPhieuChoDuyet;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Button btnTaoPhieuNhap;
        private System.Windows.Forms.Button btnTraCuuLichSu;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;

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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbPhieuChoDuyet = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnTraCuuLichSu = new System.Windows.Forms.Button();
            this.btnTaoPhieuNhap = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.tableMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.lbPhieuChoDuyet, 0, 0);
            this.tableMain.Controls.Add(this.panelMenu, 0, 1);
            this.tableMain.Controls.Add(this.panelContent, 1, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 2;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(1817, 561);
            this.tableMain.TabIndex = 0;
            // 
            // lbPhieuChoDuyet
            // 
            this.lbPhieuChoDuyet.BackColor = System.Drawing.Color.Beige;
            this.tableMain.SetColumnSpan(this.lbPhieuChoDuyet, 2);
            this.lbPhieuChoDuyet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPhieuChoDuyet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbPhieuChoDuyet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbPhieuChoDuyet.Location = new System.Drawing.Point(3, 0);
            this.lbPhieuChoDuyet.Name = "lbPhieuChoDuyet";
            this.lbPhieuChoDuyet.Size = new System.Drawing.Size(1811, 40);
            this.lbPhieuChoDuyet.TabIndex = 0;
            this.lbPhieuChoDuyet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.OldLace;
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnTaiKhoan);
            this.panelMenu.Controls.Add(this.btnTraCuuLichSu);
            this.panelMenu.Controls.Add(this.btnTaoPhieuNhap);
            this.panelMenu.Controls.Add(this.btnHangHoa);
            this.panelMenu.Controls.Add(this.btnNCC);
            this.panelMenu.Controls.Add(this.btnTrangChu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(3, 43);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(194, 515);
            this.panelMenu.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Beige;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 240);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(194, 40);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.Beige;
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 200);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(194, 40);
            this.btnTaiKhoan.TabIndex = 1;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btnTraCuuLichSu
            // 
            this.btnTraCuuLichSu.BackColor = System.Drawing.Color.Beige;
            this.btnTraCuuLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraCuuLichSu.FlatAppearance.BorderSize = 0;
            this.btnTraCuuLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuLichSu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTraCuuLichSu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTraCuuLichSu.Location = new System.Drawing.Point(0, 160);
            this.btnTraCuuLichSu.Name = "btnTraCuuLichSu";
            this.btnTraCuuLichSu.Size = new System.Drawing.Size(194, 40);
            this.btnTraCuuLichSu.TabIndex = 2;
            this.btnTraCuuLichSu.Text = "Tra Cứu Lịch Sử";
            this.btnTraCuuLichSu.UseVisualStyleBackColor = false;
            this.btnTraCuuLichSu.Click += new System.EventHandler(this.btnTraCuuLichSu_Click);
            // 
            // btnTaoPhieuNhap
            // 
            this.btnTaoPhieuNhap.BackColor = System.Drawing.Color.Beige;
            this.btnTaoPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaoPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnTaoPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaoPhieuNhap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTaoPhieuNhap.Location = new System.Drawing.Point(0, 120);
            this.btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
            this.btnTaoPhieuNhap.Size = new System.Drawing.Size(194, 40);
            this.btnTaoPhieuNhap.TabIndex = 3;
            this.btnTaoPhieuNhap.Text = "Tạo Phiếu Nhập";
            this.btnTaoPhieuNhap.UseVisualStyleBackColor = false;
            this.btnTaoPhieuNhap.Click += new System.EventHandler(this.btnTaoPhieuNhap_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.BackColor = System.Drawing.Color.Beige;
            this.btnHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHangHoa.FlatAppearance.BorderSize = 0;
            this.btnHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangHoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHangHoa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHangHoa.Location = new System.Drawing.Point(0, 80);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(194, 40);
            this.btnHangHoa.TabIndex = 4;
            this.btnHangHoa.Text = "Hàng Hóa";
            this.btnHangHoa.UseVisualStyleBackColor = false;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.BackColor = System.Drawing.Color.Beige;
            this.btnNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNCC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNCC.Location = new System.Drawing.Point(0, 40);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(194, 40);
            this.btnNCC.TabIndex = 5;
            this.btnNCC.Text = "Nhà Cung Cấp";
            this.btnNCC.UseVisualStyleBackColor = false;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FloralWhite;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelContent.Location = new System.Drawing.Point(203, 43);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1611, 515);
            this.panelContent.TabIndex = 2;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Beige;
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTrangChu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(194, 40);
            this.btnTrangChu.TabIndex = 6;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // NVKho_TrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1817, 561);
            this.Controls.Add(this.tableMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "NVKho_TrangChu";
            this.Text = "Nhân Viên Kho - Trang Chủ";
            this.Load += new System.EventHandler(this.NVKho_TrangChu_Load);
            this.tableMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrangChu;
    }
}