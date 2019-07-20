using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitgenRealtimeLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application("Approaching to realtime test!");
            int cs = app.connect_terminal();
            if (cs > 0)
            {
                app.login();
                app.setLoginData(app.m_AccessManager);
                //app.showUser();
            }

            //mysqlTEst();
            Console.In.ReadLine();
        }

        static void mysqlTEst()
        {
            string cs = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.Connection.Open();

                Console.Out.WriteLine(cs + ":=MySQL[state=" + con.State + "| server=" + con.ServerVersion);
            }
        }
    }
}
