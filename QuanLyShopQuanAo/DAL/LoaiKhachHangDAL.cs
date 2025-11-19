using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAL
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
                        MaLoaiKH = reader.GetInt32(reader.GetOrdinal("MaLoaiKH")),
                        TenLoaiKH = reader.GetString(reader.GetOrdinal("TenLoaiKH")),
                        MoTa = reader.IsDBNull(reader.GetOrdinal("MoTa")) ? null : reader.GetString(reader.GetOrdinal("MoTa")),
                        ChietKhau = reader.IsDBNull(reader.GetOrdinal("ChietKhau")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("ChietKhau"))
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