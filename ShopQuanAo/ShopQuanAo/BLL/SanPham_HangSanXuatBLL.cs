using ShopQuanAo.DAL;
using ShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo.BLL
{
    public class SanPham_HangSanXuatBLL
    {
        SanPham_HangSanXuatDAL sp = new SanPham_HangSanXuatDAL();
        public List<SanPham_HangSanXuatDTO> GetSP_HSX()
        {
            return sp.GetSP_HSX();
        }
    }
}
