using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SanPhamDAL
    {
        string connString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLVPP_ThienLong;Integrated Security=True";

        public DataTable LayDanhSachSanPham()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT MaSP AS [Mã SP], TenSP AS [Tên Sản Phẩm], DonViTinh AS [ĐVT], DonGia AS [Đơn Giá], SoLuongTon AS [Tồn Kho] FROM SanPham";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}