namespace QLVPHC.PresentationLayer
{
    partial class frmDanhMucKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucKhoan));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.gcView = new DevExpress.XtraGrid.GridControl();
            this.gvView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loopKupDieu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMaKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopKupDieu)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bindingNavigator1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcView);
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 28;
            this.splitContainer1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.toolStripSeparator1,
            this.btnLuu,
            this.toolStripSeparator2,
            this.btnSua,
            this.toolStripSeparator3,
            this.btnXoa,
            this.toolStripSeparator4,
            this.btnThoat});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(784, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QLVPHC.Properties.Resources.them1;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::QLVPHC.Properties.Resources.save;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(49, 22);
            this.btnLuu.Text = "Lưu";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QLVPHC.Properties.Resources.sua1;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(50, 22);
            this.btnSua.Text = "Sửa";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QLVPHC.Properties.Resources.xoa1;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(48, 22);
            this.btnXoa.Text = "Xóa";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QLVPHC.Properties.Resources.Exit;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(58, 22);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gcView
            // 
            this.gcView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcView.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcView.Location = new System.Drawing.Point(0, 0);
            this.gcView.MainView = this.gvView;
            this.gcView.Name = "gcView";
            this.gcView.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.loopKupDieu});
            this.gcView.Size = new System.Drawing.Size(784, 529);
            this.gcView.TabIndex = 1;
            this.gcView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvView});
            this.gcView.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.gcView_EditorKeyDown);
            // 
            // gvView
            // 
            this.gvView.Appearance.FilterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvView.Appearance.FilterPanel.Options.UseFont = true;
            this.gvView.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvView.Appearance.GroupPanel.Options.UseFont = true;
            this.gvView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvView.Appearance.Row.Options.UseFont = true;
            this.gvView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDieu,
            this.colMaKhoan,
            this.colMoTa,
            this.colGhiChu,
            this.colId});
            this.gvView.GridControl = this.gcView;
            this.gvView.Name = "gvView";
            this.gvView.ShownEditor += new System.EventHandler(this.gvView_ShownEditor);
            // 
            // colDieu
            // 
            this.colDieu.Caption = "Điều";
            this.colDieu.ColumnEdit = this.loopKupDieu;
            this.colDieu.FieldName = "MoTa";
            this.colDieu.Name = "colDieu";
            this.colDieu.Visible = true;
            this.colDieu.VisibleIndex = 0;
            this.colDieu.Width = 150;
            // 
            // loopKupDieu
            // 
            this.loopKupDieu.AutoHeight = false;
            this.loopKupDieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loopKupDieu.DisplayMember = "MoTa";
            this.loopKupDieu.Name = "loopKupDieu";
            this.loopKupDieu.NullText = "Vui lòng chọn ĐIỀU";
            this.loopKupDieu.ValueMember = "Id";
            // 
            // colMaKhoan
            // 
            this.colMaKhoan.Caption = "Mã khoản";
            this.colMaKhoan.FieldName = "MaKhoan";
            this.colMaKhoan.Name = "colMaKhoan";
            this.colMaKhoan.Visible = true;
            this.colMaKhoan.VisibleIndex = 1;
            this.colMaKhoan.Width = 181;
            // 
            // colMoTa
            // 
            this.colMoTa.Caption = "Mô tả";
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 2;
            this.colMoTa.Width = 181;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
            this.colGhiChu.Width = 193;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // frmDanhMucKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDanhMucKhoan";
            this.Text = "Danh mục khoản";
            this.Load += new System.EventHandler(this.frmDanhMucKhoan_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopKupDieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcView;
        private DevExpress.XtraGrid.Views.Grid.GridView gvView;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDieu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit loopKupDieu;
    }
}