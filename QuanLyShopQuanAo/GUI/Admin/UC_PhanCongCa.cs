using System;
using System.Data;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI.Admin.UserControls
{
    public partial class UC_PhanCongCa : UserControl
    {
        // Khai báo BLL và biến tạm
        private PhanCongCaBLL pcBLL = new PhanCongCaBLL();
        private NhanVienBLL nvBLL = new NhanVienBLL(); // Cần dùng để load MaNV
        private CaLamBLL clBLL = new CaLamBLL(); // Cần dùng để load MaCa
        private int selectedMaPhanCong = 0;

        public UC_PhanCongCa()
        {
            InitializeComponent();
        }

        private void UC_PhanCongCa_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadPhanCongData();
            // txtSDT_PC chỉ hiển thị, không cho phép chỉnh sửa
            txtSDT_PC.ReadOnly = true;
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Load cboMaNV_PC
                cboMaNV_PC.DataSource = nvBLL.GetAll();
                cboMaNV_PC.DisplayMember = "HoTen";
                cboMaNV_PC.ValueMember = "MaNV";
                cboMaNV_PC.SelectedIndexChanged += cboMaNV_PC_SelectedIndexChanged;

                // Load cboMaCa_PC
                cboMaCa_PC.DataSource = clBLL.GetAll();
                cboMaCa_PC.DisplayMember = "TenCa"; // Giả sử cột tên ca là "TenCa"
                cboMaCa_PC.ValueMember = "MaCa"; // Giả sử cột mã ca là "MaCa"
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ComboBox: " + ex.Message);
            }
        }

        private void cboMaNV_PC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNV_PC.SelectedValue != null && cboMaNV_PC.SelectedValue is int maNV)
            {
                // Giả định NhanVienBLL có hàm lấy SĐT theo Mã NV
                // string sdt = nvBLL.GetSDTByMaNV(maNV); 
                // txtSDT_PC.Text = sdt;
            }
        }

        private void LoadPhanCongData()
        {
            try
            {
                dgvPhanCong.DataSource = pcBLL.GetAll();
                dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Phân Công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearPhanCongControls()
        {
            selectedMaPhanCong = 0;
            cboMaNV_PC.SelectedIndex = -1;
            cboMaCa_PC.SelectedIndex = -1;
            dtpNgayLam_PC.Value = DateTime.Now;
            txtSDT_PC.Clear();
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhanCong.Rows[e.RowIndex];

                selectedMaPhanCong = Convert.ToInt32(row.Cells["MaPhanCong"].Value);

                cboMaNV_PC.SelectedValue = row.Cells["MaNV"].Value;
                cboMaCa_PC.SelectedValue = row.Cells["MaCa"].Value;
                dtpNgayLam_PC.Value = (DateTime)row.Cells["NgayLam"].Value;

                // Cần thêm logic để tra cứu SĐT dựa trên MaNV và điền vào txtSDT_PC
            }
        }

        private void btnThem_PC_Click(object sender, EventArgs e)
        {
            try
            {
                int maNV = (int)cboMaNV_PC.SelectedValue;
                int maCa = (int)cboMaCa_PC.SelectedValue;
                DateTime ngayLam = dtpNgayLam_PC.Value;

                bool result = pcBLL.Insert(maNV, maCa, ngayLam);
                if (result)
                {
                    MessageBox.Show("Thêm phân công thành công!");
                    LoadPhanCongData();
                    ClearPhanCongControls();
                }
                else
                {
                    MessageBox.Show("Thêm phân công thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_PC_Click(object sender, EventArgs e)
        {
            if (selectedMaPhanCong == 0)
            {
                MessageBox.Show("Vui lòng chọn phân công để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int maNV = (int)cboMaNV_PC.SelectedValue;
                int maCa = (int)cboMaCa_PC.SelectedValue;
                DateTime ngayLam = dtpNgayLam_PC.Value;

                bool result = pcBLL.Update(selectedMaPhanCong, maNV, maCa, ngayLam);
                if (result)
                {
                    MessageBox.Show("Cập nhật phân công thành công!");
                    LoadPhanCongData();
                    ClearPhanCongControls();
                }
                else
                {
                    MessageBox.Show("Cập nhật phân công thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_PC_Click(object sender, EventArgs e)
        {
            if (selectedMaPhanCong == 0)
            {
                MessageBox.Show("Vui lòng chọn phân công để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phân công này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bool result = pcBLL.Delete(selectedMaPhanCong);
                    if (result)
                    {
                        MessageBox.Show("Xóa phân công thành công!");
                        LoadPhanCongData();
                        ClearPhanCongControls();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phân công thất bại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}