using System;
using System.Windows.Forms;
using ShopQuanAo.BLL;
using ShopQuanAo.DTO;
using ShopQuanAo.GUI;
using ShopQuanAo.GUI.Admin;
using ShopQuanAo.GUI.Chung;

namespace ShopQuanAo.GUI
{
    public partial class DangNhapChung : Form
    {
        private TaiKhoanBLL tk;
        private string selectedRole; // Biến lưu vai trò đã chọn

        // Constructor mới nhận vai trò từ Form ChonVaiTro
        public DangNhapChung(string vaiTro)
        {
            InitializeComponent();
            tk = new TaiKhoanBLL();
            this.selectedRole = vaiTro;

            // Cập nhật giao diện
            this.Text = $"Đăng nhập - Vai trò: {vaiTro}";
            this.lblTitle.Text = $"Đăng nhập vai trò {vaiTro}";

            // Gán sự kiện
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Hiển thị lại Form ChonVaiTro
            ChonVaiTro chonVaiTroForm = new ChonVaiTro();
            chonVaiTroForm.Show();

            // Đóng Form Đăng nhập hiện tại
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDN = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text;

            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi hàm đăng nhập chung. BLL sẽ xử lý logic kiểm tra/cập nhật MaNV
                TaiKhoanDTO tkInfo = tk.DangNhap(tenDN, matKhau);

                if (tkInfo != null)
                {
                    string vaiTroThucTe = tkInfo.VaiTro;

                    // --- BƯỚC 1 & 2: KIỂM TRA PHÂN QUYỀN ---

                    // Xác định tài khoản có quyền truy cập rộng (chỉ còn Admin và Developer)
                    bool isSpecialUser = (vaiTroThucTe == "Admin" || vaiTroThucTe == "Developer");

                    // Nếu vai trò thực tế KHÔNG khớp với vai trò được chọn VÀ KHÔNG phải là tài khoản đặc biệt, thì chặn lại.
                    if (vaiTroThucTe != selectedRole && !isSpecialUser)
                    {
                        MessageBox.Show($"Tài khoản này có vai trò '{vaiTroThucTe}', không phải vai trò '{selectedRole}' đã chọn.", "Lỗi Phân Quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SessionManager.Logout(); // Đảm bảo Session được xóa
                        return;
                    }

                    // --- BƯỚC 3: CHUYỂN HƯỚNG FORM CHÍNH ---
                    Form formChinh;

                    if (vaiTroThucTe == "Admin")
                    {
                        // Admin luôn vào Form Admin
                        formChinh = new Admin_TrangChu();
                    }
                    else if (vaiTroThucTe == "Developer")
                    {

                        switch (selectedRole)
                        {
                            case "Admin":
                                formChinh = new Admin_TrangChu();
                                break;
                            case "NhapKho":
                                formChinh = new NVKho_TrangChu();
                                break;
                            case "BanHang":
                                formChinh = new NV_TrangChu();
                                break;
                            default:
                                // Nếu chọn vai trò không tồn tại (lỗi), đưa về Form Admin
                                formChinh = new Admin_TrangChu();
                                break;
                        }
                    }
                    else // Tài khoản nghiệp vụ thông thường (BanHang, NhapKho)
                    {
                        switch (vaiTroThucTe)
                        {
                            case "NhapKho":
                                formChinh = new NVKho_TrangChu();
                                break;

                            case "BanHang":
                                formChinh = new NV_TrangChu();
                                break;

                            default:
                                MessageBox.Show($"Vai trò '{vaiTroThucTe}' chưa được cấu hình form chính.", "Lỗi Phân Quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }
                    }

                    formChinh.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.FromArgb(110, 200, 255);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.FromArgb(90, 180, 255);
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DoiMK doiMK = new DoiMK();
            doiMK.Owner = this;
            doiMK.Show();
        }

        private void chkShoPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShoPass.Checked;
        }

    }
}