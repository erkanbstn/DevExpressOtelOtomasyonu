//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelOtomasyonu.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIlce
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIlce()
        {
            this.TMisafir = new HashSet<TMisafir>();
        }
    
        public int ID { get; set; }
        public string Ilce { get; set; }
        public int Sehir { get; set; }
    
        public virtual TIl TIl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TMisafir> TMisafir { get; set; }
    }
}
