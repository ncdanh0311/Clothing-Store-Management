using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL ncc = new NhaCungCapDAL();
        public List<NhaCungCapDTO> GetNCC()
        {
            return ncc.GetNCC();
        }
        public int ThemNCC(string TenNCC, string SDT, string DiaChi, string Email)
        {
            return ncc.ThemNCC(TenNCC, SDT, DiaChi, Email);
        }
        public int XoaNCC(int MaNCC)
        {
            return ncc.XoaNCC(MaNCC);
        }
        public int SuaNCC(NhaCungCapDTO n)
        {
            return ncc.SuaNCC(n);
        }
    }
}
