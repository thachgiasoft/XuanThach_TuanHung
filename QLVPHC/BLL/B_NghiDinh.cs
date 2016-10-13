using QLVPHC.DAL;
using QLVPHC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.BLL
{
    public class B_NghiDinh
    {
        QLVPHCEntities context = new QLVPHCEntities();
        public List<NghiDinhDto> GetList()
        {
            return context.NghiDinhs.Where(x => x.Sta == 1).Select(x => new NghiDinhDto
                                            {
                                                SoNghiDinh = x.SoNghiDinh,
                                                NgayNghiDinh = x.NgayNghiDinh,
                                                MoTa = x.MoTa,
                                                Sta = x.Sta
                                            }).ToList();
        }
        public NghiDinhDto GetByID(string SoNghiDinh)
        {
            NghiDinh bb = context.NghiDinhs.FirstOrDefault(b => b.SoNghiDinh == SoNghiDinh && b.Sta == 1);
            if (bb != null)
            {
                NghiDinhDto bd = new NghiDinhDto
                {
                    SoNghiDinh = bb.SoNghiDinh,
                    NgayNghiDinh = bb.NgayNghiDinh,
                    MoTa = bb.MoTa,
                    Sta = bb.Sta
                };
                return bd;
            }
            else
                return null;
        }
      
    }
}
