using ShopQuanAo.DAL;
using ShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo.BLL
{
    public class LoaiKhachHangBLL
    {
        LoaiKhachHangDAL lkh = new LoaiKhachHangDAL();
        public List<LoaiKhachHangDTO> GetLoaiKH()
        {
            return lkh.GetLoaiKH();
        }
    }
}
