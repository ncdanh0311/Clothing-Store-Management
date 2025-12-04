using ShopQuanAo.BLL;
using ShopQuanAo.DAL;
using ShopQuanAo.DTO;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopQuanAo.GUI
{
    public partial class NV_TrangChu : Form
    {
        private NhanVienBLL nvBLL = new NhanVienBLL();

        public NV_TrangChu()
        {
            InitializeComponent();
            LoadUserControl(new UC_TrangChu());
        }
        

        private void NV_TrangChu_Load(object sender, EventArgs e)
        {

            lblNhanVien.Text = $"Nhân viên: {nvBLL.GetAll().FirstOrDefault(nv => nv.MaNV == SessionManager.MaNVHienTai).HoTen}";
            timer1.Start();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void LoadUserControl(UserControl uc)
        {
            mainTableLayoutPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Controls.Add(uc);
        }
        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_ThongTinHoaDon ucHoaDon = new UC_ThongTinHoaDon();
            LoadUserControl(ucHoaDon);
        }

        private void tsmTrangChu_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_TrangChu());
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TaiKhoan tk = new Frm_TaiKhoan();
            tk.ShowDialog();
        }

        private void tsmDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}