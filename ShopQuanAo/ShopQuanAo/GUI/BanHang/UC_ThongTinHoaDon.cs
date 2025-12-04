using ShopQuanAo.BLL;
using ShopQuanAo.DTO;
using ShopQuanAo.GUI.BanHang;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo.GUI
{   
    public delegate void GoBackEventHandler(object sender, EventArgs e);
    public partial class UC_ThongTinHoaDon : UserControl
    {
        StoreProcedureBLL sp = new StoreProcedureBLL();
        NhanVienBLL nvBLL = new NhanVienBLL();
        KhachHangBLL khBLL = new KhachHangBLL();
        DonHangBLL dhBLL = new DonHangBLL();
        public UC_ThongTinHoaDon()
        {
            InitializeComponent();
        }
     
        private void ThongTinHoaDon_Load(object sender, EventArgs e)
        {
            DgvHoaDon.DataSource = sp.XemHoaDon(SessionManager.MaNVHienTai, DateTime.Now);
        }

        private void DgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int maDH = int.Parse(DgvHoaDon.CurrentRow.Cells[0].Value.ToString());
            FrmChiTietHoaDon frm = new FrmChiTietHoaDon();
            frm.Text = $"Chi tiết Hóa đơn Mã số: {maDH}";
            frm.editText($"CHI TIẾT ĐƠN HÀNG {maDH}");
            frm.DgvChiTiet.DataSource = sp.GetChiTietHoaDon(maDH);
            frm.ShowDialog();
        }

        private void btnInDH_Click(object sender, EventArgs e)
        {
            try
            {
                int maDH = int.Parse(DgvHoaDon.CurrentRow.Cells[0].Value.ToString());
                FrmInHoaDon view = new FrmInHoaDon();

                rp_HoaDon rp = new rp_HoaDon();
                rp.SetParameterValue("@MaDH", maDH);
                view.rpHoaDon.ReportSource = rp;
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo hoặc " +
                    $"hiển thị báo cáo: {ex.Message}", "Lỗi In Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
