using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class EgitimRepository :BaseRepository<Egitim>
    {
        public EgitimRepository(OgrenciContext db):base(db)
        {

        }
        public int KacEgitimVar()
        {
            return HepsiniGetir().Count;
        }
    }
}
