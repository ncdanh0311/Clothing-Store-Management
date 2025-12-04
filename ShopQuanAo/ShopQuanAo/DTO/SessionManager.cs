using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo.DTO
{
    // Cấu trúc giữ nguyên
    public static class SessionManager
    {
        public static TaiKhoanDTO TaiKhoanHienTai { get; private set; }
        public static NhanVienDTO NhanVienChiTiet { get; private set; }

        public static void SetUserSession(TaiKhoanDTO tkInfo, NhanVienDTO nvInfo)
        {
            TaiKhoanHienTai = tkInfo;
            NhanVienChiTiet = nvInfo;
        }

        // GIỮ LẠI: Lấy Mã Nhân viên hiện tại (quan trọng cho nghiệp vụ)
        public static int MaNVHienTai
        {
            get { return NhanVienChiTiet?.MaNV ?? 0; }
        }

        public static string VaiTroHienTai
        {
            get { return TaiKhoanHienTai?.VaiTro ?? string.Empty; }
        }

        public static void Logout()
        {
            TaiKhoanHienTai = null;
            NhanVienChiTiet = null;
        }
    }
}