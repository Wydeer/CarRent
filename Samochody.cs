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
            
            //SqlConnection connection = new SqlConnection(conn);
            //connection.Open();

            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Samochod", connection);
            //DataSet dataset = new DataSet();
            //adapter.Fill(dataset, "Samochod");

            //dgv_samochody.DataSource = dataset.Tables["Samochod"];

            //connection.Close();


        }
        private void btn_SDodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            DodajSamochod dodaj_samochod = new DodajSamochod();
            dodaj_samochod.Show();
            
    

        }

        private void Samochody_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'wypozyczalniaDataSet.SpecyfikacjeSamochodow' . Możesz go przenieść lub usunąć.
            this.specyfikacjeSamochodowTableAdapter.Fill(this.wypozyczalniaDataSet.SpecyfikacjeSamochodow);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'wypozyczalniaDataSet.Samochod' . Możesz go przenieść lub usunąć.
            this.samochodTableAdapter.Fill(this.wypozyczalniaDataSet.Samochod);
            //pokaz_siatke();
            
        }

        private void btn_SUsun_Click(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("Czy na pewno chcesz usunąć ten samochod?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedRow = dgv_samochody.CurrentRow.Index;
                int selectedId = Convert.ToInt32(dgv_samochody.Rows[selectedRow].Cells[0].Value);

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    // Usunięcie rekordów powiązanych z rekordem z tabeli "Samochod"
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM SpecyfikacjeSamochodow WHERE id_samochodu = @id_samochodu", connection);
                    deleteCommand.Parameters.AddWithValue("@id_samochodu", selectedId);
                    deleteCommand.ExecuteNonQuery();

                    // Usunięcie rekordu z tabeli "Samochod"
                    SqlCommand deleteCommand2 = new SqlCommand("DELETE FROM Samochod WHERE id_samochodu = @id_samochodu", connection);
                    deleteCommand2.Parameters.AddWithValue("@id_samochodu", selectedId);
                    deleteCommand2.ExecuteNonQuery();

                    MessageBox.Show("Usunięto samochód z bazy danych");

                    // Odświeżanie danych w kontrolce DataGridView
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Samochod", connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgv_samochody.DataSource = table;

                    connection.Close();
                }
            }
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
            try
            {
                Samochod samochod = new Samochod();
                samochod.id_samochodu = (int)dgv_samochody.CurrentRow.Cells[0].Value;

                DodajSpecyfikacje dodajSpecyfikacje = new DodajSpecyfikacje();
                dodajSpecyfikacje.label8.Text = samochod.id_samochodu.ToString();
                this.Hide();
                dodajSpecyfikacje.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Wybierz samochód");
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
