using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    class GradesPrinter : TemplatePrinter
    {
        protected override string buildGradesInformation(Student student)
        {
            List<ConcreteSubject> subjects = student.SubjectList;

            String gradesInformation = "";
            foreach(ConcreteSubject subject in subjects)
            {
                gradesInformation += subject.subjectMessage() + "\r\n";
            }
            /*String gradesInformation = "Add Maths: " + student.AddMaths + "\r\n" +
                "Maths: " + student.Maths + "\r\n" +
                "Business: " + student.Business + "\r\n" +
                "Biology: " + student.Biology + "\r\n" +
                "Chemistry: " + student.Chemistry + "\r\n" +
                "Computing: " + student.Computing + "\r\n" +
                "English: " + student.English + "\r\n" +
                "Physics: " + student.Physics + "\r\n" +
                "Average: " + student.Average + "\r\n";*/

            gradesInformation += "Average: " + student.Average + "\r\n";

            return gradesInformation;
        }
    }
}
