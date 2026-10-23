using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL nvDAL = new NhanVienDAL();

        public string Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Vui lòng nhập đầy đủ tài khoản và mật khẩu!";
            }
            if (nvDAL.KiemTraDangNhap(username, password))
            {
                return "SUCCESS";
            }
            else
            {
                return "Tên đăng nhập hoặc mật khẩu không đúng!";
            }
        }
    }
}