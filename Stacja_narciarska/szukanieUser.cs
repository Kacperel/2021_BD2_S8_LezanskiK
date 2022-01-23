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
    
    public partial class szukanieUser : UserControl
    {
        public static string setValue = "";

        public szukanieUser()
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            Form1 logForm = new Form1();
            logForm.Show();
            
        }

        private void findIdButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
                conn.Open();

                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT id_karnet FROM public.karnet where id_karnet='" + textBox1.Text + "'";
                NpgsqlDataReader dr = comm.ExecuteReader();

                if (dr.HasRows)
                {
                    
                    szukanie_biletu x = new szukanie_biletu(textBox1.Text);
                    x.Show();
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
                MessageBox.Show("Nie podano ID karnetu!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
