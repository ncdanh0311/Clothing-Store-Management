using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.DTO;
using QuanLyShopQuanAo.DAL;

namespace QuanLyShopQuanAo.BLL
{
    public class HangSanXuatBLL
    {
        HangSanXuatDAL hsx = new HangSanXuatDAL();
        public List<HangSanXuatDTO> GetHSX()
        {
            return hsx.GetHSX();
        }
    }
}
