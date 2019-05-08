using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }
        [Required]
        public string AdSoyad { get; set; }
        public DateTime KayitTarihi { get; set; }
        public  int EgitimId { get; set; }

        [ForeignKey("EgitimId")]
        public virtual Egitim Egitim { get; set; }
    }
}
