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
    public partial class EdytujKlienta : Form
    {
        String conn = Conn.conn;
        public EdytujKlienta()
        {
            InitializeComponent();
        }

        private void btn_EKDodaj_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient();
            Klienci klienci = new Klienci();

            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Klient SET imie = @imie, nazwisko = @nazwisko, data_ur = @dataur, pesel = @pesel, telefon = @telefon, mail = @email, staly_klient = @stalyklient, data_waznosci_prawa_jazdy = @datawaznosciprawka, numer_dowodu = @numerdowodu WHERE id_klienta = @id", sqlConnection);
            command.Parameters.AddWithValue("@id", label10.Text);
            command.Parameters.AddWithValue("@imie", txt_Eimie.Text);
            command.Parameters.AddWithValue("@nazwisko", txt_Enazwisko.Text);
            command.Parameters.AddWithValue("@dataur", dtp_Edata_ur.Value);
            command.Parameters.AddWithValue("@pesel", txt_Epesel.Text);
            command.Parameters.AddWithValue("@telefon", txt_Etelefon.Text);
            command.Parameters.AddWithValue("@email", txt_Eemail.Text);
            command.Parameters.AddWithValue("@stalyklient", EcheckBox_staly_klient.Checked);
            command.Parameters.AddWithValue("@datawaznosciprawka", Edtp_data_waznosci_pj.Value);
            command.Parameters.AddWithValue("@numerdowodu", Etxt_numer_dowodu.Text);


            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Zaktualizowano dane klienta");

            this.Hide();
            klienci.ShowDialog();
            klienci.pokaz_siatke();
        }

        private void btn_EKCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klienci klienci = new Klienci();
            klienci.ShowDialog();
        }
    }
}
