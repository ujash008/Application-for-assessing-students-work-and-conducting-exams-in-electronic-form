using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    class SqlActionsFacade
    {
        private AddStudentAction addStudentAction;
        private DeleteStudentAction deleteStudentAction;
        private RetrieveStudentAction retrieveStudentAction;

        public SqlActionsFacade()
        {
            addStudentAction = new AddStudentAction();
            deleteStudentAction = new DeleteStudentAction();
            retrieveStudentAction = new RetrieveStudentAction();
        }

        public void insertStudent(int studentId, String course_code, String firstName, String surname, String gender,
            int age, String address, String postCode, String mobile, int addMaths, int maths, int business,
            int biology, int chemistry, int computing, int english, int physics, int average)
        {
            String query = addStudentAction.buildInsertQuery(studentId, course_code, firstName, surname, gender, age, address, postCode,
                mobile, addMaths, maths, business, biology, chemistry, computing, english, physics, average);
            DBConnector dbConnector = DBConnector.getInstance();
            MySqlConnection conn = dbConnector.getMySqlConnection();
            MySqlCommand cmd = addStudentAction.buildMySqlCommand(query, conn);
            addStudentAction.executeInsert(cmd);
        }

        public Boolean deleteStudent(int studentId)
        {
            String query = deleteStudentAction.buildDeleteQuery(studentId);
            DBConnector dbConnector = DBConnector.getInstance();
            MySqlConnection conn = dbConnector.getMySqlConnection();
            MySqlCommand cmd = deleteStudentAction.buildMySqlCommand(query, conn);
            return deleteStudentAction.executeDelete(cmd);
        }

        public StudentCollection retrieveStudents()
        {
            String query = retrieveStudentAction.buildRetrieveQuery();
            DBConnector dbConnector = DBConnector.getInstance();
            MySqlConnection conn = dbConnector.getMySqlConnection();
            MySqlCommand cmd = retrieveStudentAction.buildMySqlCommand(query, conn);
            return retrieveStudentAction.executeRetrieve(cmd);
        }
    }
}
