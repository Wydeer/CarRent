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
    public partial class Samochody : Form
    {
        String conn = Conn.conn;
        public Samochody()
        {
            InitializeComponent();
        }
        public void pokaz_siatke()
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Samochod", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_samochody.DataSource = table;
            connection.Close();



        }
        private void btn_SDodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            DodajSamochod dodaj_samochod = new DodajSamochod();
            dodaj_samochod.Show();
            
    

        }

        private void Samochody_Load(object sender, EventArgs e)
        {
            pokaz_siatke();
            dgv_samochody.Columns[0].Visible = false;
        }

        private void btn_SUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunać ten samochod?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            { 
                SqlConnection sqlConnection = new SqlConnection(conn);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Samochod WHERE id_samochodu = @id_samochodu", sqlConnection);
                command.Parameters.AddWithValue("@id_samochodu", dgv_samochody.CurrentRow.Cells[0].Value);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Usunięto samochód z bazy danych");
            }

        pokaz_siatke();
        }

        private void btn_SModyfikuj_Click(object sender, EventArgs e)
        {
            Samochod samochod = new Samochod();
            samochod.id_samochodu = (int)dgv_samochody.CurrentRow.Cells[0].Value;
            samochod.marka = dgv_samochody.CurrentRow.Cells[1].Value.ToString();
            samochod.model = dgv_samochody.CurrentRow.Cells[2].Value.ToString();
            samochod.numer_rejestracyjny = dgv_samochody.CurrentRow.Cells[3].Value.ToString();
            samochod.rok_produkcji = Convert.ToInt32(dgv_samochody.CurrentRow.Cells[4].Value);
            samochod.rodzaj_paliwa = dgv_samochody.CurrentRow.Cells[5].Value.ToString();
            samochod.kolor = dgv_samochody.CurrentRow.Cells[6].Value.ToString();
            samochod.cena_za_dzien = Convert.ToInt32(dgv_samochody.CurrentRow.Cells[7].Value);
            samochod.rodzaj_skrzyni = dgv_samochody.CurrentRow.Cells[8].Value.ToString();
            samochod.kaucja = Convert.ToInt32(dgv_samochody.CurrentRow.Cells[9].Value);
            //samochod.status = dgv_samochody.CurrentRow.Cells[10].Value.ToString();

            
            

            EdytujSamochod edytuj_samochod = new EdytujSamochod();
            edytuj_samochod.txt_ESmarka.Text = samochod.marka;
            edytuj_samochod.txt_ESmodel.Text = samochod.model;
            edytuj_samochod.txt_ESnumer_rej.Text = samochod.numer_rejestracyjny;
            edytuj_samochod.num_ESrok_produkcji.Value = samochod.rok_produkcji;
            edytuj_samochod.cbx_ESrodzaj_paliwa.Text = samochod.rodzaj_paliwa;
            edytuj_samochod.txt_ESkolor.Text = samochod.kolor;
            edytuj_samochod.num_EScena_za_dzien.Value = samochod.cena_za_dzien;
            edytuj_samochod.cbx_ESrodzaj_skrzyni.Text = samochod.rodzaj_skrzyni;
            edytuj_samochod.num_ESkaucja.Value = samochod.kaucja;
            //edytuj_samochod.cbx_ESstatus.Text = samochod.status;
            edytuj_samochod.label10.Text = samochod.id_samochodu.ToString();


            this.Hide();
            edytuj_samochod.Show();

        }

        private void btn_specyfikacja_Click(object sender, EventArgs e)
        {
            Samochod samochod = new Samochod();
            samochod.id_samochodu = (int)dgv_samochody.CurrentRow.Cells[0].Value;

            DodajSpecyfikacje dodajSpecyfikacje = new DodajSpecyfikacje();
            dodajSpecyfikacje.label8.Text = samochod.id_samochodu.ToString();
            this.Hide();
            dodajSpecyfikacje.Show();




        }
    }
}
