using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms; // <--- DÒNG NÀY RẤT QUAN TRỌNG

namespace ShopQuanAo.GUI
{
    public partial class ShowReportHD : Form
    {
        // 1. Thêm thuộc tính để nhận dữ liệu từ Form gọi
        public ReportDataSource ReportDataSource { get; set; }
        public string ReportPath { get; set; }

        // Cần có thuộc tính ReportViewer để set Parameters (nếu có)
        // Lưu ý: Cần kiểm tra tên ReportViewer của bạn trong Designer.cs, mặc định là InHoaDon
        public ReportViewer ReportViewerControl => InHoaDon;

        public ShowReportHD()
        {
            InitializeComponent();
            // Gán sự kiện Load
            this.Load += new EventHandler(ShowReportHD_Load);
        }

        private void ShowReportHD_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.ReportPath) || this.ReportDataSource == null)
            {
                return;
            }
            this.InHoaDon.LocalReport.SetBasePermissionsForSandboxAppDomain(
                new System.Security.PermissionSet(System.Security.Permissions.PermissionState.Unrestricted));

            // 3. ĐẶT ĐƯỜNG DẪN TÀI NGUYÊN NHÚNG
            this.InHoaDon.LocalReport.ReportEmbeddedResource = this.ReportPath;

            // 4. Xóa nguồn dữ liệu cũ và thêm nguồn dữ liệu mới
            this.InHoaDon.LocalReport.DataSources.Clear();
            this.InHoaDon.LocalReport.DataSources.Add(this.ReportDataSource);

            // 5. Hiển thị báo cáo
            this.InHoaDon.RefreshReport();
        }
    }
}