using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAL
{
    public class SanPhamDAL : DBConnect
    {
        public List<SanPhamDTO> GetSP()
        {
            List<SanPhamDTO> LstSP = new List<SanPhamDTO>();
            Open();
            SqlCommand cmd = new SqlCommand("Select * from SANPHAM", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LstSP.Add(new SanPhamDTO()
                {
                    MaSP = Convert.ToInt32(dr.GetValue(0)),
                    TenSP = dr.GetValue(1).ToString(),
                    GiaNhap = Convert.ToDecimal(dr.GetValue(2)),
                    GiaBan = Convert.ToDecimal(dr.GetValue(3)),
                    SoLuongTon = Convert.ToInt32(dr.GetValue(4)),
                    BaoHanh = dr.GetValue(5).ToString(),
                    MoTa = dr.GetValue(6).ToString(),
                    AnhSP =  dr.GetValue(7) == DBNull.Value ? null: dr.GetValue(7).ToString(),
                    MaHSX = Convert.ToInt32(dr.GetValue(8))
                });
            }
            Close();
            return LstSP;
        }
    }
}
