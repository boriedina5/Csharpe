using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._12._4._feladat
{
    public partial class AddStudents : Form
    {
        public Students Student;//Létrehozom a példányt
        List<int> studentGrades;
        public AddStudents(Students s = null)
        {
            InitializeComponent();
            studentGrades = new List<int>();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTB.Text)) { 
                string name = nameTB.Text;
                int age = (int)ageN.Value;
                studentGrades.Add((int)gradeN.Value);
                if (Student == null)//Add
                {
                    Student = new Students(name, age, studentGrades);//Hozzáadom az értékeket a példányhoz
                }
                else { //Modify
                    Student.Name = nameTB.Text;
                    Student.Age = (int)ageN.Value;
                    Student.Grades.Add((int)gradeN.Value);
                }
                

                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}
