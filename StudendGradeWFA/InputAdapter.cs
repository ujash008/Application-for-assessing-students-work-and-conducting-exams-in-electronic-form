using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    class InputAdapter : ValidatorInterface
    {
        private readonly InputValidator inputValidator;

        public InputAdapter(InputValidator inputValidator)
        {
            this.inputValidator = inputValidator;
        }

        int ValidatorInterface.validateInput()
        {
            Boolean inputsEmpty = inputValidator.checkIfInputsAreEmpty();
            Boolean studendIdValid = inputValidator.isStudentIdValid();
            Boolean ageValid = inputValidator.isAgeValid();
            Boolean gradesValid = inputValidator.areGradesValid();

            if (!inputsEmpty)
            {
                if (!studendIdValid) 
                {
                    return Constants.STUDENT_ID_INVALID;                
                }

                if(!ageValid)
                {
                    return Constants.AGE_INVALID;
                }

                if(!gradesValid)
                {
                    return Constants.GRADES_INVALID;
                }

                return Constants.INPUT_VALID;
            }
            else
            {
                return Constants.FIELDS_EMPTY;
            }
        }
    }
}
