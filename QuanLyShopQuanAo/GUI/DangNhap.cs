using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using QuanLyShopQuanAo.BLL;
using QuanLyShopQuanAo.DTO;
using QuanLyShopQuanAo.GUI;
using QuanLyShopQuanAo.GUI.Admin;

namespace QuanLyShopQuanAo
{
    public partial class DangNhap : Form
    {
        TaiKhoanBLL tk;

        public DangNhap()
        {
            InitializeComponent();
            tk = new TaiKhoanBLL();
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            txtPassword.UseSystemPasswordChar = true;
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
                TaiKhoanDTO tkInfo = tk.DangNhap(tenDN, matKhau);

                if (tkInfo != null)
                {
                    Form formChinh;
                    string vaiTro = tkInfo.VaiTro;

                    switch (vaiTro)
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
                            MessageBox.Show($"Vai trò '{vaiTro}' chưa được cấu hình form chính.", "Lỗi Phân Quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
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
    }
}