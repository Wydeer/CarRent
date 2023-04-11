using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wypozyczalnia.Models;

namespace Wypozyczalnia
{
    public partial class DodajSamochod : Form
    {
        String conn = Conn.conn;
        public DodajSamochod()
        {
            InitializeComponent();
          
        }

        
        
        private void btn_DSDodaj_Click(object sender, EventArgs e)
        {
            Samochody samochody = new Samochody();
            Samochod samochod = new Samochod();
            samochod.marka = txt_marka.Text;
            samochod.model = txt_model.Text;
            samochod.numer_rejestracyjny = txt_numer_rej.Text;
            samochod.rok_produkcji = (int)num_rok_produkcji.Value;
            samochod.rodzaj_paliwa = (string)cbx_rodzaj_paliwa.SelectedItem;
            samochod.kolor = txt_kolor.Text;
            samochod.cena_za_dzien = (int)num_cena_za_dzien.Value;
            samochod.rodzaj_skrzyni = (string)cbx_rodzaj_skrzyni.SelectedItem;
            samochod.kaucja = (int)num_kaucja.Value;
            //samochod.status = (string)cbx_status.SelectedItem;

            
            
            
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Samochod (marka, model, numer_rej, rok_produkcji, rodzaj_paliwa, kolor, cena_za_dzien, rodzaj_skrzyni, kaucja) VALUES (@marka, @model, @numer_rej,@rok_produkcji, @rodzaj_paliwa, @kolor, @cena_za_dzien, @rodzaj_skrzyni, @kaucja)", connection);
            command.Parameters.AddWithValue("@marka", samochod.marka);
            command.Parameters.AddWithValue("@model", samochod.model);
            command.Parameters.AddWithValue("@numer_rej", samochod.numer_rejestracyjny);
            command.Parameters.AddWithValue("@rok_produkcji", samochod.rok_produkcji);
            command.Parameters.AddWithValue("@rodzaj_paliwa", samochod.rodzaj_paliwa);
            command.Parameters.AddWithValue("@kolor", samochod.kolor);
            command.Parameters.AddWithValue("@cena_za_dzien", samochod.cena_za_dzien);
            command.Parameters.AddWithValue("@rodzaj_skrzyni", samochod.rodzaj_skrzyni);
            command.Parameters.AddWithValue("@kaucja", samochod.kaucja);
            //command.Parameters.AddWithValue("@status", samochod.status);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Dodano samochód do bazy danych");

            this.Hide();
            samochody.ShowDialog();
            samochody.pokaz_siatke();
            
            
            
        }

        private void btn_DSCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody samochody = new Samochody();
            samochody.ShowDialog();
            
            
        }
    }
}
