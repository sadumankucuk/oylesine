using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace oylesine.Controllers
{
    
    public class ValuesController : ApiController
    {
        //oylesineEntities db = new oylesineEntities();
        //Kullanici kullanici = new Kullanici();

     

        //[HttpGet]
        //public bool KullaniciEkle(string ad, string soyad, string kullaniciAdi, string email, string parola, string fotograf, DateTime dogumTarihi, int telefon, int cinsiyetID, DateTime kayitTarihi)
        //{
        //    bool control = true;
        //    try
        //    {
        //        using (db = new oylesineEntities())
        //        {
        //            db.Kullanicis.Add(new Kullanici()
        //            {
        //                Ad = ad,
        //                Soyad = soyad,
        //                KullaniciAdi = kullaniciAdi,
        //                Email = email,
        //                Parola = parola,
        //                Fotograf = fotograf,
        //                DogumTarihi = dogumTarihi,
        //                Telefon = telefon,
        //                CinsiyetID = cinsiyetID,
        //                KayitTarihi = kayitTarihi
        //            });

        //        }
        //    }
        //    catch (Exception)
        //    {
        //        control = false;
        //        throw;
        //    }
        //    return control;
        //}

        //GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };             
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
