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
    public partial class zmianaCen : UserControl
    {

        public zmianaCen()
        {
            InitializeComponent();
            NpgsqlConnection conn7 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
            conn7.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn7;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT nazwa FROM public.rodzaj_karnetu";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                // DataTable dt = new DataTable();
                // dt.Load(dr);
                //comboBox1.DataSource = dt;
                //comboBox1.Items.Add(dr);
                while (dr.Read())
                {
                    lista_karnety.Items.Add(dr[0].ToString());
                }



            }
            comm.Dispose();
            conn7.Close();

            NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
            conn2.Open();
            NpgsqlCommand comm2 = new NpgsqlCommand();
            comm2.Connection = conn2;
            comm2.CommandType = CommandType.Text;
            comm2.CommandText = "SELECT nazwa FROM public.rodzaj_biletu";
            NpgsqlDataReader dr2 = comm2.ExecuteReader();
            if (dr2.HasRows)
            {
                // DataTable dt = new DataTable();
                // dt.Load(dr);
                //comboBox1.DataSource = dt;
                //comboBox1.Items.Add(dr);
                while (dr2.Read())
                {
                    lista_bilety.Items.Add(dr2[0].ToString());
                }



            }
            comm2.Dispose();
            conn2.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zmianaCen_Load(object sender, EventArgs e)
        {

        }

        private void lista_karnety_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void karnet_update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lista_karnety.Text))
            {
                if (!string.IsNullOrEmpty(cena_karnet.Text))
                {
                    NpgsqlConnection conn3 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
                    conn3.Open();

                    NpgsqlCommand comm3 = new NpgsqlCommand();
                    comm3.Connection = conn3;
                    comm3.CommandType = CommandType.Text;
                    comm3.CommandText = "UPDATE public.cena_karnetu SET cena_karnetu='" + cena_karnet.Text + "' WHERE rodzaj_karnetu_id_rodzaj_karnetu = (SELECT id_rodzaj_karnetu FROM public.rodzaj_karnetu WHERE   nazwa='" + lista_karnety.Text + "')";
                    comm3.ExecuteNonQuery();
                    MessageBox.Show("Zaktualizowano pomyslnie");

                    comm3.Dispose();
                    conn3.Close();
                }
                else
                {
                    MessageBox.Show("Nie podano nowej ceny!");
                }
            }
            else
            {
                MessageBox.Show("Nie wybrabo karnetu!");
            }

        }

        private void bilet_update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lista_bilety.Text))
            {
                if (!string.IsNullOrEmpty(cena_bilet.Text))
                {
                    NpgsqlConnection conn4 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
                    conn4.Open();

                    NpgsqlCommand comm4 = new NpgsqlCommand();
                    comm4.Connection = conn4;
                    comm4.CommandType = CommandType.Text;
                    comm4.CommandText = "UPDATE public.cena_biletu SET cena_biletu='" + cena_bilet.Text + "' WHERE rodzaj_biletu_id_rodzaj_biletu = (SELECT id_rodzaj_biletu FROM public.rodzaj_biletu WHERE nazwa='" + lista_bilety.Text + "')";
                    comm4.ExecuteNonQuery();
                    MessageBox.Show("Zaktualizowano pomyslnie");

                    comm4.Dispose();
                    conn4.Close();

                }
                else
                {
                    MessageBox.Show("Nie podano nowej ceny!");
                }
            }
            else
            {
                MessageBox.Show("Nie wybrabo biletu!");
            }
        }

        private void cena_karnet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
