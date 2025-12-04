using ShopQuanAo.DAL;
using ShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo.BLL
{
    public class PhieuNhapBLL
    {
        PhieuNhapDAL pn = new PhieuNhapDAL();
        public List<PhieuNhapDTO> GetPN()
        {
            return pn.GetPN();
        }
    }
}
