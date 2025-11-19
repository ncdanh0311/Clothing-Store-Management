using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DTO
{
    public static class SessionManager
    {
        public static TaiKhoanDTO TaiKhoanHienTai { get; private set; }
        public static NhanVienDTO NhanVienChiTiet { get; private set; }

        public static void LoginTaiKhoan(TaiKhoanDTO tkInfo)
        {
            TaiKhoanHienTai = tkInfo;
        }

        public static void LoginNhanVien(NhanVienDTO nvInfo)
        {
            NhanVienChiTiet = nvInfo;
        }

        public static int MaNVHienTai
        {
            get { return NhanVienChiTiet?.MaNV ?? 0; }
        }
    }
}
