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
    
    public partial class QuyetDinhTTTV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuyetDinhTTTV()
        {
            this.CTQuyetDinhTTTVs = new HashSet<CTQuyetDinhTTTV>();
        }
    
        public string SoQDTT { get; set; }
        public string SoBBVPHC { get; set; }
        public string MaNV { get; set; }
        public Nullable<System.DateTime> NgayLapQD { get; set; }
        public string NVThucHien { get; set; }
        public string MaKhoan { get; set; }
        public string MaDieu { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public string NVNhap { get; set; }
        public Nullable<short> Sta { get; set; }
    
        public virtual BienBanVPHC BienBanVPHC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTQuyetDinhTTTV> CTQuyetDinhTTTVs { get; set; }
    }
}
