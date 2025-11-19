using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI.NhapKho
{
    public partial class UC_NhaCungCap : UserControl
    {
        NhaCungCapBLL ncc = new NhaCungCapBLL();
        public UC_NhaCungCap()
        {
            InitializeComponent();
        }
        private void UpdateDgvNCC()
        {  
            dgvNCC.DataSource = ncc.GetNCC();
            dgvNCC.Refresh();
        }
        private void UCNhaCungCap_Load(object sender, EventArgs e)
        {
            UpdateDgvNCC();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var found = ncc.GetNCC().FindAll(x=>x.TenNCC.ToLower().Contains(txtTimKiem.Text.ToLower()));
            dgvNCC.DataSource = found;
        }
        private void ResetNCC()
        {
            foreach (Control ctr in grpThongTin.Controls)
            {
                if (ctr.GetType() == typeof(TextBox))
                    ctr.ResetText();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string TenNCC = txtTenNCC.Text;
                string SDT = txtSDT.Text;
                string DiaChi = txtDiaChi.Text;
                string Email = txtEmail.Text;

                int rs = ncc.ThemNCC(TenNCC, SDT, DiaChi, Email);
                if (rs != 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    ResetNCC();
                    UpdateDgvNCC();
                }
                else
                    throw new Exception("Thêm thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            UpdateDgvNCC();
            ResetNCC();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNCC.SelectedRows.Count == 0 && dgvNCC.SelectedCells.Count == 0)
                {
                    throw new Exception("Hãy chọn 1 dòng để xóa");
                }
                int maNCC = int.Parse(dgvNCC.CurrentRow.Cells[0].Value.ToString());
                int rs = ncc.XoaNCC(maNCC);
                if (rs != 0)
                {
                    MessageBox.Show("Xóa thành công");
                    UpdateDgvNCC();
                }
                else throw new Exception("Thêm thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvNCC_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
                txtSDT.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lựa chọn không hợp lệ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvNCC.SelectedRows.Count == 0 && dgvNCC.SelectedCells.Count == 0)
                {
                    throw new Exception("Hãy chọn 1 dòng để sửa");
                }
                NhaCungCapDTO n = new NhaCungCapDTO()
                {
                    MaNCC = int.Parse(txtMaNCC.Text),
                    TenNCC = txtTenNCC.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDiaChi.Text,
                    Email = txtEmail.Text
                };
                int rs = ncc.SuaNCC(n);
                if (rs != 0)
                {
                    MessageBox.Show("Sửa thành công");
                    UpdateDgvNCC();
                }
                else
                    throw new Exception("Sửa thất bại");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
