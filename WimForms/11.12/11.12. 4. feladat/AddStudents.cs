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
        public AddStudents(Students s = null) //opcionális paraméter -> módodul
        {
            InitializeComponent();
            studentGrades = new List<int>();
            if (s != null) {
                submitBTN.Text = "Modify";
                
                Student = s; //Fontos -> emiatt fog módosulni
                
                nameTB.Text = Student.Name; 
                ageN.Value = Student.Age;
                
            }
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTB.Text)) { 
                string name = nameTB.Text;
                int age = (int)ageN.Value;
                studentGrades.Add((int)gradeN.Value);

                //Egy formban van a módosítás és az új hozzáadása
                if (Student == null)//Add - mivel még nincs benne semmi
                {
                    Student = new Students(name, age, studentGrades);//Hozzáadom az értékeket a példányhoz
                }
                else { //Modify
                    Student.Name = nameTB.Text; //Student. <- már meglévő diákot írok át
                    Student.Age = (int)ageN.Value;
                    Student.Grades.Add((int)gradeN.Value);
                }
                

                DialogResult = DialogResult.OK;  //Megvannak a műveletek, minden jóvá lett hagyva
                Close();
            }

        }
    }
}
