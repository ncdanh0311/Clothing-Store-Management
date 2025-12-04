using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo.DTO
{
    public class SanPham_HangSanXuatDTO
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string BaoHanh { get; set; }
        public string MoTa { get; set; }
        public string AnhSP { get; set; }
        public string TenHSX { get; set; }
    }
}
