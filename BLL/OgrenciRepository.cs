using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class OgrenciRepository:BaseRepository<Ogrenci>
    {
        OgrenciContext _db;
        public OgrenciRepository(OgrenciContext db):base(db)
        {
            _db = db;
        }
        /// <summary>
        /// override edemedik cunki izinimiz yok overrride edebilmemiz için virtual veya abstract olmsaı gerekir
        /// </summary>
        /// <returns></returns>
        public new List<Ogrenci> HepsiniGetir()
        {
            ///Egitim -> nav prop adi
            /////Eager loafding Vs lazy loading
            ///incluede sadece bir kere getirir forweach teki performansı artıtıt ,virtual tamımladıgımız için her seferinde otomatik yuklıuor.
            ///virua egtim egitm yapmasyadık ogrenci ni egitml ile ilgili ozellikleirni getrimezdı ,virtual sayesinde ilişkilnedirlir ve otomatik gelir
            return _db.Ogrenciler.Include("Egitim").ToList();
        }

    }
}
