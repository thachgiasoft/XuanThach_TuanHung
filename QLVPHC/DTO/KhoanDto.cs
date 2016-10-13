using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.DTO
{
    public class KhoanDto
    {
        public long Id { get; set; }
        public string MaKhoan { get; set; }
        public long? MaDieu { get; set; }
        public string TenDieu { get; set; }
        public string MoTa { get; set; }
        public string GhiChu { get; set; }
        public bool? IsDelete { get; set; }
    }
}
