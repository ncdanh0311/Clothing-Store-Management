using ShopQuanAo.DAL;
using ShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ShopQuanAo.DAL
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

        public DataTable LocPhanCong(DateTime? NgayLam, string TenCa, string TenNV)
        {
            DataTable dt = new DataTable();
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand(@"
            SELECT pc.*, nv.HoTen, ca.TenCa
            FROM PHAN_CONG_CA pc
            JOIN NHANVIEN nv ON nv.MaNV = pc.MaNV
            JOIN CA_LAM_VIEC ca ON ca.MaCa = pc.MaCa
            WHERE (@TenCa = '' OR ca.TenCa = @TenCa)
              AND (@TenNV = '' OR nv.HoTen like @TenNV)
              -- SỬA ĐIỀU KIỆN LỌC NGÀY: 
              -- Nếu NgayLam là NULL (tức là không lọc) HOẶC pc.NgayLam = NgayLam
              AND (@NgayLam IS NULL OR pc.NgayLam = @NgayLam) 
        ", conn);

                // Không cần biến ngayLamCheck nữa

                cmd.Parameters.AddWithValue("@TenCa", TenCa);

                // THAY ĐỔI: Thêm tham số NgayLam. 
                // Dùng .GetValueOrDefault(DateTime.Now) để tránh lỗi nếu NgayLam là null, 
                // và sử dụng DBNull.Value nếu NgayLam thực sự là null.
                if (NgayLam.HasValue)
                {
                    cmd.Parameters.AddWithValue("@NgayLam", NgayLam.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NgayLam", DBNull.Value);
                }

                cmd.Parameters.AddWithValue("@TenNV", "%" + TenNV + "%");

                new SqlDataAdapter(cmd).Fill(dt);
            }
            finally { Close(); }

            return dt;
        }
    }
}