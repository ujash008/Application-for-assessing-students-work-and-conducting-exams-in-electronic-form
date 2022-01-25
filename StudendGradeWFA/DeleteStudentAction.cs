using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    class DeleteStudentAction
    {
        public String buildDeleteQuery(int studentId)
        {
            return "DELETE FROM STUDENTS WHERE student_id = " + studentId;
        }

        public MySqlCommand buildMySqlCommand(String query, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            return cmd;
        }

        public Boolean executeDelete(MySqlCommand cmd)
        {
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            return false;
        }
    }
}
