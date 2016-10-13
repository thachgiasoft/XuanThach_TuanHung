using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLVPHC.BLL;
using QLVPHC.DTO;
using QLVPHC.DAL;

namespace QLVPHC.PresentationLayer
{
    public partial class frmDanhMucDieu : DevExpress.XtraEditors.XtraForm
    {
        B_Dieu bDieu = new B_Dieu();

        public frmDanhMucDieu()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            txtMaDieu.Clear();
            txtMoTa.Clear();
            txtGhiChu.Clear();

            txtMaDieu.Focus();
        }

        private void frmDanhMucDieu_Load(object sender, EventArgs e)
        {
            LoadDanhMucDieu();

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaDieu.Enabled = false;
        }

        private void LoadDanhMucDieu()
        {
            try
            {
                gcView.DataSource = bDieu.GetDanhMucDieu();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaDieu.Enabled = true;
            txtMaDieu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dieu = new Dieu()
            {
                MaDieu = txtMaDieu.Text.Trim(),
                MoTa = txtMoTa.Text.Trim(),
                GhiChu = txtGhiChu.Text.Trim(),
                IsDelete = false,
            };

            bool success = bDieu.Insert(dieu);
            if (success)
            {
                XtraMessageBox.Show(ValueContants.SuccessMesage.LuuThanhCong, ValueContants.SuccessMesage.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                LoadDanhMucDieu();
            }
            else
                XtraMessageBox.Show(ValueContants.ErrorMessage.LoiLuu, ValueContants.ErrorMessage.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(ValueContants.SuccessMesage.Thoat, ValueContants.SuccessMesage.XacNhan, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var dieu = new Dieu()
            {
                Id = Int64.Parse(lblId.Text),
                MaDieu = txtMaDieu.Text.Trim(),
                MoTa = txtMoTa.Text.Trim(),
                GhiChu = txtGhiChu.Text.Trim(),
            };

            bool success = bDieu.Update(dieu);
            if (success)
            {
                XtraMessageBox.Show(ValueContants.SuccessMesage.CapNhatThanhCong, ValueContants.SuccessMesage.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhMucDieu();
                ClearAll();
            }
            else
                XtraMessageBox.Show(ValueContants.ErrorMessage.LoiLuu, ValueContants.ErrorMessage.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(ValueContants.SuccessMesage.Xoa, ValueContants.SuccessMesage.XacNhan, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                long Id = Int64.Parse(lblId.Text);
                bool status = true;

                bDieu.Delete(Id, status);
                ClearAll();
                LoadDanhMucDieu();
            }
        }

        private void gvView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column == colSTT)
            {
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
            }
        }

        private void gvView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaDieu.Text = gvView.GetFocusedRowCellDisplayText(colMaDieu);
            txtMoTa.Text = gvView.GetFocusedRowCellDisplayText(colMoTa);
            txtGhiChu.Text = gvView.GetFocusedRowCellDisplayText(colGhiChu);
            lblId.Text = gvView.GetFocusedRowCellDisplayText(colId);

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaDieu.Enabled = true;
        }

        private void txtMaDieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtMoTa.Focus();
        }

        private void txtMoTa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtGhiChu.Focus();
        }

        private void txtGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLuu_Click(sender, e);
        }
    }
}