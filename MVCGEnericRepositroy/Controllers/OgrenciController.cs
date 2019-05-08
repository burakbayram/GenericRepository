using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGEnericRepositroy.Controllers
{
   
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        UnitofWork unitofWork = new UnitofWork();
        public ActionResult Index()
        {
            return View(unitofWork.ogrenciRep.HepsiniGetir());
        }
        public ActionResult Yeni()
        {

            var egitimler = unitofWork.egitimRep.HepsiniGetir();
            var secenekler = egitimler.Select(x => new SelectListItem()
            {
                Text=x.EgitimAdi,
                Value=x.EgitimId.ToString()
            });
            //Viewbag.bisey iviewdata["bisey"],tempdata["bisey"]
            ViewBag.secenekler = secenekler;

            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Ogrenci ogr)
        {
            if (ModelState.IsValid)
            {
                unitofWork.ogrenciRep.Ekle(ogr);
                return RedirectToAction("Index");

            }
            ///eski sayfa gerigozkusun diye
            var egitimler = unitofWork.egitimRep.HepsiniGetir();
            var secenekler = egitimler.Select(x => new SelectListItem()
            {
                Text = x.EgitimAdi,
                Value = x.EgitimId.ToString()
            });
            //Viewbag.bisey iviewdata["bisey"],tempdata["bisey"]
            ViewBag.secenekler = secenekler;
            return View();
        }

        //public ActionResult Sil(int id)
        //{
        //    unitofWork.ogrenciRep.Delete(id);
        //    ///bunu jquey farkettimek lazım bunun için ajax kullanıcak 
        //    ///jq deki silinecek id almak için 
        //return REdiac("Index)
        //}
        public void Sil(int id)
        {
            unitofWork.ogrenciRep.Delete(id);
            ///bunu jquey farkettimek lazım bunun için ajax kullanıcak 
            ///jq deki silinecek id almak için 
        }
        public ActionResult Duzenle(int id)
        {
            //int ? id
            //    if (!id.HasValue)
            //    return HttpNotFound();//Eger int null olarak ayarladoysak boyle kontrol edebşlirz
            return View(unitofWork.ogrenciRep.GetById(id));
        }
        [HttpPost]
        public ActionResult Duzenle(Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                unitofWork.ogrenciRep.Update(ogrenci);
                return RedirectToAction("Index");
            }
            ///son yazdılakrrımnı tekrar gorsun diye if girmezse eger
            return View(ogrenci);
        }
    }
}