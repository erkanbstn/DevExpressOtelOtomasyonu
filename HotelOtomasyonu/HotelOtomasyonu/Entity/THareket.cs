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
    
    public partial class THareket
    {
        public int HareketID { get; set; }
        public Nullable<byte> Urun { get; set; }
        public string HareketTur { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Aciklama { get; set; }
    
        public virtual TUrun TUrun { get; set; }
    }
}
