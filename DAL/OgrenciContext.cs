using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OgrenciContext:DbContext
    {
        public virtual DbSet<Egitim> Egitimler { get; set; }
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }

    }
}
