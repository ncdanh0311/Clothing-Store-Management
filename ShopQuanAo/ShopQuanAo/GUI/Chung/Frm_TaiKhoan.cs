using ShopQuanAo.BLL;
using ShopQuanAo.DTO;
using ShopQuanAo.GUI.Chung;
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
    public partial class Frm_TaiKhoan : Form
    {
        NhanVienBLL nvBLL = new NhanVienBLL();
        public Frm_TaiKhoan()
        {
            InitializeComponent();
        }

        private void Frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            var ttNV = nvBLL.GetAll().FirstOrDefault(nv => nv.MaNV == SessionManager.MaNVHienTai);
            if (ttNV != null)
            {
                TxtHoTen.Text = ttNV.HoTen.ToString();
                TxtNgaySinh.Text = ttNV.NgaySinh.ToString();
                TxtSDT.Text = ttNV.SDT.ToString();
                TxtDiaChi.Text = ttNV.DiaChi.ToString();
                TxtGioiTinh.Text = ttNV?.GioiTinh.ToString();

                TxtMaNV.Text = ttNV.MaNV.ToString();
                TxtTrangThai.Text = ttNV?.TrangThai.ToString();

                LblHoTen.Text = ttNV.HoTen.ToString();
                LblViTri.Text = ttNV.VitriLamViec.ToString();
            }
        }

        private void ChoPhepCapNhat() { 
            TxtHoTen.ReadOnly = true;
            TxtNgaySinh.ReadOnly = true;
            TxtSDT.ReadOnly = true;
            TxtDiaChi.ReadOnly = true;
            TxtGioiTinh.ReadOnly = true;
        }
        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
           ChoPhepCapNhat();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            var nhanvien = nvBLL.GetAll().FirstOrDefault(nv => nv.MaNV == SessionManager.MaNVHienTai);
            nhanvien.HoTen = TxtHoTen.Text;
            nhanvien.NgaySinh = Convert.ToDateTime(TxtNgaySinh.Text);
            nhanvien.SDT = TxtSDT.Text;
            nhanvien.DiaChi = TxtDiaChi.Text;
            nhanvien.GioiTinh = TxtGioiTinh.Text;
            nvBLL.Update(nhanvien);
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMK doiMK = new DoiMK();
            doiMK.Owner = this;
            doiMK.ShowDialog();
        }
    }
}
