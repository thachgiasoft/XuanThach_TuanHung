using DevExpress.XtraGrid.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVPHC.PresentationLayer
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            GridLocalizer.Active = new ValueContants.VietHoaGridview();
            InitializeComponent();
        }

        private Form KiemTraTonTai(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType) { return f; }
            }
            return null;
        }

        public void LoadNenForm()
        {
            Form frm = this.KiemTraTonTai(typeof(frmScreenMain));
            if (frm != null) { frm.Activate(); }
            else
            {
                frmScreenMain f = new frmScreenMain();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadNenForm();
            btnDangXuat.Enabled = false;
            stGioHeThong.Caption = "Giờ hệ thống: " + DateTime.Now.ToShortTimeString();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void btnDieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form frm = this.KiemTraTonTai(typeof(frmDanhMucDieu));
            //if (frm != null) { frm.Activate(); }
            //else
            //{
            //    frmDanhMucDieu f = new frmDanhMucDieu();
            //    f.MdiParent = this;
            //    f.Show();
            //}
            frmDanhMucDieu frm = new frmDanhMucDieu();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void barLapQDXPHC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form frm = this.KiemTraTonTai(typeof(frmQDXPHC));
            //if (frm != null) { frm.Activate(); }
            //else
            //{
            //    frmQDXPHC f = new frmQDXPHC();
            //    f.MdiParent = this;
            //    f.Show();
            //}
            frmQDXPHC frm = new frmQDXPHC();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btnLapBBVPHC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBBXPHC frm = new frmBBXPHC();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btnLapQDXPHC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            frmQDXPHC frm = new frmQDXPHC();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }

        private void btnKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhMucKhoan frm = new frmDanhMucKhoan();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
