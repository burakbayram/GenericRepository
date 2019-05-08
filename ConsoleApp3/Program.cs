using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DosyaOkucu<Pdf> pdfOkuyucu = new DosyaOkucu<Pdf>();
            var okunanUzanti = pdfOkuyucu.OkunanDosya.Uzanti;
            Console.ReadLine();
        }
    }
}
