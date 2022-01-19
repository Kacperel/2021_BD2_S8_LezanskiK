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
    public partial class wyciagi : UserControl
    {
        public wyciagi()
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
                    wybor_wyciagu.Items.Add(dr[0].ToString());
                }
                


            }
            comm.Dispose();
            conn.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zablokuj_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aktualizuj_Click(object sender, EventArgs e)
        {
            string wybrany_stan;
            if (zablokowany.Checked == true)
            {
                wybrany_stan = "false";
            }
            else
            {
                wybrany_stan = "true";

            }

            NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
            conn2.Open();

            NpgsqlCommand comm2 = new NpgsqlCommand();
            comm2.Connection = conn2;
            comm2.CommandType = CommandType.Text;
            comm2.CommandText = "UPDATE public.wyciag SET  status_wyciagu="+wybrany_stan+" WHERE nazwa_wyciagu='"+ wybor_wyciagu.Text+"'";
            comm2.ExecuteNonQuery();
            MessageBox.Show("Zaktualizowano pomyslnie");
           
            comm2.Dispose();
            conn2.Close();
        }
    }
}