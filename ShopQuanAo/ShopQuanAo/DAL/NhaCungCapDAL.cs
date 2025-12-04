using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ShopQuanAo.DTO;

namespace ShopQuanAo.DAL
{
    public class NhaCungCapDAL : DBConnect
    {
        public List<NhaCungCapDTO> GetNCC()
        {
            List<NhaCungCapDTO> LstNCC = new List<NhaCungCapDTO>();
            Open();
            SqlCommand cmd = new SqlCommand("Select * from NHACUNGCAP", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                LstNCC.Add(new NhaCungCapDTO
                {
                    MaNCC = Convert.ToInt32(rd.GetValue(0)),
                    TenNCC = rd.GetValue(1).ToString(),
                    SDT = rd.GetValue(2).ToString(),
                    DiaChi = rd.GetValue(3).ToString(),
                    Email = rd.GetValue(4).ToString(),
                });
            }
            Close();
            return LstNCC;
        }
        public int ThemNCC(string TenNCC, string SDT, string DiaChi, string Email)
        {
            int rs = 0;
            Open();
            SqlCommand cmd = new SqlCommand("insert into NHACUNGCAP values(@TenNCC,@SDT,@DiaChi,@Email)", conn);
            cmd.Parameters.AddWithValue("@TenNCC", TenNCC);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@Email", Email);
            rs = cmd.ExecuteNonQuery();
            Close();
            return rs;
        }
        public int XoaNCC(int MaNCC)
        {
            int rs = 0;
            Open();
            SqlCommand cmd = new SqlCommand("Delete from NHACUNGCAP where MaNCC = @MaNCC", conn);
            cmd.Parameters.AddWithValue("@MaNCC", MaNCC);
            rs = cmd.ExecuteNonQuery();
            Close();
            return rs;
        }
        public int SuaNCC(NhaCungCapDTO ncc)
        {
            int rs = 0;
            Open();
            SqlCommand cmd = new SqlCommand("Update NHACUNGCAP " +
                                            "Set TenNCC = @TenNCC, SDT = @SDT, DiaChi = @DiaChi, Email = @Email " +
                                            "Where MaNCC = @MaNCC", conn);
            cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC);
            cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC);
            cmd.Parameters.AddWithValue("@SDT", ncc.SDT);
            cmd.Parameters.AddWithValue("@DiaChi", ncc.DiaChi);
            cmd.Parameters.AddWithValue("@Email", ncc.Email);
            rs = cmd.ExecuteNonQuery();
            Close();
            return rs;
        }
    }
}
