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

            
            DataSet ds = new DataSet();

            
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Klient WHERE id_klienta = @id", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@id", label10.Text);

            
            adapter.Fill(ds, "Klient");

            
            DataRow row = ds.Tables["Klient"].Rows[0];

            
            row["imie"] = txt_Eimie.Text;
            row["nazwisko"] = txt_Enazwisko.Text;
            row["data_ur"] = dtp_Edata_ur.Value;
            row["pesel"] = txt_Epesel.Text;
            row["telefon"] = txt_Etelefon.Text;
            row["mail"] = txt_Eemail.Text;
            row["staly_klient"] = EcheckBox_staly_klient.Checked;
            row["data_waznosci_prawa_jazdy"] = Edtp_data_waznosci_pj.Value;
            row["numer_dowodu"] = Etxt_numer_dowodu.Text;

            
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            
            adapter.Update(ds, "Klient");

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
