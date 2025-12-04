using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopQuanAo.DTO;
using ShopQuanAo.DAL;

namespace ShopQuanAo.BLL
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
