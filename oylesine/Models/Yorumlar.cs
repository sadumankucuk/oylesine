//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace oylesine.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yorumlar
    {
        public int YorumID { get; set; }
        public int GonderiID { get; set; }
        public int KullaniciID { get; set; }
        public string Yorum { get; set; }
        public System.DateTime YorumTarihi { get; set; }
    
        public virtual Gonderiler Gonderiler { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}
