using System.Data;

namespace DAL
{
    public class NhanVienDAL
    {
        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string query = $"SELECT * FROM NhanVien WHERE TenDangNhap = '{tenDangNhap}' AND MatKhau = '{matKhau}'";
            DataTable dt = DatabaseAccess.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}