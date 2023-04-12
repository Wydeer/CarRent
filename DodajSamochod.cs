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





            try
            {
                // utworzenie połączenia z bazą danych
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                // utworzenie adaptera danych
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Samochod", connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                // utworzenie tabeli z danymi
                DataTable table = new DataTable();
                adapter.Fill(table);

                // dodanie nowego wiersza do tabeli
                DataRow row = table.NewRow();
                row["marka"] = samochod.marka;
                row["model"] = samochod.model;
                row["numer_rej"] = samochod.numer_rejestracyjny;
                row["rok_produkcji"] = samochod.rok_produkcji;
                row["rodzaj_paliwa"] = samochod.rodzaj_paliwa;
                row["kolor"] = samochod.kolor;
                row["cena_za_dzien"] = samochod.cena_za_dzien;
                row["rodzaj_skrzyni"] = samochod.rodzaj_skrzyni;
                row["kaucja"] = samochod.kaucja;
                table.Rows.Add(row);

                // zaktualizowanie bazy danych
                adapter.Update(table);

                // zamknięcie połączenia z bazą danych
                connection.Close();

                MessageBox.Show("Dodano samochód do bazy danych");

                this.Hide();
                samochody.ShowDialog();
                samochody.pokaz_siatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uzupelnij wszystkie pola");
            }


        }

        private void btn_DSCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody samochody = new Samochody();
            samochody.ShowDialog();
            
            
        }
    }
}
