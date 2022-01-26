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
            if (!string.IsNullOrEmpty(narciarz_ID.Text))
            {
                if (!string.IsNullOrEmpty(rodzajWejscia.Text))
                {
                    if (!string.IsNullOrEmpty(wybrany_wyciag.Text))
                    {
                        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
                        conn.Open();

                        NpgsqlCommand comm = new NpgsqlCommand();
                        comm.Connection = conn;
                        comm.CommandType = CommandType.Text;
                        comm.CommandText = "SELECT id_karnet FROM public.karnet where id_karnet='" + narciarz_ID.Text + "'";
                        NpgsqlDataReader dr = comm.ExecuteReader();

                        if (dr.HasRows)
                        {
                            NpgsqlConnection conn7 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
                            conn7.Open();
                            NpgsqlCommand comm2 = new NpgsqlCommand();
                            comm2.Connection = conn7;
                            comm2.CommandType = CommandType.Text;
                            if (rodzajWejscia.Text == "bilet")
                            {
                                comm2.CommandText = "INSERT INTO public.historia(data, sposob_wejscia, rozklad_wyciagu_id_rozklad, bilet_id_bilet) SELECT current_timestamp, 'bilet', id_rozklad, '" + narciarz_ID.Text + "'  FROM public.rozklad_wyciagu rz INNER JOIN public.wyciag wy on wy.id_wyciag = rz.id_wyciag WHERE wy.nazwa_wyciagu='" + wybrany_wyciag.Text + "'";
                            }
                            else if (rodzajWejscia.Text == "karnet")
                            {
                                comm2.CommandText = "INSERT INTO public.historia(data, sposob_wejscia, rozklad_wyciagu_id_rozklad, karnet_id_karnet) SELECT current_timestamp, 'karnet', id_rozklad, '" + narciarz_ID.Text + "'  FROM public.rozklad_wyciagu rz INNER JOIN public.wyciag wy on wy.id_wyciag = rz.id_wyciag WHERE wy.nazwa_wyciagu='" + wybrany_wyciag.Text + "'";
                            }

                            NpgsqlDataReader dr2 = comm2.ExecuteReader();

                            comm2.Dispose();
                            conn7.Close();

                            MessageBox.Show("Mozna wejsc na stok.");


                        }
                        else
                        {
                            MessageBox.Show("Dane ID nie istnieje.");
                        }

                        comm.Dispose();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nie wybrabo wyciagu.");
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano rodzaju wejscia.");
                }
            }
            else
            {
                MessageBox.Show("Nie podano ID narciarza.");
            }


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

        private void rodzajWejscia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
