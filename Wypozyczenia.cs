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
    public partial class Wypozyczenia : Form
    {
        String conn = Conn.conn;
        public Wypozyczenia()
        {
            InitializeComponent();
        }
        public void pokaz_siatke()
        {

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Wypozyczenia.id_samochodu,Klient.imie, Klient.nazwisko, Klient.pesel, Samochod.marka, Samochod.model, Samochod.numer_rej, Wypozyczenia.ubezpieczenie, Wypozyczenia.data_wypozyczenia, Wypozyczenia.data_zwrotu, Wypozyczenia.koszt FROM Wypozyczenia INNER JOIN Klient ON Wypozyczenia.id_klienta = Klient.id_klienta INNER JOIN Samochod ON Wypozyczenia.id_samochodu = Samochod.id_samochodu;", conn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Wypozyczenia");
            dgv_Wypozyczenia.DataSource = dataset.Tables["Wypozyczenia"];

        }
        private void btn_DodajWypo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajWypozyczenie dodajWypozyczenie = new DodajWypozyczenie();
            dodajWypozyczenie.Show();

        }
        

        private void Wypozyczenia_Load(object sender, EventArgs e)
        {
            
            pokaz_siatke();
            dgv_Wypozyczenia.Columns[0].Visible = false;

        }

        private void btn_Zwrot_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(Conn.conn);
                conn.Open();
                SqlCommand updateCommand = new SqlCommand("UPDATE Samochod SET status = 'Dostępny' WHERE id_samochodu = @id_samochodu", conn);
                updateCommand.Parameters.AddWithValue("@id_samochodu", dgv_Wypozyczenia.CurrentRow.Cells[0].Value);
                updateCommand.ExecuteNonQuery();
                conn.Close();


                conn.Open();
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Wypozyczenia WHERE id_samochodu = @id_samochodu", conn);
                deleteCommand.Parameters.AddWithValue("@id_samochodu", dgv_Wypozyczenia.CurrentRow.Cells[0].Value);
                deleteCommand.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Samochód został zwrócony");
                pokaz_siatke();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Wybierz wypozyczenie");
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
