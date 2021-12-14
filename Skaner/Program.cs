using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Skaner
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TestConnection();
           // Console.ReadKey();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Skaner());
        }
        private static void TestConnection()
        {
            using(NpgsqlConnection con=GetConnection())
            {
                con.Open();
                if(con.State==System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("connected");
                }    
            }    
        }
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=rowery;Database=Stacja_narciarska;");
        }
    }
}
