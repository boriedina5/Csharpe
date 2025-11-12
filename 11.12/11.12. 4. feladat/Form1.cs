namespace _11._12._4._feladat
{
    public partial class Form1 : Form
    {
        List<Students> allStudents;
        public Form1()
        {
            InitializeComponent();
            allStudents = new List<Students>();
            ListBoxShow(allStudents);
        }

        public void ListBoxShow(List<Students> studentList) {
            lbStudents.Items.Clear();
            foreach (var s in studentList) { 
                lbStudents.Items.Add(s);
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
           AddStudents newStudent = new AddStudents();
            if (newStudent.ShowDialog() == DialogResult.OK) {
                allStudents.Add(newStudent.Student);
                ListBoxShow(allStudents);
            }
        }

        private void modifyBTN_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItem != null)
            {
                int index = lbStudents.SelectedIndex;
                AddStudents newStudent = new AddStudents(allStudents[index]);
                if (newStudent.ShowDialog() == DialogResult.OK) {
                    lbStudents.ClearSelected();
                    ListBoxShow(allStudents);
                }

            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItem != null)
            {
                int index = lbStudents.SelectedIndex;
                allStudents.Remove(allStudents[index]);
                ListBoxShow(allStudents);
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(studentNameTB.Text)) { 
                List<Students> searchedStudent = new List<Students>();
                searchedStudent = allStudents.Where(x => x.Name.Contains(studentNameTB.Text)).ToList();

                lbStudents.Items.Clear();
                foreach (var searchedItem in searchedStudent) { 
                    lbStudents.Items.Add(searchedItem);
                }
            }
        }
    }
}
