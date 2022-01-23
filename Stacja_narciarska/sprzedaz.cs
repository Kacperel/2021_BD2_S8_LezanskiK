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

namespace Stacja_narciarska
{
    public partial class sprzedaz : UserControl
    {
        public sprzedaz()
        {

            InitializeComponent();



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aktualizuj_Click(object sender, EventArgs e)
        {

        }

        private void aktualizuj_Click_1(object sender, EventArgs e)
        {
            rodzajWejscia.Items.Clear();
            if (bilet_karnet.SelectedItem.ToString() == "karnet")
            {
                NpgsqlConnection conn7 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
                conn7.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn7;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT nazwa FROM public.rodzaj_karnetu";
                NpgsqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        rodzajWejscia.Items.Add(dr[0].ToString());
                    }
                }
                comm.Dispose();
                conn7.Close();
            }
            else if (bilet_karnet.Text == "bilet")
            {
                NpgsqlConnection conn7 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
                conn7.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn7;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT nazwa FROM public.rodzaj_biletu";
                NpgsqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        rodzajWejscia.Items.Add(dr[0].ToString());
                    }
                }
                comm.Dispose();
                conn7.Close();
            }
        }

        private void potwierdz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rodzajWejscia.Text))
            {
                if (!string.IsNullOrEmpty(ilosc.Text))
                {

                    NpgsqlConnection conn4 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
                    conn4.Open();

                    NpgsqlCommand comm4 = new NpgsqlCommand();
                    comm4.Connection = conn4;
                    comm4.CommandType = CommandType.Text;
                    if (bilet_karnet.Text == "karnet")
                    {
                        for(int i=0; i<int.Parse(ilosc.SelectedItem.ToString());i++)
                        { 
                        comm4.CommandText = "WITH ins AS ( INSERT INTO public.karnet(czy_zablokowany, cena_karnetu_cena_karnetu)SELECT 'false', cena_karnetu_id FROM public.cena_karnetu cen INNER JOIN public.rodzaj_karnetu rodz on rodz.id_rodzaj_karnetu = cen.rodzaj_karnetu_id_rodzaj_karnetu WHERE rodz.nazwa = '" + rodzajWejscia.Text + "' RETURNING id_karnet) INSERT INTO public.transakcja(data_sprzedazy, karnet_id_karnet) SELECT current_timestamp, id_karnet FROM ins;";
                        comm4.ExecuteNonQuery();
                        }
                    }
                    else if (bilet_karnet.Text == "bilet")
                    {
                        for (int i = 0; i < int.Parse(ilosc.SelectedItem.ToString()); i++)
                        {
                            comm4.CommandText = "WITH ins AS ( INSERT INTO public.bilet(czy_zablokowany, cena_biletu_cena_biletu)SELECT 'false', cena_biletu_id FROM public.cena_biletu cen INNER JOIN public.rodzaj_biletu rodz on rodz.id_rodzaj_biletu = cen.rodzaj_biletu_id_rodzaj_biletu WHERE rodz.nazwa = '" + rodzajWejscia.Text + "' RETURNING id_bilet) INSERT INTO public.transakcja(data_sprzedazy, bilet_id_bilet) SELECT current_timestamp, id_bilet FROM ins;";
                        comm4.ExecuteNonQuery();
                        }
                    }
                    
                    MessageBox.Show("Zakupiono pomyslnie");

                    comm4.Dispose();
                    conn4.Close();

                }
                else
                {
                    MessageBox.Show("Nie podano ilosci!");
                }
            }
            else
            {
                MessageBox.Show("Nie wybrabo wejscia");
            }
        }
    }
}
