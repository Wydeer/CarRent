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
    public partial class Klienci : Form
    {
        String conn = Conn.conn;
        public Klienci()
        {
            InitializeComponent();
        }

        public void pokaz_siatke()
        {
            

            SqlConnection connection = new SqlConnection(conn);
            DataSet ds = new DataSet();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Klient", connection);
            adapter.Fill(ds, "Klient");
            dgv_klienci.DataSource = ds.Tables["Klient"];
            connection.Close();
        }

        private void btn_KDodaj_Click(object sender, EventArgs e)
        {
            this.Hide();

            DodajKlienta dodaj_klienta = new DodajKlienta();
            dodaj_klienta.Show();
        }

        private void Klienci_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'wypozyczalniaDataSet.Klient' . Możesz go przenieść lub usunąć.
            this.klientTableAdapter.Fill(this.wypozyczalniaDataSet.Klient);
            //pokaz_siatke();
            //dgv_klienci.Columns[0].Visible = false;
        }

        private void btn_KUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunać tego klienta?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                SqlConnection sqlConnection = new SqlConnection(conn);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Klient WHERE id_klienta = @id_klienta", sqlConnection);
                command.Parameters.AddWithValue("@id_klienta", dgv_klienci.CurrentRow.Cells[0].Value);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Usunięto klienta z bazy danych");
            }

            pokaz_siatke();
        }

        

        private void btn_KModyfikuj_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient();
            klient.id_klienta = (int)dgv_klienci.CurrentRow.Cells[0].Value;
            klient.imie = dgv_klienci.CurrentRow.Cells[1].Value.ToString();
            klient.nazwisko = dgv_klienci.CurrentRow.Cells[2].Value.ToString();
            klient.data_ur = (DateTime)dgv_klienci.CurrentRow.Cells[3].Value;
            klient.pesel = dgv_klienci.CurrentRow.Cells[4].Value.ToString();
            klient.telefon = dgv_klienci.CurrentRow.Cells[5].Value.ToString();
            klient.email = dgv_klienci.CurrentRow.Cells[6].Value.ToString();
            klient.staly_klient = (bool)dgv_klienci.CurrentRow.Cells[7].Value;
            klient.data_waznosci_prawa_jazdy = (DateTime)dgv_klienci.CurrentRow.Cells[8].Value;
            klient.numer_dowodu = dgv_klienci.CurrentRow.Cells[9].Value.ToString();


            EdytujKlienta edytuj_klienta = new EdytujKlienta();
            edytuj_klienta.txt_Eimie.Text = klient.imie;
            edytuj_klienta.txt_Enazwisko.Text = klient.nazwisko;
            edytuj_klienta.txt_Epesel.Text = klient.pesel;
            edytuj_klienta.txt_Etelefon.Text = klient.telefon;
            edytuj_klienta.txt_Eemail.Text = klient.email;
            edytuj_klienta.EcheckBox_staly_klient.Checked = klient.staly_klient;
            edytuj_klienta.Etxt_numer_dowodu.Text = klient.numer_dowodu;
            edytuj_klienta.label10.Text = klient.id_klienta.ToString();


            this.Hide();
            edytuj_klienta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();

        }
    }
}
