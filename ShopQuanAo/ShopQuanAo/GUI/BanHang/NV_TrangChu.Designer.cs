using System.Drawing;
using System.Windows.Forms;

namespace ShopQuanAo.GUI
{
    partial class NV_TrangChu
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNhanVien = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.crownMenuStrip1 = new ReaLTaiizor.Controls.CrownMenuStrip();
            this.tsmTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1.SuspendLayout();
            this.crownMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNhanVien,
            this.lblThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1097, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(110, 17);
            this.lblNhanVien.Text = "NV: Nguyen Van A |";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(974, 17);
            this.lblThoiGian.Spring = true;
            this.lblThoiGian.Text = "18/10/2025 09:30:15";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // crownMenuStrip1
            // 
            this.crownMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.crownMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTrangChu,
            this.tsmDangXuat,
            this.tàiKhoảnToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
            this.crownMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.crownMenuStrip1.Name = "crownMenuStrip1";
            this.crownMenuStrip1.Padding = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.crownMenuStrip1.Size = new System.Drawing.Size(1097, 27);
            this.crownMenuStrip1.TabIndex = 7;
            this.crownMenuStrip1.Text = "crownMenuStrip1";
            // 
            // tsmTrangChu
            // 
            this.tsmTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tsmTrangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tsmTrangChu.Name = "tsmTrangChu";
            this.tsmTrangChu.Size = new System.Drawing.Size(73, 19);
            this.tsmTrangChu.Text = "Trang Chủ";
            this.tsmTrangChu.Click += new System.EventHandler(this.tsmTrangChu_Click);
            // 
            // tsmDangXuat
            // 
            this.tsmDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tsmDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tsmDangXuat.Name = "tsmDangXuat";
            this.tsmDangXuat.Size = new System.Drawing.Size(74, 19);
            this.tsmDangXuat.Text = "Đăng Xuất";
            this.tsmDangXuat.Click += new System.EventHandler(this.tsmDangXuat_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.hóaĐơnToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.65907F));
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 27);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1097, 533);
            this.mainTableLayoutPanel.TabIndex = 11;
            // 
            // NV_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 582);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.crownMenuStrip1);
            this.KeyPreview = true;
            this.Name = "NV_TrangChu";
            this.Text = "Trang Chủ Nhân Viên - Bán Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NV_TrangChu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.crownMenuStrip1.ResumeLayout(false);
            this.crownMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblNhanVien;
        private ToolStripStatusLabel lblThoiGian;
        private ReaLTaiizor.Controls.CrownMenuStrip crownMenuStrip1;
        private ToolStripMenuItem tsmTrangChu;
        private ToolStripMenuItem tsmDangXuat;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private Timer timer1;
        private TableLayoutPanel mainTableLayoutPanel;
    }
}