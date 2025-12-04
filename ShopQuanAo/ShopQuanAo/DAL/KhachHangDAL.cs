using ShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ShopQuanAo.DAL
{
    public class KhachHangDAL : DBConnect
    {
        // ⚡ Lấy tất cả khách hàng, trả về List<KhachHangDTO>
        public List<KhachHangDTO> GetAll()
        {
            List<KhachHangDTO> LstKH = new List<KhachHangDTO>();
            string sql = "SELECT * FROM KHACHHANG";
            SqlCommand cmd = new SqlCommand(sql, conn);

            Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LstKH.Add(new KhachHangDTO
                {
                    MaKH = (int)dr["MaKH"],
                    TenKH = dr["TenKH"].ToString(),
                    MaLoaiKH = (int)dr["MaLoaiKH"],
                    SDT = dr["SDT"] == DBNull.Value ? null : dr["SDT"].ToString(),
                    DiaChi = dr["DiaChi"] == DBNull.Value ? null : dr["DiaChi"].ToString(),
                    Email = dr["Email"] == DBNull.Value ? null : dr["Email"].ToString(),
                    TenCongTy = dr["TenCongTy"] == DBNull.Value ? null : dr["TenCongTy"].ToString(),
                    MaSoThue = dr["MaSoThue"] == DBNull.Value ? null : dr["MaSoThue"].ToString(),
                    NgayTao = (DateTime)dr["NgayTao"]
                });
            }
            Close();
            return LstKH;
        }

        // ⚡ Thêm khách hàng - Nhận vào DTO
        public bool Insert(KhachHangDTO kh)
        {
            try
            {
                // KHẮC PHỤC LỖI: Bỏ cột 'NgayTao' khỏi lệnh INSERT, giả định nó có giá trị mặc định là GETDATE() trong CSDL.
                string sql = "INSERT INTO KHACHHANG (TenKH, MaLoaiKH, SDT, DiaChi, Email, TenCongTy, MaSoThue) " +
                             "VALUES (@TenKH, @MaLoaiKH, @SDT, @DiaChi, @Email, @TenCongTy, @MaSoThue)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@MaLoaiKH", kh.MaLoaiKH);
                cmd.Parameters.AddWithValue("@SDT", kh.SDT ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", kh.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TenCongTy", kh.TenCongTy ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaSoThue", kh.MaSoThue ?? (object)DBNull.Value);

                Open();
                int rows = cmd.ExecuteNonQuery();
                Close();

                return rows > 0;
            }
            catch
            {
                Close();
                return false;
            }
        }

        // ⚡ Sửa khách hàng - Nhận vào DTO
        public bool Update(KhachHangDTO kh)
        {
            try
            {
                string sql = "UPDATE KHACHHANG SET TenKH=@TenKH, MaLoaiKH=@MaLoaiKH, SDT=@SDT, DiaChi=@DiaChi, Email=@Email, " +
                             "TenCongTy=@TenCongTy, MaSoThue=@MaSoThue WHERE MaKH=@MaKH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
                cmd.Parameters.AddWithValue("@MaLoaiKH", kh.MaLoaiKH);
                cmd.Parameters.AddWithValue("@SDT", kh.SDT ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", kh.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TenCongTy", kh.TenCongTy ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaSoThue", kh.MaSoThue ?? (object)DBNull.Value);

                Open();
                int rows = cmd.ExecuteNonQuery();
                Close();

                return rows > 0;
            }
            catch
            {
                Close();
                return false;
            }
        }

        // ⚡ Xóa khách hàng (Giữ nguyên)
        public bool Delete(int maKH)
        {
            string sql = "DELETE FROM KHACHHANG WHERE MaKH=@MaKH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKH", maKH);

            Open();
            int rows = cmd.ExecuteNonQuery();
            Close();

            return rows > 0;
        }
    }
}