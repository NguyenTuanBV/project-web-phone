//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace btap.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class thongtinkhachhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public thongtinkhachhang()
        {
            this.dondathangs = new HashSet<dondathang>();
        }
    
        public int makhachhang { get; set; }
        public string tenkhachhang { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dondathang> dondathangs { get; set; }
    }
}
