using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Egitim
    {
        [Key]
        public int EgitimId { get; set; }
        public string EgitimAdi { get; set; }
        public virtual List<Ogrenci> Ogrenci { get; set; }
    }
}
