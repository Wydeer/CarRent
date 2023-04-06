using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wypozyczalnia.Models;

namespace Wypozyczalnia
{
    public partial class DodajKlienta : Form
    {
        
        public DodajKlienta()
        {
            InitializeComponent();
        }

        String conn = Conn.conn;
        

        private void btn_KKDodaj_Click(object sender, EventArgs e)
        {

            Klienci klienci = new Klienci();
            Klient klient = new Klient();
            klient.imie = txt_imie.Text;
            klient.nazwisko= txt_nazwisko.Text;
            klient.data_ur = dtp_data_ur.Value;
            klient.pesel= txt_pesel.Text;
            klient.telefon= txt_telefon.Text;
            klient.email= txt_email.Text;
            klient.staly_klient = checkBox_staly_klient.Checked;
            klient.data_waznosci_prawa_jazdy = dtp_data_waznosci_pj.Value;
            klient.numer_dowodu = txt_numer_dowodu.Text;

            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Klient ( imie ,nazwisko,data_ur,pesel,telefon ,mail,staly_klient ,data_waznosci_prawa_jazdy  ,numer_dowodu) VALUES (@imie,@nazwisko,@dataur,@pesel,@telefon,@email,@stalyklient,@datawaznosciprawka,@numerdowodu)", sqlConnection);
            command.Parameters.AddWithValue("@imie",klient.imie);
            command.Parameters.AddWithValue("@nazwisko",klient.nazwisko);
            command.Parameters.AddWithValue("@dataur",klient.data_ur);
            command.Parameters.AddWithValue("@pesel",klient.pesel);
            command.Parameters.AddWithValue("@telefon", klient.telefon);
            command.Parameters.AddWithValue("@email",klient.email);
            command.Parameters.AddWithValue("@stalyklient", klient.staly_klient);
            command.Parameters.AddWithValue("@datawaznosciprawka", klient.data_waznosci_prawa_jazdy);
            command.Parameters.AddWithValue("@numerdowodu", klient.numer_dowodu);


            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Dodano nowego klienta");

            this.Hide();
            klienci.ShowDialog();
            klienci.pokaz_siatke();

        }
        private void btn_DKCofnij_Click(object sender, EventArgs e)
        {

            this.Hide();
            Klienci klient = new Klienci();
            klient.ShowDialog();



        }
    }
}
