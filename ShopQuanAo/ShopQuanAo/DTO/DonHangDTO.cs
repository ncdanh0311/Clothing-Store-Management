using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopQuanAo.DTO
{
    public class DonHangDTO
    {
        public int MaDH { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaNV { get; set; }
        public int MaKH { get; set; }
        public decimal TongTien { get; set; }
    }
}
