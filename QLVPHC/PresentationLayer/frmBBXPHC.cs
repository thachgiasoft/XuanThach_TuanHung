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
    public partial class frmBBXPHC : DevExpress.XtraEditors.XtraForm
    {
        string SoBBVPHC;
        B_BBVPHC b_bbvphc = new B_BBVPHC();
        B_NhanVien b_nv = new B_NhanVien();
        QLVPHCEntities context = new QLVPHCEntities();
        public frmBBXPHC(string SoBBVPHC)
        {
            InitializeComponent();
            this.SoBBVPHC = SoBBVPHC;
        }
        public frmBBXPHC()
        {
            InitializeComponent();
        }
        private void frmBBXPHC_Load(object sender, EventArgs e)
        {
            b_nv.LoadCbbNhanVien(cbbNhanVien1);
            b_nv.LoadCbbNhanVien(cbbNhanVien2);
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
                else if (c.GetType() == typeof(LookUpEdit))
                {
                    c.Text = DateTime.Today.ToShortDateString();
                }
            }
            txtSoBBVPHC.Focus();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSoBBVPHC.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập số biên bản", "Thông báo");
                txtSoBBVPHC.Focus();
                return;
            }
            if (txtQuyenSo.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống số quyển", "Thông báo");
                txtQuyenSo.Focus();
                return;
            }
            if (cbbNhanVien1.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống nhân viên", "Thông báo");
                cbbNhanVien1.Focus();
                return;
            }
            if (cbbNhanVien2.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống nhân viên", "Thông báo");
                cbbNhanVien2.Focus();
                return;
            }
            if (txtChuTheViPham.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống chủ thể vi phạm", "Thông báo");
                txtChuTheViPham.Focus();
                return;
            }
            if (mmNoiDungVP.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống nội dung vi phạm", "Thông báo");
                mmNoiDungVP.Focus();
                return;
            }

            string kq = b_bbvphc.Insert(TaoBienBan());
            if (kq != "")
            {
                XtraMessageBox.Show(kq, "Thông báo");
                txtSoBBVPHC.SelectAll();
                txtSoBBVPHC.Focus();
                return;
            }
            else
            {
                XtraMessageBox.Show("Thêm biên bản VPHC thành công", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoBBVPHC.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập số biên bản", "Thông báo");
                txtSoBBVPHC.Focus();
                return;
            }
            if (txtQuyenSo.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống số quyển", "Thông báo");
                txtQuyenSo.Focus();
                return;
            }
            if (cbbNhanVien1.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống nhân viên", "Thông báo");
                cbbNhanVien1.Focus();
                return;
            }
            if (cbbNhanVien2.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống nhân viên", "Thông báo");
                cbbNhanVien2.Focus();
                return;
            }
            if (txtChuTheViPham.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống chủ thể vi phạm", "Thông báo");
                txtChuTheViPham.Focus();
                return;
            }
            if (mmNoiDungVP.Text == "")
            {
                XtraMessageBox.Show("Vui lòng không để trống nội dung vi phạm", "Thông báo");
                mmNoiDungVP.Focus();
                return;
            }
            string soBB = txtSoBBVPHC.Text.Trim();
            string kq = b_bbvphc.Update(TaoBienBan());
            if (kq != "")
            {
                XtraMessageBox.Show(kq, "Thông báo");
                txtSoBBVPHC.SelectAll();
                txtSoBBVPHC.Focus();
                return;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật biên bản VPHC thành công", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSoBBVPHC.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập số biên bản cần xóa","Thông báo");
                txtSoBBVPHC.Focus();
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa biên bản VPHC này?", "Chú ý",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string soBB = txtSoBBVPHC.Text.Trim();
                string kq = b_bbvphc.Delete(soBB);
                if (kq != "")
                {
                    XtraMessageBox.Show(kq, "Thông báo");
                    txtSoBBVPHC.SelectAll();
                    txtSoBBVPHC.Focus();
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Đã xóa biên bản VPHC thành công", "Thông báo");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hàm
        BBVPHCDto TaoBienBan()
        {
            BBVPHCDto bb = new BBVPHCDto();
            bb.SoBBVPHC = txtSoBBVPHC.Text;
            bb.SoQuyen = txtQuyenSo.Text;
            bb.VeViecLapBB = txtVeViecLapBB.Text;
            bb.CanCuLapBB = txtCanCuLapBB.Text;
            bb.GioLapBB = txtGioLapBB.Text;
            bb.PhutLapBB = txtPhutLapBB.Text;
            bb.NgayLapBB = (DateTime)deNgayLapBB.EditValue;
            bb.DiaDiemLapBB = txtDiaDiemLapBB.Text;
            bb.MaNV1 = cbbNhanVien1.EditValue.ToString();
            bb.MaNV2 = cbbNhanVien2.EditValue.ToString();
            bb.ChuTheViPham = txtChuTheViPham.Text;
            bb.NgaySinh = (DateTime)deNgaySinh.EditValue;
            bb.QuocTich = txtQuocTich.Text;
            bb.NgheNghiep = txtNgheNghiep.Text;
            bb.DiaChi = txtDiaChi.Text;
            bb.CMND = txtCMND.Text;
            bb.NgayCap = (DateTime)deNgayCap.EditValue;
            bb.NoiCap = txtNoiCap.Text;
            bb.NoiDungVP = mmNoiDungVP.Text;
            bb.LoiKhaiNguoiVP = mmLoiKhaiNguoiVP.Text;
            bb.LoiKhaiNhanChung = mmLoiKhaiNhanChung.Text;
            bb.BienPhap = mmBienPhap.Text;
            bb.TangVatTamGiu = mmTangVatTamGiu.Text;
            bb.GioHen = txtGioHen.Text;
            bb.PhutHen = txtPhutHen.Text;
            bb.NgayHen = (DateTime)deNgayHen.EditValue;
            bb.DiaDiemHen = txtDiaDiemHen.Text;
            bb.GioXongBB = txtGioXongBB.Text;
            bb.PhutXongBB = txtPhutXongBB.Text;
            bb.NgayXongBB = (DateTime)deNgayXongBB.EditValue;
            bb.LyDoKhongKyBB = txtLyDoKhongKyBB.Text;
            bb.NguoiLapBB = cbbNhanVien1.EditValue.ToString();
            bb.NVNhap = "";
            bb.Sta = 1;
            return bb;
        }
        
        #endregion

        #region Event xử lý nhập giao diện
        //không cho nhập chuỗi
        private void txtGioLapBB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbNhanVien1_EditValueChanged(object sender, EventArgs e)
        {
            b_bbvphc.LoadCapBacDonVi(cbbNhanVien1, txtCapBac1, txtDonVi1);
        }

        private void cbbNhanVien2_EditValueChanged(object sender, EventArgs e)
        {
            b_bbvphc.LoadCapBacDonVi(cbbNhanVien2, txtCapBac2, txtDonVi2);
        }
        #endregion
    }
}