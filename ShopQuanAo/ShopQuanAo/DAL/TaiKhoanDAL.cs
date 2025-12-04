using ShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ShopQuanAo.DAL
{
    public class TaiKhoanDAL : DBConnect
    {
        public TaiKhoanDAL() : base() { }

        public TaiKhoanDTO AuthenticateTaiKhoan(string tenDN, string matKhau)
        {
            TaiKhoanDTO tkInfo = null;
            string authQuery = "SELECT MaTK, MaNV, VaiTro, TenDangNhap FROM TAIKHOAN WHERE TenDangNhap = @TenDN AND MatKhau = @MatKhau";

            try
            {
                Open();
                using (SqlCommand authCmd = new SqlCommand(authQuery, conn))
                {
                    authCmd.Parameters.AddWithValue("@TenDN", tenDN);
                    authCmd.Parameters.AddWithValue("@MatKhau", matKhau);

                    SqlDataReader reader = authCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        tkInfo = new TaiKhoanDTO
                        {
                            MaTK = (int)reader["MaTK"],
                            VaiTro = reader["VaiTro"].ToString(),
                            MaNV = reader["MaNV"] != DBNull.Value ? (int?)reader["MaNV"] : null
                        };
                    }
                    reader.Close();
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
            return tkInfo;
        }

        public bool UpdateMaNVForTaiKhoan(int maTK, int maNV)
        {
            string updateQuery = "UPDATE TAIKHOAN SET MaNV = @MaNV WHERE MaTK = @MaTK";
            try
            {
                Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@MaTK", maTK);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật MaNV cho Tài Khoản: " + ex.Message);
                return false;
            }
            finally
            {
                Close();
            }
        }
        public int InsertNhatKyDangNhap(int maTK, int? maNV, int? maCa, string diaChiIP, string thietBi)
        {
            string insertQuery = @"
                INSERT INTO NHATKY_DANGNHAP (MaTK, MaNV, MaCa, ThoiGianDangNhap, DiaChiIP, ThietBi)
                VALUES (@MaTK, @MaNV, @MaCa, @ThoiGianDangNhap, @DiaChiIP, @ThietBi);
                SELECT SCOPE_IDENTITY();";

            int maNhatKy = 0;
            try
            {
                Open();
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaTK", maTK);
                    cmd.Parameters.AddWithValue("@MaNV", maNV.HasValue ? (object)maNV.Value : DBNull.Value);
                    // MaCa luôn là NULL khi không kiểm tra ca làm
                    cmd.Parameters.AddWithValue("@MaCa", maCa.HasValue ? (object)maCa.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ThoiGianDangNhap", DateTime.Now);
                    cmd.Parameters.AddWithValue("@DiaChiIP", string.IsNullOrEmpty(diaChiIP) ? (object)DBNull.Value : diaChiIP);
                    cmd.Parameters.AddWithValue("@ThietBi", string.IsNullOrEmpty(thietBi) ? (object)DBNull.Value : thietBi);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        maNhatKy = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi ghi nhật ký đăng nhập: " + ex.Message);
            }
            finally
            {
                Close();
            }
            return maNhatKy;
        }

        public int UpdateTaiKhoan(string tenDN,string newMK)
        {
            Open();
            int rs = 0;
            SqlCommand cmd = new SqlCommand("Update TAIKHOAN set MatKhau = @newMK where TenDangNhap = @tenDN",conn);
            cmd.Parameters.AddWithValue("@newMK", newMK);
            cmd.Parameters.AddWithValue("@tenDN", tenDN);
            rs = cmd.ExecuteNonQuery();
            Close();
            return rs;
        }

        public List<TaiKhoanDTO> GetTK()
        {
            List<TaiKhoanDTO> LstTK = new List<TaiKhoanDTO>();
            Open();
            SqlCommand cmd = new SqlCommand("Select * from TAIKHOAN", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TaiKhoanDTO tk = new TaiKhoanDTO
                {
                    MaTK = (int)dr.GetValue(0),
                    TenDangNhap = dr.GetValue(1).ToString(),
                    MatKhau = dr.GetValue(2).ToString(),
                    VaiTro = dr.GetValue(3).ToString(),
                    TrangThai = (bool)dr.GetValue(4),                   
                    NgayTao = (DateTime)dr.GetValue(5),
                    MaNV = (int)dr.GetValue(6)
                };
                LstTK.Add(tk);
            }
            Close();
            return LstTK;
        }

    }
}