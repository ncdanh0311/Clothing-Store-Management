using QuanLyShopQuanAo.DTO;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DAL
{
    public class PhieuNhapDAL : DBConnect
    {
        public List<PhieuNhapDTO> GetPN()
        {
            List<PhieuNhapDTO> LstPN = new List<PhieuNhapDTO>();
            Open();
            SqlCommand cmd = new SqlCommand("Select * from PhieuNhap", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                PhieuNhapDTO pn = new PhieuNhapDTO
                {
                    MaPN = (int)rd.GetValue(0),
                    NgayNhap = Convert.ToDateTime(rd.GetValue(1)),
                    MaNV = (int)rd.GetValue(2),
                    MaNCC = (int)rd.GetValue(3),
                    TongTien = Convert.ToDecimal(rd.GetValue(4)),
                    TrangThai = rd.GetValue(5).ToString()
                };
                LstPN.Add(pn);
            }
            Close();
            return LstPN;
        }
    }
}
