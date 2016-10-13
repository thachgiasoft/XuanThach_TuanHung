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
using QLVPHC.DAL;
using QLVPHC.DTO;
using DevExpress.Utils;

namespace QLVPHC.PresentationLayer
{
    public partial class frmQDXPHC : DevExpress.XtraEditors.XtraForm
    {
        int soControl = 0;
        string SoQD;
        B_NghiDinh b_nd = new B_NghiDinh();
        B_GiaoQuyen b_gq = new B_GiaoQuyen();
        B_GiaiTrinh b_gt = new B_GiaiTrinh();
        B_QDVPHC b_qdvphc = new B_QDVPHC();
        B_CTQDVPHC b_ctqdvphc = new B_CTQDVPHC();
        B_BBVPHC b_bbvphc = new B_BBVPHC();
        B_NhanVien b_nv = new B_NhanVien();
        QDVPHCDto qdDto = new QDVPHCDto();
        QLVPHCEntities context = new QLVPHCEntities();
        public frmQDXPHC(string SoQD)
        {
            InitializeComponent();
            this.SoQD = SoQD;
        }
        public frmQDXPHC()
        {
            InitializeComponent();
        }
      
        private void frmQDXPHC_Load(object sender, EventArgs e)
        {
            b_nv.LoadCbbNhanVien(cbbNhanVien);
        }

