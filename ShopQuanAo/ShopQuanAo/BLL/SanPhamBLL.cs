using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopQuanAo.DAL;
using ShopQuanAo.DTO;
using ReaLTaiizor.Controls;

namespace ShopQuanAo.BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL sp = new SanPhamDAL();
        public List<SanPhamDTO> GetSP()
        {
            return sp.GetSP();
        }
    }
}
