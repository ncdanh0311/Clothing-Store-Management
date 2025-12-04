using System;
using ShopQuanAo.DAL;
using ShopQuanAo.DTO;
using ShopQuanAo.BLL;
using System.Collections.Generic;

namespace ShopQuanAo.BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL dal;
        private NhanVienBLL nvBLL;

        public TaiKhoanBLL()
        {
            dal = new TaiKhoanDAL();
            nvBLL = new NhanVienBLL();
        }

        public TaiKhoanDTO DangNhap(string tenDN, string matKhau)
        {
            TaiKhoanDTO tkInfo = dal.AuthenticateTaiKhoan(tenDN, matKhau);

            if (tkInfo == null)
            {
                return null;
            }

            NhanVienDTO nvInfo = null;
            int? maCa = null;

            if (tkInfo.VaiTro != "Developer" && tkInfo.MaNV.HasValue)
            {
                int maNVToUse = tkInfo.MaNV.Value;
                nvInfo = nvBLL.GetById(maNVToUse);
            }
            SessionManager.SetUserSession(tkInfo, nvInfo);
            int? maNVToLog = nvInfo?.MaNV;
            dal.InsertNhatKyDangNhap(tkInfo.MaTK, maNVToLog, maCa, "IP_Address_Placeholder", "Device_Info_Placeholder");

            return tkInfo;
        }

        public int UpdateTaiKhoan(string tenDN, string newMK)
        {
            return dal.UpdateTaiKhoan(tenDN, newMK);
        }

        public List<TaiKhoanDTO> GetTK()
        {
            return dal.GetTK();
        }
    }
}