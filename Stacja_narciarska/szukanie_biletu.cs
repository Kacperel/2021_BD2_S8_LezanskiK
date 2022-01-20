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
    public partial class szukanie_biletu : Form
    {
        public szukanie_biletu()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlConnection conn2 = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
            conn2.Open();

            NpgsqlCommand comm2 = new NpgsqlCommand();
            comm2.Connection = conn2;
            comm2.CommandType = CommandType.Text;
            //comm2.CommandText = "SELECT id_karnet FROM public.karnet where id_karnet='" + textBox1.Text + "'";
            NpgsqlDataReader dr = comm2.ExecuteReader();

        }
    }
}
