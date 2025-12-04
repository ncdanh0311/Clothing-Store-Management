namespace ShopQuanAo.GUI
{
    partial class ShowReportHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // InHoaDon
            // 
            this.InHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InHoaDon.Location = new System.Drawing.Point(0, 0);
            this.InHoaDon.Name = "InHoaDon";
            this.InHoaDon.ServerReport.BearerToken = null;
            this.InHoaDon.Size = new System.Drawing.Size(800, 450);
            this.InHoaDon.TabIndex = 0;
            // 
            // ShowReportHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InHoaDon);
            this.Name = "ShowReportHD";
            this.Text = "ShowReportHD";
            this.Load += new System.EventHandler(this.ShowReportHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer InHoaDon;
    }
}