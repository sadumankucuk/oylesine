using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oylesine.Models
{
    public class YorumIstek
    {
        public int gonderiID { get; set; }
        public int kullaniciID { get; set; }
        public string yorum { get; set; }
    }
}