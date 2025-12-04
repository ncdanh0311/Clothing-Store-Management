using System;
using System.Data;
using System.Windows.Forms;
using ShopQuanAo.BLL;
using ShopQuanAo.DTO;

namespace ShopQuanAo.GUI.Admin.UserControls
{
    public partial class UC_QuanLyHoaDon : UserControl
    {
        // Khai báo BLL và biến tạm (Giả định bạn có các class này)
        private DonHangBLL dhBLL = new DonHangBLL();
        private StoreProcedureBLL sp = new StoreProcedureBLL();
        private NhanVienBLL nvBLL = new NhanVienBLL();
        private SanPhamBLL spBLL = new SanPhamBLL();
        private LoaiKhachHangBLL lkhBLL = new LoaiKhachHangBLL();

        private DataTable dtHoaDon;

        private int selectedMaDH = 0;

        public UC_QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void LoadAllCbo()
        {
            cboTenNhanVien.DataSource = nvBLL.GetAll();
            cboTenNhanVien.DisplayMember = "HoTen";
            cboTenNhanVien.ValueMember = "MaNV";

            cboTenSP.DataSource = spBLL.GetSP();
            cboTenSP.DisplayMember = "TenSP";
            cboTenSP.ValueMember = "MaSP";

            cboLoaiKH.Items.Add("Cá nhân");
            cboLoaiKH.Items.Add("Doanh Nghiệp");
        }

        private void UC_QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            AddComboBoxColumns();
            LoadHoaDonData();
            LoadAllCbo();
        }

        private void AddComboBoxColumns()
        {
            DataGridViewComboBoxColumn colNhanVien = new DataGridViewComboBoxColumn();
            colNhanVien.HeaderText = "Tên Nhân Viên";
            colNhanVien.Name = "Cbo_TenNhanVien";
            colNhanVien.DataSource = nvBLL.GetAll();
            colNhanVien.DisplayMember = "HoTen";
            colNhanVien.ValueMember = "MaNV";
            colNhanVien.DataPropertyName = "MaNV";
            colNhanVien.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            colNhanVien.FlatStyle = FlatStyle.Flat;
            dgvHoaDon.Columns.Add(colNhanVien);

            DataGridViewComboBoxColumn colSanPham = new DataGridViewComboBoxColumn();
            colSanPham.HeaderText = "Sản phẩm";
            colSanPham.Name = "Cbo_TenSP";
            colSanPham.DataSource = spBLL.GetSP();
            colSanPham.DisplayMember = "TenSP";
            colSanPham.ValueMember = "MaSP";
            colSanPham.DataPropertyName = "MaSP";
            colSanPham.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            colSanPham.FlatStyle = FlatStyle.Flat;
            dgvHoaDon.Columns.Add(colSanPham);

            DataGridViewComboBoxColumn colLoaiKH = new DataGridViewComboBoxColumn();
            colLoaiKH.HeaderText = "Loại khách hàng";
            colLoaiKH.Name = "Cbo_LoaiKH";
            colLoaiKH.DataSource = lkhBLL.GetLoaiKH();
            colLoaiKH.DisplayMember = "TenLoaiKH";
            colLoaiKH.ValueMember = "MaLoaiKH";
            colLoaiKH.DataPropertyName = "MaLoaiKH";
            colLoaiKH.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            colLoaiKH.FlatStyle = FlatStyle.Flat;
            dgvHoaDon.Columns.Add(colLoaiKH);

            string[] colsToHide = { "MaDH", "MaNV", "MaKH", "MaSP", "TenNhanVien", "TenSP", "TenLoaiKH" };
            foreach (string colName in colsToHide)
            {
                if (dgvHoaDon.Columns.Contains(colName))
                {
                    dgvHoaDon.Columns[colName].Visible = false;
                }
            }
        }

        private void LoadHoaDonData()
        {
            try
            {
                dtHoaDon = sp.GetThongTinHoaDon();
                dgvHoaDon.DataSource = dtHoaDon;
                dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Hóa Đơn: " + ex.Message);
            }
        }

