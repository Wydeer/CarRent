using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia.Models
{
    public class Samochod
    {
        
        private int _id_samochodu;
        public int id_samochodu
        {
            get { return _id_samochodu; }
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("ID samochodu musi być większe niż zero.");
                }
                else
                {
                    _id_samochodu = value;
                }
            }
        }
        private string _marka;
        public string marka
        {
            get { return _marka; }
            set
            {
                if (value.Length < 3)
                {
                    MessageBox.Show("Marka musi mieć przynajmniej 3 znaki.");
                }
                else
                {
                    _marka = value;
                }
            }
        }
        private string _model;
        public string model
        {
            get { return _model; }
            set
            {
                if (value.Length < 3)
                {
                    MessageBox.Show("Model musi mieć przynajmniej 3 znaki.");
                }
                else
                {
                    _model = value;
                }
            }
        }
        private string _numer_rejestracyjny;
        public string numer_rejestracyjny
        {
            get { return _numer_rejestracyjny; }
            set
            {
                if (value.Length < 3)
                {
                    MessageBox.Show("Numer rejestracyjny musi mieć przynajmniej 3 znaki.");
                }
                else
                {
                    _numer_rejestracyjny = value;
                }
            }
        }
        private int _rok_produkcji;
        public int rok_produkcji
        {
            get { return _rok_produkcji; }
            set
            {
                if (value < 1900)
                {
                    MessageBox.Show("Rok produkcji musi być większy niż 1900.");
                }
                else
                {
                    _rok_produkcji = value;
                }
            }
        }
        private string _rodzaj_paliwa;
        public string rodzaj_paliwa { get; set; }
        
        private string _kolor;
        public string kolor
        {
            get { return _kolor; }
            set
            {
                if (value.Length < 3)
                {
                    MessageBox.Show("Kolor musi mieć przynajmniej 3 znaki.");
                }
                else
                {
                    _kolor = value;
                }
            }
        }
        private int _cena_za_dzien;
        public int cena_za_dzien
        {
            get { return _cena_za_dzien; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Cena za dzień musi być większa niż 0.");
                }
                else
                {
                    _cena_za_dzien = value;
                }
            }
        }
        private string _rodzaj_skrzyni;
        public string rodzaj_skrzyni { get; set; }
        
        private int _kaucja;
        public int kaucja
        {
            get { return _kaucja; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Kaucja musi być większa niż 0.");
                }
                else
                {
                    _kaucja = value;
                }
            }
        }
        private string _status;
        public string status { get; set; }


    }

    

}
