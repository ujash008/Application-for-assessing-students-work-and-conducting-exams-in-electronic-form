using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    class Student
    {
        private int studentId;
        private String courseCode;
        private String firstName;
        private String surname;
        private String gender;
        private int age;
        private String address;
        private String postCode;
        private String mobile;
        private List<ConcreteSubject> subjectList;
        private int addMaths;
        private int maths;
        private int business;
        private int biology;
        private int chemistry;
        private int computing;
        private int english;
        private int physics;
        private int average;

        public int StudentId { get => studentId; set => studentId = value; }
        public string CourseCode { get => courseCode; set => courseCode = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public string PostCode { get => postCode; set => postCode = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public int AddMaths { get => addMaths; set => addMaths = value; }
        public int Maths { get => maths; set => maths = value; }
        public int Business { get => business; set => business = value; }
        public int Biology { get => biology; set => biology = value; }
        public int Chemistry { get => chemistry; set => chemistry = value; }
        public int Computing { get => computing; set => computing = value; }
        public int English { get => english; set => english = value; }
        public int Physics { get => physics; set => physics = value; }
        public int Average { get => average; set => average = value; }
        internal List<ConcreteSubject> SubjectList { get => subjectList; set => subjectList = value; }
    }
}
