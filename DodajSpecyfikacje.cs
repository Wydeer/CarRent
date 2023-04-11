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
    public partial class DodajSpecyfikacje : Form
    {
        String conn = Conn.conn;
        public DodajSpecyfikacje()
        {
            InitializeComponent();
        }

        private void btn_DSpecyfikacje_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO SpecyfikacjeSamochodow (id_samochodu, marka_silnika, moc_silnika, pojemnosc_silnika, liczba_miejsc, liczba_drzwi,typ_nadwozia,typ_paliwa) VALUES( @id_samochodu, @marka_silnika, @moc_silnika, @pojemnosc_silnika, @liczba_miejsc, @liczba_drzwi,@typ_nadwozia,@typ_paliwa)", sqlConnection);
            command.Parameters.AddWithValue("@id_samochodu", label8.Text);
            command.Parameters.AddWithValue("@marka_silnika", txt_Markasilnika.Text);
            command.Parameters.AddWithValue("@moc_silnika", txt_Mocsilnika.Text);
            command.Parameters.AddWithValue("@pojemnosc_silnika", txt_Pojemnosc.Text);
            command.Parameters.AddWithValue("@liczba_miejsc", txt_Liczbamiejsc.Text);
            command.Parameters.AddWithValue("@liczba_drzwi", txt_Liczbadrzwi.Text);
            command.Parameters.AddWithValue("@typ_nadwozia", txt_Typnadwozia.Text);
            command.Parameters.AddWithValue("@typ_paliwa", txt_Typpaliwa.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Dodano specyfikacje do bazy danych");

            
        }

        private void DodajSpecyfikacje_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM SpecyfikacjeSamochodow WHERE id_samochodu = @id_samochodu", sqlConnection);
            command.Parameters.AddWithValue("@id_samochodu", label8.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txt_Markasilnika.Text = reader["marka_silnika"].ToString();
                txt_Mocsilnika.Text = reader["moc_silnika"].ToString();
                txt_Pojemnosc.Text = reader["pojemnosc_silnika"].ToString();
                txt_Liczbamiejsc.Text = reader["liczba_miejsc"].ToString();
                txt_Liczbadrzwi.Text = reader["liczba_drzwi"].ToString();
                txt_Typnadwozia.Text = reader["typ_nadwozia"].ToString();
                txt_Typpaliwa.Text = reader["typ_paliwa"].ToString();

                btn_DSpecyfikacje.Enabled = false;

            }
            else
            {
                txt_Markasilnika.Text = "";
                txt_Mocsilnika.Text = "";
                txt_Pojemnosc.Text = "";
                txt_Liczbamiejsc.Text = "";
                txt_Liczbadrzwi.Text = "";
                txt_Typnadwozia.Text = "";
                txt_Typpaliwa.Text = "";

                btn_SEdytuj.Enabled = false;
            }
            sqlConnection.Close();

        }

        private void btn_SEdytuj_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE SpecyfikacjeSamochodow SET marka_silnika = @marka_silnika, moc_silnika = @moc_silnika, pojemnosc_silnika = @pojemnosc_silnika, liczba_miejsc = @liczba_miejsc, liczba_drzwi = @liczba_drzwi, typ_nadwozia = @typ_nadwozia, typ_paliwa = @typ_paliwa WHERE id_samochodu = @id_samochodu", sqlConnection);
            command.Parameters.AddWithValue("@id_samochodu", label8.Text);
            command.Parameters.AddWithValue("@marka_silnika", txt_Markasilnika.Text);
            command.Parameters.AddWithValue("@moc_silnika", txt_Mocsilnika.Text);
            command.Parameters.AddWithValue("@pojemnosc_silnika", txt_Pojemnosc.Text);
            command.Parameters.AddWithValue("@liczba_miejsc", txt_Liczbamiejsc.Text);
            command.Parameters.AddWithValue("@liczba_drzwi", txt_Liczbadrzwi.Text);
            command.Parameters.AddWithValue("@typ_nadwozia", txt_Typnadwozia.Text);
            command.Parameters.AddWithValue("@typ_paliwa", txt_Typpaliwa.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Zaktualizowano dane w bazie danych");

        }
    }
}
