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
    public partial class mapa : UserControl
    {
        public mapa()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM public.pracownicy";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }

     
    }
}
