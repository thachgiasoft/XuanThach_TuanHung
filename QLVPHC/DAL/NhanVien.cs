//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLVPHC.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        public int Id { get; set; }
        public string MaNV { get; set; }
        public Nullable<int> MaCV { get; set; }
        public Nullable<int> MaPB { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public Nullable<System.DateTime> NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string Email { get; set; }
        public string TenDN { get; set; }
        public string MatKhau { get; set; }
        public Nullable<int> MaQuyen { get; set; }
        public byte[] AnhDaiDien { get; set; }
        public string GhiChu { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        public virtual ChucVu ChucVu { get; set; }
        public virtual PhongBan PhongBan { get; set; }
        public virtual Quyen Quyen { get; set; }
    }
}
