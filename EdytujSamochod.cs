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
    public partial class EdytujSamochod : Form
    {
        String conn = Conn.conn;
        public EdytujSamochod()
        {
            InitializeComponent();
        }

        private void EdytujSamochod_Load(object sender, EventArgs e)
        {

        }

        private void btn_ESEdytuj_Click(object sender, EventArgs e)
        {
            Samochod samochod = new Samochod();
            Samochody samochody = new Samochody();

            

            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Samochod SET marka = @marka, model = @model, numer_rej = @numer_rej ,rok_produkcji = @rok_produkcji, rodzaj_paliwa = @rodzaj_paliwa, kolor = @kolor, cena_za_dzien = @cena_za_dzien, rodzaj_skrzyni = @rodzaj_skrzyni, kaucja = @kaucja WHERE id_samochodu = @id", sqlConnection);
            command.Parameters.AddWithValue("@id", label10.Text);
            command.Parameters.AddWithValue("@marka", txt_ESmarka.Text);
            command.Parameters.AddWithValue("@model", txt_ESmodel.Text);
            command.Parameters.AddWithValue("@numer_rej", txt_ESnumer_rej.Text);
            command.Parameters.AddWithValue("@rok_produkcji", num_ESrok_produkcji.Value);
            command.Parameters.AddWithValue("@rodzaj_paliwa", cbx_ESrodzaj_paliwa.Text);
            command.Parameters.AddWithValue("@kolor", txt_ESkolor.Text);
            command.Parameters.AddWithValue("@cena_za_dzien", num_EScena_za_dzien.Value);
            command.Parameters.AddWithValue("@rodzaj_skrzyni", cbx_ESrodzaj_skrzyni.Text);
            command.Parameters.AddWithValue("@kaucja", num_ESkaucja.Value);
            //command.Parameters.AddWithValue("@status", cbx_ESstatus.Text);
            

            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Zaktualizowano dane samochodu");

            this.Hide();
            samochody.ShowDialog();
            samochody.pokaz_siatke();
        }

        private void btn_ESCofnij_Click(object sender, EventArgs e)
        {

        }
    }
}
