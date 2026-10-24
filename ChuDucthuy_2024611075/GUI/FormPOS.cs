using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace ChuDucthuy_2024611075
{
    public partial class FormPOS : Form
    {
        DataTable dtGioHang = new DataTable();

        public FormPOS()
        {
            InitializeComponent();
        }

        private void FormPOS_Load(object sender, EventArgs e)
        {
            SanPhamBLL spBLL = new SanPhamBLL();
            dgvSanPham.DataSource = spBLL.LayDanhSachSanPham();
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGioHang.Columns.Add("Mã SP");
            dtGioHang.Columns.Add("Tên SP");
            dtGioHang.Columns.Add("Số Lượng", typeof(int));
            dtGioHang.Columns.Add("Đơn Giá", typeof(long));
            dtGioHang.Columns.Add("Thành Tiền", typeof(long));

            dgvGioHang.DataSource = dtGioHang;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CapNhatTongTien()
        {
            long tong = 0;
            foreach (DataRow row in dtGioHang.Rows)
            {
                tong += Convert.ToInt64(row["Thành Tiền"]);
            }
            lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " VNĐ";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách bên trái!");
                return;
            }

            if (int.TryParse(txtSoLuong.Text, out int soLuongMua) == false || soLuongMua <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ (số nguyên > 0)!");
                return;
            }
            DataGridViewRow row = dgvSanPham.CurrentRow;
            string maSP = row.Cells["Mã SP"].Value.ToString();
            string tenSP = row.Cells["Tên Sản Phẩm"].Value.ToString();
            long donGia = Convert.ToInt64(row.Cells["Đơn Giá"].Value);
            int tonKho = Convert.ToInt32(row.Cells["Tồn Kho"].Value);

            if (soLuongMua > tonKho)
            {
                MessageBox.Show("Số lượng mua vượt quá số lượng tồn kho!");
                return;
            }
            long thanhTien = donGia * soLuongMua;
            dtGioHang.Rows.Add(maSP, tenSP, soLuongMua, donGia, thanhTien);

            CapNhatTongTien();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách bên trái!");
                return;
            }

            if (int.TryParse(txtSoLuong.Text, out int soLuongMua) == false || soLuongMua <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ (số nguyên > 0)!");
                return;
            }

            DataGridViewRow row = dgvSanPham.CurrentRow;
            string maSP = row.Cells["Mã SP"].Value.ToString();
            string tenSP = row.Cells["Tên Sản Phẩm"].Value.ToString();
            long donGia = Convert.ToInt64(row.Cells["Đơn Giá"].Value);
            int tonKho = Convert.ToInt32(row.Cells["Tồn Kho"].Value);

            if (soLuongMua > tonKho)
            {
                MessageBox.Show("Số lượng mua vượt quá số lượng tồn kho hiện có!");
                return;
            }

            long thanhTien = donGia * soLuongMua;
            dtGioHang.Rows.Add(maSP, tenSP, soLuongMua, donGia, thanhTien);


            CapNhatTongTien();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng chọn mua sản phẩm trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string tongTien = lblTongTien.Text;
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn thanh toán hóa đơn này?\n{tongTien}", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công! Đang in hóa đơn...", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                dtGioHang.Clear();
                CapNhatTongTien();
            }
        }
    }
}