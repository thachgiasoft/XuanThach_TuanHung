using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.DTO
{
    public class QDVPHCDto
    {
        public string SoQD { get; set; }
        public string SoQuyen { get; set; }
        public DateTime? NgayLapQD { get; set; }
        public string SoNghiDinh { get; set; }
        public string SoBBVPHC { get; set; }
        public DateTime? NgayLapBB { get; set; }
        public string SoBBGiaiTrinh { get; set; }
        public string SoVBGiaoQuyen { get; set; }
        public string MaNV { get; set; }
        public string TTTangGiam { get; set; }
        public decimal? TongTienPhat { get; set; }
        public string XuPhatBoSung { get; set; }

        public string BPNganChan { get; set; }
        public string BPKhacPhuc { get; set; }
        public DateTime? NgayHieuLuc { get; set; }
        public int? ThoiHanNop { get; set; }
        public string GuiDVThuTien { get; set; }
        public string GuiCho { get; set; }
        public DateTime? NgayNhap { get; set; }
        public string NVNhap { get; set; }
        public int? Sta { get; set; }
        public DateTime? NgayNghiDinh { get; set; }
        public DateTime? NgayGiaiTrinh { get; set; }
        public DateTime? NgayGiaoQuyen { get; set; }
        public string ChuTheViPham { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string QuocTich { get; set; }
        public string NgheNghiep { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
        public DateTime? NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string NoiDungVP { get; set; }
    }
}
