using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopQuanAo.BLL;
using ShopQuanAo.DTO;
using ShopQuanAo.GUI.NhapKho;
// THÊM: Namespace chứa các User Control
using ShopQuanAo.GUI.Admin.UserControls;

namespace ShopQuanAo.GUI.Admin
{
    public partial class Admin_TrangChu : Form
    {
        // XÓA TẤT CẢ KHAI BÁO BLL VÀ BIẾN selectedMa... CŨ

        public Admin_TrangChu()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmMain_Admin_Load);
        }

        private void frmMain_Admin_Load(object sender, EventArgs e)
        {
            // Gắn sự kiện Click cho các Menu Item
            mnuQL_KhachHang.Click += MnuQL_KhachHang_Click;
            mnuQL_NhanVien.Click += MnuQL_NhanVien_Click;
            mnuQL_HoaDon.Click += MnuQL_HoaDon_Click;
            mnuQL_PhanCong.Click += MnuQL_PhanCong_Click;
            MenuThongKe.Click += MnuThongKe_Click;

            // XÓA: LoadComboBoxes() và LoadAllData()

            // Tải User Control mặc định (Trang chủ) khi Form Load
            LoadUserControl(new UC_TrangChuMacDinh());
        }

        /// <summary>
        /// Phương thức chung để tải và hiển thị một User Control trong panelMainContent.
        /// </summary>
        private void LoadUserControl(UserControl uc)
        {
            // Dọn dẹp controls cũ
            panelMainContent.Controls.Clear();
            // Đảm bảo UC lấp đầy panel
            uc.Dock = DockStyle.Fill;
            // Thêm UC mới vào panel
            panelMainContent.Controls.Add(uc);
        }

        // --- Định nghĩa User Control Trang Chủ Mặc Định (Tạm thời) ---
        private class UC_TrangChuMacDinh : UserControl
        {
            public UC_TrangChuMacDinh()
            {
                this.BackColor = System.Drawing.Color.FloralWhite; // Nền thống nhất
                Label lbl = new Label();
                lbl.Text = "Chào mừng đến Trang Quản Lý Hệ Thống";
                lbl.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(lbl);
            }
        }


        #region Xử lý chuyển User Control bằng Menu
        private void MnuQL_KhachHang_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QuanLyKhachHang());
        }

        private void MnuQL_NhanVien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_QuanLyNhanVien());
        }

        private void MnuQL_HoaDon_Click(object sender, EventArgs e)
        {
           LoadUserControl(new UC_QuanLyHoaDon());
        }

        private void MnuQL_PhanCong_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_PhanCongCa());
        }

        private void MnuThongKe_Click(object sender, EventArgs e)
        {
            // LoadUserControl(new UC_ThongKe()); 
            MessageBox.Show("Chức năng Thống Kê đang được phát triển.");
        }

        private void mnuKho_HangHoa_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_HangHoa());
        }

        private void mnuKho_NhaCungCap_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_NhaCungCap());
        }
        #endregion

    }
}