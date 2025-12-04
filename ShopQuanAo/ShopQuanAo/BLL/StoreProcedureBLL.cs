using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopQuanAo.DAL;
using ShopQuanAo.DTO;

namespace ShopQuanAo.BLL
{
    public class StoreProcedureBLL
    {
        StoreProcedureDAL sp = new StoreProcedureDAL();
        public int TaoPhieuNhap(int MaNV, int MaNCC)
        {
            return sp.TaoPhieuNhap(MaNV, MaNCC);
        }
        public int ThemChiTietPN(int MaPN, int MaSP, int SoLuong, decimal DonGia)
        {
            return sp.ThemChiTietPN(MaPN, MaSP, SoLuong, DonGia);
        }
        public DataTable ThongKeSPtheoHSX()
        {
            return sp.ThongKeSPtheoHSX();
        }
        public DataTable ThongKeTienNhapTheoNgay(DateTime TuNgay, DateTime DenNgay)
        {
            return sp.ThongKeTienNhapTheoNgay(TuNgay,DenNgay);
        }

        public DataTable GetThongTinHoaDon()
        {
            return sp.GetThongTinHoaDon();
        }
        public int CapNhatDonHang(int MaDH, int MaNV, DateTime NgayLap)
        {
            return sp.CapNhatDonHang(MaDH, MaNV, NgayLap);
        }

        public int CapNhatKhachHang(int MaKH, string TenKH)
        {
            return sp.CapNhatKhachHang(MaKH, TenKH);
        }

        public int CapNhatChiTietHoaDon(int MaDH, int MaSP, int SoLuong, decimal DonGia, int MaSP_Cu)
        {
            if (SoLuong <= 0)
            {
                throw new Exception("Số lượng sản phẩm phải lớn hơn 0.");
            }
            return sp.CapNhatChiTietHoaDon(MaDH, MaSP, SoLuong, DonGia, MaSP_Cu);
        }

        public int ThemChiTietDonHang(ChiTietDonHangDTO ctdh)
        {
            if (ctdh.SoLuong <= 0)
            {
                throw new Exception("Số lượng phải lớn hơn 0 khi thêm mới.");
            }

            return sp.ThemChiTietDonHang(ctdh);
        }

        public DataTable XemHoaDon(int MaNV, DateTime ThoiGianHienTai)
        {
            return sp.XemHoaDon(MaNV,ThoiGianHienTai);
        }
        public DataTable GetChiTietHoaDon(int maDH)
        {
            return sp.GetChiTietHoaDon(maDH);
        }

        public DataTable GetInHoaDon(int maDH)
        {
            return sp.GetInHoaDon(maDH);
        }
        public DataTable GetPhanCong()
        {
            return sp.GetPhanCong();
        }
    }
}
