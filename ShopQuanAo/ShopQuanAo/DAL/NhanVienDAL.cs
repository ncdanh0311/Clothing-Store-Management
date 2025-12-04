using ShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ShopQuanAo.DAL
{
    public class NhanVienDAL : DBConnect
    {
        // ⚡ Lấy toàn bộ danh sách nhân viên, trả về List<NhanVienDTO>
        public List<NhanVienDTO> GetAll()
        {
            List<NhanVienDTO> LstNV = new List<NhanVienDTO>();
            string sql = "SELECT * FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(sql, conn);

            Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = (int)dr["MaNV"],
                    HoTen = dr["HoTen"].ToString(),
                    GioiTinh = dr["GioiTinh"].ToString(),
                    NgaySinh = (DateTime)dr["NgaySinh"],
                    SDT = dr["SDT"].ToString(),
                    DiaChi = dr["DiaChi"].ToString(),
                    NgayVaoLam = (DateTime)dr["NgayVaoLam"],
                    TrangThai = dr["TrangThai"].ToString(),
                    Luong = (decimal)dr["Luong"],
                    VitriLamViec = dr["VitriLamViec"].ToString()
                };
                LstNV.Add(nv);
            }
            Close();
            return LstNV;
        }

        // ⚡ Thêm nhân viên - Nhận vào DTO
        public bool Insert(NhanVienDTO nv)
        {
            try
            {
                string sql = @"INSERT INTO NHANVIEN (HoTen, GioiTinh, NgaySinh, SDT, DiaChi, NgayVaoLam, TrangThai, Luong, VitriLamViec)
                               VALUES (@HoTen, @GioiTinh, @NgaySinh, @SDT, @DiaChi, @NgayVaoLam, @TrangThai, @Luong, @VitriLamViec)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@NgayVaoLam", nv.NgayVaoLam);
                cmd.Parameters.AddWithValue("@TrangThai", nv.TrangThai);
                cmd.Parameters.AddWithValue("@Luong", nv.Luong);
                cmd.Parameters.AddWithValue("@VitriLamViec",nv.VitriLamViec);

                Open();
                int rows = cmd.ExecuteNonQuery();
                Close();

                return rows > 0;
            }
            catch
            {
                Close();
                return false;
            }
        }

        // ⚡ Sửa nhân viên - Nhận vào DTO
        public bool Update(NhanVienDTO nv)
        {
            try
            {
                string sql = @"UPDATE NHANVIEN
                               SET HoTen=@HoTen, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh,
                                   SDT=@SDT, DiaChi=@DiaChi, NgayVaoLam=@NgayVaoLam, TrangThai=@TrangThai, Luong=@Luong, VitriLamViec = @VitriLamViec
                               WHERE MaNV=@MaNV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@NgayVaoLam", nv.NgayVaoLam);
                cmd.Parameters.AddWithValue("@TrangThai", nv.TrangThai);
                cmd.Parameters.AddWithValue("@Luong", nv.Luong);
                cmd.Parameters.AddWithValue("@VitriLamViec", nv.VitriLamViec);

                Open();
                int rows = cmd.ExecuteNonQuery();
                Close();

                return rows > 0;
            }
            catch
            {
                Close();
                return false;
            }
        }
        public bool Delete(int maNV)
        {
            try
            {
                string sql = "UPDATE NHANVIEN SET TRANGTHAI = N'Nghỉ việc' WHERE MaNV=@MaNV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                Open();
                int rows = cmd.ExecuteNonQuery();
                Close();

                return rows > 0;
            }
            catch
            {
                Close();
                return false;
            }
        }

        public NhanVienDTO GetById(int maNV)
        {
            NhanVienDTO nv = null;
            // Bổ sung ViTriLamViec vào câu truy vấn
            string sql = "SELECT MaNV, HoTen, GioiTinh, NgaySinh, SDT, DiaChi, NgayVaoLam, TrangThai, Luong, VitriLamViec FROM NHANVIEN WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaNV", maNV);

            try
            {
                Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nv = new NhanVienDTO
                    {
                        MaNV = (int)dr["MaNV"],
                        HoTen = dr["HoTen"].ToString(),
                        GioiTinh = dr["GioiTinh"].ToString(),
                        NgaySinh = (DateTime)dr["NgaySinh"],
                        SDT = dr["SDT"].ToString(),
                        DiaChi = dr["DiaChi"].ToString(),
                        NgayVaoLam = (DateTime)dr["NgayVaoLam"],
                        TrangThai = dr["TrangThai"].ToString(),
                        Luong = (decimal)dr["Luong"],
                        VitriLamViec = dr["VitriLamViec"].ToString() // Lấy Vị trí
                    };
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn thông tin nhân viên theo ID: " + ex.Message);
            }
            finally
            {
                Close();
            }
            return nv;
        }
    }
}