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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlActionsFacade facade = new SqlActionsFacade();
            StudentCollection collection = facade.retrieveStudents();

            displayItems.Text = "";
            if (collection.getItems().Count != 0)
            {
                TemplatePrinter templatePrinter = new GradesPrinter();
                foreach (Student student in collection.getItems()) 
                {
                    String printerMessage = templatePrinter.buildStudentPrinterMessage(student);
                    displayItems.AppendText(printerMessage);
                }
            }
            else 
            {
                displayItems.Text = "NO ITEMS TO DISPLAY FOR NOW!";
            }

        }
    }
}
