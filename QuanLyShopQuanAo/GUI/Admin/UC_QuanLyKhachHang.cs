using System;
using System.Data;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI.Admin.UserControls
{
    public partial class UC_QuanLyKhachHang : UserControl
    {
        // Khai báo BLL và biến tạm
        private KhachHangBLL khBLL = new KhachHangBLL();
        private int selectedMaKH = 0;

        public UC_QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void UC_QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadKhachHangData();
            // Khóa trường Mã Khách Hàng khi thêm/sửa
            txtMaKH.ReadOnly = true;
            // Gắn sự kiện cho ComboBox để điều khiển trường thuế/công ty
            this.cboLoaiKH.SelectedIndexChanged += new System.EventHandler(this.cboLoaiKH_SelectedIndexChanged);
            // Kích hoạt sự kiện lần đầu để thiết lập trạng thái ban đầu
            cboLoaiKH_SelectedIndexChanged(null, null);
        }

        private void LoadComboBoxes()
        {
            cboLoaiKH.Items.Clear();
            cboLoaiKH.Items.Add("Cá Nhân"); // Index 0 -> MaLoaiKH = 1
            cboLoaiKH.Items.Add("Doanh Nghiệp"); // Index 1 -> MaLoaiKH = 2
            cboLoaiKH.SelectedIndex = 0;
        }

        /// <summary>
        /// Tải dữ liệu khách hàng, hỗ trợ tìm kiếm qua từ khóa.
        /// </summary>
        public void LoadKhachHangData()
        {
            try
            {
                // Giả định KhachHangBLL.GetAll() hoặc GetBySearch(keyword) sẽ được gọi
                // Hiện tại chỉ gọi GetAll() cho mục đích trình bày
                dgvKhachHang.DataSource = khBLL.GetAll();

                // Tùy chỉnh hiển thị cột
                dgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
                dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
                dgvKhachHang.Columns["SDT"].HeaderText = "SĐT";
                dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvKhachHang.Columns["Email"].HeaderText = "Email";
                dgvKhachHang.Columns["TenCongTy"].HeaderText = "Tên Công Ty";
                dgvKhachHang.Columns["MaSoThue"].HeaderText = "Mã Số Thuế";
                // Chú ý: Cột MaLoaiKH thường là ID, nếu muốn hiển thị tên, bạn cần join data.
                // Tạm thời, ta chỉ hiển thị ID.
                // dgvKhachHang.Columns["MaLoaiKH"].HeaderText = "Mã Loại KH"; 

                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Khách Hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearKhachHangControls()
        {
            selectedMaKH = 0;
            txtMaKH.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            cboLoaiKH.SelectedIndex = 0;
            txtSDT_KH.Text = string.Empty;
            txtEmail_KH.Text = string.Empty;
            txtDiaChi_KH.Text = string.Empty;
            txtMaSoThue_KH.Text = string.Empty;
            txtTenCongTy_KH.Text = string.Empty;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                selectedMaKH = Convert.ToInt32(row.Cells["MaKH"].Value);
                int maLoaiKH = Convert.ToInt32(row.Cells["MaLoaiKH"].Value);

                txtMaKH.Text = selectedMaKH.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();

                // Chọn ComboBox dựa trên MaLoaiKH (1 => 0, 2 => 1)
                cboLoaiKH.SelectedIndex = maLoaiKH - 1;

                txtSDT_KH.Text = row.Cells["SDT"].Value?.ToString();
                txtEmail_KH.Text = row.Cells["Email"].Value?.ToString();
                txtDiaChi_KH.Text = row.Cells["DiaChi"].Value?.ToString();
                txtMaSoThue_KH.Text = row.Cells["MaSoThue"].Value?.ToString();
                txtTenCongTy_KH.Text = row.Cells["TenCongTy"].Value?.ToString();
            }
        }

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKH.Text) || string.IsNullOrEmpty(txtSDT_KH.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Khách Hàng và Số Điện Thoại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // XỬ LÝ MA LOẠI KH VÀ THÔNG TIN CÔNG TY
            int MaLoaiKH = cboLoaiKH.SelectedIndex + 1; // Index 0 -> 1 (Cá nhân), Index 1 -> 2 (Doanh nghiệp)
            string MaSoThue = null;
            string TenCty = null;

            if (MaLoaiKH == 2) // Nếu là Doanh Nghiệp
            {
                MaSoThue = txtMaSoThue_KH.Text;
                TenCty = txtTenCongTy_KH.Text;
            }
            // else: MaSoThue và TenCty giữ nguyên là null

            try
            {
                KhachHangDTO kh = new KhachHangDTO
                {
                    TenKH = txtTenKH.Text,
                    MaLoaiKH = MaLoaiKH, // Đã sửa lỗi: Gán MaLoaiKH là số nguyên
                    SDT = txtSDT_KH.Text,
                    Email = txtEmail_KH.Text,
                    DiaChi = txtDiaChi_KH.Text,
                    MaSoThue = MaSoThue,
                    TenCongTy = TenCty
                };

                // Giả định BLL.Insert(DTO) được định nghĩa
                if (khBLL.Insert(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHangData();
                    ClearKhachHangControls();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại (Kiểm tra kết nối và DTO).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_KH_Click(object sender, EventArgs e)
        {
            if (selectedMaKH == 0)
            {
                MessageBox.Show("Vui lòng chọn Khách Hàng cần sửa.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // XỬ LÝ MA LOẠI KH VÀ THÔNG TIN CÔNG TY
            int MaLoaiKH = cboLoaiKH.SelectedIndex + 1;
            string MaSoThue = null;
            string TenCty = null;

            if (MaLoaiKH == 2) // Nếu là Doanh Nghiệp
            {
                MaSoThue = txtMaSoThue_KH.Text;
                TenCty = txtTenCongTy_KH.Text;
            }
            // else: MaSoThue và TenCty giữ nguyên là null

            try
            {
                KhachHangDTO kh = new KhachHangDTO
                {
                    MaKH = selectedMaKH,
                    TenKH = txtTenKH.Text,
                    MaLoaiKH = MaLoaiKH, // Đã sửa lỗi: Gán MaLoaiKH là số nguyên
                    SDT = txtSDT_KH.Text,
                    Email = txtEmail_KH.Text,
                    DiaChi = txtDiaChi_KH.Text,
                    MaSoThue = MaSoThue,
                    TenCongTy = TenCty
                };

                // Giả định BLL.Update(DTO) được định nghĩa
                if (khBLL.Update(kh))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHangData();
                    ClearKhachHangControls();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại (Kiểm tra kết nối và DTO).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_KH_Click(object sender, EventArgs e)
        {
            if (selectedMaKH == 0)
            {
                MessageBox.Show("Vui lòng chọn Khách Hàng cần xóa.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng có Mã KH: {selectedMaKH}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Giả định BLL.Delete(int) được định nghĩa
                    if (khBLL.Delete(selectedMaKH))
                    {
                        MessageBox.Show("Xóa khách hàng thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKhachHangData();
                        ClearKhachHangControls();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_KH_Click(object sender, EventArgs e)
        {
            // Cần cập nhật LoadKhachHangData(string keyword) trong BLL và gọi nó ở đây
            MessageBox.Show($"Đã kích hoạt tìm kiếm với từ khóa: {txtTimKiem_KH.Text}. Cần cập nhật BLL/DAL để thực hiện chức năng này.");
            // LoadKhachHangData(txtTimKiem_KH.Text.Trim());
        }

        private void cboLoaiKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Index 0: Cá nhân (MaLoaiKH = 1)
            // Index 1: Doanh nghiệp (MaLoaiKH = 2)
            bool isCompany = cboLoaiKH.SelectedIndex == 1;

            txtMaSoThue_KH.Enabled = isCompany;
            txtTenCongTy_KH.Enabled = isCompany;

            if (!isCompany)
            {
                // Xóa dữ liệu nếu chuyển sang Cá nhân
                txtMaSoThue_KH.Clear();
                txtTenCongTy_KH.Clear();
            }
        }
    }
}