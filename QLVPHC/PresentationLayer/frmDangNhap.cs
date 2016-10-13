using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVPHC.PresentationLayer
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string s = txtChayVN.Text; txtChayVN.Text = s.Substring(1, s.Length - 1) + s[0];
                lblNgay.Text = DateTime.Now.ToShortDateString().ToString();
                lblGio.Text = DateTime.Now.ToLongTimeString().ToString();
            }
            catch { }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
            //try { DataAccess kn = new DataAccess(); lblTest.Text = "Kết nối máy chủ thành công !"; }
            //catch { lblTest.Text = "Kết nối máy chủ thất bại !"; }
        }

        private void btnDangNhap_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_CheckedChanged(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = txtMatKhau.Text = "";
        }

        private void btnThoat_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult tl = XtraMessageBox.Show("Bạn có thực sự muốn thoát chương trình ?", "Chú ý !",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (tl == DialogResult.Yes) { Application.Exit(); }
        }
    }
}
