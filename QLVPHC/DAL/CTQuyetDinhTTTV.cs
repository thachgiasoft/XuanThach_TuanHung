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
    
    public partial class CTQuyetDinhTTTV
    {
        public int Id { get; set; }
        public string SoQDTTTV { get; set; }
        public string TenTangVat { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string DVTinh { get; set; }
        public string MoTa { get; set; }
        public string GhiChu { get; set; }
    
        public virtual QuyetDinhTTTV QuyetDinhTTTV { get; set; }
    }
}
