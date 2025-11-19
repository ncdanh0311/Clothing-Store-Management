using System;
using System.Data;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI.Admin.UserControls
{
    public partial class UC_QuanLyNhanVien : UserControl
    {
        // Khai báo BLL và biến tạm (Giả định bạn có các class này)
        private NhanVienBLL nvBLL = new NhanVienBLL();
        private int selectedMaNV = 0;

        public UC_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void UC_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadNhanVienData();
        }

        private void LoadComboBoxes()
        {
            // Load cboGioiTinh_NV
            cboGioiTinh_NV.Items.Clear();
            cboGioiTinh_NV.Items.Add("Nam");
            cboGioiTinh_NV.Items.Add("Nữ");
            cboGioiTinh_NV.Items.Add("Khác");
            cboGioiTinh_NV.SelectedIndex = 0;

            cboTrangThai.Items.Add("Đang làm");
            cboTrangThai.Items.Add("Nghỉ việc");
            cboTrangThai.Items.Add("Tạm nghỉ");
        }

        private void LoadNhanVienData()
        {
            try
            {
                // Giả định NhanVienBLL.GetAll() trả về danh sách nhân viên
                dgvNhanVien.DataSource = nvBLL.GetAll();
                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Tùy chỉnh Header Text
                dgvNhanVien.Columns["MaNV"].HeaderText = "Mã NV";
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvNhanVien.Columns["SDT"].HeaderText = "SĐT";
                dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvNhanVien.Columns["NgayVaoLam"].HeaderText = "Ngày Vào Làm";
                dgvNhanVien.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvNhanVien.Columns["Luong"].HeaderText = "Lương";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Nhân Viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearNhanVienControls()
        {
            selectedMaNV = 0;
            txtHoTen_NV.Clear();
            cboGioiTinh_NV.SelectedIndex = 0;
            dtpNgaySinh_NV.Value = DateTime.Now;
            txtSDT_NV.Clear();
            txtDiaChi_NV.Clear();
            dtpNgayVaoLam_NV.Value = DateTime.Now;
            cboTrangThai.SelectedIndex = -1;
            txtLuong.Clear();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                selectedMaNV = Convert.ToInt32(row.Cells["MaNV"].Value);

                txtHoTen_NV.Text = row.Cells["HoTen"].Value.ToString();
                cboGioiTinh_NV.SelectedItem = row.Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh_NV.Value = (DateTime)row.Cells["NgaySinh"].Value;
                txtSDT_NV.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi_NV.Text = row.Cells["DiaChi"].Value.ToString();
                dtpNgayVaoLam_NV.Value = (DateTime)row.Cells["NgayVaoLam"].Value;
                cboTrangThai.SelectedItem = row.Cells["TrangThai"].Value.ToString();
                txtLuong.Text = row.Cells["Luong"].Value.ToString();
            }
        }

        private void btnThem_NV_Click(object sender, EventArgs e)
        {
            // Logic thêm nhân viên (sử dụng logic cũ từ Admin_TrangChu.cs)
            try
            {
                string hoTen = txtHoTen_NV.Text;
                string gioiTinh = cboGioiTinh_NV.SelectedItem.ToString();
                DateTime ngaySinh = dtpNgaySinh_NV.Value;
                string sdt = txtSDT_NV.Text;
                string diaChi = txtDiaChi_NV.Text;
                DateTime ngayVaoLam = dtpNgayVaoLam_NV.Value;
                string trangThai = cboTrangThai.SelectedItem.ToString();
                decimal luong = Convert.ToDecimal(txtLuong.Text);

                bool result = nvBLL.Insert(hoTen, gioiTinh, ngaySinh, sdt, diaChi, ngayVaoLam, trangThai, luong);
                if (result)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadNhanVienData();
                    ClearNhanVienControls();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_NV_Click(object sender, EventArgs e)
        {
            if (selectedMaNV == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Logic sửa nhân viên (sử dụng logic cũ từ Admin_TrangChu.cs)
            try
            {
                string hoTen = txtHoTen_NV.Text;
                string gioiTinh = cboGioiTinh_NV.SelectedItem.ToString();
                DateTime ngaySinh = dtpNgaySinh_NV.Value;
                string sdt = txtSDT_NV.Text;
                string diaChi = txtDiaChi_NV.Text;
                DateTime ngayVaoLam = dtpNgayVaoLam_NV.Value;
                string trangThai = cboTrangThai.SelectedItem.ToString();
                decimal luong = Convert.ToDecimal(txtLuong.Text);

                bool result = nvBLL.Update(selectedMaNV, hoTen, gioiTinh, ngaySinh, sdt, diaChi, ngayVaoLam, trangThai, luong);
                if (result)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    LoadNhanVienData();
                    ClearNhanVienControls();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_NV_Click(object sender, EventArgs e)
        {
            if (selectedMaNV == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cho thôi việc.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn thôi việc nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool result = nvBLL.Delete(selectedMaNV);
                    if (result)
                    {
                        MessageBox.Show("Cho thôi việc nhân viên thành công!");
                        LoadNhanVienData();
                        ClearNhanVienControls();
                    }
                    else
                    {
                        MessageBox.Show("Thôi việc nhân viên thất bại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thôi việc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}