using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyShopQuanAo.DAL
{
    internal class StoreProcedureDAL : DBConnect
    {
        public int TaoPhieuNhap(int MaNV, int MaNCC)
        {
            int? maPNMoi = null;
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand("TaoPhieuNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@MaNCC", MaNCC);

                // SỬA LẠI: DÙNG EXECUTESCALAR()
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    maPNMoi = Convert.ToInt32(result);
            }
            finally
            {
                Close();
            }

            if (maPNMoi == null)
                throw new Exception("Không thể tạo MaPN mới.");

            return maPNMoi.Value;
        }

        public int ThemChiTietPN(int MaPN, int MaSP, int SoLuong, decimal DonGia)
        {
            int rs = 0;
            Open();
            SqlCommand cmd = new SqlCommand("TaoChiTietPN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPN", MaPN);
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@SoLuong",SoLuong);
            cmd.Parameters.AddWithValue("@DonGia",DonGia);
            rs = cmd.ExecuteNonQuery();
            Close();
            return rs;
        }

        public DataTable ThongKeSPtheoHSX()
        {
            Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_ThongKeSPtheoHSX", conn);
            da.Fill(dt);
            Close();
            return dt;
        }

        public DataTable ThongKeTienNhapTheoNgay(DateTime TuNgay, DateTime DenNgay)
        {
            Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ThongKeTienNhapTheoNgay", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuNgay", TuNgay);
            cmd.Parameters.AddWithValue("@DenNgay", DenNgay);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Close();
            return dt;
        }

        public DataTable GetThongTinHoaDon()
        {
            Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ThongTinHoaDon", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Close();
            return dt;
        }

        public int CapNhatDonHang(int MaDH, int MaNV, DateTime NgayLap)
        {
            int rs = 0;
            Open();
            SqlCommand cmd = new SqlCommand("sp_CapNhatDonHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDH", MaDH);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.Parameters.AddWithValue("@NgayLap", NgayLap);
            rs = cmd.ExecuteNonQuery();
            Close();
            return rs;
        }
        public int CapNhatKhachHang(int MaKH, string TenKH)
        {
            int rs = 0;
            Open();
            SqlCommand cmd = new SqlCommand("sp_CapNhatKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@TenKH", TenKH);
            rs = cmd.ExecuteNonQuery();
            Close();
            return rs;
        }

        public int CapNhatChiTietHoaDon(int MaDH, int MaSP, int SoLuong, decimal DonGia, int MaSP_Cu)
        {
            int rs = 0;
            Open();
            SqlCommand cmd = new SqlCommand("sp_CapNhatChiTietDonHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDH", MaDH);
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", DonGia);
            cmd.Parameters.AddWithValue("@MaSP_Cu", MaSP_Cu);
            rs = cmd.ExecuteNonQuery();
            Close();
            return rs;
        }

        public int ThemChiTietDonHang(int MaDH, int MaSP, int SoLuong, decimal DonGia)
        {
            int rs = 0;
            Open();
            // Giả định bạn đã tạo Stored Procedure tên là TaoChiTietDonHang
            SqlCommand cmd = new SqlCommand("TaoChiTietDonHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDH", MaDH);
            cmd.Parameters.AddWithValue("@MaSP", MaSP);
            cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", DonGia);
            rs = cmd.ExecuteNonQuery();
            Close();
            return rs;
        }
    }
}
