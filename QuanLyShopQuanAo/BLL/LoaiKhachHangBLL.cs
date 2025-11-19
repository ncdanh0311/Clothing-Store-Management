using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.BLL
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
