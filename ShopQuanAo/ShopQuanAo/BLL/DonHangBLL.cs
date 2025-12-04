using System;
using System.Collections.Generic;
using ShopQuanAo.DAL;
using ShopQuanAo.DTO;

namespace ShopQuanAo.BLL
{
    public class DonHangBLL
    {
        private DonHangDAL dal = new DonHangDAL();

        public List<DonHangDTO> GetAll()
        {
            return dal.GetAll();
        }

        // --- PHƯƠNG THỨC MỚI: Thêm Header và trả về MaDH (Cho nút Thêm) ---
        /// <summary>
        /// Thêm mới Header Đơn hàng và trả về Mã ĐH (MaDH).
        /// </summary>
        /// <returns>MaDH mới (int) nếu thành công, 0 nếu thất bại.</returns>
        public int InsertHeader(DateTime ngayLap, int maNV, int maKH)
        {
            // Gọi hàm DAL mới: InsertHeader(maNV, maKH, ngayLap)
            // Phương thức này trả về ID mới (int), thay vì bool như phương thức Insert cũ.
            return dal.InsertHeader(maNV, maKH, ngayLap);
        }

        // --- PHƯƠNG THỨC MỚI: Sửa Header (Chỉ sửa 3 trường) ---
        /// <summary>
        /// Cập nhật 3 trường Header chính của Đơn hàng (NgayLap, MaNV, MaKH).
        /// </summary>
        public bool UpdateHeader(int maDH, DateTime ngayLap, int maNV, int maKH)
        {
            // Gọi hàm DAL mới: UpdateHeader(maDH, maNV, maKH, ngayLap)
            // Phương thức này không cần TongTien.
            return dal.UpdateHeader(maDH, maNV, maKH, ngayLap);
        }

        // ⚡ Xóa đơn hàng (Giữ nguyên)
        public bool Delete(int maDH)
        {
            return dal.Delete(maDH);
        }
        
        // Cần xóa các hàm Insert(DateTime, int, int, decimal) và Update(int, DateTime, int, int, decimal) cũ
        // để tránh xung đột và buộc logic UI sử dụng InsertHeader/UpdateHeader.
    }
}