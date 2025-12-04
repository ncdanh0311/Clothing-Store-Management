using System;
using System.Collections.Generic;
using System.Data;
using ShopQuanAo.DAL;
using ShopQuanAo.DTO;

namespace ShopQuanAo.BLL
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
