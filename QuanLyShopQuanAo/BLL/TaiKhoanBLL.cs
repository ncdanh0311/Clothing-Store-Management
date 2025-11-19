using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO; // Thêm DTO
using System;
using System.Collections.Generic;
using System.Data; // Thêm để dùng DataTable
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL _taiKhoanDAL;

        public TaiKhoanBLL()
        {
            _taiKhoanDAL = new TaiKhoanDAL();
        }
        public TaiKhoanDTO DangNhap(string tenDN, string matKhau)
        {
            // TODO: Băm mật khẩu (matKhau) trước khi gửi xuống DAL
            // Ví dụ: string hashedMatKhau = MaHoaMatKhau(matKhau);
            // Hiện tại đang dùng mật khẩu thô để khớp với DAL
            string hashedMatKhau = matKhau;

            // Bước 1: Gọi DAL để xác thực TAIKHOAN
            DataTable dtTaiKhoan = _taiKhoanDAL.AuthenticateTaiKhoan(tenDN, hashedMatKhau);

            // Bước 2: Kiểm tra kết quả
            if (dtTaiKhoan == null || dtTaiKhoan.Rows.Count == 0)
            {
                return null; // Tên đăng nhập hoặc mật khẩu sai
            }

            // Bước 3: Map dữ liệu từ DataTable sang TaiKhoanDTO
            DataRow tkRow = dtTaiKhoan.Rows[0];
            TaiKhoanDTO tkInfo = new TaiKhoanDTO
            {
                MaTK = Convert.ToInt32(tkRow["MaTK"]),
                MaNV = Convert.ToInt32(tkRow["MaNV"]),
                TenDangNhap = tkRow["TenDangNhap"].ToString(),
                VaiTro = tkRow["VaiTro"].ToString()
            };

            // Bước 4: Gọi DAL để lấy thông tin chi tiết NHANVIEN
            DataTable dtNhanVien = _taiKhoanDAL.GetNhanVienInfo(tkInfo.MaNV);

            // Bước 5: Kiểm tra kết quả
            if (dtNhanVien == null || dtNhanVien.Rows.Count == 0)
            {
                // Đây là lỗi dữ liệu (có tài khoản nhưng không có nhân viên)
                throw new Exception($"Lỗi dữ liệu: Không tìm thấy thông tin nhân viên với MaNV = {tkInfo.MaNV}");
            }

            // Bước 6: Map dữ liệu từ DataTable sang NhanVienDTO
            DataRow nvRow = dtNhanVien.Rows[0];
            NhanVienDTO nvInfo = new NhanVienDTO
            {
                MaNV = tkInfo.MaNV, // Lấy từ tkInfo cho nhất quán
                HoTen = nvRow["HoTen"].ToString(),
                GioiTinh = nvRow["GioiTinh"].ToString(),
                NgaySinh = Convert.ToDateTime(nvRow["NgaySinh"]),
                SDT = nvRow["SDT"].ToString(),
                DiaChi = nvRow["DiaChi"].ToString(),
                NgayVaoLam = Convert.ToDateTime(nvRow["NgayVaoLam"]),
                TrangThai = nvRow["TrangThai"].ToString(),
                Luong = Convert.ToDecimal(nvRow["Luong"])
            };

            // Bước 7: Gọi DAL để kiểm tra ca làm việc
            tkInfo.MaCaHienTai = _taiKhoanDAL.CheckCaLamViec(tenDN);

            // Bước 8: Lưu thông tin vào SessionManager (theo yêu cầu của DangNhap.cs)
            SessionManager.LoginTaiKhoan(tkInfo);
            SessionManager.LoginNhanVien(nvInfo);

            // Bước 9: Trả về thông tin tài khoản cho GUI
            return tkInfo;
        }
    }
}