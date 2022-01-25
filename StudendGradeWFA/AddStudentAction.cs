using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    class AddStudentAction
    {
        public String buildInsertQuery(int studentId, String course_code, String firstName, String surname, String gender,
            int age, String address, String postCode, String mobile, int addMaths, int maths, int business,
            int biology, int chemistry, int computing, int english, int physics, int average)
        {
            return "INSERT INTO STUDENTS (student_id, course_code, first_name, surname, gender, age, address, post_code, mobile, add_maths," +
                "maths, business, biology, chemistry, computing, english, physics, average) VALUES (" + studentId + ", '" + course_code + "', '" + firstName + "', " +
                "'" + surname + "', '" + gender + "', " + age + ", '" + address + "', '" + postCode + "', '" + mobile + "', " + addMaths + ", " + maths + ", " +
                business + ", " + biology + ", " + chemistry + ", " + computing + ", " + english + ", " + physics + ", " + average + ")";
        }

        public MySqlCommand buildMySqlCommand(String query, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            return cmd;
        }

        public void executeInsert(MySqlCommand cmd)
        {
            cmd.ExecuteNonQuery();
        }
    }
}
