using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppGyumolcsokAdattablabol
{
    internal class Database
    {
        private MySqlConnection connection;
        private MySqlCommand sqlCommand;
        private string hibaSzöveg = null;
        public Database(string host,string user,string password,string db)
        {
            MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();
            stringBuilder.Server = host;
            stringBuilder.UserID = user;
            stringBuilder.Password = password;
            stringBuilder.Database = db;
            connection = new MySqlConnection(stringBuilder.ConnectionString);
            sqlCommand = connection.CreateCommand();
        }
        private bool dbOpen()
        {
            try
            {
                if (connection.State!=System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                hibaSzöveg=ex.Message;
                return false;
            }
            return true;
        }
        private bool dbClose()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                hibaSzöveg = ex.Message;
                return false;
            }
            return true;
        }

        public List<Gyumolcs> getAllGyumolcs()
        {
            List<Gyumolcs> gyumolcs=new List<Gyumolcs> ();
            sqlCommand.CommandText = "SELECT `id`,`nev`,`egysegar`,`mennyiseg` FROM `gyumolcsok` WHERE 1;";
            if (dbOpen())
            {
                using (MySqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Gyumolcs uj = new Gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                        gyumolcs.Add(uj);
                    }
                }
            }
            else
            {
                MessageBox.Show(hibaSzöveg);
            }
            dbClose();
            return gyumolcs;
        }
    }
}
