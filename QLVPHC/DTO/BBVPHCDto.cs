using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVPHC.DTO
{
    public class BBVPHCDto
    {
        public string SoBBVPHC { get; set; }
        public string SoQuyen { get; set; }
        public string VeViecLapBB { get; set; }
        public string CanCuLapBB { get; set; }
        public string GioLapBB { get; set; }
        public string PhutLapBB { get; set; }
        public DateTime? NgayLapBB { get; set; }
        public string DiaDiemLapBB { get; set; }
        public string MaNV1 { get; set; }
        public string MaNV2 { get; set; }
        public string ChuTheViPham { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string QuocTich { get; set; }
        public string NgheNghiep { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
        public DateTime? NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string NoiDungVP { get; set; }
        public string LoiKhaiNguoiVP { get; set; }
        public string LoiKhaiNhanChung { get; set; }
        public string BienPhap { get; set; }
        public string TangVatTamGiu { get; set; }
        public string GioHen { get; set; }
        public string PhutHen { get; set; }
        public DateTime? NgayHen { get; set; }
        public string DiaDiemHen { get; set; }
        public string GioXongBB { get; set; }
        public string PhutXongBB { get; set; }
        public DateTime? NgayXongBB { get; set; }
        public string LyDoKhongKyBB { get; set; }
        public string NguoiLapBB { get; set; }
        public string NVNhap { get; set; }
        public int? Sta { get; set; }
    }

    public class NhanVienInfo
    {
        public string TenCV { get; set; }
        public string TenPB { get; set; }
    }
}
