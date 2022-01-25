using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    class DBConnector
    {
        private MySqlConnection mySqlConn = null;
        private static DBConnector dbConnectorInstance = null;
        private static String connectionString = "server=localhost;port=3307;database=students;uid=root;pwd=root;";

        private DBConnector()
        {
            mySqlConn = new MySqlConnection(connectionString);
            mySqlConn.Open();
        }

        public static DBConnector getInstance()
        {
            if (dbConnectorInstance == null)
            {
                dbConnectorInstance = new DBConnector();
            }

            return dbConnectorInstance;
        }

        public MySqlConnection getMySqlConnection()
        {
            return mySqlConn;
        }
    }
}
