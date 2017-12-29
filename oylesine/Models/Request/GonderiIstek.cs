using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oylesine.Models.Request
{
    public class GonderiIstek
    {
        public int kullaniciID { get; set; }
        public string icerik { get; set; }
        public int medyaID { get; set; }
       
    }
}