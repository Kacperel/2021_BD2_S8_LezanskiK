using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (login.Text == "admin" && password.Text == "admin")
            {
                this.Hide();
                panel x = new panel();
                x.Show();
                
            }
            else
            {
                MessageBox.Show("Login lub hasło jest nieprawidłowe!");
            }
        }

      
    }
}
