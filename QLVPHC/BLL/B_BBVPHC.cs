using DevExpress.XtraEditors;
using QLVPHC.DAL;
using QLVPHC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.BLL
{
    public class B_BBVPHC
    {
        QLVPHCEntities context = new QLVPHCEntities();
        public List<BBVPHCDto> GetList()
        {
            return context.BienBanVPHCs.Where(x => x.Sta == 1).Select(x => new BBVPHCDto
                                                    {
                                                        SoBBVPHC = x.SoBBVPHC,
                                                        SoQuyen = x.SoQuyen,
                                                        VeViecLapBB = x.VeViecLapBB,
                                                        CanCuLapBB = x.CanCuLapBB,
                                                        GioLapBB = x.GioLapBB,
                                                        PhutLapBB = x.PhutLapBB,
                                                        NgayLapBB = x.NgayLapBB,
                                                        DiaDiemLapBB = x.DiaDiemLapBB,
                                                        MaNV1 = x.MaNV1,
                                                        MaNV2 = x.MaNV2,
                                                        ChuTheViPham = x.ChuTheViPham,
                                                        NgaySinh = x.NgaySinh,
                                                        QuocTich = x.QuocTich,
                                                        NgheNghiep = x.NgheNghiep,
                                                        DiaChi = x.DiaChi,
                                                        CMND = x.CMND,
                                                        NgayCap = x.NgayCap,
                                                        NoiCap = x.NoiCap,
                                                        NoiDungVP = x.NoiDungVP,
                                                        LoiKhaiNguoiVP = x.LoiKhaiNguoiVP,
                                                        LoiKhaiNhanChung = x.LoiKhaiNhanChung,
                                                        BienPhap = x.BienPhap,
                                                        TangVatTamGiu = x.TangVatTamGiu,
                                                        GioHen = x.GioHen,
                                                        PhutHen = x.PhutHen,
                                                        NgayHen = x.NgayHen,
                                                        DiaDiemHen = x.DiaDiemHen,
                                                        GioXongBB = x.GioXongBB,
                                                        PhutXongBB = x.PhutXongBB,
                                                        NgayXongBB = x.NgayXongBB,
                                                        LyDoKhongKyBB = x.LyDoKhongKyBB,
                                                        NguoiLapBB = x.NguoiLapBB,
                                                        NVNhap = x.NVNhap,
                                                        Sta = x.Sta
                                                    }
                                              ).ToList();
        }
        public BBVPHCDto GetByID(string SoBBVPHC)
        {
            BienBanVPHC bb = context.BienBanVPHCs.FirstOrDefault(b => b.SoBBVPHC == SoBBVPHC && b.Sta==1);
            if (bb != null)
            {
                BBVPHCDto bd = new BBVPHCDto
                {
                    SoBBVPHC = bb.SoBBVPHC,
                    SoQuyen = bb.SoQuyen,
                    VeViecLapBB = bb.VeViecLapBB,
                    CanCuLapBB = bb.CanCuLapBB,
                    GioLapBB = bb.GioLapBB,
                    PhutLapBB = bb.PhutLapBB,
                    NgayLapBB = bb.NgayLapBB,
                    DiaDiemLapBB = bb.DiaDiemLapBB,
                    MaNV1 = bb.MaNV1,
                    MaNV2 = bb.MaNV2,
                    ChuTheViPham = bb.ChuTheViPham,
                    NgaySinh = bb.NgaySinh,
                    QuocTich = bb.QuocTich,
                    NgheNghiep = bb.NgheNghiep,
                    DiaChi = bb.DiaChi,
                    CMND = bb.CMND,
                    NgayCap = bb.NgayCap,
                    NoiCap = bb.NoiCap,
                    NoiDungVP = bb.NoiDungVP,
                    LoiKhaiNguoiVP = bb.LoiKhaiNguoiVP,
                    LoiKhaiNhanChung = bb.LoiKhaiNhanChung,
                    BienPhap = bb.BienPhap,
                    TangVatTamGiu = bb.TangVatTamGiu,
                    GioHen = bb.GioHen,
                    PhutHen = bb.PhutHen,
                    NgayHen = bb.NgayHen,
                    DiaDiemHen = bb.DiaDiemHen,
                    GioXongBB = bb.GioXongBB,
                    PhutXongBB = bb.PhutXongBB,
                    NgayXongBB = bb.NgayXongBB,
                    LyDoKhongKyBB = bb.LyDoKhongKyBB,
                    NguoiLapBB = bb.NguoiLapBB,
                    NVNhap = bb.NVNhap,
                    Sta = bb.Sta
                };
                return bd;
            }
            else
                return null;
        }
        public string Insert(BBVPHCDto bd)
        {
            try
            {
                //kiểm tra SoBBVPHC có chưa
                BienBanVPHC bb = context.BienBanVPHCs.FirstOrDefault(b => b.SoBBVPHC == bd.SoBBVPHC);
                if (bb == null) //chưa có SoBBVPHC 
                {
                    bb = new BienBanVPHC
                    {
                        SoBBVPHC = bd.SoBBVPHC,
                        SoQuyen = bd.SoQuyen,
                        VeViecLapBB = bd.VeViecLapBB,
                        CanCuLapBB = bd.CanCuLapBB,
                        GioLapBB = bd.GioLapBB,
                        PhutLapBB = bd.PhutLapBB,
                        NgayLapBB = bd.NgayLapBB,
                        DiaDiemLapBB = bd.DiaDiemLapBB,
                        MaNV1 = bd.MaNV1,
                        MaNV2 = bd.MaNV2,
                        ChuTheViPham = bd.ChuTheViPham,
                        NgaySinh = bd.NgaySinh,
                        QuocTich = bd.QuocTich,
                        NgheNghiep = bd.NgheNghiep,
                        DiaChi = bd.DiaChi,
                        CMND = bd.CMND,
                        NgayCap = bd.NgayCap,
                        NoiCap = bd.NoiCap,
                        NoiDungVP = bd.NoiDungVP,
                        LoiKhaiNguoiVP = bd.LoiKhaiNguoiVP,
                        LoiKhaiNhanChung = bd.LoiKhaiNhanChung,
                        BienPhap = bd.BienPhap,
                        TangVatTamGiu = bd.TangVatTamGiu,
                        GioHen = bd.GioHen,
                        PhutHen = bd.PhutHen,
                        NgayHen = bd.NgayHen,
                        DiaDiemHen = bd.DiaDiemHen,
                        GioXongBB = bd.GioXongBB,
                        PhutXongBB = bd.PhutXongBB,
                        NgayXongBB = bd.NgayXongBB,
                        LyDoKhongKyBB = bd.LyDoKhongKyBB,
                        NguoiLapBB = bd.NguoiLapBB,
                        NVNhap = bd.NVNhap,
                        Sta = 1 //được kích hoạt     (short)bd.Sta
                    };
                    context.BienBanVPHCs.Add(bb);
                    context.SaveChanges();
                    return "";// "Thêm biên bản VPHC thành công";
                }
                else
                {
                    return "Biên bản VPHC đã tồn tại";
                }
            }
            catch (Exception ex)
            {
                return "Không thêm được biên bản VPHC \n" + ex.Message;
            }
        }
        public string Update(BBVPHCDto bd)
        { 
            try
            {
                BienBanVPHC bb = context.BienBanVPHCs.FirstOrDefault(b => b.SoBBVPHC == bd.SoBBVPHC);
                if (bb != null)
                {
                    bb.SoQuyen = bd.SoQuyen;
                    bb.VeViecLapBB = bd.VeViecLapBB;
                    bb.CanCuLapBB = bd.CanCuLapBB;
                    bb.GioLapBB = bd.GioLapBB;
                    bb.PhutLapBB = bd.PhutLapBB;
                    bb.NgayLapBB = bd.NgayLapBB;
                    bb.DiaDiemLapBB = bd.DiaDiemLapBB;
                    bb.MaNV1 = bd.MaNV1;
                    bb.MaNV2 = bd.MaNV2;
                    bb.ChuTheViPham = bd.ChuTheViPham;
                    bb.NgaySinh = bd.NgaySinh;
                    bb.QuocTich = bd.QuocTich;
                    bb.NgheNghiep = bd.NgheNghiep;
                    bb.DiaChi = bd.DiaChi;
                    bb.CMND = bd.CMND;
                    bb.NgayCap = bd.NgayCap;
                    bb.NoiCap = bd.NoiCap;
                    bb.NoiDungVP = bd.NoiDungVP;
                    bb.LoiKhaiNguoiVP = bd.LoiKhaiNguoiVP;
                    bb.LoiKhaiNhanChung = bd.LoiKhaiNhanChung;
                    bb.BienPhap = bd.BienPhap;
                    bb.TangVatTamGiu = bd.TangVatTamGiu;
                    bb.GioHen = bd.GioHen;
                    bb.PhutHen = bd.PhutHen;
                    bb.NgayHen = bd.NgayHen;
                    bb.DiaDiemHen = bd.DiaDiemHen;
                    bb.GioXongBB = bd.GioXongBB;
                    bb.PhutXongBB = bd.PhutXongBB;
                    bb.NgayXongBB = bd.NgayXongBB;
                    bb.LyDoKhongKyBB = bd.LyDoKhongKyBB;
                    bb.NguoiLapBB = bd.NguoiLapBB;
                    bb.NVNhap = bd.NVNhap;
                    bb.Sta = 1; //(short)bd.Sta;
                    context.SaveChanges();
                    return "";// "Cập nhật biên bản VPHC thành công";
                }
                else
                    return "Không tìm thấy biên bản VPHC: "+bd.SoBBVPHC;
            }
            catch (Exception ex)
            {
                return "Không cập nhật được biên bản VPHC \n" + ex.Message;
            }
        }
        public string Delete(string SoBBVPHC)
        {
            try
            {
                BienBanVPHC bb = context.BienBanVPHCs.FirstOrDefault(b => b.SoBBVPHC == SoBBVPHC);
                if (bb != null)
                {
                    bb.Sta = 0; // cập nhật lại trạng thái = 0 nghĩa là đã xóa
                    context.SaveChanges();
                    return "";// "Đã xóa biên bản VPHC thành công";
                }
                else
                    return "Không tìm thấy biên bản VPHC: "+SoBBVPHC;
            }
            catch (Exception ex)
            {
                return "Không xóa được biên bản VPHC \n" + ex.Message;
            }

        }
        public void LoadCapBacDonVi(LookUpEdit cbb, TextEdit txtCB, TextEdit txtDV)
        {
            var a = context.NhanViens.Where(x => x.IsDelete == true && x.MaNV == cbb.EditValue.ToString())
                                     .Select(x => new NhanVienInfo()
                                                {
                                                    TenCV = x.ChucVu.TenCV,
                                                    TenPB = x.PhongBan.TenPB
                                                }
                                            ).FirstOrDefault();
            txtCB.Text = a.TenCV;
            txtDV.Text = a.TenPB;
        }
    }
}
