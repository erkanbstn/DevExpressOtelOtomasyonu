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
    
    public partial class TRezervasyon
    {
        public int RezervasyonID { get; set; }
        public Nullable<byte> Misafir { get; set; }
        public Nullable<System.DateTime> GirisTarih { get; set; }
        public Nullable<System.DateTime> CikisTarih { get; set; }
        public string Kisi { get; set; }
        public Nullable<byte> Oda { get; set; }
        public string RezervasyonKisi { get; set; }
        public string Telefon { get; set; }
        public string Aciklama { get; set; }
        public Nullable<byte> Durum { get; set; }
        public Nullable<int> Kisi2 { get; set; }
        public Nullable<int> Kisi3 { get; set; }
        public Nullable<int> Kisi4 { get; set; }
    
        public virtual TDurum TDurum { get; set; }
        public virtual TMisafir TMisafir { get; set; }
        public virtual TOda TOda { get; set; }
    }
}
