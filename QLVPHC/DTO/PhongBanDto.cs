using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.DTO
{
    public class PhongBanDto
    {
        public long Id { get; set; }
        public string MaPB { get; set; }
        public string TenPB { get; set; }
        public string GhiChu { get; set; }
        public bool? IsDelete { get; set; }
    }
}
