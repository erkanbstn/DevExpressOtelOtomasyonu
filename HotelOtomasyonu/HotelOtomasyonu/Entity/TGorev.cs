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
    
    public partial class TGorev
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TGorev()
        {
            this.TPersonel = new HashSet<TPersonel>();
        }
    
        public byte GorevID { get; set; }
        public string GorevAd { get; set; }
        public Nullable<byte> Departman { get; set; }
        public Nullable<byte> Durum { get; set; }
    
        public virtual TDepartman TDepartman { get; set; }
        public virtual TDurum TDurum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TPersonel> TPersonel { get; set; }
    }
}
