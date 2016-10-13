namespace QLVPHC.PresentationLayer
{
    partial class frmDangNhap
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
            this.btnDangNhap = new DevExpress.XtraEditors.CheckButton();
            this.lblGio = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblTestDN = new DevExpress.XtraEditors.LabelControl();
            this.lblTest = new DevExpress.XtraEditors.LabelControl();
            this.txtChayVN = new System.Windows.Forms.TextBox();
            this.btnThoat = new DevExpress.XtraEditors.CheckButton();
            this.btnReset = new DevExpress.XtraEditors.CheckButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(22, 112);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(98, 27);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.CheckedChanged += new System.EventHandler(this.btnDangNhap_CheckedChanged);
            // 
            // lblGio
            // 
            this.lblGio.AutoSize = true;
            this.lblGio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblGio.Location = new System.Drawing.Point(223, 162);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(23, 13);
            this.lblGio.TabIndex = 27;
            this.lblGio.Text = "....";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNgay.Location = new System.Drawing.Point(91, 162);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(23, 13);
            this.lblNgay.TabIndex = 26;
            this.lblNgay.Text = "....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(191, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Giờ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(50, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ngày:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(121, 69);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(172, 25);
            this.txtMatKhau.TabIndex = 2;
            // 
            // lblTestDN
            // 
            this.lblTestDN.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTestDN.Location = new System.Drawing.Point(41, 96);
            this.lblTestDN.Name = "lblTestDN";
            this.lblTestDN.Size = new System.Drawing.Size(0, 13);
            this.lblTestDN.TabIndex = 14;
            // 
            // lblTest
            // 
            this.lblTest.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTest.Location = new System.Drawing.Point(58, 144);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(58, 13);
            this.lblTest.TabIndex = 13;
            this.lblTest.Text = "Test Kêt Nối";
            // 
            // txtChayVN
            // 
            this.txtChayVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.txtChayVN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChayVN.ForeColor = System.Drawing.Color.DarkRed;
            this.txtChayVN.Location = new System.Drawing.Point(5, 182);
            this.txtChayVN.Multiline = true;
            this.txtChayVN.Name = "txtChayVN";
            this.txtChayVN.Size = new System.Drawing.Size(396, 19);
            this.txtChayVN.TabIndex = 12;
            this.txtChayVN.Text = "                          Chương trình quản lý vi phạm hành chính (2016)         " +
    "         ";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(301, 112);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 27);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.CheckedChanged += new System.EventHandler(this.btnThoat_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.Location = new System.Drawing.Point(158, 112);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 27);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.CheckedChanged += new System.EventHandler(this.btnReset_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(16, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mật Khẩu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(16, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tên Đăng Nhập:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.EditValue = "admin";
            this.txtTenDangNhap.EnterMoveNextControl = true;
            this.txtTenDangNhap.Location = new System.Drawing.Point(121, 31);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(172, 24);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.btnDangNhap);
            this.groupControl1.Controls.Add(this.lblGio);
            this.groupControl1.Controls.Add(this.lblNgay);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.lblTestDN);
            this.groupControl1.Controls.Add(this.lblTest);
            this.groupControl1.Controls.Add(this.txtChayVN);
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnReset);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtTenDangNhap);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(405, 206);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông Tin Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVPHC.Properties.Resources.DangNhapHeTHong;
            this.pictureBox1.Location = new System.Drawing.Point(311, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 206);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.CheckButton btnDangNhap;
        private System.Windows.Forms.Label lblGio;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private DevExpress.XtraEditors.LabelControl lblTestDN;
        private DevExpress.XtraEditors.LabelControl lblTest;
        private System.Windows.Forms.TextBox txtChayVN;
        private DevExpress.XtraEditors.CheckButton btnThoat;
        private DevExpress.XtraEditors.CheckButton btnReset;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}