using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    /// <summary>
    /// repository ları new ledıgımız yer 
    /// butun repository getiren kısmı
    /// sebebi unit of work db yi olustumak 
    /// aynı db instance kullanması ıcın db bir kere olusturalım diyeeunit of work kullanım amacı
    /// </summary>
    public class UnitofWork
    {
        public OgrenciContext db;
        public EgitimRepository egitimRep;
        public BaseRepository<Ogrenci> ogrenciRep;
        public UnitofWork()
        {
            db = new OgrenciContext();
            egitimRep = new EgitimRepository(db);
            ogrenciRep = new OgrenciRepository(db);

        }
    }
}
