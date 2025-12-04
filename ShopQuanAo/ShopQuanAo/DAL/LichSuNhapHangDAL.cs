using ShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo.DAL
{
    internal class LichSuNhapHangDAL : DBConnect
    {
        public List<LichSuNhapHangDTO> GetLichSuNhapHang(DateTime tuNgay, DateTime denNgay)
        {
            List<LichSuNhapHangDTO> list = new List<LichSuNhapHangDTO>();

            using (SqlCommand cmd = new SqlCommand("sp_TraCuuLichSuNhapHang", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LichSuNhapHangDTO dto = new LichSuNhapHangDTO
                        {
                            MaPN = reader.GetInt32(reader.GetOrdinal("MaPN")),
                            TenSP = reader["TenSP"].ToString(),
                            HangSanXuat = reader["TenHSX"].ToString(),
                            NgayNhap = reader.GetDateTime(reader.GetOrdinal("NgayNhap")),
                            SoLuong = Convert.ToInt32(reader["SoLuong"]),
                            DonGia = Convert.ToDecimal(reader["DonGia"]),
                            ThanhTien = Convert.ToDecimal(reader["ThanhTien"]),
                            NhanVienNhap = reader["NhanVienNhap"].ToString()
                        };
                        list.Add(dto);
                    }
                }
            }

            return list;
        }
    }
}
