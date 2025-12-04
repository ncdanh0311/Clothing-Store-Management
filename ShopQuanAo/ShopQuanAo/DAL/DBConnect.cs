using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ShopQuanAo.DAL
{
    public class DBConnect
    {
        // 🧩 Lấy chuỗi kết nối từ App.config
        protected readonly string StrCon = ConfigurationManager.ConnectionStrings["ShopQuanAo"].ConnectionString;

        // 🔌 Đối tượng kết nối
        protected SqlConnection conn;

        // 🏗️ Hàm khởi tạo
        public DBConnect()
        {
            conn = new SqlConnection(StrCon);
        }

        // 🔓 Mở kết nối
        protected void Open()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        // 🔒 Đóng kết nối
        protected void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        // ⚡ Thực thi SELECT, trả về DataTable
        protected DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                Close();
            }
            return dt;
        }

        // ⚡ Thực thi INSERT, UPDATE, DELETE
        protected int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thao tác dữ liệu: " + ex.Message);
            }
            finally
            {
                Close();
            }
            return rowsAffected;
        }
    }
}
