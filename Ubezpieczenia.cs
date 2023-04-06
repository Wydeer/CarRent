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
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Ubezpieczenie.id_ubezpieczenia ,Samochod.numer_rej, Ubezpieczenie.data_od, Ubezpieczenie.data_do, Ubezpieczenie.typ FROM Samochod JOIN Ubezpieczenie ON Samochod.id_samochodu = Ubezpieczenie.id_samochodu;", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_ubezpieczenia.DataSource = table;
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

        }

        private void btn_UUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunać to ubezpieczenie?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(Conn.conn);
                conn.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Ubezpieczenie WHERE id_ubezpieczenia = @id_ubezpieczenia", conn);
                command.Parameters.AddWithValue("@id_ubezpieczenia", dgv_ubezpieczenia.CurrentRow.Cells[0].Value);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Usunięto ubezpieczenie");
                
            }
            pokaz_siatke();
        }

        private void btn_UModyfikuj_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Conn.conn);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Ubezpieczenie SET data_od = @data_od, data_do = @data_do, typ = @typ WHERE id_ubezpieczenia = @id_ubezpieczenia", sqlConnection);
            command.Parameters.AddWithValue("@id_ubezpieczenia", dgv_ubezpieczenia.CurrentRow.Cells[0].Value);
            command.Parameters.AddWithValue("@data_od", dtp_EUdata_od.Value);
            command.Parameters.AddWithValue("@data_do", dtp_EUdata_do.Value);
            command.Parameters.AddWithValue("@typ", cbx_EUtyp.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Zmodyfikowano ubezpieczenie");
            pokaz_siatke();


        }

        private void dgv_ubezpieczenia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgv_ubezpieczenia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_ubezpieczenia.CurrentRow.Selected = true;
            dtp_EUdata_od.Text = dgv_ubezpieczenia.CurrentRow.Cells[2].Value.ToString();
            dtp_EUdata_do.Text = dgv_ubezpieczenia.CurrentRow.Cells[3].Value.ToString();
            cbx_EUtyp.Text = dgv_ubezpieczenia.CurrentRow.Cells[4].Value.ToString();

            
        }
    }
}
