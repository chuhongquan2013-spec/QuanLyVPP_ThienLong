using System.Data;
using DAL;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL spDAL = new SanPhamDAL();

        public DataTable LayDanhSachSanPham()
        {
            return spDAL.LayDanhSachSanPham();
        }
    }
}