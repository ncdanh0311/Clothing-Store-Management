using ShopQuanAo.BLL;
using ShopQuanAo.GUI.NhapKho;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShopQuanAo.GUI
{
    public partial class NVKho_TrangChu : Form
    {
        public NVKho_TrangChu()
        {
            InitializeComponent();
        }

        PhieuNhapBLL pn = new PhieuNhapBLL();

        public void CapNhatThongKe()
        {
            lbPhieuChoDuyet.Text = "Phiếu xuất chờ duyệt: " +
                pn.GetPN().Where(ma => ma.TrangThai == "Tạo mới").Count().ToString();
        }

        private void UcTaoPhieuNhap_OnPhieuNhapSaved()
        {
            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    CapNhatThongKe();
                }
                catch (Exception)
                {
                    lbPhieuChoDuyet.Text = "Phiếu xuất chờ duyệt: 1";
                }
            });
        }

        private void LoadUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);

            if (uc is UC_TaoPhieuNhap ucPN)
            {
                ucPN.OnPhieuNhapSaved += UcTaoPhieuNhap_OnPhieuNhapSaved;
            }
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_NhaCungCap());
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_HangHoa());
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_TaoPhieuNhap());
        }

        private void btnTraCuuLichSu_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_TraCuuLichSu());
        }

        private void NVKho_TrangChu_Load(object sender, EventArgs e)
        {
            CapNhatThongKe();
            btnTrangChu_Click(null, EventArgs.Empty);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ThongKe());
        }
    }
}