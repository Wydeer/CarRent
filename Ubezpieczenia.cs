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

    public partial class Ubezpieczenia : Form
    {
        String conn = Conn.conn;

        public Ubezpieczenia()
        {
            InitializeComponent();
        }

        public void pokaz_siatke()
        {
            //SqlConnection connection = new SqlConnection(conn);
            //connection.Open();
            //SqlCommand command = new SqlCommand("SELECT Ubezpieczenie.id_ubezpieczenia ,Ubezpieczenie.id_samochodu ,Samochod.numer_rej, Ubezpieczenie.data_od, Ubezpieczenie.data_do, Ubezpieczenie.typ FROM Samochod JOIN Ubezpieczenie ON Samochod.id_samochodu = Ubezpieczenie.id_samochodu;", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //dgv_ubezpieczenia.DataSource = table;
            //connection.Close();

            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Ubezpieczenie.id_ubezpieczenia ,Ubezpieczenie.id_samochodu ,Samochod.numer_rej, Ubezpieczenie.data_od, Ubezpieczenie.data_do, Ubezpieczenie.typ FROM Samochod JOIN Ubezpieczenie ON Samochod.id_samochodu = Ubezpieczenie.id_samochodu;", connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Ubezpieczenie");

            dgv_ubezpieczenia.DataSource = dataSet.Tables["Ubezpieczenie"];

            connection.Close();

        }
        private void btn_UDodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajUbezpieczenie dodaj_ubezpieczenie = new DodajUbezpieczenie();
            dodaj_ubezpieczenie.Show();
        }

        private void Ubezpieczenia_Load(object sender, EventArgs e)
        {
            
            pokaz_siatke();
            dgv_ubezpieczenia.Columns[0].Visible = false;
            dgv_ubezpieczenia.Columns[1].Visible = false;

        }

        private void btn_UUsun_Click(object sender, EventArgs e)
        {
          
            // pobranie danych z bazy i wypełnienie obiektu DataSet
            SqlConnection conn = new SqlConnection(Conn.conn);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ubezpieczenie", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Ubezpieczenie");

            // usuwanie wybranego rekordu z obiektu DataSet
            int selectedRowIndex = dgv_ubezpieczenia.CurrentRow.Index;
            ds.Tables["Ubezpieczenie"].Rows[selectedRowIndex].Delete();

            // zapisywanie zmian do bazy danych
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Ubezpieczenie");

            // aktualizacja statusu samochodu w bazie danych
            int idSamochodu = Convert.ToInt32(dgv_ubezpieczenia.CurrentRow.Cells[1].Value);
            SqlCommand updateCommand = new SqlCommand("UPDATE Samochod SET status = 'Nieprzypisany' WHERE id_samochodu = @id_samochodu", conn);
            updateCommand.Parameters.AddWithValue("@id_samochodu", idSamochodu);
            conn.Open();
            updateCommand.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Usunięto ubezpieczenie");

            pokaz_siatke();
        }

        private void btn_UModyfikuj_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(Conn.conn);

            
            conn.Open();

            
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ubezpieczenie", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            
            DataRow row = table.Rows[dgv_ubezpieczenia.CurrentRow.Index];
            row["data_od"] = dtp_EUdata_od.Value;
            row["data_do"] = dtp_EUdata_do.Value;
            row["typ"] = cbx_EUtyp.Text;

            
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(table);

            
            conn.Close();

            MessageBox.Show("Zmodyfikowano ubezpieczenie");
            pokaz_siatke();


        }

        private void dgv_ubezpieczenia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgv_ubezpieczenia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_ubezpieczenia.CurrentRow.Selected = true;
            dtp_EUdata_od.Text = dgv_ubezpieczenia.CurrentRow.Cells[3].Value.ToString();
            dtp_EUdata_do.Text = dgv_ubezpieczenia.CurrentRow.Cells[4].Value.ToString();
            cbx_EUtyp.Text = dgv_ubezpieczenia.CurrentRow.Cells[5].Value.ToString();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
