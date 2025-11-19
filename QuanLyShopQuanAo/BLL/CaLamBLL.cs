using System.Collections.Generic;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class CaLamBLL
    {
        private CaLamDAL dal = new CaLamDAL();
        public List<CaLamViecDTO> GetAll()
        {
            return dal.GetAll();
        }
    }
}
