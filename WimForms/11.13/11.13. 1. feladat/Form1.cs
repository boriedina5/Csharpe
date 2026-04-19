namespace _11._13._1._feladat
{
    public partial class Form1 : Form
    {
        List<Student> allStudent;
        public Form1()
        {
            InitializeComponent();
            allStudent = new List<Student>();
            ListBoxLoader(allStudent);
        }

        public void ListBoxLoader(List<Student> listP)
        {
            lbStudents.Items.Clear();
            foreach (var item in listP)
            {
                lbStudents.Items.Add(item);
            }
        }
        private void addBTN_Click(object sender, EventArgs e)
        {
            StudentForm newForm = new StudentForm();
            if (newForm.ShowDialog() == DialogResult.OK)
            {

                allStudent.Add(newForm.Student);
                ListBoxLoader(allStudent);
            }
        }

        private void modifyBTN_Click(object sender, EventArgs e)
        {
            int index = lbStudents.SelectedIndex;
            StudentForm updateForm = new StudentForm(allStudent[index]);

            if (updateForm.ShowDialog() == DialogResult.OK)
            {

                ListBoxLoader(allStudent);
            }

        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItem != null)
            {
                int index = lbStudents.SelectedIndex;
                allStudent.RemoveAt(index);
                ListBoxLoader(allStudent);
            }
        }

        private void gradeBTN_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItem != null)
            {
                int index = lbStudents.SelectedIndex;
                int studentGrade = (int)gradeN.Value;

                allStudent[index].Grades.Add(studentGrade);
                ListBoxLoader(allStudent);
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string quary = searchTB.Text;
            var result = allStudent.Where(x => x.Name.Contains(quary)).ToList(); //LINQ keresés, var miatt egyedi gyûjtemény lesz
            ListBoxLoader(result);


        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selected = (Student)lbStudents.SelectedItem;
            avarageL.Text = selected.Grades.Count > 0 ? selected.Grades.Average().ToString() : ("");
            minL.Text = selected.Grades.Count > 0? selected.Grades.Min().ToString() : ("");
            maxL.Text = selected.Grades.Count > 0 ? selected.Grades.Max().ToString() : ("");

        }
    }
}
