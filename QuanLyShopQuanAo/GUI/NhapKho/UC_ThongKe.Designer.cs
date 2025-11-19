using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI.NhapKho
{
    partial class UC_ThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKeTheoHSX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNgay;

        // KHAI BÁO CÁC CONTROL LỌC NGÀY
        private System.Windows.Forms.Panel pnlFilterNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnLocNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        // Hết khai báo

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.chartThongKeTheoHSX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNgay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilterNgay = new System.Windows.Forms.Panel();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnLocNgay = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeTheoHSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNgay)).BeginInit();
            this.pnlFilterNgay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.chartThongKeTheoHSX, 0, 1);
            this.tlpMain.Controls.Add(this.chartNgay, 0, 3);
            this.tlpMain.Controls.Add(this.lblTitle, 0, 0);
            this.tlpMain.Controls.Add(this.pnlFilterNgay, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(1000, 700);
            this.tlpMain.TabIndex = 0;
            // 
            // chartThongKeTheoHSX
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThongKeTheoHSX.ChartAreas.Add(chartArea1);
            this.chartThongKeTheoHSX.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartThongKeTheoHSX.Legends.Add(legend1);
            this.chartThongKeTheoHSX.Location = new System.Drawing.Point(3, 43);
            this.chartThongKeTheoHSX.Name = "chartThongKeTheoHSX";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Label = "#PERCENT";
            series1.Legend = "Legend1";
            series1.Name = "SoLuongSP";
            this.chartThongKeTheoHSX.Series.Add(series1);
            this.chartThongKeTheoHSX.Size = new System.Drawing.Size(994, 304);
            this.chartThongKeTheoHSX.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Tỷ lệ sản phẩm nhập theo Nhà Cung Cấp";
            this.chartThongKeTheoHSX.Titles.Add(title1);
            // 
            // chartNgay
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "Ngày";
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Title = "Tổng tiền (VNĐ)";
            chartArea2.Name = "ChartArea1";
            this.chartNgay.ChartAreas.Add(chartArea2);
            this.chartNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartNgay.Legends.Add(legend2);
            this.chartNgay.Location = new System.Drawing.Point(3, 393);
            this.chartNgay.Name = "chartNgay";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "TongTienNgay";
            this.chartNgay.Series.Add(series2);
            this.chartNgay.Size = new System.Drawing.Size(994, 304);
            this.chartNgay.TabIndex = 1;
            title2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title2";
            title2.Text = "Thống kê số tiền nhập hàng theo Ngày";
            this.chartNgay.Titles.Add(title2);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(994, 40);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "THỐNG KÊ NHẬP HÀNG KHO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilterNgay
            // 
            this.pnlFilterNgay.Controls.Add(this.lblTuNgay);
            this.pnlFilterNgay.Controls.Add(this.dtpTuNgay);
            this.pnlFilterNgay.Controls.Add(this.lblDenNgay);
            this.pnlFilterNgay.Controls.Add(this.dtpDenNgay);
            this.pnlFilterNgay.Controls.Add(this.btnLocNgay);
            this.pnlFilterNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterNgay.Location = new System.Drawing.Point(3, 353);
            this.pnlFilterNgay.Name = "pnlFilterNgay";
            this.pnlFilterNgay.Size = new System.Drawing.Size(994, 34);
            this.pnlFilterNgay.TabIndex = 5;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(10, 10);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(49, 13);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(90, 7);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 20);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(233, 10);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(56, 13);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(317, 7);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 20);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // btnLocNgay
            // 
            this.btnLocNgay.Location = new System.Drawing.Point(443, 6);
            this.btnLocNgay.Name = "btnLocNgay";
            this.btnLocNgay.Size = new System.Drawing.Size(75, 27);
            this.btnLocNgay.TabIndex = 4;
            this.btnLocNgay.Text = "Lọc";
            this.btnLocNgay.UseVisualStyleBackColor = true;
            this.btnLocNgay.Click += new System.EventHandler(this.btnLocNgay_Click);
            // 
            // UC_ThongKe
            // 
            this.Controls.Add(this.tlpMain);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1000, 700);
            this.Load += new System.EventHandler(this.UC_ThongKe_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeTheoHSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNgay)).EndInit();
            this.pnlFilterNgay.ResumeLayout(false);
            this.pnlFilterNgay.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
    }
}