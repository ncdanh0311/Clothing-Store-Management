using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DAL
{
    public class TaiKhoanDAL : DBConnect
    {
        // Constructor sẽ tự gọi constructor của DBConnect để khởi tạo chuỗi kết nối và đối tượng conn
        public TaiKhoanDAL() : base() { }

        /// <summary>
        /// Bước 1: Xác thực TAIKHOAN và lấy thông tin TAIKHOAN.
        /// </summary>
        public DataTable AuthenticateTaiKhoan(string tenDN, string matKhau)
        {
            DataTable dt = new DataTable();
            string authQuery = "SELECT MaTK, MaNV, VaiTro, TenDangNhap FROM TAIKHOAN WHERE TenDangNhap = @TenDN AND MatKhau = @MatKhau";

            try
            {
                Open(); // Dùng hàm Open() từ DBConnect
                using (SqlCommand authCmd = new SqlCommand(authQuery, conn))
                {
                    authCmd.Parameters.AddWithValue("@TenDN", tenDN);
                    authCmd.Parameters.AddWithValue("@MatKhau", matKhau);

                    SqlDataReader reader = authCmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn tài khoản: " + ex.Message);
            }
            finally
            {
                Close();
            }
            return dt;
        }

        /// <summary>
        /// Bước 2: Lấy thông tin chi tiết NHANVIEN.
        /// </summary>
        public DataTable GetNhanVienInfo(int maNV)
        {
            DataTable dt = new DataTable();
            string nvQuery = "SELECT HoTen, GioiTinh, NgaySinh, SDT, DiaChi, NgayVaoLam, TrangThai, Luong FROM NHANVIEN WHERE MaNV = @MaNV";

            try
            {
                Open();
                using (SqlCommand nvCmd = new SqlCommand(nvQuery, conn))
                {
                    nvCmd.Parameters.AddWithValue("@MaNV", maNV);
                    dt.Load(nvCmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn thông tin nhân viên: " + ex.Message);
            }
            finally
            {
                Close();
            }
            return dt;
        }

        /// <summary>
        /// Bước 3: Kiểm tra ca làm việc (Sử dụng Store Procedure và ExecuteScalar).
        /// </summary>
        public int? CheckCaLamViec(string tenDN)
        {
            int? maCa = null;
            try
            {
                Open();
                using (SqlCommand caCmd = new SqlCommand("sp_KiemTraCaLamViec", conn))
                {
                    caCmd.CommandType = CommandType.StoredProcedure;
                    caCmd.Parameters.AddWithValue("@TenDangNhap", tenDN);
                    caCmd.Parameters.AddWithValue("@ThoiGianDangNhap", DateTime.Now);

                    object result = caCmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        maCa = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra ca làm việc: " + ex.Message);
            }
            finally
            {
                Close();
            }
            return maCa;
        }
    }
}
