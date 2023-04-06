using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models
{
    public class Ubezpieczenie
    {
        public int id_ubezpieczenia { get; set; }
        public int id_samochodu { get; set; }
        public DateTime data_od { get; set; }
        public DateTime data_do { get; set; }

        public string typ { get; set; }
        public string numer_rej { get; set; }
    }
}
