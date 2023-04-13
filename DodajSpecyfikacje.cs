using System;
using System.Collections;
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
            

            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand("INSERT INTO SpecyfikacjeSamochodow (id_samochodu, marka_silnika, moc_silnika, pojemnosc_silnika, liczba_miejsc, liczba_drzwi,typ_nadwozia,typ_paliwa) VALUES( @id_samochodu, @marka_silnika, @moc_silnika, @pojemnosc_silnika, @liczba_miejsc, @liczba_drzwi,@typ_nadwozia,@typ_paliwa)", connection);
                adapter.InsertCommand.Parameters.Add("@id_samochodu", SqlDbType.Int).Value = int.Parse(label8.Text);
                adapter.InsertCommand.Parameters.Add("@marka_silnika", SqlDbType.NVarChar, 50).Value = txt_Markasilnika.Text;
                adapter.InsertCommand.Parameters.Add("@moc_silnika", SqlDbType.Float).Value = float.Parse(txt_Mocsilnika.Text);
                adapter.InsertCommand.Parameters.Add("@pojemnosc_silnika", SqlDbType.Float).Value = float.Parse(txt_Pojemnosc.Text);
                adapter.InsertCommand.Parameters.Add("@liczba_miejsc", SqlDbType.Int).Value = int.Parse(txt_Liczbamiejsc.Text);
                adapter.InsertCommand.Parameters.Add("@liczba_drzwi", SqlDbType.Int).Value = int.Parse(txt_Liczbadrzwi.Text);
                adapter.InsertCommand.Parameters.Add("@typ_nadwozia", SqlDbType.NVarChar, 50).Value = txt_Typnadwozia.Text;
                adapter.InsertCommand.Parameters.Add("@typ_paliwa", SqlDbType.NVarChar, 50).Value = cbx_typpaliwa.Text;

                connection.Open();
                adapter.InsertCommand.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Dodano specyfikacje do bazy danych");
            this.Hide();
            Samochody samochody = new Samochody();
            samochody.Show();

        }

        private void DodajSpecyfikacje_Load(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SpecyfikacjeSamochodow WHERE id_samochodu = @id_samochodu", sqlConnection);
            adapter.SelectCommand.Parameters.AddWithValue("@id_samochodu", label8.Text);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "SpecyfikacjeSamochodow");
            DataTable table = dataset.Tables["SpecyfikacjeSamochodow"];
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                txt_Markasilnika.Text = row["marka_silnika"].ToString();
                txt_Mocsilnika.Text = row["moc_silnika"].ToString();
                txt_Pojemnosc.Text = row["pojemnosc_silnika"].ToString();
                txt_Liczbamiejsc.Text = row["liczba_miejsc"].ToString();
                txt_Liczbadrzwi.Text = row["liczba_drzwi"].ToString();
                txt_Typnadwozia.Text = row["typ_nadwozia"].ToString();
                cbx_typpaliwa.Text = row["typ_paliwa"].ToString();

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
                cbx_typpaliwa.Text = "";

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
            command.Parameters.AddWithValue("@typ_paliwa", cbx_typpaliwa.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Zaktualizowano dane w bazie danych");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody samochody = new Samochody();
            samochody.Show();
        }
    }
}
