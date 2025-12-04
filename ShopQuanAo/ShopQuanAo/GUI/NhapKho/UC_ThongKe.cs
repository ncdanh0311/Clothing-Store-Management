using ShopQuanAo.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ShopQuanAo.GUI.NhapKho
{
    public partial class UC_ThongKe : UserControl
    {
        StoreProcedureBLL sp = new StoreProcedureBLL();
        public UC_ThongKe()
        {
            InitializeComponent();
        }

        public void LoadChartNCC()
        {
            chartThongKeTheoHSX.Series["SoLuongSP"].Points.Clear();

            foreach (DataRow row in sp.ThongKeSPtheoHSX().Rows)
            {
                string tenNCC = row["TenHSX"].ToString();
                double soLuong = Convert.ToDouble(row["SoLuong"]);

                chartThongKeTheoHSX.Series["SoLuongSP"].Points.AddXY(tenNCC, soLuong);
            }

            chartThongKeTheoHSX.Series["SoLuongSP"].IsValueShownAsLabel = true;
            chartThongKeTheoHSX.Series["SoLuongSP"].LegendText = "#VALX";
        }

        public void LoadChartTheoNgay()
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date;

                if (tuNgay > denNgay)
                    throw new Exception("Ngày bắt đầu không thể lớn hơn Ngày kết thúc.");

                if (denNgay > DateTime.Now.Date)
                    throw new Exception("Ngày kết thúc không thể là ngày trong tương lai.");

                DataTable dt = sp.ThongKeTienNhapTheoNgay(tuNgay, denNgay);

                chartNgay.Series["TongTienNgay"].Points.Clear();

                if (chartNgay.Titles.Count > 1)
                {
                    chartNgay.Titles[1].Text = "";
                }

                if (dt != null && dt.Rows.Count > 0)
                {
                    chartNgay.Series["TongTienNgay"].ChartType = SeriesChartType.Column;

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime ngayNhap = Convert.ToDateTime(row["NgayNhap"]);
                        double tongTien = Convert.ToDouble(row["TongNhapNgay"]);

                        chartNgay.Series["TongTienNgay"].Points.AddXY(ngayNhap.ToString("dd/MM"), tongTien);
                    }

                    chartNgay.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";

                    chartNgay.Series["TongTienNgay"].IsValueShownAsLabel = true;
                    chartNgay.Series["TongTienNgay"].LabelFormat = "#,##0";

                }
                else
                {
                    if (chartNgay.Titles.Count > 1)
                    {
                        chartNgay.Titles[1].Text = "Không có dữ liệu trong khoảng thời gian này.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải biểu đồ ngày: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            LoadChartNCC();
        }

        private void btnLocNgay_Click(object sender, EventArgs e)
        {
            LoadChartTheoNgay();
        }
    }
}
