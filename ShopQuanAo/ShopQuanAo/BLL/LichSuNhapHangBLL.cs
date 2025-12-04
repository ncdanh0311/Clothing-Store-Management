using ShopQuanAo.DAL;
using ShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo.BLL
{
    internal class LichSuNhapHangBLL
    {
        private readonly LichSuNhapHangDAL dal = new LichSuNhapHangDAL();

        public List<LichSuNhapHangDTO> LayLichSuNhapHang(DateTime tuNgay, DateTime denNgay)
        {
            return dal.GetLichSuNhapHang(tuNgay, denNgay);
        }
    }
}