        private void ClearHoaDonControls()
        {
            selectedMaDH = 0;
            lblMaDH_Selected.Text = "Mã ĐH: CHƯA CHỌN";
            cboTenNhanVien.SelectedIndex = -1;
            txtMaKH_HD.Clear();
            dtpNgayLap_HD.Value = DateTime.Now;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

                // Lấy Mã ĐH (PK) từ cột ẩn
                selectedMaDH = Convert.ToInt32(row.Cells["MaDH"].Value);
                lblMaDH_Selected.Text = "Mã ĐH: " + selectedMaDH.ToString();

                // Do lưới là dữ liệu tổng hợp (nhiều dòng cho 1 ĐH), ta phải lọc để lấy dữ liệu header duy nhất
                cboTenNhanVien.SelectedValue = Convert.ToInt32(row.Cells["MaNV"].Value);
                txtMaKH_HD.Text = row.Cells["MaKH"].Value.ToString();
                cboTenSP.SelectedValue = Convert.ToInt32(row.Cells["MaSP"].Value);
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
                cboLoaiKH.SelectedItem = row.Cells["TenLoaiKH"].Value.ToString();

                dtpNgayLap_HD.Value = (DateTime)row.Cells["NgayLap"].Value;
                ;
            }
        }

        private void btnThem_HD_Click(object sender, EventArgs e)
        {
            try
            {
                int maNV = int.Parse(cboTenNhanVien.SelectedValue.ToString());
                int maKH = int.Parse(txtMaKH_HD.Text);
                DateTime ngayLap = dtpNgayLap_HD.Value;

                int newMaDH = dhBLL.InsertHeader(ngayLap, maNV, maKH);

                if (newMaDH > 0)
                {
                    // 2. MỞ FORM NHẬP CHI TIẾT ĐỘC LẬP
                    using (Form_ChiTietDonHangInput frmChiTiet = new Form_ChiTietDonHangInput(newMaDH))
                    {
                        // Hiển thị Form dưới dạng Dialog để chặn form chính
                        frmChiTiet.ShowDialog();

                        // Nếu người dùng lưu, Form sẽ đóng và chúng ta tải lại dữ liệu
                        if (frmChiTiet.IsDataSaved)
                        {
                            MessageBox.Show($"Đơn hàng {newMaDH} và các chi tiết đã được lưu thành công.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    // 3. Tải lại DataGridView
                    LoadHoaDonData();
                    selectedMaDH = newMaDH;
                    lblMaDH_Selected.Text = "Mã ĐH: " + selectedMaDH.ToString();
                }
                else
                {
                    MessageBox.Show("Tạo mới Header Hóa Đơn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_HD_Click(object sender, EventArgs e)
        {
            if (selectedMaDH == 0)
            {
                MessageBox.Show("Vui lòng chọn Hóa Đơn để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa Hóa Đơn {selectedMaDH} và tất cả chi tiết liên quan?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool result = dhBLL.Delete(selectedMaDH);
                    if (result)
                    {
                        MessageBox.Show("Xóa Hóa Đơn thành công!");
                        LoadHoaDonData();
                        ClearHoaDonControls();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Hóa Đơn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dgvHoaDon.EndEdit();

            if (selectedMaDH == 0)
            {
                MessageBox.Show("Vui lòng chọn Hóa Đơn cần sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dtChanges = (dgvHoaDon.DataSource as DataTable)?.GetChanges(DataRowState.Modified);
            DataTable dtCurrent = dgvHoaDon.DataSource as DataTable;

            try
            {
                // Lấy dữ liệu Header/Khách hàng từ controls
                int maNV = int.Parse(cboTenNhanVien.SelectedValue.ToString());
                int maKH = int.Parse(txtMaKH_HD.Text);
                DateTime ngayLap = dtpNgayLap_HD.Value;

                DataRow[] selectedRows = dtCurrent.Select($"MaDH = {selectedMaDH}");
                string tenKH = selectedRows[0]["TenKhachHang"].ToString();

                sp.CapNhatDonHang(selectedMaDH, maNV, ngayLap);
                sp.CapNhatKhachHang(maKH, tenKH);

                int rowsUpdated = 0;

                if (dtChanges != null && dtChanges.Rows.Count > 0)
                {
                    foreach (DataRow row in dtChanges.Rows)
                    {
                        if (Convert.ToInt32(row["MaDH"]) != selectedMaDH) continue;

                        int detail_maDH = Convert.ToInt32(row["MaDH"]);
                        int maSP_Moi = Convert.ToInt32(row["MaSP"]);
                        int sl = Convert.ToInt32(row["SoLuong"]);
                        decimal donGia = Convert.ToDecimal(row["DonGia"]);
                        int maSP_Cu = Convert.ToInt32(row["MaSP", DataRowVersion.Original]);

                        int result = sp.CapNhatChiTietHoaDon(detail_maDH, maSP_Moi, sl, donGia, maSP_Cu);

                        if (result > 0) rowsUpdated++;
                    }
                }
                dtCurrent.AcceptChanges();

                string msg = "Cập nhật Header/Khách hàng thành công!";
                if (rowsUpdated > 0)
                {
                    msg += $" Đã lưu thành công {rowsUpdated} dòng chi tiết hóa đơn.";
                }

                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadHoaDonData();
                ClearHoaDonControls();
            }
            catch (Exception ex)
            {
                (dgvHoaDon.DataSource as DataTable)?.RejectChanges();
                MessageBox.Show("Lỗi khi sửa hóa đơn: " + ex.Message + " Vui lòng kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in groupBox3.Controls)
            {
                if(ctr.GetType() == typeof(TextBox) || ctr.GetType() == typeof(ComboBox) || ctr.GetType() == typeof(DateTimePicker))
                {
                    ctr.Enabled = true;
                }
            }
        }
    }
}