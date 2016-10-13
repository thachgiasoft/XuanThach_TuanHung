using QLVPHC.DAL;
using QLVPHC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.BLL
{
    public class B_GiaoQuyen
    {
        QLVPHCEntities context = new QLVPHCEntities();
        public List<GiaoQuyenDto> GetList()
        {
            return context.GiaoQuyens.Where(x => x.Sta == 1).Select(x => new GiaoQuyenDto
            {
                SoGiaoQuyen = x.SoGiaoQuyen,
                NgayGiaoQuyen = x.NgayGiaoQuyen,
                MoTa = x.MoTa,
                Sta = x.Sta
            }).ToList();
        }
        public GiaoQuyenDto GetByID(string SoGiaoQuyen)
        {
            GiaoQuyen bb = context.GiaoQuyens.FirstOrDefault(b => b.SoGiaoQuyen == SoGiaoQuyen && b.Sta == 1);
            if (bb != null)
            {
                GiaoQuyenDto bd = new GiaoQuyenDto
                {
                    SoGiaoQuyen = bb.SoGiaoQuyen,
                    NgayGiaoQuyen = bb.NgayGiaoQuyen,
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
