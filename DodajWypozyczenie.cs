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
    public partial class DodajWypozyczenie : Form
    {
        String conn = Conn.conn;
        public DodajWypozyczenie()
        {
            InitializeComponent();
        }
        public void pokaz_siatke_samochody()
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT id_samochodu, marka, model, numer_rej, cena_za_dzien, kaucja FROM Samochod WHERE status = 'Dostępny'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_DWsamochody.DataSource = table;
            connection.Close();

        }
        public void pokaz_siatke_klienci()
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT id_klienta, imie, nazwisko, pesel, data_waznosci_prawa_jazdy, staly_klient FROM Klient", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_DWklienci.DataSource = table;
            connection.Close();
        }

        private void btn_DodajWypo_Click(object sender, EventArgs e)
        {
            DateTime data1 = (DateTime)dgv_DWklienci.CurrentRow.Cells[4].Value;
            DateTime data2 = (DateTime)dtp_Datawypo.Value;
            

            
            if (dtp_Datazwrotu.Value <= dtp_Datawypo.Value)
            {
                MessageBox.Show("Data zwrotu nie może być wcześniejsza bądź równa niż data wypożyczenia ");
                return;
            }
            else
            {
                if (data1 > data2 ) {
                    Wypozyczenie wypozyczenie = new Wypozyczenie();
                    wypozyczenie.id_samochodu = Convert.ToInt32(dgv_DWsamochody.CurrentRow.Cells[0].Value);
                    wypozyczenie.id_klienta = Convert.ToInt32(dgv_DWklienci.CurrentRow.Cells[0].Value);
                    wypozyczenie.ubezpieczenie = cbx_Ubezpiecznie.Checked;
                    wypozyczenie.koszt = Convert.ToInt32(txt_koszt.Text);
                    wypozyczenie.data_wypozyczenia = dtp_Datawypo.Value;
                    wypozyczenie.data_zwrotu = dtp_Datazwrotu.Value;


                    SqlConnection conn = new SqlConnection(Conn.conn);
                    try
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO Wypozyczenia (id_samochodu, id_klienta, ubezpieczenie, data_wypozyczenia, data_zwrotu, koszt) VALUES (@id_samochodu, @id_klienta,@ubezpieczenie, @data_od, @data_do, @koszt)", conn);
                        command.Parameters.AddWithValue("@id_samochodu", wypozyczenie.id_samochodu);
                        command.Parameters.AddWithValue("@id_klienta", wypozyczenie.id_klienta);
                        command.Parameters.AddWithValue("@ubezpieczenie", wypozyczenie.ubezpieczenie);
                        command.Parameters.AddWithValue("@data_od", wypozyczenie.data_wypozyczenia);
                        command.Parameters.AddWithValue("@data_do", wypozyczenie.data_zwrotu);
                        command.Parameters.AddWithValue("@koszt", wypozyczenie.koszt);
                        command.ExecuteNonQuery();

                        SqlCommand updateCommand = new SqlCommand("UPDATE Samochod SET status = 'Niedostępny' WHERE id_samochodu = @id_samochodu", conn);
                        updateCommand.Parameters.AddWithValue("@id_samochodu", wypozyczenie.id_samochodu);
                        updateCommand.ExecuteNonQuery();


                        MessageBox.Show("Dodano wypozyczenie");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {

                        conn.Close();
                    }


                    this.Hide();
                    Wypozyczenia wypozyczenia = new Wypozyczenia();
                    wypozyczenia.Show();
                }
                else
                {
                    MessageBox.Show("Klient nie posiada ważnego prawa jazdy");
                }
            }
        }

        private void DodajWyporzyczenie_Load(object sender, EventArgs e)
        {
            pokaz_siatke_samochody();
            pokaz_siatke_klienci();
        }

        private void dgv_DWsamochody_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dgv_DWsamochody.CurrentRow.Selected = true;
            kwota();
            
        }

        private void dgv_DWklienci_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dgv_DWklienci.CurrentRow.Selected = true;
            kwota();
            
        }
        public void kwota()
        {
            Wypozyczenie wypozyczenie = new Wypozyczenie();
            wypozyczenie.cena_dzienna = Convert.ToInt32(dgv_DWsamochody.CurrentRow.Cells[4].Value);
            wypozyczenie.kaucja = Convert.ToInt32(dgv_DWsamochody.CurrentRow.Cells[5].Value);
            wypozyczenie.staly_klient = Convert.ToBoolean(dgv_DWklienci.CurrentRow.Cells[5].Value);
            wypozyczenie.data_wypozyczenia = dtp_Datawypo.Value;
            wypozyczenie.data_zwrotu = dtp_Datazwrotu.Value;
            int dni = (wypozyczenie.data_zwrotu - wypozyczenie.data_wypozyczenia).Days + 1;

            


            if (wypozyczenie.staly_klient == true)
            {
                if (cbx_Ubezpiecznie.Checked == true)
                {
                    wypozyczenie.koszt = Convert.ToInt32((((wypozyczenie.cena_dzienna * 0.9) * dni) + wypozyczenie.kaucja) + 1000);
                }
                else
                {
                    wypozyczenie.koszt = Convert.ToInt32(((wypozyczenie.cena_dzienna * 0.9) * dni) + wypozyczenie.kaucja);
                }
            }
            else
            {
                if (cbx_Ubezpiecznie.Checked == true)
                {
                    wypozyczenie.koszt = Convert.ToInt32(((wypozyczenie.cena_dzienna * dni) + wypozyczenie.kaucja) + 1000);
                }
                else
                {
                    wypozyczenie.koszt = Convert.ToInt32((wypozyczenie.cena_dzienna * dni) + wypozyczenie.kaucja);
                }
            }


            txt_koszt.Text = Convert.ToString(wypozyczenie.koszt);
        }

        private void dtp_Datazwrotu_BindingContextChanged(object sender, EventArgs e)
        {
            //kwota();
        }

        private void cbx_Ubezpiecznie_CheckedChanged(object sender, EventArgs e)
        {
            kwota();
        }

        private void dtp_Datazwrotu_ValueChanged(object sender, EventArgs e)
        {
            kwota();
        }

        private void dtp_Datawypo_ValueChanged(object sender, EventArgs e)
        {
            kwota();
        }
    }
}
