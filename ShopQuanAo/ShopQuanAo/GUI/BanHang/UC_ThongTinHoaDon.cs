using ShopQuanAo.BLL;
using ShopQuanAo.DTO;
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
            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            DataTable dtHoaDon = sp.XemHoaDon(SessionManager.MaNVHienTai, DateTime.Now);

            if (dtHoaDon == null || dtHoaDon.Rows.Count == 0)
            {
                dtHoaDon = sp.GetThongTinHoaDon();

                if (dtHoaDon != null && dtHoaDon.Rows.Count > 0)
                {
                    MessageBox.Show("Hiện chưa có hóa đơn nào cho ca làm việc hiện tại. Đang hiển thị toàn bộ hóa đơn để bạn lựa chọn.",
                        "Không có hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có hóa đơn nào để hiển thị.", "Không có hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            DgvHoaDon.DataSource = dtHoaDon;
            btnInDH.Enabled = dtHoaDon != null && dtHoaDon.Rows.Count > 0;
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
                if (DgvHoaDon.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn trước khi in.", "Chưa chọn hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maDH = int.Parse(DgvHoaDon.CurrentRow.Cells[0].Value.ToString());
                DataTable dtChiTiet = sp.GetInHoaDon(maDH);

                if (dtChiTiet == null || dtChiTiet.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu hóa đơn để in.", "Lỗi In Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ShowReportHD view = new ShowReportHD();
                view.Text = $"Thông tin hóa đơn {maDH}";

                ReportDataSource rds = new ReportDataSource("DataSet1", dtChiTiet);

                view.ReportDataSource = rds;
                view.ReportPath = "ShopQuanAo.GUI.HoaDonBanHang.rdlc";

                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo hoặc hiển thị báo cáo: {ex.Message}", "Lỗi In Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
