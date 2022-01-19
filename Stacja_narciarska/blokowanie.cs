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
    public partial class blokowanie : UserControl
    {
        public blokowanie()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(podaneID.Text))
            {

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT id_karnet FROM public.karnet where id_karnet='"+podaneID.Text +"'";
            NpgsqlDataReader dr = comm.ExecuteReader();

            string wybrany_stan="";
            if (zablokowany.Checked == true)
            {
                wybrany_stan = "true";
            }
            else
            {
                wybrany_stan = "false";
            }
            if (dr.HasRows)
            {
                if(zablokowany.Checked||odblokowany.Checked)
                {
                    NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
                    conn2.Open();

                    NpgsqlCommand comm2 = new NpgsqlCommand();
                    comm2.Connection = conn2;
                    comm2.CommandType = CommandType.Text;
                    comm2.CommandText = "UPDATE public.karnet SET czy_zablokowany=" + wybrany_stan + " WHERE id_karnet='" + podaneID.Text + "'";
                    comm2.ExecuteNonQuery();
                    MessageBox.Show("Zaktualizowano pomyslnie");

                    comm2.Dispose();
                    conn2.Close();
                }
                else
                {
                    MessageBox.Show("Nie wybrano stanu!");
                }    
            }
            else
            {
                MessageBox.Show("Karnet o podanym ID nie istnieje!");
            }
            comm.Dispose();
            conn.Close();



            }
            else
            {
                MessageBox.Show("Nie podano ID karnetu!");
            }
        }
    }
}
