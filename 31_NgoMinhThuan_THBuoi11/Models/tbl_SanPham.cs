//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _31_NgoMinhThuan_THBuoi11.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SanPham()
        {
            this.tbl_ChiTiet = new HashSet<tbl_ChiTiet>();
            this.tbl_ChiTiet1 = new HashSet<tbl_ChiTiet>();
        }
    
        public int MaSanPham { get; set; }
        public string TenSP { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public string HinhAnh { get; set; }
        public string MoTa { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChiTiet> tbl_ChiTiet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChiTiet> tbl_ChiTiet1 { get; set; }
    }
}
