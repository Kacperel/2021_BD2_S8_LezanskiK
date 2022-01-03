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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT login, haslo FROM public.pracownicy where login='"+login.Text+"'and haslo='"+password.Text+"'";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                this.Hide();
                panel x = new panel();
                x.Show();
                
            }
            else
            {
                MessageBox.Show("Login lub hasło jest nieprawidłowe!");
            }
            comm.Dispose();
            conn.Close();
        }

    }
}
