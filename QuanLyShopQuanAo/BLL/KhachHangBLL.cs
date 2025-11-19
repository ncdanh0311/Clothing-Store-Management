using System.Collections.Generic;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL dal = new KhachHangDAL();

        public List<KhachHangDTO> GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(KhachHangDTO kh)
        {
            return dal.Insert(kh);
        }

        public bool Update(KhachHangDTO kh)
        {
            return dal.Update(kh);
        }

        public bool Delete(int maKH)
        {
            return dal.Delete(maKH);
        }
    }
}
