using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia.Models
{
    public class Samochod
    {
        public int id_samochodu { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string numer_rejestracyjny { get; set; }
        public int rok_produkcji { get; set; }
        public string rodzaj_paliwa { get; set; }
        public string kolor { get; set; }
        public int cena_za_dzien { get; set; }
        public string rodzaj_skrzyni { get; set; }
        public int kaucja { get; set; }
        public string status { get; set; }
        
    
    }
    

}
