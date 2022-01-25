using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    class RetrieveStudentAction
    {
        public String buildRetrieveQuery()
        {
            return "SELECT * FROM STUDENTS";
        }

        public MySqlCommand buildMySqlCommand(String query, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            return cmd;
        }

        public StudentCollection executeRetrieve(MySqlCommand cmd)
        {
            StudentCollection studentCollection = new StudentCollection();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Student student = new Student();
                student.CourseCode = reader.GetString(0);
                student.FirstName = reader.GetString(1);
                student.Surname = reader.GetString(2);
                student.Gender = reader.GetString(3);
                student.Age = reader.GetInt16(4);
                student.Address = reader.GetString(5);
                student.PostCode = reader.GetString(6);
                student.Mobile = reader.GetString(7);

                List<ConcreteSubject> subjects = new List<ConcreteSubject>();
                subjects.Add(new ConcreteSubject("Add Maths", reader.GetInt16(8)));
                subjects.Add(new ConcreteSubject("Maths", reader.GetInt16(9)));
                subjects.Add(new ConcreteSubject("Business", reader.GetInt16(10)));
                subjects.Add(new ConcreteSubject("Biology", reader.GetInt16(11)));
                subjects.Add(new ConcreteSubject("Chemistry", reader.GetInt16(12)));
                subjects.Add(new ConcreteSubject("Computing", reader.GetInt16(13)));
                subjects.Add(new ConcreteSubject("English", reader.GetInt16(14)));
                subjects.Add(new ConcreteSubject("Physics", reader.GetInt16(15)));

                student.SubjectList = subjects;
                /*student.AddMaths = reader.GetInt16(8);
                student.Maths = reader.GetInt16(9);
                student.Business = reader.GetInt16(10);
                student.Biology = reader.GetInt16(11);
                student.Chemistry = reader.GetInt16(12);
                student.Computing = reader.GetInt16(13);
                student.English = reader.GetInt16(14);
                student.Physics = reader.GetInt16(15);*/
                student.Average = reader.GetInt16(16);
                student.StudentId = reader.GetInt16(17);
                studentCollection.AddItem(student);
            }

            reader.Close();

            return studentCollection;
        }
    }
}
