using QuanLyShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyShopQuanAo.DAL
{
    // Giả định class DonHangDAL kế thừa DBConnect và có thể gọi Open/Close
    public class DonHangDAL : DBConnect
    {
        // ⚡ Lấy toàn bộ danh sách đơn hàng, trả về List<DonHangDTO>
        public List<DonHangDTO> GetAll()
        {
            List<DonHangDTO> LstDH = new List<DonHangDTO>();
            string sql = "SELECT * FROM DONHANG";
            SqlCommand cmd = new SqlCommand(sql, conn);

            Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LstDH.Add(new DonHangDTO
                {
                    MaDH = (int)dr["MaDH"],
                    NgayLap = (DateTime)dr["NgayLap"],
                    MaNV = (int)dr["MaNV"],
                    MaKH = (int)dr["MaKH"],
                    TongTien = (decimal)dr["TongTien"]
                });
            }
            Close();
            return LstDH;
        }

        // --- PHƯƠNG THỨC MỚI: THÊM HEADER VÀ TRẢ VỀ ID (Cho nút Thêm) ---
        /// <summary>
        /// Thêm mới Header Đơn hàng với Tổng tiền mặc định bằng 0 và trả về MaDH vừa tạo.
        /// </summary>
        /// <returns>MaDH mới nếu thành công, 0 nếu thất bại.</returns>
        public int InsertHeader(int maNV, int maKH, DateTime ngayLap)
        {
            try
            {
                // Sử dụng OUTPUT inserted.MaDH hoặc SCOPE_IDENTITY() để lấy ID mới
                string sql = "INSERT INTO DONHANG (NgayLap, MaNV, MaKH, TongTien) OUTPUT INSERTED.MaDH VALUES (@NgayLap, @MaNV, @MaKH, 0)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NgayLap", ngayLap);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                Open();
                // Thực thi và lấy MaDH mới
                object result = cmd.ExecuteScalar();
                Close();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                return 0;
            }
            catch
            {
                Close();
                return 0;
            }
        }

        // --- PHƯƠNG THỨC MỚI: SỬA HEADER (Cho nút Sửa) ---
        /// <summary>
        /// Cập nhật 3 trường Header chính của Đơn hàng, bỏ qua TongTien.
        /// </summary>
        public bool UpdateHeader(int maDH, int maNV, int maKH, DateTime ngayLap)
        {
            try
            {
                string sql = "UPDATE DONHANG SET NgayLap=@NgayLap, MaNV=@MaNV, MaKH=@MaKH WHERE MaDH=@MaDH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDH", maDH);
                cmd.Parameters.AddWithValue("@NgayLap", ngayLap);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@MaKH", maKH);

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

        // ⚡ Xóa đơn hàng (Giữ nguyên)
        public bool Delete(int maDH)
        {
            try
            {
                string sql = "DELETE FROM DONHANG WHERE MaDH=@MaDH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDH", maDH);

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