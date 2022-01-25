using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudendGradeWFA
{
    class InputValidator
    {
        private String studentId, course_code, firstName, surname, gender, age, address, postCode,
            mobile, addMaths, maths, business, biology, chemistry, computing, english, physics;

        public InputValidator(String studentId, String course_code, String firstName, String surname, String gender,
            String age, String address, String postCode, String mobile, String addMaths, String maths, String business,
            String biology, String chemistry, String computing, String english, String physics)
        {
            this.studentId = studentId;
            this.course_code = course_code;
            this.firstName = firstName;
            this.surname = surname;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.postCode = postCode;
            this.mobile = mobile;
            this.addMaths = addMaths;
            this.maths = maths;
            this.business = business;
            this.biology = biology;
            this.chemistry = chemistry;
            this.computing = computing;
            this.english = english;
            this.physics = physics;
        }

        public Boolean checkIfInputsAreEmpty()
        {
            if (String.IsNullOrEmpty(studentId) || String.IsNullOrEmpty(course_code) || String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(surname)
                || String.IsNullOrEmpty(gender) || String.IsNullOrEmpty(age) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(postCode)
                || String.IsNullOrEmpty(mobile) || String.IsNullOrEmpty(addMaths) || String.IsNullOrEmpty(maths) || String.IsNullOrEmpty(business)
                || String.IsNullOrEmpty(biology) || String.IsNullOrEmpty(chemistry) || String.IsNullOrEmpty(computing) || String.IsNullOrEmpty(english)
                || String.IsNullOrEmpty(physics)) {
                return true;
            }
            return false;
        }

        public Boolean isStudentIdValid()
        {
            if (Regex.IsMatch(studentId, @"^\d+$"))
            {
                return true;
            }
            return false;
        }

        public Boolean isAgeValid()
        {
            if (Regex.IsMatch(age, @"^\d+$"))
            {
                return true;
            }
            return false;
        }

        public Boolean areGradesValid()
        {
            if (Regex.IsMatch(addMaths, @"^\d+$") && Regex.IsMatch(maths, @"^\d+$") && Regex.IsMatch(business, @"^\d+$") 
                && Regex.IsMatch(biology, @"^\d+$") && Regex.IsMatch(chemistry, @"^\d+$") && Regex.IsMatch(computing, @"^\d+$")
                && Regex.IsMatch(english, @"^\d+$") && Regex.IsMatch(physics, @"^\d+$"))
            {
                return true;
            }
            return false;
        }
    }
}
