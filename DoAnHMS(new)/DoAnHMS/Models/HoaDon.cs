//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnHMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        public string maHD { get; set; }
        public System.DateTime ngayTT { get; set; }
        public string maPTP { get; set; }
        public string maNV { get; set; }
        public decimal tongTien { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhieuThuePhong PhieuThuePhong { get; set; }
    }
}
