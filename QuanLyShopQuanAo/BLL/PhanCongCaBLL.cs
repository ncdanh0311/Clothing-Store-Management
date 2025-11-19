using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class PhanCongCaBLL
    {
        private PhanCongCaDAL dal = new PhanCongCaDAL();

        public List<PhanCongCaDTO> GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(int maNV, int maCa, DateTime ngayLam)
        {
            var dto = new PhanCongCaDTO
            {
                MaNV = maNV,
                MaCa = maCa,
                NgayLam = ngayLam
            };
            return dal.Insert(dto);
        }

        public bool Update(int maPhanCong, int maNV, int maCa, DateTime ngayLam)
        {
            var dto = new PhanCongCaDTO
            {
                MaPhanCong = maPhanCong,
                MaNV = maNV,
                MaCa = maCa,
                NgayLam = ngayLam
            };
            return dal.Update(dto);
        }

        public bool Delete(int maPhanCong)
        {
            return dal.Delete(maPhanCong);
        }
    }
}
