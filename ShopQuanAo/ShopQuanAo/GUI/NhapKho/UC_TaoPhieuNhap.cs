using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopQuanAo.BLL;
using ShopQuanAo.DTO;


namespace ShopQuanAo.GUI.NhapKho
{
    public partial class UC_TaoPhieuNhap : UserControl
    {
        public delegate void PhieuNhapSavedHandler();
        public event PhieuNhapSavedHandler OnPhieuNhapSaved;
        StoreProcedureBLL proc = new StoreProcedureBLL();
        NhaCungCapBLL ncc = new NhaCungCapBLL();
        HangSanXuatBLL hsx = new HangSanXuatBLL();
        SanPhamBLL sp = new SanPhamBLL();
        DataSet dsNhapHang = new DataSet();
        DataTable ctpn = new DataTable();

        private int _maNCCCu = 0;
        private bool _isRestoring = false;
        NhanVienBLL nv = new NhanVienBLL();
        private bool IsValidInput()
        {
            // Kiểm tra ComboBox (Phải chọn)
            if (cboNCC.SelectedValue == null || cboHSX.SelectedValue == null ||
                cboSP.SelectedValue == null || cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Nhà cung cấp, Hãng SX, Sản phẩm và Nhân viên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra Số lượng (Không được rỗng và phải là số nguyên dương)
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập Số lượng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return false;
            }
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương lớn hơn 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return false;
            }

            // Kiểm tra Đơn giá (Không được rỗng và phải là số thập phân không âm)
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập Đơn giá.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return false;
            }
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số tiền hợp lệ và không âm.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return false;
            }

            return true; // Tất cả ràng buộc đều thỏa mãn
        }
        private void KhoiTaoDataSet()
        {
            dsNhapHang = new DataSet("PhieuNhapTam");
            ctpn = new DataTable("ChiTietPN");

            // 1. Thêm cột MaSP vào DataTable
            ctpn.Columns.Add("MaSP", typeof(int));
            ctpn.Columns.Add("TenSP", typeof(string));
            ctpn.Columns.Add("SoLuong", typeof(int));
            ctpn.Columns.Add("DonGia", typeof(decimal));
            ctpn.Columns.Add("ThanhTien", typeof(decimal));

            dsNhapHang.Tables.Add(ctpn);

            dgvChiTiet.DataSource = dsNhapHang.Tables["ChiTietPN"];

            dgvChiTiet.Columns["MaSP"].Visible = false;
        }

        public UC_TaoPhieuNhap()
        {
            InitializeComponent();
            KhoiTaoDataSet();
        }
        public void CapNhatTongTien()
        {
            decimal sum = 0;
            if (ctpn.Rows.Count > 0)
            {
                foreach (DataRow row in ctpn.Rows)
                {
                    sum += decimal.Parse(row["ThanhTien"].ToString());
                }
            }
            else
                sum = 0;
            lbTongTien.Text = sum.ToString("N0") + " VNĐ";
            lbTongTien.ForeColor = Color.Red;
            lbTongTien.Font = new Font(lbTongTien.Font, FontStyle.Bold);
        }
        private void UC_TaoPhieuNhap_Load(object sender, EventArgs e)
        {
            cboNCC.DataSource = ncc.GetNCC();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";

            if (cboNCC.SelectedValue != null)
                _maNCCCu = int.Parse(cboNCC.SelectedValue.ToString());

            cboHSX.DataSource = hsx.GetHSX();
            cboHSX.DisplayMember = "TenHSX";
            cboHSX.ValueMember = "MaHSX";

            cboSP.DataSource = sp.GetSP();
            cboSP.DisplayMember = "TenSP";
            cboSP.ValueMember = "MaSP";

            cboNhanVien.DataSource = nv.GetAll().Where(x=> x.TrangThai.ToLower() != "nghỉ việc").ToList();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNV";
            CapNhatTongTien();
        }

        private void btnThemDong_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
            {
                return;
            }

            DataRow newRow = ctpn.NewRow();
            newRow["MaSP"] = (int)cboSP.SelectedValue;
            newRow["TenSP"] = cboSP.Text;
            newRow["SoLuong"] = Convert.ToInt32(txtSoLuong.Text);
            newRow["DonGia"] = Convert.ToDecimal(txtDonGia.Text);
            newRow["ThanhTien"] = Convert.ToInt32(txtSoLuong.Text) * Convert.ToDecimal(txtDonGia.Text);

            ctpn.Rows.Add(newRow);
            CapNhatTongTien();

            txtSoLuong.Text = string.Empty;
            txtDonGia.Text = string.Empty;
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.SelectedRows.Count == 0 && dgvChiTiet.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int selectedIndex = dgvChiTiet.SelectedCells[0].RowIndex;
                    ctpn.Rows.RemoveAt(selectedIndex);
                    CapNhatTongTien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetForm()
        {
            ctpn.Rows.Clear();

            txtSoLuong.Text = string.Empty;
            txtDonGia.Text = string.Empty;

            if (cboNCC.Items.Count > 0)
            {
                cboNCC.SelectedIndex = 0;
                if (cboNCC.SelectedValue != null)
                {
                    _maNCCCu = int.Parse(cboNCC.SelectedValue.ToString());
                }
            }

            if (cboSP.Items.Count > 0) cboSP.SelectedIndex = 0;
            if (cboHSX.Items.Count > 0) cboHSX.SelectedIndex = 0;
            if (cboNhanVien.Items.Count > 0) cboNhanVien.SelectedIndex = 0;
            cboNCC.Focus();
            MessageBox.Show("Phiếu nhập đã được lưu và form đã được làm mới, sẵn sàng cho phiếu nhập mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ctpn.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm vào phiếu nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int MaNV = int.Parse(cboNhanVien.SelectedValue.ToString());
                int MaNCC_HienTai = int.Parse(cboNCC.SelectedValue.ToString());
                int MaPN = proc.TaoPhieuNhap(MaNV, MaNCC_HienTai);

                foreach (DataRow row in ctpn.Rows)
                {
                    int maSP = (int)row["MaSP"];
                    int soLuong = (int)row["SoLuong"];
                    decimal donGia = (decimal)row["DonGia"];
                    proc.ThemChiTietPN(MaPN, maSP, soLuong, donGia);
                }
                if (OnPhieuNhapSaved != null)
                {
                    OnPhieuNhapSaved();
                }

                MessageBox.Show("Thêm thành công!");
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại! Lỗi hệ thống: " + ex.Message);
            }
        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isRestoring)
                return;

            if (cboNCC.SelectedValue == null)
            {
                return;
            }

            int maNCCMoi;
            if (!int.TryParse(cboNCC.SelectedValue.ToString(), out maNCCMoi))
            {
                return;
            }

            if (ctpn.Rows.Count > 0 && maNCCMoi != _maNCCCu)
            {
                string mess = "Đổi nhà cung cấp sẽ xóa hết sản phẩm đã nhập. Bạn có chắc muốn đổi nhà cung cấp?";

                if (MessageBox.Show(mess, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ctpn.Rows.Clear();
                    _maNCCCu = maNCCMoi;
                    CapNhatTongTien();
                }
                else
                {
                    _isRestoring = true;
                    cboNCC.SelectedValue = _maNCCCu;
                    _isRestoring = false;
                }
            }
            else if (ctpn.Rows.Count == 0)
            {
                _maNCCCu = maNCCMoi;
            }
        }
    }
}