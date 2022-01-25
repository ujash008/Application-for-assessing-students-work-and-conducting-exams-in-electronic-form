using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudendGradeWFA
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String studentId = textBox1.Text;
            if (Regex.IsMatch(studentId, @"^\d+$"))
            {
                SqlActionsFacade facade = new SqlActionsFacade();
                Boolean deleteSuccessful = facade.deleteStudent(int.Parse(studentId));
                if (deleteSuccessful)
                {
                    resultMessage.BackColor = Color.Green;
                    resultMessage.Text = "Delete successful!";
                }
                else
                {
                    resultMessage.BackColor = Color.Red;
                    resultMessage.Text = "There is no student with this ID!";
                }
            }
            else 
            {
                resultMessage.BackColor = Color.Red;
                resultMessage.Text = "Student ID must be a number!";
            }
        }
    }
}
