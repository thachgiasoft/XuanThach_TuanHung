using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.DTO
{
    public class DieuDto
    {
        public long Id { get; set; }
        public string MaDieu { get; set; }
        public string MoTa { get; set; }
        public string GhiChu { get; set; }
        public bool? IsDelete { get; set; }
    }

    public class DieuLoopkup
    {
        public long Id { get; set; }

        [DisplayName("Mã điều")]
        public string MaDieu { get; set; }

        [DisplayName("Mô tả")]
        public string MoTa { get; set; }
    }
}