        #region Event Thêm, lưu, sửa, xóa, thoát
        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextEdit))
                {
                    c.Text = "";
                }
                else if (c.GetType() == typeof(MemoEdit))
                {
                    c.Text = "";
                }
                else if (c.GetType() == typeof(DateEdit))
                {
                    c.Text = DateTime.Today.ToShortDateString();
                }
                else if (c.GetType() == typeof(FlowLayoutPanel))
                {
                    c.Controls.Clear();
                }
                else if (c.GetType() == typeof(LookUpEdit))
                {
                    c.Text = "";
                }
            }
            txtSoQD.Focus();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            soControl = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoQD.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống số quyết định", "Thông báo");
                txtSoQD.Focus();
                return;
            }
            if (txtSoBBVPHC.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập số biên bản", "Thông báo");
                txtSoBBVPHC.Focus();
                return;
            }
            if (txtSoQuyen.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống số quyển", "Thông báo");
                txtSoQuyen.Focus();
                return;
            }
            if (cbbNhanVien.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống nhân viên", "Thông báo");
                cbbNhanVien.Focus();
                return;
            }
            if (txtSoNghiDinh.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập số nghị định", "Thông báo");
                txtSoNghiDinh.Focus();
                return;
            }
            if (txtSoBBGiaiTrinh.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập số biên bản giải trình", "Thông báo");
                txtSoBBGiaiTrinh.Focus();
                return;
            }
            if (txtSoVBGiaoQuyen.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập số văn bản giao quyền", "Thông báo");
                txtSoVBGiaoQuyen.Focus();
                return;
            }
            if (double.Parse(txtTongTienPhat.Text.Trim()) == 0)
            {
                XtraMessageBox.Show("Vui lòng nhấn nút tính tổng tiền", "Thông báo");
                btnTinh.Focus();
                return;
            }
            if (flowLayoutPanel1.Controls.Count==0)
            {
                XtraMessageBox.Show("Vui lòng không để trống quy định tại...", "Thông báo");
                btnAddControl.Focus();
                return;
            }

            string kq = b_qdvphc.Insert(TaoQuyetDinh());
            if (kq != "")
            {
                XtraMessageBox.Show(kq, "Thông báo");
                txtSoQD.SelectAll();
                txtSoQD.Focus();
                return;
            }
            else
            {
                XtraMessageBox.Show("Thêm quyết định VPHC thành công", "Thông báo");
                
                for (int i = 1; i <= soControl ; i++)
                {
                    string MaDiem = "", MaKhoan = "", MaDieu = "", MucPhat = "";
                    foreach(Control c in flowLayoutPanel1.Controls )
                    {
                        if (c.GetType() == typeof(TextEdit))
                        {
                            if (c.Name.Contains("txtDiem" + i.ToString()))
                            {
                                MaDiem = c.Text.Trim();
                            }
                            if (c.Name.Contains("txtKhoan" + i.ToString()))
                            {
                                MaKhoan = c.Text.Trim();
                            }
                            if (c.Name.Contains("txtDieu" + i.ToString()))
                            {
                                MaDieu = c.Text.Trim();
                            }
                            if (c.Name.Contains("txtMuc" + i.ToString()))
                            {
                                MucPhat = c.Text.Trim();
                            }
                        }
                        else
                            continue;
                    }
                    string inkq = b_ctqdvphc.Insert(TaoChiTietQuyetDinh(MaDiem, MaKhoan, MaDieu, MucPhat));
                    if (inkq != "")
                    {
                        string upkq = b_ctqdvphc.Update(TaoChiTietQuyetDinh(MaDiem, MaKhoan, MaDieu, MucPhat));
                    }
                }
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoQD.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống số quyết định", "Thông báo");
                txtSoQD.Focus();
                return;
            }
            if (txtSoBBVPHC.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập số biên bản", "Thông báo");
                txtSoBBVPHC.Focus();
                return;
            }
            if (txtSoQuyen.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống số quyển", "Thông báo");
                txtSoQuyen.Focus();
                return;
            }
            if (cbbNhanVien.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống nhân viên", "Thông báo");
                cbbNhanVien.Focus();
                return;
            }
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                XtraMessageBox.Show("Vui lòng không để trống quy định tại...", "Thông báo");
                btnAddControl.Focus();
                return;
            }
            string soQD = txtSoQD.Text.Trim();
            string kq = b_qdvphc.Update(TaoQuyetDinh());
            if (kq != "")
            {
                XtraMessageBox.Show(kq, "Thông báo");
                txtSoQD.SelectAll();
                txtSoQD.Focus();
                return;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật quyết định VPHC thành công", "Thông báo");
                for (int i = 1; i <= soControl; i++)
                {
                    string MaDiem = "", MaKhoan = "", MaDieu = "", MucPhat = "";
                    foreach (Control c in flowLayoutPanel1.Controls)
                    {
                        if (c.GetType() == typeof(TextEdit))
                        {
                            if (c.Name.Contains("txtDiem" + i.ToString()))
                            {
                                MaDiem = c.Text.Trim();
                            }
                            if (c.Name.Contains("txtKhoan" + i.ToString()))
                            {
                                MaKhoan = c.Text.Trim();
                            }
                            if (c.Name.Contains("txtDieu" + i.ToString()))
                            {
                                MaDieu = c.Text.Trim();
                            }
                            if (c.Name.Contains("txtMuc" + i.ToString()))
                            {
                                MucPhat = c.Text.Trim();
                            }
                        }
                        else
                            continue;
                    }
                    string inkq = b_ctqdvphc.Update(TaoChiTietQuyetDinh(MaDiem, MaKhoan, MaDieu, MucPhat));
                    if (inkq != "")
                    {
                        string upkq = b_ctqdvphc.Update(TaoChiTietQuyetDinh(MaDiem, MaKhoan, MaDieu, MucPhat));
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSoQD.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập số quyết định cần xóa", "Thông báo");
                txtSoQD.Focus();
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa quyết định VPHC này?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string soBB = txtSoQD.Text.Trim();
                string kq = b_qdvphc.Delete(soBB);
                if (kq != "")
                {
                    XtraMessageBox.Show(kq, "Thông báo");
                    txtSoQD.SelectAll();
                    txtSoQD.Focus();
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Đã xóa quyết định VPHC thành công", "Thông báo");
                    for (int i = 1; i <= soControl; i++)
                    {
                        string MaDiem = "", MaKhoan = "", MaDieu = "", MucPhat = "";
                        foreach (Control c in flowLayoutPanel1.Controls)
                        {
                            if (c.GetType() == typeof(TextEdit))
                            {
                                if (c.Name.Contains("txtDiem" + i.ToString()))
                                {
                                    MaDiem = c.Text.Trim();
                                }
                                if (c.Name.Contains("txtKhoan" + i.ToString()))
                                {
                                    MaKhoan = c.Text.Trim();
                                }
                                if (c.Name.Contains("txtDieu" + i.ToString()))
                                {
                                    MaDieu = c.Text.Trim();
                                }
                                if (c.Name.Contains("txtMuc" + i.ToString()))
                                {
                                    MucPhat = c.Text.Trim();
                                }
                            }
                            else
                                continue;
                        }
                        string inkq = b_ctqdvphc.Delete(txtSoQD.Text.Trim(),MaDiem, MaKhoan, MaDieu);
                        if (inkq != "")
                        {
                            string upkq = b_ctqdvphc.Delete(txtSoQD.Text.Trim(), MaDiem, MaKhoan, MaDieu);
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hàm
        private void CreateControlsDetails(CTQDVPHCDto ct)
        {
            soControl++;
            LabelControl lblDiem = new LabelControl();
            lblDiem.Name = "lblDiem" + soControl;
            lblDiem.Text = "+Điểm:";
            lblDiem.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            TextEdit txtDiem = new TextEdit();
            txtDiem.Name = "txtDiem" + soControl;
            txtDiem.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            txtDiem.Width = 50;
            txtDiem.Text = ct.MaDiem;

            LabelControl lblKhoan = new LabelControl();
            lblKhoan.Name = "lblKhoan" + soControl;
            lblKhoan.Text = "Khoản:";
            lblKhoan.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            TextEdit txtKhoan = new TextEdit();
            txtKhoan.Name = "txtKhoan" + soControl;
            txtKhoan.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            txtKhoan.Width = 50;
            txtKhoan.Text = ct.MaKhoan;

            LabelControl lblDieu = new LabelControl();
            lblDieu.Name = "lblDieu" + soControl;
            lblDieu.Text = "Điều:";
            lblDieu.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            TextEdit txtDieu = new TextEdit();
            txtDieu.Name = "txtDieu" + soControl;
            txtDieu.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            txtDieu.Width = 50;
            txtDieu.Text = ct.MaDieu;

            LabelControl lblMuc = new LabelControl();
            lblMuc.Name = "lblMuc" + soControl;
            lblMuc.Text = "Mức phạt tiền:";
            lblMuc.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            TextEdit txtMuc = new TextEdit();
            txtMuc.Name = "txtMuc" + soControl;
            txtMuc.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            txtMuc.Width = 200;
            txtMuc.Text = String.Format("{0:#,##0}", ct.MucPhat);
            txtMuc.BackColor = Color.AliceBlue;
            txtMuc.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            txtMuc.Properties.Appearance.TextOptions.VAlignment = VertAlignment.Center;
            // không cho nhập chuỗi - dùng chung 
            txtMuc.KeyPress += txtTongTienPhat_KeyPress;
            //// cập nhật giá trị tiền khi enter
            //txtMuc.KeyDown += txtMuc_KeyDown;

            flowLayoutPanel1.Controls.Add(lblDiem);
            flowLayoutPanel1.Controls.Add(txtDiem);
            flowLayoutPanel1.Controls.Add(lblDieu);
            flowLayoutPanel1.Controls.Add(txtDieu);
            flowLayoutPanel1.Controls.Add(lblKhoan);
            flowLayoutPanel1.Controls.Add(txtKhoan);
            flowLayoutPanel1.Controls.Add(lblMuc);
            flowLayoutPanel1.Controls.Add(txtMuc);
        }
        private void CreateControls()
        {
            soControl++;
            LabelControl lblDiem = new LabelControl();
            lblDiem.Name = "lblDiem" + soControl;
            lblDiem.Text = "+Điểm:";
            lblDiem.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            TextEdit txtDiem = new TextEdit();
            txtDiem.Name = "txtDiem" + soControl;
            txtDiem.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            txtDiem.Width = 50;

            LabelControl lblKhoan = new LabelControl();
            lblKhoan.Name = "lblKhoan" + soControl;
            lblKhoan.Text = "Khoản:";
            lblKhoan.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            TextEdit txtKhoan = new TextEdit();
            txtKhoan.Name = "txtKhoan" + soControl;
            txtKhoan.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            txtKhoan.Width = 50;

            LabelControl lblDieu = new LabelControl();
            lblDieu.Name = "lblDieu" + soControl;
            lblDieu.Text = "Điều:";
            lblDieu.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            TextEdit txtDieu = new TextEdit();
            txtDieu.Name = "txtDieu" + soControl;
            txtDieu.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            txtDieu.Width = 50;

            LabelControl lblMuc = new LabelControl();
            lblMuc.Name = "lblMuc" + soControl;
            lblMuc.Text = "Mức phạt tiền:";
            lblMuc.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            TextEdit txtMuc = new TextEdit();
            txtMuc.Name = "txtMuc" + soControl;
            txtMuc.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            txtMuc.Width = 200;
            //txtMuc.Text = String.Format("{0:0,00}", decimal.Parse("0"));
            txtMuc.BackColor = Color.AliceBlue;
            txtMuc.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            txtMuc.Properties.Appearance.TextOptions.VAlignment = VertAlignment.Center;
            // không cho nhập chuỗi - dùng chung 
            txtMuc.KeyPress += txtTongTienPhat_KeyPress;
            //// cập nhật giá trị tiền khi enter
            //txtMuc.KeyDown += txtMuc_KeyDown;

            flowLayoutPanel1.Controls.Add(lblDiem);
            flowLayoutPanel1.Controls.Add(txtDiem);
            flowLayoutPanel1.Controls.Add(lblDieu);
            flowLayoutPanel1.Controls.Add(txtDieu);
            flowLayoutPanel1.Controls.Add(lblKhoan);
            flowLayoutPanel1.Controls.Add(txtKhoan);
            flowLayoutPanel1.Controls.Add(lblMuc);
            flowLayoutPanel1.Controls.Add(txtMuc);
        }
        private void RemoveControls()
        {
            string so = soControl.ToString();
            int tongControl = flowLayoutPanel1.Controls.Count - 1;
            for (int i = tongControl; i > tongControl - 8; i--)
            {
                try
                {
                    //string MaDiem = "", MaKhoan = "", MaDieu = "";
                    Control c = flowLayoutPanel1.Controls[i];
                    if (c.Name.Contains(so))
                    {
                        //if (c.Name.Contains("txtDiem"))
                        //{
                        //    MaDiem = c.Text.Trim();
                        //}
                        //if (c.Name.Contains("txtKhoan"))
                        //{
                        //    MaKhoan = c.Text.Trim();
                        //}
                        //if (c.Name.Contains("txtDieu"))
                        //{
                        //    MaDieu = c.Text.Trim();
                        //}
                        //if (c.Name.Contains("txtMuc"))
                        //{
                        //    //double tongTienPhat = double.Parse(txtTongTienPhat.Text);
                        //    //double mucPhat = double.Parse(c.Text);
                        //    //tongTienPhat -= mucPhat;
                        //    //txtTongTienPhat.Text = String.Format("{0:0,00}", tongTienPhat);

                        //    string dekq = b_ctqdvphc.Delete(txtSoQD.Text.Trim(),MaDiem,MaKhoan,MaDieu);
                        //    if (dekq != "")
                        //        continue;
                        //}
                        c.Dispose();
                    }
                }
                catch
                {
                    return;
                }
            }

            if (flowLayoutPanel1.Controls.Count % 8 == 0)
                soControl = flowLayoutPanel1.Controls.Count / 8;
        }
        QDVPHCDto TaoQuyetDinh()
        {
            QDVPHCDto bb = new QDVPHCDto();
            bb.SoQD = txtSoQD.Text;
            bb.SoQuyen = txtSoQuyen.Text;
            bb.SoNghiDinh = txtSoNghiDinh.Text;
            bb.NgayNghiDinh = (DateTime)deNgayNghiDinh.EditValue;
            bb.NgayLapQD = (DateTime)deNgapLapQD.EditValue;
            bb.SoBBVPHC = txtSoBBVPHC.Text;
            bb.SoBBGiaiTrinh = txtSoBBGiaiTrinh.Text;
            bb.NgayGiaiTrinh = (DateTime)deNgayBBGiaiTrinh.EditValue;
            bb.SoVBGiaoQuyen = txtSoVBGiaoQuyen.Text;
            bb.NgayGiaoQuyen = (DateTime)deNgayVBGiaoQuyen.EditValue;
            bb.MaNV = cbbNhanVien.EditValue.ToString();
            bb.TTTangGiam = txtTTTangGiam.Text;
            bb.TongTienPhat = decimal.Parse(txtTongTienPhat.Text);
            bb.XuPhatBoSung = txtXuPhatBoSung.Text;
            bb.BPNganChan = txtBPNganChan.Text;
            bb.BPKhacPhuc = txtBPKhacPhuc.Text;
            bb.ChuTheViPham = txtChuThe.Text;
            bb.NgaySinh = (DateTime)deNgaySinh.EditValue;
            bb.QuocTich = txtQuocTich.Text;
            bb.NgheNghiep = txtNgheNghiep.Text;
            bb.DiaChi = txtDiaChi.Text;
            bb.CMND = txtCMND.Text;
            bb.NgayCap = (DateTime)deNgayCap.EditValue;
            bb.NoiCap = txtNoiCap.Text;
            bb.NoiDungVP = txtHanhViViPham.Text;
            bb.NgayHieuLuc = (DateTime)deNgayHieuLuc.EditValue;
            if (txtThoiHanNop.Text == "")
                bb.ThoiHanNop = 0;
            else
                bb.ThoiHanNop = Int32.Parse(txtThoiHanNop.Text);

            bb.GuiDVThuTien = txtGuiDVThuTien.Text;
            bb.GuiCho = txtGuiCho.Text;
            bb.NgayNhap = DateTime.Today;
            bb.NVNhap = "";
            bb.Sta = 1;
            return bb;
        }
        CTQDVPHCDto TaoChiTietQuyetDinh(string MaDiem, string MaKhoan, string MaDieu, string MucPhat)
        {
            CTQDVPHCDto bb = new CTQDVPHCDto();
            bb.SoQDXPVPHC = txtSoQD.Text;
            bb.MaDiem = MaDiem;
            bb.MaKhoan = MaKhoan;
            bb.MaDieu = MaDieu;
            bb.MucPhat = decimal.Parse(MucPhat);
            bb.Sta = 1;
            return bb;
        }
        public void HienThi(QDVPHCDto bb, List<CTQDVPHCDto> list)
        {
            txtSoQuyen.Text = bb.SoQuyen;
            txtSoNghiDinh.Text = bb.SoNghiDinh;
            deNgayNghiDinh.EditValue = bb.NgayNghiDinh;
            deNgapLapQD.EditValue = bb.NgayLapQD;
            txtSoBBVPHC.Text = bb.SoBBVPHC;
            deNgayLapBBVPHC.EditValue = bb.NgayLapBB;
            txtSoBBGiaiTrinh.Text = bb.SoBBGiaiTrinh;
            deNgayBBGiaiTrinh.EditValue = bb.NgayGiaiTrinh;
            txtSoVBGiaoQuyen.Text = bb.SoVBGiaoQuyen;
            deNgayVBGiaoQuyen.EditValue = bb.NgayGiaoQuyen;
            cbbNhanVien.EditValue = bb.MaNV;
            txtTTTangGiam.Text = bb.TTTangGiam;
            txtTongTienPhat.Text = String.Format("{0:#,##0}",bb.TongTienPhat);
            txtXuPhatBoSung.Text = bb.XuPhatBoSung;
            txtBPNganChan.Text = bb.BPNganChan;
            txtBPKhacPhuc.Text = bb.BPKhacPhuc;
            txtChuThe.Text = bb.ChuTheViPham;
            deNgaySinh.EditValue = bb.NgaySinh;
            txtQuocTich.Text = bb.QuocTich;
            txtNgheNghiep.Text = bb.NgheNghiep;
            txtDiaChi.Text = bb.DiaChi;
            txtCMND.Text = bb.CMND;
            deNgayCap.EditValue = bb.NgayCap;
            txtNoiCap.Text = bb.NoiCap;
            txtHanhViViPham.Text = bb.NoiDungVP;
            deNgayHieuLuc.EditValue = bb.NgayHieuLuc;
            txtThoiHanNop.Text = bb.ThoiHanNop.ToString();
            txtGuiDVThuTien.Text = bb.GuiDVThuTien;
            txtGuiCho.Text = bb.GuiCho;
            flowLayoutPanel1.Controls.Clear();
            foreach (CTQDVPHCDto ct in list)
            {
                CreateControlsDetails(ct);
            }
        }
        #endregion

        #region Event xử lý nhập giao diện
        private void txtSoQD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                qdDto = b_qdvphc.GetByID(txtSoQD.Text.Trim());
                List<CTQDVPHCDto> list = b_ctqdvphc.GetList(txtSoQD.Text.Trim());
                if (qdDto == null)
                {
                    XtraMessageBox.Show("Số quyết định vừa nhập không tồn tại", "Thông báo");
                    txtSoQD.Focus();
                    txtSoQD.SelectAll();
                }
                else
                {
                    HienThi(qdDto, list);
                }
            }
        }
        private void txtSoNghiDinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    deNgayNghiDinh.EditValue = b_nd.GetByID(txtSoNghiDinh.Text.Trim()).NgayNghiDinh;
                }
                catch
                {
                    XtraMessageBox.Show("Số nghị định không tồn tại.\nVui lòng nhập lại","Thông báo");
                    txtSoNghiDinh.Focus();
                    txtSoNghiDinh.SelectAll();
                }
            }
        }
        private void txtSoBBGiaiTrinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    deNgayBBGiaiTrinh.EditValue = b_gt.GetByID(txtSoBBGiaiTrinh.Text.Trim()).NgayGiaiTrinh;
                }
                catch
                {
                    XtraMessageBox.Show("Số biên bản giải trình không tồn tại.\nVui lòng nhập lại", "Thông báo");
                    txtSoBBGiaiTrinh.Focus();
                    txtSoBBGiaiTrinh.SelectAll();
                }
            }
        }
        private void txtSoVBGiaoQuyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    deNgayVBGiaoQuyen.EditValue = b_gq.GetByID(txtSoVBGiaoQuyen.Text.Trim()).NgayGiaoQuyen;
                }
                catch
                {
                    XtraMessageBox.Show("Số văn bản giao quyền không tồn tại.\nVui lòng nhập lại", "Thông báo");
                    txtSoVBGiaoQuyen.Focus();
                    txtSoVBGiaoQuyen.SelectAll();
                }
            }
        }
        //void txtMuc_KeyDown(object sender, KeyEventArgs e)
        //{
        //    TextEdit txt= sender as TextEdit;
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        double tongTienPhat = double.Parse(txtTongTienPhat.Text.Trim());
        //        double mucPhat = double.Parse(txt.Text.Trim());
        //        tongTienPhat += mucPhat;
        //        txtTongTienPhat.Text = String.Format("{0:0,00}", tongTienPhat); 
        //    }
        //}
        //không cho nhập chuỗi
        private void txtTongTienPhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cbbNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            b_bbvphc.LoadCapBacDonVi(cbbNhanVien, txtCapBac, txtDonVi);
        }
        private void txtSoBBVPHC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSoBBVPHC.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập số biên bản", "Thông báo");
                    txtSoBBVPHC.Focus();
                    return;
                }
                else
                {
                   BBVPHCDto bb = b_bbvphc.GetByID(txtSoBBVPHC.Text.Trim());
                    ////xử lý
                   if (bb != null)
                   {
                       deNgayLapBBVPHC.EditValue = bb.NgayLapBB;
                       txtChuThe.Text = bb.ChuTheViPham;
                       deNgaySinh.EditValue = bb.NgaySinh;
                       txtQuocTich.Text = bb.QuocTich;
                       txtNgheNghiep.Text = bb.NgheNghiep;
                       txtDiaChi.Text = bb.DiaChi;
                       txtCMND.Text = bb.CMND;
                       deNgayCap.EditValue = bb.NgayCap;
                       txtNoiCap.Text = bb.NoiCap;
                       txtHanhViViPham.Text = bb.NoiDungVP;
                   }
                   else
                   {
                       XtraMessageBox.Show("Biên bản vi phạm hành chính không tìm thấy.\nVui lòng nhập lại","Thông báo");
                       txtSoBBVPHC.Focus();
                       txtSoBBVPHC.SelectAll();
                   }
                }
            }
        }
        private void btnAddControl_Click(object sender, EventArgs e)
        {
            CreateControls();
        }
        private void btnDelControl_Click(object sender, EventArgs e)
        {
            RemoveControls();
            btnTinh_Click(sender, e);
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            double tongTienPhat = 0;
            double mucPhat = 0;
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(TextEdit) && c.Name.Contains("txtMuc"))
                {
                    if (c.Text == "")
                        mucPhat = 0;
                    else
                        mucPhat = double.Parse(c.Text.Trim());
                    tongTienPhat += mucPhat;
                }
                else
                    continue;
            }
            txtTongTienPhat.Text =String.Format("{0:#,##0}", tongTienPhat); 
        }
        #endregion

      
       
    }
}