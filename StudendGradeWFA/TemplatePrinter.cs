using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    abstract class TemplatePrinter
    {
        public String buildStudentPrinterMessage(Student student)
        {
            String personalInformation = buildPersonalInformation(student);
            String gradesInformation = buildGradesInformation(student);

            return "Personal Information: " + "\r\n" +
                personalInformation + "Grades Information: " + "\r\n" + gradesInformation + "\r\n";
        }

        protected String buildPersonalInformation(Student student)
        {
            String personalInformation = "Student ID: " + student.StudentId + "\r\n" +
                "First Name: " + student.FirstName + "\r\n" +
                "Surname: " + student.Surname + "\r\n" +
                "Gender: " + student.Gender + "\r\n" +
                "Age: " + student.Age + "\r\n" +
                "Mobile: " + student.Mobile + "\r\n" +
                "Address: " + student.Address + "\r\n" +
                "Post Code: " + student.PostCode + "\r\n";

            return personalInformation;
        }

        protected abstract String buildGradesInformation(Student student);

    }
}
