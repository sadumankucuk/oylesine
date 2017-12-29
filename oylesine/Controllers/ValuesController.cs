using oylesine.Models;
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
        oylesineEntities db = new oylesineEntities();
        Kullanicilar kullanici = new Kullanicilar();



        [HttpGet]
        public bool KullaniciEkle(string ad, string soyad, string kullaniciAdi, string email, string parola, string fotograf, string dogumTarihi, int telefon, int cinsiyetID, string kayitTarihi)
        {
            bool control = true;
            try
            {
                using (db = new oylesineEntities())
                {
                    db.Kullanicilars.Add(new Kullanicilar()
                    {
                        Ad = ad,
                        Soyad = soyad,
                        KullaniciAdi = kullaniciAdi,
                        Email = email,
                        Parola = parola,
                        Fotograf = fotograf,
                        DogumTarihi = Convert.ToDateTime(dogumTarihi),
                        Telefon = telefon,
                        CinsiyetID = cinsiyetID,
                        KayitTarihi = Convert.ToDateTime(kayitTarihi)
                    });

                }
            }
            catch (Exception)
            {
                control = false;
                throw;
            }
            return control;
        }

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
