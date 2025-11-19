using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL; // Cần thiết để gọi BLL
// Giả định bạn có lớp DTO cho sản phẩm

namespace QuanLyShopQuanAo.GUI
{
    public partial class Form_ChiTietDonHangInput : Form
    {
        private int _MaDonHang;
        private SanPhamBLL spBLL = new SanPhamBLL();
        private StoreProcedureBLL sp = new StoreProcedureBLL();
        private DataTable dtChiTietMoi; // DataTable chứa các chi tiết mới thêm vào

        // Cờ báo hiệu có thay đổi đã được lưu
        public bool IsDataSaved { get; private set; }

        public Form_ChiTietDonHangInput(int maDH)
        {
            InitializeComponent();
            _MaDonHang = maDH;
            lblMaDH.Text = $"Mã ĐH: {maDH}";
            IsDataSaved = false;
        }

        private void Form_ChiTietDonHangInput_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            SetupDataGridView();
        }

        private void LoadComboBoxData()
        {
            // Tải danh sách sản phẩm
            cboSanPham.DataSource = spBLL.GetSP(); // Giả định hàm này trả về List<DTO> hoặc DataTable
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";
        }

        private void SetupDataGridView()
        {
            // Tạo DataTable ảo để người dùng nhập dữ liệu trước khi lưu vào DB
            dtChiTietMoi = new DataTable();
            dtChiTietMoi.Columns.Add("MaSP", typeof(int));
            dtChiTietMoi.Columns.Add("TenSP", typeof(string));
            dtChiTietMoi.Columns.Add("SoLuong", typeof(int));
            dtChiTietMoi.Columns.Add("DonGia", typeof(decimal));
            dtChiTietMoi.Columns.Add("ThanhTien", typeof(decimal));

            dgvChiTiet.DataSource = dtChiTietMoi;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ẩn MaSP
            if (dgvChiTiet.Columns.Contains("MaSP"))
            {
                dgvChiTiet.Columns["MaSP"].Visible = false;
            }
        }

        // --- Sự kiện Buttons ---

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ controls
                int maSP = (int)cboSanPham.SelectedValue;
                string tenSP = cboSanPham.Text;
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal donGia = decimal.Parse(txtDonGia.Text);
                decimal thanhTien = soLuong * donGia;

                // 2. Thêm vào DataTable ảo
                dtChiTietMoi.Rows.Add(maSP, tenSP, soLuong, donGia, thanhTien);

                // 3. Xóa controls nhập liệu (giữ lại MaSP)
                txtSoLuong.Clear();
                txtDonGia.Clear();
                txtThanhTien.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết: Vui lòng kiểm tra định dạng số lượng/đơn giá. Chi tiết lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.SelectedRows.Count > 0)
            {
                // Xóa dòng được chọn khỏi DataTable
                dgvChiTiet.Rows.RemoveAt(dgvChiTiet.SelectedRows[0].Index);
            }
        }

        private void btnLuuVaDong_Click(object sender, EventArgs e)
        {
            if (dtChiTietMoi.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một chi tiết đơn hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rowsSaved = 0;
                // Lặp qua tất cả chi tiết trong DataTable ảo
                foreach (DataRow row in dtChiTietMoi.Rows)
                {
                    int maSP = (int)row["MaSP"];
                    int soLuong = (int)row["SoLuong"];
                    decimal donGia = (decimal)row["DonGia"];

                    // Gọi BLL để thêm vào CSDL
                    // Lưu ý: Đây là thao tác INSERT, nên không cần MaSP_Cu
                    int result = sp.ThemChiTietDonHang(_MaDonHang, maSP, soLuong, donGia);
                    if (result > 0)
                    {
                        rowsSaved++;
                    }
                }

                MessageBox.Show($"Đã lưu thành công {rowsSaved} chi tiết cho Mã ĐH {_MaDonHang}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsDataSaved = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu vào CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dtChiTietMoi.Rows.Count > 0 && MessageBox.Show("Bạn có muốn hủy bỏ các chi tiết đã nhập và thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}