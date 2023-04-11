using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models
{
    internal class Specyfikacja
    {
        public int id_specyfikacji { get; set; }
        public int id_samochodu { get; set; }
        public string marka_silnika { get; set; }
        public int moc_silnika { get; set; }
        public int pojemnosc_silnika { get; set; }
        public int liczba_miejsc { get; set; }
        public int liczba_drzwi { get; set; }
        public string typ_nadwozia { get; set; }
        public string typ_paliwa { get; set; }


    }
}
