using QLVPHC.DAL;
using QLVPHC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.BLL
{
    public class B_CTQDVPHC
    {
        QLVPHCEntities context = new QLVPHCEntities();
        public List<CTQDVPHCDto> GetList(string SoQDXPVPHC)
        {
            return context.CTQuyetDinhXPVPHCs.Where(x => x.SoQDXPVPHC == SoQDXPVPHC && x.Sta==1).Select(x => new CTQDVPHCDto
                                                        {
                                                            SoQDXPVPHC = x.SoQDXPVPHC,
                                                            MaDiem = x.MaDiem,
                                                            MaKhoan = x.MaKhoan,
                                                            MaDieu = x.MaDieu,
                                                            MucPhat = x.MucPhat,
                                                            Sta = x.Sta
                                                        }
                                                    ).ToList();
        }
        //public CTQDVPHCDto GetByID(string SoQDXPVPHC)
        //{
        //    CTQuyetDinhXPVPHC bb = context.CTQuyetDinhXPVPHCs.FirstOrDefault(b => b.SoQDXPVPHC == SoQDXPVPHC && b.Sta == 1);
        //    if (bb != null)
        //    {
        //        CTQDVPHCDto bd = new CTQDVPHCDto
        //        {
        //            SoQDXPVPHC = bb.SoQDXPVPHC,
        //            MaDiem = bb.MaDiem,
        //            MaKhoan = bb.MaKhoan,
        //            MaDieu = bb.MaDieu,
        //            MucPhat = bb.MucPhat,
        //            Sta = bb.Sta
        //        };
        //        return bd;
        //    }
        //    else
        //        return null;
        //}
        public string Insert(CTQDVPHCDto x)
        {
            try
            {
                //kiểm tra SoQDXPVPHC có chưa
                CTQuyetDinhXPVPHC bb = context.CTQuyetDinhXPVPHCs.FirstOrDefault(b => b.SoQDXPVPHC == x.SoQDXPVPHC &&
                                                                                      b.MaDiem == x.MaDiem &&
                                                                                      b.MaKhoan == x.MaKhoan &&
                                                                                      b.MaDieu == x.MaDieu);
                if (bb == null) //chưa có SoQDXPVPHC 
                {
                    bb = new CTQuyetDinhXPVPHC
                    {
                        SoQDXPVPHC = x.SoQDXPVPHC,
                        MaDiem = x.MaDiem,
                        MaKhoan = x.MaKhoan,
                        MaDieu = x.MaDieu,
                        MucPhat = x.MucPhat,
                        Sta = 1 //được kích hoạt    
                    };
                    context.CTQuyetDinhXPVPHCs.Add(bb);
                    context.SaveChanges();
                    return "";// "Thêm chi tiết quyết định VPHC thành công";
                }
                else
                {
                    return "Chi tiết quyết định VPHC đã tồn tại";
                }
            }
            catch (Exception ex)
            {
                return "Không thêm được chi tiết quyết định VPHC \n" + ex.Message;
            }
        }
        public string Update(CTQDVPHCDto x)
        {
            try
            {
                CTQuyetDinhXPVPHC bb = context.CTQuyetDinhXPVPHCs.FirstOrDefault(b => b.SoQDXPVPHC == x.SoQDXPVPHC &&
                                                                                  b.MaDiem == x.MaDiem &&
                                                                                  b.MaKhoan == x.MaKhoan &&
                                                                                  b.MaDieu == x.MaDieu);
                if (bb != null)
                {
                    bb.SoQDXPVPHC = x.SoQDXPVPHC;
                    bb.MaDiem = x.MaDiem;
                    bb.MaKhoan = x.MaKhoan;
                    bb.MaDieu = x.MaDieu;
                    bb.MucPhat = x.MucPhat;
                    bb.Sta = 1;
                    context.SaveChanges();
                    return "";// "Cập nhật chi tiết quyết định VPHC thành công";
                }
                else
                    return "Không tìm thấy chi tiết quyết định VPHC: " + x.SoQDXPVPHC;
            }
            catch (Exception ex)
            {
                return "Không cập nhật được chi tiết quyết định VPHC \n" + ex.Message;
            }
        }
        public string Delete(string SoQDXPVPHC, string MaDiem, string MaKhoan, string MaDieu)
        {
            try
            {
                CTQuyetDinhXPVPHC bb = context.CTQuyetDinhXPVPHCs.FirstOrDefault(b => b.SoQDXPVPHC == SoQDXPVPHC &&
                                                                                  b.MaDiem == MaDiem &&
                                                                                  b.MaKhoan == MaKhoan &&
                                                                                  b.MaDieu == MaDieu);
                if (bb != null)
                {
                    bb.Sta = 0; // cập nhật lại trạng thái = 0 nghĩa là đã xóa
                    context.SaveChanges();
                    return "";// "Đã xóa chi tiết quyết định VPHC thành công";
                }
                else
                    return "Không tìm thấy chi tiết quyết định VPHC";
            }
            catch (Exception ex)
            {
                return "Không xóa được chi tiết quyết định VPHC \n" + ex.Message;
            }

        }
    }
}
