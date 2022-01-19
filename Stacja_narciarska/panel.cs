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
    public partial class panel : Form
    {
        public panel()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            
            
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            sprzedaz1.BringToFront();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            historia1.BringToFront();
        }

        private void wyciagButton_Click(object sender, EventArgs e)
        {
            wyciagi1.BringToFront();
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            zmianaCen1.BringToFront();
        }

        private void blockButton_Click(object sender, EventArgs e)
        {
            blokowanie1.BringToFront();
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            mapa1.BringToFront();
        }

        private void sprzedaz1_Load(object sender, EventArgs e)
        {

        }

        private void panel_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
            conn.Close();
        }
    }
}
