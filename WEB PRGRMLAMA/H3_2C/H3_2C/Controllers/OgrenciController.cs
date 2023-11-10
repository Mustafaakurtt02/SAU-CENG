using H3_2C.Models;
using Microsoft.AspNetCore.Mvc;

namespace H3_2C.Controllers
{
    public class OgrenciController : Controller
    {
       static public List<Ogrenci> ogrenciler =new List<Ogrenci>();
        public IActionResult OgrOlustur()
        {
            return View();
        }
        public string OgrKaydet()
        {
            string ad=HttpContext.Request.Query["OgrAd"];
            string soyad=HttpContext.Request.Query["OgrSoyad"];
            int no=Convert.ToInt32( HttpContext.Request.Query["OgrNo"]);
            string msj = "";
            if (ad.Length<3 || no < 100)
            {
                msj = "Kayıt Başarısız";
            }
            else
            {
                msj = ad + " adlı ve no=" + no + " lu öğrenci kaydedildi";
            }
            return msj;
        }
        [HttpPost]
        public IActionResult OgrKaydetPost()
        {
            string ad = HttpContext.Request.Form["OgrAd"];
            string soyad = HttpContext.Request.Form["OgrSoyad"];
            int no = Convert.ToInt32( HttpContext.Request.Form["OgrNo"]);
            //Filtreleme
            //Db Kayıt
            string msj = "";
            if (ad.Length < 3 || no < 100)
            {
                //msj = "Kayıt Başarısız";
               return View ("OgrHata");
            }
            else
            {
               return RedirectToAction("OgrKayit");
                //msj = ad + " adlı ve no=" + no + " lu öğrenci kaydedildi";
            }
            //return msj;
        }

        public string OgrKaydetParam(string OgrAd,string OgrSoyad,string OgrNo)
        {
           string msj = "";
            return msj = OgrAd + " adlı ve no=" + OgrNo + " lu öğrenci kaydedildi";
        }

        public IActionResult OgrKaydetClass(Ogrenci ogr)
        {
           
            //string msj = "";
            // return msj = ogr.OgrAd + " adlı ve no=" + ogr.OgrNo + " lu öğrenci kaydedildi";
           //filtreleme
           ogrenciler.Add(ogr);
            return RedirectToAction("OgrList");
            //return View(ogr);

        }
        public IActionResult OgrList()
        {
            return View(ogrenciler);
        }
        public IActionResult OgrKaydetClass2(Ogrenci ogr)
        {
            Personel per=new Personel();
            per.PerAd = "Hasan";
            per.PerNo = 5000;
            Kisi k=new Kisi();
            k.Ogr = ogr;
            k.Per=per;
            //string msj = "";
            // return msj = ogr.OgrAd + " adlı ve no=" + ogr.OgrNo + " lu öğrenci kaydedildi";
            return View(k);

        }

        public IActionResult OgrHata()
        {
            return View();
        }
        public IActionResult OgrKayit()
        {
            return View();
        }

        public double OgrNotOrtGetir()
        {
            Ogrenci ogr=new Ogrenci();
            double ortno = ogr.OgrenciOrtNotGetir(10);
            return ortno;
        }
    }
}
