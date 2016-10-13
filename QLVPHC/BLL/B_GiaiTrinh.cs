using QLVPHC.DAL;
using QLVPHC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.BLL
{
    public class B_GiaiTrinh
    {
        QLVPHCEntities context = new QLVPHCEntities();
        public List<GiaiTrinhDto> GetList()
        {
            return context.GiaiTrinhs.Where(x => x.Sta == 1).Select(x => new GiaiTrinhDto
            {
                SoGiaiTrinh = x.SoGiaiTrinh,
                NgayGiaiTrinh = x.NgayGiaiTrinh,
                MoTa = x.MoTa,
                Sta = x.Sta
            }).ToList();
        }
        public GiaiTrinhDto GetByID(string SoGiaiTrinh)
        {
            GiaiTrinh bb = context.GiaiTrinhs.FirstOrDefault(b => b.SoGiaiTrinh == SoGiaiTrinh && b.Sta == 1);
            if (bb != null)
            {
                GiaiTrinhDto bd = new GiaiTrinhDto
                {
                    SoGiaiTrinh = bb.SoGiaiTrinh,
                    NgayGiaiTrinh = bb.NgayGiaiTrinh,
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
