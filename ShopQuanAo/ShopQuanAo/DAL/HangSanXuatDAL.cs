using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopQuanAo.DTO;

namespace ShopQuanAo.DAL
{
    public class HangSanXuatDAL : DBConnect
    {
        public List<HangSanXuatDTO> GetHSX()
        {
            List<HangSanXuatDTO> LstHSX = new List<HangSanXuatDTO>();
            Open();
            SqlCommand cmd = new SqlCommand("Select * from HANGSANXUAT", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                LstHSX.Add(new HangSanXuatDTO()
                {
                    MaHSX = Convert.ToInt32(rd.GetValue(0)),
                    TenHSX = rd.GetValue(1).ToString(),
                    QuocGia = rd.GetValue(2).ToString()
                });
            }
            Close();
            return LstHSX;
        }
    }
}
