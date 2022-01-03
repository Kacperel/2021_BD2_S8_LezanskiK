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
    public partial class panel : Form
    {
        public panel()
        {
            InitializeComponent();
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
    }
}
