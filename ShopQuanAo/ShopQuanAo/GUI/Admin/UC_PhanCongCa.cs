using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ShopQuanAo.BLL;
using ShopQuanAo.DAL;
using ShopQuanAo.DTO;

namespace ShopQuanAo.GUI.Admin.UserControls
{
    public partial class UC_PhanCongCa : UserControl
    {
        // Khai báo BLL và biến tạm
        private PhanCongCaBLL pcBLL = new PhanCongCaBLL();
        private NhanVienBLL nvBLL = new NhanVienBLL(); // Cần dùng để load MaNV
        private CaLamBLL clBLL = new CaLamBLL(); // Cần dùng để load MaCa
        private StoreProcedureBLL sp = new StoreProcedureBLL();
        private int selectedMaPhanCong = 0;

        public UC_PhanCongCa()
        {
            InitializeComponent();
        }
        private void UC_PhanCongCa_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadPhanCongData();
            LoadCaLam();
            txtSDT_PC.ReadOnly = true;
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Load nhân viên
                cboMaNV_PC.DataSource = nvBLL.GetAll();
                cboMaNV_PC.DisplayMember = "HoTen";
                cboMaNV_PC.ValueMember = "MaNV";

                // Load ca làm việc
                cboMaCa_PC.DataSource = clBLL.GetAll();
                cboMaCa_PC.DisplayMember = "TenCa";
                cboMaCa_PC.ValueMember = "MaCa";

                // ========== TẠO COMBOBOX LỌC CA ==============
                var listCa = clBLL.GetAll(); // List<CaLamDTO>

                var listLocCa = new List<CaLamViecDTO>();
                listLocCa.Add(new CaLamViecDTO
                {
                    MaCa = 0,
                    TenCa = "Lọc theo Ca"
                });

                listLocCa.AddRange(listCa);

                cboLocTheoCa.DataSource = listLocCa;
                cboLocTheoCa.DisplayMember = "TenCa";
                cboLocTheoCa.ValueMember = "MaCa";
                cboLocTheoCa.SelectedIndex = 0; // đặt mặc định là "Lọc theo Ca"
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
                dgvPhanCong.DataSource = sp.GetPhanCong();
                dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Phân Công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCaLam()
        {
            try
            {
                dgvCaLam.DataSource = clBLL.GetAll();
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
            cboLocTheoCa.SelectedIndex = -1;
            txtSDT_PC.Clear();
            txtViTriLamViec.Clear();
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
                int maNV = int.Parse(row.Cells["MaNV"].Value.ToString());
                txtSDT_PC.Text = nvBLL.GetAll().FirstOrDefault(nv => nv.MaNV == maNV).SDT.ToString();
                txtViTriLamViec.Text = nvBLL.GetAll().FirstOrDefault(nv => nv.MaNV == maNV).VitriLamViec;
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
                DateTime ngayLam = dtp_LocTheoNgay.Value;

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

        private void btnLoc_Click(object sender, EventArgs e)
        {
            // Thay đổi từ DateTime sang DateTime? (Nullable<DateTime>)
            DateTime? ngayLam;

            if (dtp_LocTheoNgay.Checked)
            {
                ngayLam = dtp_LocTheoNgay.Value.Date;
            }
            else
            {
                // Bây giờ có thể gán null
                ngayLam = null;
            }

            string tenCa = (int)cboLocTheoCa.SelectedValue != 0 ? cboLocTheoCa.Text : "";
            string TenNV = txtSearch.Text.Trim();

            // Hàm LocPhanCong cũng phải chấp nhận kiểu DateTime?
            dgvPhanCong.DataSource = pcBLL.LocPhanCong(ngayLam, tenCa, TenNV);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvPhanCong.DataSource = sp.GetPhanCong();
        }
    }
}