using QLVPHC.DAL;
using QLVPHC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.BLL
{
    public class B_PhongBan
    {
        QLVPHCEntities context = new QLVPHCEntities();
        public List<PhongBanDto> GetList()
        {
            return context.PhongBans.Where(x => x.IsDelete == false).Select(x => new PhongBanDto
            {
                Id = x.Id,
                MaPB = x.MaPB,
                TenPB = x.TenPB,
                IsDelete = x.IsDelete
            }).ToList();
        }
    }
}
