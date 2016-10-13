using QLVPHC.DAL;
using QLVPHC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.BLL
{
    public class B_ChucVu
    {
        QLVPHCEntities context = new QLVPHCEntities();
        public List<ChucVuDto> GetList()
        {
            return context.ChucVus.Where(x => x.IsDelete == false).Select(x => new ChucVuDto
                                                    {
                                                        Id = x.Id,
                                                        MaCV = x.MaCV,
                                                        TenCV = x.TenCV,
                                                        IsDelete = x.IsDelete
                                                    }).ToList();
        }
    }
}
