using System;
using System.Collections.Generic;
using ShopQuanAo.DAL;
using ShopQuanAo.DTO;

namespace ShopQuanAo.BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL dal = new NhanVienDAL();

        public List<NhanVienDTO> GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(string hoTen, string gioiTinh, DateTime ngaySinh, string sdt,
                           string diaChi, DateTime ngayVaoLam, string trangThai, decimal luong, string vitriLamViec)
        {
            var nv = new NhanVienDTO
            {
                HoTen = hoTen,
                GioiTinh = gioiTinh,
                NgaySinh = ngaySinh,
                SDT = sdt,
                DiaChi = diaChi,
                NgayVaoLam = ngayVaoLam,
                TrangThai = trangThai,
                Luong = luong,
                VitriLamViec = vitriLamViec
            };
            return dal.Insert(nv);
        }
        public bool Update(NhanVienDTO nv)
        {
            return dal.Update(nv);
        }
        public bool Delete(int maNV)
        {
            return dal.Delete(maNV);
        }

        public NhanVienDTO GetById(int maNV)
        {
            return dal.GetById(maNV);
        }
    }
}
