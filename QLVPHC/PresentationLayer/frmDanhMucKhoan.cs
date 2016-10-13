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
using DevExpress.XtraGrid.Views.Grid;
using QLVPHC.BLL;
using QLVPHC.DAL;
using DevExpress.XtraGrid;

namespace QLVPHC.PresentationLayer
{
    public partial class frmDanhMucKhoan : DevExpress.XtraEditors.XtraForm
    {
        B_Dieu bDieu = new B_Dieu();

        public frmDanhMucKhoan()
        {
            InitializeComponent();
        }

        private bool CheckAddNewRow(GridView gvView)
        {
            if (gvView.FocusedColumn.VisibleIndex == gvView.VisibleColumns.Count - 1)
            {
                if (gvView.IsNewItemRow(gvView.FocusedRowHandle))
                {
                    gvView.PostEditor();
                    gvView.UpdateCurrentRow();
                }
                if (gvView.IsLastRow)
                    return AddNewRow(gvView);
            }
            return false;
        }

        // Them dong moi
        private bool AddNewRow(GridView gvView)
        {
            gvView.AddNewRow();
            gvView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            gvView.FocusedColumn = gvView.VisibleColumns[0];
            return true;
        }

        private bool OnKeyDown(Keys keyCode, Keys modifiers, GridView gvView)
        {
            if (modifiers == Keys.None & (keyCode == Keys.Enter || keyCode == Keys.Tab))
            {
                return CheckAddNewRow(gvView);
            }
            return false;
        }

        private void frmDanhMucKhoan_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            gcView.ForceInitialize();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            AddNewRow(gvView);
        }

        private void gvView_ShownEditor(object sender, EventArgs e)
        {
            GridView view;
            view = sender as GridView;
            if (view.FocusedColumn.FieldName == "MoTa" && view.ActiveEditor is LookUpEdit)
            {
                LookUpEdit edit;
                edit = (LookUpEdit)view.ActiveEditor;

                DataRow row = view.GetDataRow(view.FocusedRowHandle);
                edit.Properties.DataSource = bDieu.GetLoopkup();
            }
        }

        private void gcView_EditorKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = OnKeyDown(e.KeyCode, e.Modifiers, gvView);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}