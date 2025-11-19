using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL dal = new NhanVienDAL();

        public List<NhanVienDTO> GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(string hoTen, string gioiTinh, DateTime ngaySinh, string sdt,
                           string diaChi, DateTime ngayVaoLam, string trangThai, decimal luong)
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
                Luong = luong
            };
            return dal.Insert(nv);
        }
        public bool Update(int maNV, string hoTen, string gioiTinh, DateTime ngaySinh, string sdt,
                           string diaChi, DateTime ngayVaoLam, string trangThai, decimal luong)
        {
            var nv = new NhanVienDTO
            {
                MaNV = maNV,
                HoTen = hoTen,
                GioiTinh = gioiTinh,
                NgaySinh = ngaySinh,
                SDT = sdt,
                DiaChi = diaChi,
                NgayVaoLam = ngayVaoLam,
                TrangThai = trangThai,
                Luong = luong
            };
            return dal.Update(nv);
        }
        public bool Delete(int maNV)
        {
            return dal.Delete(maNV);
        }
    }
}
