using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    class SubjectCreator : Subject
    {
        private String subjectName;
        private int subjectGrade;

        public SubjectCreator(String subjectName, int subjectGrade)
        {
            this.subjectName = subjectName;
            this.subjectGrade = subjectGrade;
        }

        public override ISubject FactoryMethod()
        {
            return new ConcreteSubject(subjectName, subjectGrade); 
        }
    }
}
