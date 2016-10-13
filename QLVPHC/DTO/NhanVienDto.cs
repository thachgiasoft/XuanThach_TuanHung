using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.DTO
{
    public class NhanVienDto
    {
        public long Id { get; set; }
        public string MaNV { get; set; }
        public int? MaCV { get; set; }
        public int? MaPB { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime? NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string Email { get; set; }
        public string TenDN { get; set; }
        public string MatKhau { get; set; }
        public int? MaQuyen { get; set; }
        public byte[] AnhDaiDien { get; set; }
        public string GhiChu { get; set; }
        public bool? IsDelete { get; set; }
    }
}
