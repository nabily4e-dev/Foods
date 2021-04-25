using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Devart.Data;
using Devart.Data.PostgreSql;
using Npgsql;

namespace Foods
{
    class Database
    {

        //public static string databaseFileName = "foods.accdb";
        //public static OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databaseFileName + ";Persist Security Info=False");
        //public static OleDbCommand command = new OleDbCommand("", connect);

        //public static string databaseName = "foods";
        //public static PgSqlConnection pgConnect = new PgSqlConnection("Server=localhost;Port=5432;Database=" + databaseName + ";User id=postgres;password=postgresql;pooling=false");
        //public static PgSqlCommand pgCommand = new PgSqlCommand("", pgConnect);

        public static string databaseName = "foods";
        public static NpgsqlConnection pgConnect = new NpgsqlConnection("Server=localhost;Port=5432;Database=" + databaseName + ";User id=postgres;password=postgresql;");
        public static NpgsqlCommand pgCommand = new NpgsqlCommand("", pgConnect);

        public static void ChangeDatabaseName(string newDatabaseName)
        {

            if (pgConnect.State == ConnectionState.Closed)
            {

                pgConnect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + newDatabaseName + ";Persist Security Info=False";

            }

        }

        public static void OpenConnection()
        {

            if (pgConnect.State == ConnectionState.Closed) pgConnect.Open();

        }

        public static void CloseConnection()
        {

            if (pgConnect.State == ConnectionState.Open) pgConnect.Close();

        }

        public static DataTable GetData(string select)
        {

            DataTable table = new DataTable();
            pgCommand.CommandText = select;
            table.Load(pgCommand.ExecuteReader());
            return table;

        }

        public static void RunRequest(string querry)
        {

            pgCommand.CommandText = querry;
            pgCommand.ExecuteNonQuery();

        }

    }

}
