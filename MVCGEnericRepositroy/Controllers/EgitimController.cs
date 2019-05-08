using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGEnericRepositroy.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim
        UnitofWork _uw = new UnitofWork();
        public ActionResult Index()
        {
           
            return View(_uw.egitimRep.HepsiniGetir());
        }
        public ActionResult Yeni()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Egitim egitim)
        {
            _uw.egitimRep.Ekle(egitim);
            return RedirectToAction("Index");
        }

        public void Sil(int id)
        {
            _uw.egitimRep.Delete(id);
            ///bunu jquey farkettimek lazım bunun için ajax kullanıcak 
            ///jq deki silinecek id almak için 
        }
        public ActionResult Duzenle(int id)
        {
            //int ? id
            //    if (!id.HasValue)
            //    return HttpNotFound();//Eger int null olarak ayarladoysak boyle kontrol edebşlirz
            return View(_uw.egitimRep.GetById(id));
        }
        [HttpPost]
        public ActionResult Duzenle(Egitim egitim)
        {
            if (ModelState.IsValid) { 
            _uw.egitimRep.Update(egitim);
                return RedirectToAction("Index");
            }
            ///son yazdılakrrımnı tekrar gorsun diye if girmezse eger
            return View(egitim);
        }
    }
}