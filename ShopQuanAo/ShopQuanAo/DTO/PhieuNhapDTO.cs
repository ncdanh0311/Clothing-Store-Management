using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo.DTO
{
    public class PhieuNhapDTO
    {
        public int MaPN { get; set; }
        public DateTime NgayNhap { get; set; }
        public int MaNV { get; set; }
        public int MaNCC { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
    }
}
