using QLVPHC.DAL;
using QLVPHC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.BLL
{
    public class B_QDVPHC
    {
        QLVPHCEntities context = new QLVPHCEntities();
        public List<QDVPHCDto> GetList()
        {
            return context.QuyetDinhXPVPHCs.Where(x=>x.Sta==1).Select(x => new QDVPHCDto
                                                        {
                                                            SoQD=x.SoQD,
                                                            SoQuyen = x.SoQuyen,
                                                            NgayLapQD = x.NgapLapQD,
                                                            SoNghiDinh=x.SoNghiDinh,
                                                            SoBBVPHC = x.SoBBVPHC,
                                                            SoBBGiaiTrinh = x.SoBBGiaiTrinh,
                                                            SoVBGiaoQuyen = x.SoVBGiaoQuyen,
                                                            MaNV = x.MaNV,
                                                            TTTangGiam = x.TTTangGiam,
                                                            TongTienPhat = x.TongTienPhat,
                                                            XuPhatBoSung = x.XuPhatBoSung,
                                                            BPNganChan = x.BPNganChan,
                                                            BPKhacPhuc = x.BPKhacPhuc,
                                                            //ChuTheViPham = x.ChuTheViPham,
                                                            //NgaySinh = x.NgaySinh,
                                                            //QuocTich = x.QuocTich,
                                                            //NgheNghiep = x.NgheNghiep,
                                                            //DiaChi = x.DiaChi,
                                                            //CMND = x.CMND,
                                                            //NgayCap = x.NgayCap,
                                                            //NoiCap = x.NoiCap,
                                                            NgayHieuLuc = x.NgayHieuLuc,
                                                            ThoiHanNop = x.ThoiHanNop,
                                                            GuiDVThuTien = x.GuiDVThuTien,
                                                            GuiCho = x.GuiCho,
                                                            NgayNhap = x.NgayNhap,
                                                            NVNhap = x.NVNhap,
                                                            Sta = x.Sta
                                                        }
                                              ).ToList();
        }
        public QDVPHCDto GetByID(string SoQD)
        {
            QuyetDinhXPVPHC bb = context.QuyetDinhXPVPHCs.FirstOrDefault(b => b.SoQD == SoQD && b.Sta == 1);
            //var bb = context.QuyetDinhXPVPHCs.Include("BienBanVPHC").Where(b => b.SoQD == SoQD && b.Sta == 1).FirstOrDefault();
            // Entity 6.0 context.QuyetDinhXPVPHCs.Include(x=>x.BienBanVPHC)
            // cach thu 2 dung join trong entity

            if (bb != null)
            {
                var bd = new QDVPHCDto
                {
                    SoQD = bb.SoQD,
                    SoQuyen = bb.SoQuyen,
                    NgayLapQD = bb.NgapLapQD,
                    SoNghiDinh = bb.SoNghiDinh,
                    NgayNghiDinh= bb.NghiDinh.NgayNghiDinh,
                    SoBBVPHC = bb.SoBBVPHC,
                    NgayLapBB=bb.BienBanVPHC.NgayLapBB,
                    SoBBGiaiTrinh = bb.SoBBGiaiTrinh,
                    NgayGiaiTrinh = bb.GiaiTrinh.NgayGiaiTrinh,
                    SoVBGiaoQuyen = bb.SoVBGiaoQuyen,
                    NgayGiaoQuyen = bb.GiaoQuyen.NgayGiaoQuyen,
                    MaNV = bb.MaNV,

                    ChuTheViPham = bb.BienBanVPHC.ChuTheViPham,
                    NgaySinh = bb.BienBanVPHC.NgaySinh,
                    QuocTich = bb.BienBanVPHC.QuocTich,
                    NgheNghiep = bb.BienBanVPHC.NgheNghiep,
                    DiaChi = bb.BienBanVPHC.DiaChi,
                    CMND = bb.BienBanVPHC.CMND,
                    NgayCap = bb.BienBanVPHC.NgayCap,
                    NoiCap = bb.BienBanVPHC.NoiCap,
                    NoiDungVP=bb.BienBanVPHC.NoiDungVP,

                    TTTangGiam = bb.TTTangGiam,
                    TongTienPhat = bb.TongTienPhat,
                    XuPhatBoSung =bb.XuPhatBoSung,
                    BPNganChan = bb.BPNganChan,
                    BPKhacPhuc = bb.BPKhacPhuc,
                    
                    NgayHieuLuc = bb.NgayHieuLuc,
                    ThoiHanNop = bb.ThoiHanNop,
                    GuiDVThuTien = bb.GuiDVThuTien,
                    GuiCho = bb.GuiCho,
                    NgayNhap = bb.NgayNhap,
                    NVNhap = bb.NVNhap,
                    Sta = bb.Sta
                };
                return bd;
            }
            else
                return null;
        }
        public string Insert(QDVPHCDto x)
        {
            try
            {
                //kiểm tra SoQD có chưa
                QuyetDinhXPVPHC bb = context.QuyetDinhXPVPHCs.FirstOrDefault(b => b.SoQD == x.SoQD);
                if (bb == null) //chưa có SoQD 
                {
                    bb = new QuyetDinhXPVPHC
                    {
                        SoQD = x.SoQD,
                        SoQuyen = x.SoQuyen,
                        NgapLapQD = x.NgayLapQD,
                        SoNghiDinh = x.SoNghiDinh,
                        SoBBVPHC = x.SoBBVPHC,
                        SoBBGiaiTrinh = x.SoBBGiaiTrinh,
                        SoVBGiaoQuyen = x.SoVBGiaoQuyen,
                        MaNV = x.MaNV,
                        TTTangGiam = x.TTTangGiam,
                        TongTienPhat = x.TongTienPhat,
                        XuPhatBoSung = x.XuPhatBoSung,
                        BPNganChan = x.BPNganChan,
                        BPKhacPhuc = x.BPKhacPhuc,
                        //ChuTheViPham = x.ChuTheViPham,
                        //NgaySinh = x.NgaySinh,
                        //QuocTich = x.QuocTich,
                        //NgheNghiep = x.NgheNghiep,
                        //DiaChi = x.DiaChi,
                        //CMND = x.CMND,
                        //NgayCap = x.NgayCap,
                        //NoiCap = x.NoiCap,
                        NgayHieuLuc = x.NgayHieuLuc,
                        ThoiHanNop = x.ThoiHanNop,
                        GuiDVThuTien = x.GuiDVThuTien,
                        GuiCho = x.GuiCho,
                        NgayNhap = x.NgayNhap,
                        NVNhap = x.NVNhap,
                        Sta = 1 //được kích hoạt    
                    };
                    context.QuyetDinhXPVPHCs.Add(bb);
                    context.SaveChanges();
                    return "";// "Thêm quyết định VPHC thành công";
                }
                else
                {
                    return "Quyết định VPHC đã tồn tại";
                }
            }
            catch (Exception ex)
            {
                return "Không thêm được quyết định VPHC \n" + ex.Message;
            }
        }
        public string Update(QDVPHCDto x)
        {
            try
            {
                QuyetDinhXPVPHC bb = context.QuyetDinhXPVPHCs.FirstOrDefault(b => b.SoQD == x.SoQD);
                if (bb != null)
                {
                    bb.SoQD = x.SoQD;
                    bb.SoQuyen = x.SoQuyen;
                    bb.NgapLapQD = x.NgayLapQD;
                    bb.SoNghiDinh = x.SoNghiDinh;
                    bb.SoBBVPHC = x.SoBBVPHC;
                    bb.SoBBGiaiTrinh = x.SoBBGiaiTrinh;
                    bb.SoVBGiaoQuyen = x.SoVBGiaoQuyen;
                    bb.MaNV = x.MaNV;
                    bb.TTTangGiam = x.TTTangGiam;
                    bb.TongTienPhat = x.TongTienPhat;
                    bb.XuPhatBoSung = x.XuPhatBoSung;
                    bb.BPNganChan = x.BPNganChan;
                    bb.BPKhacPhuc = x.BPKhacPhuc;
                    //ChuTheViPham = x.ChuTheViPham,
                    //NgaySinh = x.NgaySinh,
                    //QuocTich = x.QuocTich,
                    //NgheNghiep = x.NgheNghiep,
                    //DiaChi = x.DiaChi,
                    //CMND = x.CMND,
                    //NgayCap = x.NgayCap,
                    //NoiCap = x.NoiCap,
                    bb.NgayHieuLuc = x.NgayHieuLuc;
                    bb.ThoiHanNop = x.ThoiHanNop;
                    bb.GuiDVThuTien = x.GuiDVThuTien;
                    bb.GuiCho = x.GuiCho;
                    bb.NgayNhap = x.NgayNhap;
                    bb.NVNhap = x.NVNhap;
                    bb.Sta = 1;
                    context.SaveChanges();
                    return "";// "Cập nhật quyết định VPHC thành công";
                }
                else
                    return "Không tìm thấy quyết định VPHC: " + x.SoBBVPHC;
            }
            catch (Exception ex)
            {
                return "Không cập nhật được quyết định VPHC \n" + ex.Message;
            }
        }
        public string Delete(string SoQD)
        {
            try
            {
                QuyetDinhXPVPHC bb = context.QuyetDinhXPVPHCs.FirstOrDefault(b => b.SoQD == SoQD);
                if (bb != null)
                {
                    bb.Sta = 0; // cập nhật lại trạng thái = 0 nghĩa là đã xóa
                    context.SaveChanges();
                    return "";// "Đã xóa quyết định VPHC thành công";
                }
                else
                    return "Không tìm thấy quyết định VPHC: " + SoQD;
            }
            catch (Exception ex)
            {
                return "Không xóa được quyết định VPHC \n" + ex.Message;
            }

        }
    }
}
