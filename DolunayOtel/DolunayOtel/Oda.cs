//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DolunayOtel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oda
    {
        public int OdaID { get; set; }
        public Nullable<System.DateTime> GirisTarihi { get; set; }
        public Nullable<System.DateTime> CikisTarihi { get; set; }
        public string OdaTipi { get; set; }
        public string OdaFiyatı { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public string ResimYolu { get; set; }
        public string OdaText { get; set; }
    
        public virtual Musteri Musteri { get; set; }
    }
}
