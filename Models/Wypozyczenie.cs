using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models
{
    internal class Wypozyczenie
    {
        public int id_wypozyczenia { get; set; }
        public int id_samochodu { get; set; }
        public int id_klienta { get; set; }

        public bool ubezpieczenie {get; set; }
        public DateTime data_wypozyczenia { get; set; }
        public DateTime data_zwrotu { get; set; }
        public int koszt { get; set; }
        public int cena_dzienna { get; set; }
        public int kaucja { get; set; }

        public bool staly_klient { get; set; }
        
    }
}
