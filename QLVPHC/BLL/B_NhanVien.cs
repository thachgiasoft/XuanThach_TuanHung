using DevExpress.XtraEditors;
using QLVPHC.DAL;
using QLVPHC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.BLL
{
    public class B_NhanVien
    {
        QLVPHCEntities context = new QLVPHCEntities();
        public List<NhanVienDto> GetList()
        {
            return context.NhanViens.Where(x => x.IsDelete == false).Select(x => new NhanVienDto
                                                {
                                                    Id = x.Id,
                                                    MaNV = x.MaNV,
                                                    MaCV = x.MaCV,
                                                    MaPB = x.MaPB,
                                                    Ho = x.Ho,
                                                    Ten = x.Ten,
                                                    NamSinh = x.NamSinh,
                                                    GioiTinh = x.GioiTinh,
                                                    DiaChi = x.DiaChi,
                                                    SoDT = x.SoDT,
                                                    Email = x.Email,
                                                    TenDN = x.TenDN,
                                                    MatKhau = x.MatKhau,
                                                    MaQuyen = x.MaQuyen,
                                                    AnhDaiDien = (byte[])x.AnhDaiDien,
                                                    GhiChu = x.GhiChu,
                                                    IsDelete = x.IsDelete
                                                }
                                            ).ToList();
        }
        public void LoadCbbNhanVien(LookUpEdit cbb)
        {
            cbb.Properties.DataSource = context.NhanViens.Where(x => x.IsDelete == true)
                                                                  .Select(x => new
                                                                  {
                                                                      MaNV = x.MaNV,
                                                                      HoTen = x.Ho + " " + x.Ten
                                                                  }
                                        ).ToList();
            cbb.Properties.ValueMember = "MaNV";
            cbb.Properties.DisplayMember = "HoTen";
        }
    }
}
