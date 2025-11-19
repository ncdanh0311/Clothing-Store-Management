using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DTO
{
    public class SanPhamDTO
    {

        public int MaSP { get; set; }
        public string TenSP { get; set; }

        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }

        public string Size { get; set; }
        public string MauSac { get; set; }
        public string ChatLieu { get; set; }
        public string GioiTinh { get; set; }  // Nam/Nữ/Unisex
        public int MaLoaiSP { get; set; }  // loại: áo, quần, váy...
        public string BaoHanh { get; set; }

        public string MoTa { get; set; }
        public string AnhSP { get; set; }
        public int MaHSX { get; set; }     // hãng / brand
    }

}

