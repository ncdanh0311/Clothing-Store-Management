using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ShopQuanAo.DTO;

namespace ShopQuanAo.DAL
{
    public class LoaiKhachHangDAL : DBConnect
    {


        public List<LoaiKhachHangDTO> GetLoaiKH()
        {
            List<LoaiKhachHangDTO> danhSach = new List<LoaiKhachHangDTO>();
            string query = "SELECT MaLoaiKH, TenLoaiKH, MoTa, ChietKhau FROM dbo.LOAI_KHACHHANG";

            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LoaiKhachHangDTO lkh = new LoaiKhachHangDTO
                    {
                        MaLoaiKH = (int)reader.GetValue(0),
                        TenLoaiKH = reader.GetString(reader.GetOrdinal("TenLoaiKH")),
                        MoTa = reader.IsDBNull(reader.GetOrdinal("MoTa")) ? null : reader.GetString(reader.GetOrdinal("MoTa")),
                        ChietKhau = (decimal)reader.GetValue(3)
                    };
                    danhSach.Add(lkh);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi DAL: " + ex.Message);
            }

            return danhSach;
        }
    }
}