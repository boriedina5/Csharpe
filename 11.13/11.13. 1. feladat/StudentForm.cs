using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._13._1._feladat
{
    public partial class StudentForm : Form
    {
        public Student Student;
        public StudentForm(Student s = null)
        {
            InitializeComponent();

            if (s != null) {
                submitBTN.Text = "Modify";
                Student = s;
                nameTB.Text = Student.Name;
                ageN.Value = Student.Age;   
            }
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTB.Text)){ 
                
                string name = nameTB.Text;
                int age = (int)ageN.Value;

                if (Student == null)
                {
                    Student = new Student(name, age);
                }
                else {
                    Student.Name = name;
                    Student.Age = age;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
