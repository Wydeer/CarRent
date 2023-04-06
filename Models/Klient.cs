using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models
{
    public class Klient
    {

        public int id_klienta { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public DateTime data_ur { get; set; }
        public string pesel { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public bool staly_klient { get; set; }
        public DateTime data_waznosci_prawa_jazdy { get; set; }
        public string numer_dowodu { get; set; }

    }
}
