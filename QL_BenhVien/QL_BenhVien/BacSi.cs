//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_BenhVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class BacSi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BacSi()
        {
            this.CuocHens = new HashSet<CuocHen>();
        }
    
        public int id { get; set; }
        public string ho { get; set; }
        public string ten { get; set; }
        public int id_nganh { get; set; }
        public string taikhoan { get; set; }
        public string matkhau { get; set; }
    
        public virtual Nganh Nganh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuocHen> CuocHens { get; set; }
    }
}
