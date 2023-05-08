
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Cinema.Model
{
    class DBHandler
    {
        private static DBHandler instance = null;
        private SqlConnection backend = null;

        private DBHandler()
        {
            connectToDB();
        }

        public static DBHandler getInstance()
        {
            if (instance == null)
                instance = new DBHandler();

            return instance;
        }

        private void connectToDB()
        {
            backend = new SqlConnection(@"Data Source=(local);Initial Catalog=CinemaSystem;Integrated Security=True");
            backend.Open();
        }

        //private bool isConnected() => backend != null;

        public SqlConnection getConnection() => backend;
    }
}
