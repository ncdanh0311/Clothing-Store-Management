using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo.DTO
{
    public class LichSuNhapHangDTO
    {
        public int MaPN { get; set; }
        public string TenSP { get; set; }
        public string HangSanXuat { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public string NhanVienNhap { get; set; }

        public LichSuNhapHangDTO() { }

        public LichSuNhapHangDTO(int maPN, string tenSP, string hangSX, DateTime ngayNhap,
                                 int soLuong, decimal donGia, decimal thanhTien, string nhanVienNhap)
        {
            MaPN = maPN;
            TenSP = tenSP;
            HangSanXuat = hangSX;
            NgayNhap = ngayNhap;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
            NhanVienNhap = nhanVienNhap;
        }
    }
}
