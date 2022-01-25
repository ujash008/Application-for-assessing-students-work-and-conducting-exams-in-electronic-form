using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    abstract class Subject
    {

        public abstract ISubject FactoryMethod();

        public string printSubject()
        {
            var subject = FactoryMethod();
            var result = subject.subjectMessage();

            return result;
        }
    }
}
