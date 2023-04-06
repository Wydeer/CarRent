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
    public partial class DodajUbezpieczenie : Form
    {
        public DodajUbezpieczenie()
        {
            InitializeComponent();
        }
        string conn = Conn.conn;
        
        public void pokaz_siatke()
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Samochod WHERE id_samochodu NOT IN (SELECT id_samochodu FROM Ubezpieczenie)", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_Dubezpieczenie.DataSource = table;
            connection.Close();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ubezpieczenie ubezpieczenie = new Ubezpieczenie();
            ubezpieczenie.id_samochodu = Convert.ToInt32(dgv_Dubezpieczenie.CurrentRow.Cells[0].Value);
            ubezpieczenie.data_od = dtp_DUdata_od.Value;
            ubezpieczenie.data_do = dtp_DUdata_do.Value;
            ubezpieczenie.typ = cbx_typ.Text;
            
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Ubezpieczenie (id_samochodu, data_od, data_do, typ) VALUES (@id_samochodu, @data_od, @data_do, @typ)", connection);
            command.Parameters.AddWithValue("@id_samochodu", ubezpieczenie.id_samochodu);
            command.Parameters.AddWithValue("@data_od", ubezpieczenie.data_od);
            command.Parameters.AddWithValue("@data_do", ubezpieczenie.data_do);
            command.Parameters.AddWithValue("@typ", ubezpieczenie.typ);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Dodano ubezpieczenie");
            this.Hide();
            Ubezpieczenia ubezpieczenia = new Ubezpieczenia();
            ubezpieczenia.Show();

        }

        private void DodajUbezpieczenie_Load(object sender, EventArgs e)
        {
            pokaz_siatke();
            dgv_Dubezpieczenie.Columns[0].Visible = false;
        }

        private void dtp_DUdata_od_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
