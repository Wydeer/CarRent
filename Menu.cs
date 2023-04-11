using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Samochody_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody samochody = new Samochody();
            samochody.Show();
        }

        private void btn_Klienci_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci klienci = new Klienci();
            klienci.Show();
        }

        private void btn_Ubezpieczenie_Click(object sender, EventArgs e)
        {
            this .Hide();
            Ubezpieczenia ubezpieczenia = new Ubezpieczenia();
            ubezpieczenia.Show();
        }

        private void btn_Wypożyczenie_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wypozyczenia wypozyczenia = new Wypozyczenia();
            wypozyczenia.Show();
        }
    }
}
