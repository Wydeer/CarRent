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

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Samochod WHERE id_samochodu = @id", sqlConnection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", label10.Text);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Samochod");

            DataRow row = dataSet.Tables["Samochod"].Rows[0];
            row["marka"] = txt_ESmarka.Text;
            row["model"] = txt_ESmodel.Text;
            row["numer_rej"] = txt_ESnumer_rej.Text;
            row["rok_produkcji"] = num_ESrok_produkcji.Value;
            row["rodzaj_paliwa"] = cbx_ESrodzaj_paliwa.Text;
            row["kolor"] = txt_ESkolor.Text;
            row["cena_za_dzien"] = num_EScena_za_dzien.Value;
            row["rodzaj_skrzyni"] = cbx_ESrodzaj_skrzyni.Text;
            row["kaucja"] = num_ESkaucja.Value;

            dataAdapter.Update(dataSet, "Samochod");

            sqlConnection.Close();
            MessageBox.Show("Zaktualizowano dane samochodu");

            this.Hide();
            samochody.ShowDialog();
            samochody.pokaz_siatke();
        }

        private void btn_ESCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            Samochody samochody = new Samochody();
            samochody.ShowDialog();
        }
    }
}
