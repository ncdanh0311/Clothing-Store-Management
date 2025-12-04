using ShopQuanAo.BLL;
using ShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo.GUI
{
    public partial class UC_TrangChu : UserControl
    {
        public UC_TrangChu()
        {
            InitializeComponent();
        }

        private SanPhamBLL spBLL = new SanPhamBLL();
        private HangSanXuatBLL hsxBLL = new HangSanXuatBLL();
        private KhachHangBLL khBLL = new KhachHangBLL();
        private LoaiKhachHangBLL lkhBLL = new LoaiKhachHangBLL();
        private NhanVienBLL nvBLL = new NhanVienBLL();
        private DonHangBLL dhBLL = new DonHangBLL();
        private StoreProcedureBLL sp = new StoreProcedureBLL();


        private string msThue = null;
        private string sdt = null;
        private string email = null;

        private List<ChiTietDonHangDTO> LstCtdh = new List<ChiTietDonHangDTO>();
        private int maDH_hientai;
        private BindingSource bsChiTietDonHang = new BindingSource();
        private void AnThongTin()
        {
            txtHoTen.Enabled = false;
            txtTenCty.Enabled = false;
            txtDiaChi.Enabled = false;
            txtMSThue.Enabled = false;

            txtSDT.Enabled = true;
            txtEmail.Enabled = true;

            lblTamTinh.Text = "0";
            txtChietKhau.Text = "0";

        }

        private void AnButtonXuLiDH()
        {
            btnTaoDH.Enabled = false;
            btnThemDH.Enabled = false;
            btnHuyDon.Enabled = false;
            btnThanhToan.Enabled = false;
        }
        private void CapNhapSP()
        {
            dgvOrderList.DataSource = spBLL.GetSP();
        }

        private void CapNhatCboLoaiKH()
        {
            cboLoaiKH.DataSource = lkhBLL.GetLoaiKH();
            cboLoaiKH.DisplayMember = "TenLoaiKH";
            cboLoaiKH.ValueMember = "MaLoaiKH";
            cboLoaiKH.SelectedIndex = 0;
        }

        private void UC_TrangChu_Load(object sender, EventArgs e)
        {
            CapNhapSP();
            CapNhatCboLoaiKH();
            AnThongTin();
            AnButtonXuLiDH();
            bsChiTietDonHang.DataSource = LstCtdh;
            dgvDonHang.DataSource = bsChiTietDonHang;
        }

        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string AnhSP = dgvOrderList.CurrentRow.Cells[7].Value.ToString();
            picAnhSP.Load("../../GUI/Images/" + AnhSP);
            picAnhSP.SizeMode = PictureBoxSizeMode.Zoom;
            picAnhSP.Width = 150;
            if (e.RowIndex >= 0)
            {
                object value = dgvOrderList.Rows[e.RowIndex].Cells[4].Value;

                if (value != null && int.TryParse(value.ToString(), out int soLuongTon))
                {
                    nmrSoLuong.Maximum = (decimal)soLuongTon;

                    if (nmrSoLuong.Value > nmrSoLuong.Maximum)
                    {
                        nmrSoLuong.Value = nmrSoLuong.Maximum;
                    }
                }
                else
                {
                    nmrSoLuong.Maximum = 0;
                }
            }
        }

        private void cboLoaiKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatBtnTaoDH();
            if (cboLoaiKH.SelectedIndex == 1)
            {
                txtMSThue.Enabled = true;
                txtTenCty.Enabled = true;
            }
            else
            {
                txtMSThue.Enabled = false;
                txtTenCty.Enabled = false;
            }
        }

        private void btnUpdateKH_Click(object sender, EventArgs e)
        {
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtHoTen.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void btnLuuTTKH_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = khBLL.GetAll().FirstOrDefault(k => k.SDT == sdt);
                string NewmsThue = txtMSThue.Text;
                string Newsdt = txtSDT.Text;
                string Newemail = txtEmail.Text;
                if (kh != null)
                {
                    kh.SDT = Newsdt;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.TenKH = txtHoTen.Text;
                    kh.Email = Newemail;
                    khBLL.Update(kh);
                    MessageBox.Show("Đã cập nhật thông tin liên hệ");
                }
                else
                {
                    KhachHangDTO newKH = new KhachHangDTO
                    {
                        TenKH = txtHoTen.Text,
                        MaLoaiKH = int.Parse(cboLoaiKH.SelectedValue.ToString()),
                        SDT = Newsdt,
                        DiaChi = txtDiaChi.Text,
                        Email = Newemail,
                        TenCongTy = txtTenCty.Text,
                        MaSoThue = NewmsThue
                    };
                    khBLL.Insert(newKH);
                    MessageBox.Show("Thêm khách hàng thành công!");
                }
                AnThongTin();
                btnTaoDH.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lưu thông tin thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemKHmoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in tblKH.Controls)
            {
                if (ctr.Name != "txtMSThue")
                    ctr.Enabled = true;
            }
            if (cboLoaiKH.SelectedIndex == 0)
                txtTenCty.Enabled = false;
            else
                txtTenCty.Enabled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn làm mới toàn bộ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                foreach (Control ctr in tblKH.Controls)
                {
                    if (ctr is System.Windows.Forms.TextBox)
                    {
                        ctr.Enabled = false;
                    }
                }
                cboLoaiKH.SelectedIndex = -1;
                nmrSoLuong.ResetText();
                lblTamTinh.Text = "0";
                lblTongCong.Text = "0";
                lbTienThoi.Text = "0";
                txtChietKhau.Text = "0";
                txtTienKhachDua.Text = "0";

                // *** CHỈNH SỬA: Reset LstCtdh và BindingSource ***
                LstCtdh.Clear();
                bsChiTietDonHang.ResetBindings(false);
                dgvDonHang.DataSource = bsChiTietDonHang;
                maDH_hientai = 0; // Đặt lại mã đơn hàng hiện tại
                AnButtonXuLiDH();
            }
            AnThongTin();
            CapNhatBtnTaoDH();
        }

        private void btnKtraKH_Click(object sender, EventArgs e)
        {
            string sdtTam = txtSDT.Text;
            string msThueTam = txtMSThue.Text;
            string emailTam = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(msThueTam) &&
                string.IsNullOrWhiteSpace(sdtTam) &&
                string.IsNullOrWhiteSpace(emailTam))
            {
                MessageBox.Show("Vui lòng nhập Mã số thuế, SĐT, hoặc Email để kiểm tra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnLuuTTKH.Enabled = false;

                var kh = khBLL.GetAll().FirstOrDefault(k => k.SDT == sdtTam);

                if (kh != null)
                {
                    sdt = kh.SDT;
                    msThue = kh.MaSoThue;
                    email = kh.Email;

                    txtHoTen.Text = kh.TenKH;
                    txtDiaChi.Text = kh.DiaChi;
                    txtEmail.Text = kh.Email;
                    txtSDT.Text = kh.SDT;


                    if (kh.MaLoaiKH == 2)
                    {
                        cboLoaiKH.SelectedIndex = 1;
                        txtTenCty.Text = kh.TenCongTy;
                        txtMSThue.Text = kh.MaSoThue;
                    }
                    else
                        cboLoaiKH.SelectedIndex = 0;

                    MessageBox.Show($"Đã tìm thấy Khách hàng: {kh.TenKH}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (Control ctr in tblKH.Controls)
                    {
                        if (ctr is System.Windows.Forms.TextBox)
                        {
                            ctr.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng. Vui lòng thêm mới hoặc kiểm tra lại thông tin.", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtHoTen.Text = string.Empty;
                    txtDiaChi.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtTenCty.Text = string.Empty;

                    btnLuuTTKH.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình kiểm tra khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HuyDonHang()
        {
            if (maDH_hientai > 0)
            {
                try
                {
                    // Giả định dhBLL có phương thức Delete để xóa đơn hàng khỏi Database
                    dhBLL.Delete(maDH_hientai);
                    MessageBox.Show($"Đã hủy đơn hàng {maDH_hientai} thành công.", "Hủy đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset trạng thái
                    LstCtdh.Clear();
                    bsChiTietDonHang.ResetBindings(false);
                    maDH_hientai = 0;
                    AnButtonXuLiDH();
                    CapNhatBtnTaoDH();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hủy đơn hàng trong CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có đơn hàng nào đang chờ để hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            HuyDonHang();
        }

        private decimal GetCurrentChietKhauRate()
        {
            decimal chietKhauRate = 0;

            if (cboLoaiKH.SelectedValue != null)
            {
                if (int.TryParse(cboLoaiKH.SelectedValue.ToString(), out int maLoaiKH))
                {
                    var loaiKhach = lkhBLL.GetLoaiKH().FirstOrDefault(l => l.MaLoaiKH == maLoaiKH);

                    if (loaiKhach != null)
                    {
                        chietKhauRate = loaiKhach.ChietKhau / 100M;
                    }
                }
            }
            return chietKhauRate;
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (LstCtdh.Count == 0 || maDH_hientai == 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào đơn hàng trước khi thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lưu tất cả chi tiết đơn hàng
                foreach (var item in LstCtdh)
                {
                    sp.ThemChiTietDonHang(item);
                }

                decimal tongTien = 0;
                decimal.TryParse(lblTongCong.Text.Replace(",", ""), out tongTien);
                AnThongTin();
                AnButtonXuLiDH();
                CapNhapSP();
                MessageBox.Show("Thanh toán và lưu đơn hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi thanh toán thành công, reset lại giỏ hàng và mã đơn hiện tại
                LstCtdh.Clear();
                bsChiTietDonHang.ResetBindings(false);
                maDH_hientai = 0;
                CapNhatBtnTaoDH();
            }
            catch (Exception ex)
            {
                // Nếu thất bại, xóa đơn hàng header đã tạo trước đó để tránh rác DB
                if (maDH_hientai > 0)
                {
                    dhBLL.Delete(maDH_hientai);
                    maDH_hientai = 0;
                }
                MessageBox.Show("Lưu đơn thất bại. Vui lòng kiểm tra kết nối CSDL và dữ liệu chi tiết. \nChi tiết lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhapGioHang()
        {
            bsChiTietDonHang.ResetBindings(false);
        }

        private void CapNhatThanhToan()
        {
            // 1. TÍNH TẠM TÍNH (GROSS TOTAL)
            // LstCtdh.Sum(ct => ct.ThanhTien) = Tổng tiền thô
            decimal tamTinh = LstCtdh.Sum(ct => ct.ThanhTien);
            lblTamTinh.Text = tamTinh.ToString("N0"); // Hiển thị Gross Total

            // 2. TÍNH VÀ HIỂN THỊ CHIẾT KHẤU
            decimal chietKhauRate = GetCurrentChietKhauRate();

            // Tính tiền chiết khấu thực tế
            decimal tienChietKhau = tamTinh * chietKhauRate;

            // Tổng cộng cuối cùng (NET TOTAL)
            decimal tongCong = tamTinh - tienChietKhau;

            // Hiển thị phần trăm chiết khấu (đã nhân 100)
            txtChietKhau.Text = (chietKhauRate * 100).ToString("N0") + " %";

            // 3. HIỂN THỊ TỔNG CỘNG CUỐI CÙNG (NET TOTAL)
            lblTongCong.Text = tongCong.ToString("N0");

            // Giữ nguyên logic Tiền khách đưa
            decimal tienKhachDua = 0;
            string rawTienDua = txtTienKhachDua.Text;

            if (decimal.TryParse(rawTienDua, out tienKhachDua))
            {
                decimal tienThoi = tienKhachDua - tongCong;
                lbTienThoi.Text = tienThoi.ToString("N0");

                btnThanhToan.Enabled = tienKhachDua >= tongCong;
            }
            else
            {
                lbTienThoi.Text = "0";
                btnThanhToan.Enabled = false;
            }
        }

        private void btnThemDH_Click(object sender, EventArgs e)
        {
            try
            {
                if (nmrSoLuong.Value == 0)
                {
                    throw new Exception("Vui lòng chọn số lượng sản phẩm!");
                }

                if (dgvOrderList.CurrentRow != null)
                {
                    decimal originalDonGia = (decimal)dgvOrderList.CurrentRow.Cells[3].Value;
                    int soLuong = (int)nmrSoLuong.Value;

                    ChiTietDonHangDTO ctdh = new ChiTietDonHangDTO
                    {
                        MaDH = maDH_hientai,
                        MaSP = (int)dgvOrderList.CurrentRow.Cells[0].Value,
                        TenSP = dgvOrderList.CurrentRow.Cells[1].Value.ToString(),
                        SoLuong = soLuong,
                        DonGia = originalDonGia,
                    };

                    int maSP = int.Parse(dgvOrderList.CurrentRow.Cells[0].Value.ToString());
                    var item = LstCtdh.FirstOrDefault(ct => ct.MaDH == maDH_hientai && ct.MaSP == maSP);

                    if (item != null)
                    {
                        item.SoLuong += ctdh.SoLuong;
                    }
                    else
                    {
                        LstCtdh.Add(ctdh);
                    }

                    CapNhapGioHang();
                    CapNhatThanhToan(); // Gọi hàm tính toán
                }
                else
                    throw new Exception("Bạn chưa chọn sản phẩm");

                int soLuongHienTai = int.Parse(dgvOrderList.CurrentRow.Cells[4].Value.ToString());
                int soLuongGiam = (int)nmrSoLuong.Value;
                int soLuongMoi = soLuongHienTai - soLuongGiam;
                dgvOrderList.CurrentRow.Cells[4].Value = soLuongMoi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnTaoDH_Click(object sender, EventArgs e)
        {

            var khachhang = khBLL.GetAll().FirstOrDefault(kh => kh.SDT == txtSDT.Text);
            if (khachhang != null)
            {
                int maKH = khachhang.MaKH;
                dhBLL.InsertHeader(DateTime.Now, SessionManager.MaNVHienTai, maKH);

                maDH_hientai = dhBLL.GetAll()
                           .Where(dh => dh.MaNV == SessionManager.MaNVHienTai)
                           .OrderByDescending(dh => dh.NgayLap)
                           .FirstOrDefault().MaDH;

                MessageBox.Show($"Đơn hàng của khách: {txtHoTen.Text} tạo thành công. Mã ĐH: {maDH_hientai}");
            }
            else
            {
                MessageBox.Show("Tạo đơn hàng thất bại: Khách hàng không nằm trong hệ thống. Vui lòng tạo mới và lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnTaoDH.Enabled = false;
            btnThemDH.Enabled = true;
            btnHuyDon.Enabled = true;
        }


        private bool KiemTraThongTinKhachHangDayDu()
        {
            // Nếu ComboBox chưa sẵn sàng -> chưa đạt điều kiện
            if (cboLoaiKH.DataSource == null)
                return false;

            object selected = cboLoaiKH.SelectedValue;

            // Nếu SelectedValue là null hoặc SelectedItem null -> chưa sẵn sàng
            if (selected == null && cboLoaiKH.SelectedItem == null)
                return false;

            int loaiKH;

            // Các khả năng: SelectedValue trực tiếp là int, hoặc là DTO, hoặc là string có thể parse
            if (selected is int i)
            {
                loaiKH = i;
            }
            else if (selected is LoaiKhachHangDTO dtoFromValue) // nếu SelectedValue bị WinForms set thành DTO
            {
                loaiKH = dtoFromValue.MaLoaiKH;
            }
            else if (cboLoaiKH.SelectedItem is LoaiKhachHangDTO dtoFromItem) // dùng SelectedItem làm fallback
            {
                loaiKH = dtoFromItem.MaLoaiKH;
            }
            else if (int.TryParse(selected?.ToString(), out int parsed))
            {
                loaiKH = parsed;
            }
            else
            {
                // Không xác định được -> an toàn trả về false
                return false;
            }

            bool bacbuoc = !string.IsNullOrWhiteSpace(txtHoTen.Text) &&
                           !string.IsNullOrWhiteSpace(txtSDT.Text) &&
                           !string.IsNullOrWhiteSpace(txtDiaChi.Text);

            if (loaiKH == 1) // cá nhân
            {
                return bacbuoc;
            }
            else if (loaiKH == 2) // doanh nghiệp
            {
                bool bacbuocDN = !string.IsNullOrWhiteSpace(txtTenCty.Text) &&
                                 !string.IsNullOrWhiteSpace(txtMSThue.Text);
                return bacbuoc && bacbuocDN;
            }

            return false;
        }


        private void CapNhatBtnTaoDH()
        {
            btnTaoDH.Enabled = KiemTraThongTinKhachHangDayDu();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            CapNhatBtnTaoDH();
        }

        private void txtTenCty_TextChanged(object sender, EventArgs e)
        {
            CapNhatBtnTaoDH();
        }


        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            CapNhatBtnTaoDH();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            CapNhatBtnTaoDH();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            CapNhatBtnTaoDH();
        }

        private void txtMSThue_TextChanged(object sender, EventArgs e)
        {
            CapNhatBtnTaoDH();
        }

        private void btnHuyDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                HuyDonHang();
            }
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            string rawText = txtTienKhachDua.Text;

            if (string.IsNullOrWhiteSpace(rawText))
            {
                txtTienKhachDua.Text = "0";
                txtTienKhachDua.SelectionStart = txtTienKhachDua.Text.Length;
                txtTienKhachDua.SelectionLength = 0;

                CapNhatThanhToan();
                return;
            }

            if (rawText.Length > 1 && rawText.StartsWith("0"))
            {
                string newText = rawText.TrimStart('0');

                if (string.IsNullOrWhiteSpace(newText))
                {
                    newText = "0";
                }
                if (txtTienKhachDua.Text != newText)
                {
                    txtTienKhachDua.Text = newText;
                    txtTienKhachDua.SelectionStart = txtTienKhachDua.Text.Length;
                    txtTienKhachDua.SelectionLength = 0;
                    return;
                }
            }
            CapNhatThanhToan();
        }

        private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UC_TrangChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                btnHuyDon_Click(btnHuyDon, new EventArgs());
            }


            if (e.KeyCode == Keys.R && e.Control)
            {
                e.Handled = true;
                btnLamMoi_Click(btnLamMoi, new EventArgs());
            }
        }

    }
}
