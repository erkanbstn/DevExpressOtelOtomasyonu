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
    
    public partial class TOda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOda()
        {
            this.TRezervasyon = new HashSet<TRezervasyon>();
        }
    
        public byte OdaID { get; set; }
        public string OdaNo { get; set; }
        public string Kat { get; set; }
        public string Kapasite { get; set; }
        public string Aciklama { get; set; }
        public string Telefon { get; set; }
        public Nullable<byte> Durum { get; set; }
    
        public virtual TDurum TDurum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRezervasyon> TRezervasyon { get; set; }
    }
}
