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
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Wypozyczenia.id_samochodu,Klient.imie, Klient.nazwisko, Klient.pesel, Samochod.marka, Samochod.model, Samochod.numer_rej, Wypozyczenia.ubezpieczenie, Wypozyczenia.data_wypozyczenia, Wypozyczenia.data_zwrotu, Wypozyczenia.koszt FROM Wypozyczenia INNER JOIN Klient ON Wypozyczenia.id_klienta = Klient.id_klienta INNER JOIN Samochod ON Wypozyczenia.id_samochodu = Samochod.id_samochodu;", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_Wypozyczenia.DataSource = table;
            connection.Close();



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
            SqlConnection conn = new SqlConnection(Conn.conn);
            conn.Open();
            SqlCommand command = new SqlCommand("UPDATE Samochod SET status = 'Dostępny' WHERE id_samochodu = @id_samochodu", conn);
            command.Parameters.AddWithValue("@id_samochodu", dgv_Wypozyczenia.CurrentRow.Cells[0].Value);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            SqlCommand command2 = new SqlCommand("DELETE FROM Wypozyczenia WHERE id_samochodu = @id_samochodu", conn);
            command2.Parameters.AddWithValue("@id_samochodu", dgv_Wypozyczenia.CurrentRow.Cells[0].Value);
            command2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Samochód został zwrócony");
            pokaz_siatke();

        }
    }
}
