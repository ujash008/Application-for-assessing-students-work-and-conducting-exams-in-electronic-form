using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    class ConcreteSubject : ISubject
    {
        private String subjectName;
        private int subjectGrade;

        public ConcreteSubject(String subjectName, int subjectGrade)
        {
            this.subjectName = subjectName;
            this.subjectGrade = subjectGrade;
        }

        public string subjectMessage()
        {
            return subjectName + ": " + subjectGrade;
        }
    }
}
