using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;
using ReaLTaiizor.Controls;

namespace QuanLyShopQuanAo.BLL
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
