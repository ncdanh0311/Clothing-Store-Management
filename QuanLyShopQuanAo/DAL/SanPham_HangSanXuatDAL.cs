using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.DTO;
using System.Data;

namespace QuanLyShopQuanAo.DAL
{
    public class SanPham_HangSanXuatDAL : DBConnect
    {
        public List<SanPham_HangSanXuatDTO> GetSP_HSX()
        {
            List<SanPham_HangSanXuatDTO> LstSP_HSX = new List<SanPham_HangSanXuatDTO>();
            Open();
            SqlCommand cmd = new SqlCommand("sp_ThongTinSanPham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SanPham_HangSanXuatDTO sp = new SanPham_HangSanXuatDTO
                {
                    MaSP = (int)dr.GetValue(0),
                    TenSP = dr.GetValue(1).ToString(),
                    GiaNhap = decimal.Parse(dr.GetValue(2).ToString()),
                    GiaBan = decimal.Parse(dr.GetValue(3).ToString()),
                    SoLuongTon = (int)dr.GetValue(4),
                    BaoHanh = dr.GetValue(5).ToString(),
                    MoTa = dr.GetValue(6).ToString(),
                    AnhSP = dr.GetValue(7).ToString(),
                    TenHSX = dr.GetValue(8).ToString()
                };
                LstSP_HSX.Add(sp);
            }
            Close();
            return LstSP_HSX;
        }
    }
}
