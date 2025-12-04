using System;
using System.Windows.Forms;
using ShopQuanAo.GUI; // Giả định Form DangNhapChung nằm trong thư mục GUI

namespace ShopQuanAo.GUI
{
    // Đảm bảo Form DangNhap cũ của bạn được đổi tên thành DangNhapChung
    // và có constructor nhận 1 tham số string (vai trò)

    public partial class ChonVaiTro : Form
    {
        public ChonVaiTro()
        {
            InitializeComponent();
            // Gán sự kiện cho các nút
            this.btnAdmin.Click += btnRole_Click;
            this.btnNhapKho.Click += btnRole_Click;
            this.btnBanHang.Click += btnRole_Click;
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string vaiTro = btn.Tag.ToString(); // Lấy Vai trò từ thuộc tính Tag

            // Khởi tạo Form đăng nhập chung và truyền vai trò đã chọn
            DangNhapChung loginForm = new DangNhapChung(vaiTro);
            loginForm.Show();
            this.Hide(); // Ẩn Form chọn vai trò
        }
    }
}