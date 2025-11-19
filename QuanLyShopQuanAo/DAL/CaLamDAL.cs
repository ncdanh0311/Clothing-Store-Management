using QuanLyShopQuanAo.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyShopQuanAo.DTO; // Thêm DTO

namespace QuanLyShopQuanAo.DAL
{
    public class CaLamDAL : DBConnect
    {
        // ⚡ Lấy toàn bộ danh sách ca làm việc, trả về List<CaLamViecDTO>
        public List<CaLamViecDTO> GetAll()
        {
            List<CaLamViecDTO> LstCa = new List<CaLamViecDTO>();
            string sql = "SELECT MaCa, TenCa, GioBatDau, GioKetThuc FROM CA_LAM_VIEC";
            SqlCommand cmd = new SqlCommand(sql, conn);

            Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LstCa.Add(new CaLamViecDTO
                {
                    MaCa = (int)dr["MaCa"],
                    TenCa = dr["TenCa"].ToString(),
                    // Cần ép kiểu từ object sang TimeSpan
                    GioBatDau = (TimeSpan)dr["GioBatDau"],
                    GioKetThuc = (TimeSpan)dr["GioKetThuc"]
                });
            }
            Close();
            return LstCa;
        }
    }
}