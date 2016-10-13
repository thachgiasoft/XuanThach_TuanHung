using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.DTO
{
    public class ChucVuDto
    {
        public long Id { get; set; }
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public string GhiChu { get; set; }
        public bool? IsDelete { get; set; }
    }
}
