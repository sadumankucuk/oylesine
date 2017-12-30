using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oylesine.Models
{
    public class YorumlariGetir
    {
        public string kullaniciAdi { get; set; }
        public string yorum { get; set; }
        public DateTime yorumTarihi { get; set; }
    }
}