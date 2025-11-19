using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL;

namespace QuanLyShopQuanAo.GUI.NhapKho
{
    public partial class UC_HangHoa : UserControl
    {
        SanPham_HangSanXuatBLL sp = new SanPham_HangSanXuatBLL();
        public UC_HangHoa()
        {
            InitializeComponent();
        }
        public void UpdateDgvSP()
        {
            dgvSanPham.DataSource = sp.GetSP_HSX();
        }

        private void UC_HangHoa_Load(object sender, EventArgs e)
        {
            UpdateDgvSP();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = sp.GetSP_HSX().FindAll(s=>s.TenSP.ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            UpdateDgvSP();
        }
    }
}
