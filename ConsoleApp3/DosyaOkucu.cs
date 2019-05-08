using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  public  class DosyaOkucu<DosyaTipi> where DosyaTipi:class
    {
        public int Pozisyon { get; set; }
        public bool BittiMi { get; set; }
        public DosyaTipi OkunanDosya { get; set; }

    }
}
