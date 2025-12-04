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
    public partial class FrmChiTietHoaDon : Form
    {
        public FrmChiTietHoaDon()
        {
            InitializeComponent();
        }
        public void editText(string text)
        {
            LblTitle.Text = text;
        }
    }
}
