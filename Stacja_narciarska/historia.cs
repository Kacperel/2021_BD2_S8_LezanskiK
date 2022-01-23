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
    public partial class historia : UserControl
    {
        public historia()
        {
            InitializeComponent();
        }

        private void szukaj_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(podaneID.Text))
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Stacja_narciarska;User Id=postgres;Password=rowery;");
                conn.Open();

                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT hi.data , wy.nazwa_wyciagu FROM public.historia hi INNER JOIN public.rozklad_wyciagu rz on hi.rozklad_wyciagu_id_rozklad = rz.id_rozklad LEFT JOIN public.wyciag wy on wy.id_wyciag = rz.id_rozklad WHERE hi.karnet_id_karnet = '" + podaneID.Text + "'";
                NpgsqlDataReader dr = comm.ExecuteReader();


                if (dr.HasRows)
                {

                    lista.Columns.Clear(); // Clear previously added columns
                    lista.Items.Clear(); // Clear previously populated items
                    lista.View = View.Details; // Set View property

                    lista.Columns.Add("Data");
                    lista.Columns.Add("Nazwa wyciagu");

                    
                    while (dr.Read())
                    {
                        ListViewItem lv = new ListViewItem(dr[0].ToString());
                        lv.SubItems.Add(dr[1].ToString());
                        lista.Items.Add(lv);
                    }
                    lista.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lista.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


                }
                else
                {
                    MessageBox.Show("Podane ID nie istnieje lub nie ma historii");
                }
                comm.Dispose();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Nie podano ID!");
            }    
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
