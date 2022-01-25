using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudendGradeWFA
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String _studentId = studentId.Text;
            String _courseCode = courseCode.Text;
            String _firstName = firstName.Text;
            String _surname = surname.Text;
            String _gender = gender.SelectedItem != null ? gender.SelectedItem.ToString() : null;
            String _age = age.Text;
            String _address = address.Text;
            String _postCode = postCode.Text;
            String _mobile = mobile.Text;
            String _addMaths = addMaths.Text;
            String _maths = maths.Text;
            String _business = business.Text;
            String _biology = biology.Text;
            String _chemistry = chemistry.Text;
            String _computing = computing.Text;
            String _english = english.Text;
            String _physics = physics.Text;

            InputValidator inputValidator = new InputValidator(_studentId, _courseCode, _firstName, _surname, _gender, _age, _address, _postCode, _mobile,
                _addMaths, _maths, _business, _biology, _chemistry, _computing, _english, _physics);
            ValidatorInterface validator = new InputAdapter(inputValidator);
            int validationResult = validator.validateInput();
            if (validationResult == Constants.INPUT_VALID)
            {
                int _total = int.Parse(_addMaths) + int.Parse(_maths) + int.Parse(_business) + int.Parse(_biology) + int.Parse(_chemistry) + int.Parse(_computing)
                    + int.Parse(_english) + int.Parse(_physics);
                int _average = _total / 8;
                SqlActionsFacade facade = new SqlActionsFacade();
                try
                {
                    facade.insertStudent(int.Parse(_studentId), _courseCode, _firstName, _surname, _gender, int.Parse(_age), _address, _postCode, _mobile, int.Parse(_addMaths),
                        int.Parse(_maths), int.Parse(_business), int.Parse(_biology), int.Parse(_chemistry), int.Parse(_computing), int.Parse(_english), int.Parse(_physics), _average);
                    resultMessage.BackColor = Color.Green;
                    resultMessage.Text = "Insert successfuly executed!";
                }
                catch(Exception ex)
                {
                    resultMessage.BackColor = Color.Red;
                    resultMessage.Text = "A student already exists with this ID!";
                }
            }
            else {
                resultMessage.BackColor = Color.Red;
                switch (validationResult)
                {
                    case Constants.FIELDS_EMPTY:
                        resultMessage.Text = "All fields are required! Please insert all fields!";
                        break;
                    case Constants.STUDENT_ID_INVALID:
                        resultMessage.Text = "Student ID must be a number!";
                        break;
                    case Constants.AGE_INVALID:
                        resultMessage.Text = "Student age must be a number!";
                        break;
                    case Constants.GRADES_INVALID:
                        resultMessage.Text = "Grades must be numbers! Check all grades again!";
                        break;
                }
            }
        }
    }
}
