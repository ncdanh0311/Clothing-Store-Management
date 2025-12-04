using ShopQuanAo.BLL;
using ShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo.GUI.Chung
{
    public partial class DoiMK : Form
    {
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        public DoiMK()
        {
            InitializeComponent();
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (tkBLL.UpdateTaiKhoan(TxtTenDN.Text.ToString(), TxtMatKhauMoi.Text.ToString()) > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                TxtTenDN.Text = String.Empty;
                TxtMatKhauMoi.Text = String.Empty;
                TxtXacNhanMK.Text = String.Empty;
                
                if (this.Owner != null)
                {
                    this.Owner.Show();
                }
                this.Close();
            }

        }

        private void DoiMK_Load(object sender, EventArgs e)
        {

            if (SessionManager.MaNVHienTai != 0)
            {
                string tenDN = tkBLL.GetTK().FirstOrDefault(tk => tk.MaNV == SessionManager.MaNVHienTai).TenDangNhap;
                TxtTenDN.Text = tenDN;
                TxtTenDN.ReadOnly = false;
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Close();
        }
    }
}
