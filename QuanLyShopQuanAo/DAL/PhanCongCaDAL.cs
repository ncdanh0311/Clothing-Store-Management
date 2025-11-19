using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyShopQuanAo.DAL
{
    public class PhanCongCaDAL : DBConnect
    {
        // ⚡ Lấy tất cả phân công, trả về List<PhanCongCaDTO>
        public List<PhanCongCaDTO> GetAll()
        {
            List<PhanCongCaDTO> LstPC = new List<PhanCongCaDTO>();
            string sql = "SELECT * FROM PHAN_CONG_CA";
            SqlCommand cmd = new SqlCommand(sql, conn);

            Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LstPC.Add(new PhanCongCaDTO
                {
                    MaPhanCong = (int)dr["MaPhanCong"],
                    MaNV = (int)dr["MaNV"],
                    MaCa = (int)dr["MaCa"],
                    NgayLam = (DateTime)dr["NgayLam"]
                });
            }
            Close();
            return LstPC;
        }

        // ⚡ Thêm phân công - Nhận vào DTO
        public bool Insert(PhanCongCaDTO pc)
        {
            try
            {
                string sql = @"INSERT INTO PHAN_CONG_CA (MaNV, MaCa, NgayLam)
                               VALUES (@MaNV, @MaCa, @NgayLam)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", pc.MaNV);
                cmd.Parameters.AddWithValue("@MaCa", pc.MaCa);
                cmd.Parameters.AddWithValue("@NgayLam", pc.NgayLam);

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

        // ⚡ Cập nhật phân công - Nhận vào DTO
        public bool Update(PhanCongCaDTO pc)
        {
            try
            {
                string sql = @"UPDATE PHAN_CONG_CA
                               SET MaNV=@MaNV, MaCa=@MaCa, NgayLam=@NgayLam
                               WHERE MaPhanCong=@MaPhanCong";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaPhanCong", pc.MaPhanCong);
                cmd.Parameters.AddWithValue("@MaNV", pc.MaNV);
                cmd.Parameters.AddWithValue("@MaCa", pc.MaCa);
                cmd.Parameters.AddWithValue("@NgayLam", pc.NgayLam);

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

        // ⚡ Xóa phân công (Giữ nguyên)
        public bool Delete(int maPhanCong)
        {
            try
            {
                string sql = "DELETE FROM PHAN_CONG_CA WHERE MaPhanCong=@MaPhanCong";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaPhanCong", maPhanCong);

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
    }
}