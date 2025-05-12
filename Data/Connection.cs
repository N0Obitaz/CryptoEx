using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WebSocketStreamingWithUI.Data
{
    public class Connection
    {

        private readonly string connectionString;
       
        public Connection()
        {
            string server = "localhost";
            string database = "multicurrency";
            string username = "root";
            string password = "";
            connectionString = $"SERVER={server};DATABASE={database};USERNAME={username};PASSWORD={password};";


        }
        public string GetConnectionString()
        {
            return connectionString;

        }


    }




}
