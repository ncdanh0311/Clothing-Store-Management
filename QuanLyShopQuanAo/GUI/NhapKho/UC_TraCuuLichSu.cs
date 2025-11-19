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
    public partial class UC_TraCuuLichSu : UserControl
    {
        LichSuNhapHangBLL ls = new LichSuNhapHangBLL();
        public UC_TraCuuLichSu()
        {
            InitializeComponent();
        }
        public void UpdateTraCuu()
        {
            DateTime TuNgay = Convert.ToDateTime(dtpTuNgay.Value);
            DateTime DenNgay = Convert.ToDateTime(dtpDenNgay.Value);
            dgvLichSuNhap.DataSource = ls.LayLichSuNhapHang(TuNgay, DenNgay);
            if(TuNgay > DenNgay || DenNgay > DateTime.Now)
            {
                throw new Exception("Ngày tra cứu không hợp lệ");
            }
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            try
            {   
                UpdateTraCuu();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
