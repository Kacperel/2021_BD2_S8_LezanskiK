using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Skaner
{
    public partial class Skaner : Form
    {
        public Skaner()
        {
            InitializeComponent();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT nazwa_wyciagu FROM public.wyciag";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                // DataTable dt = new DataTable();
                // dt.Load(dr);
                //comboBox1.DataSource = dt;
                //comboBox1.Items.Add(dr);
                while (dr.Read())
                {
                    wybrany_wyciag.Items.Add(dr[0].ToString());
                }



            }
            comm.Dispose();
            conn.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'stacja_narciarskaDataSet1.wyciag' . Możesz go przenieść lub usunąć.
            //this.wyciagTableAdapter.Fill(this.stacja_narciarskaDataSet1.wyciag);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'stacja_narciarskaDataSet.wyciag' . Możesz go przenieść lub usunąć.
            //this.wyciagTableAdapter.Fill(this.stacja_narciarskaDataSet.wyciag);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "INSERT INTO public.historia(data, sposob_wejscia, rozklad_wyciagu_id_rozklad, karnet_id_karnet, bilet_id_bilet) VALUES(CURRENT_DATE, rodzaj_wejscia, id_rozklad, ?, ?); ";
            //id_rozklad = "SELECT id_rozklad FROM public.rozklad_wyciagu where id_wyciag=(select id_wyciag from public.wyciag where nazwa_wyciagu='lewy_stok') and data_pocz<current_date and current_date<data_konc";

            comm.Dispose();
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void narciarz_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
