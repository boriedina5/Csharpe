namespace _11._12._4._feladat
{
    public partial class Form1 : Form
    {
        List<Students> allStudents; //Ebbe gyûjtöm a diákokat, hogy eg tudjam jeleníteni
        public Form1()
        {
            InitializeComponent();
            allStudents = new List<Students>();
            ListBoxShow(allStudents);
        }

        public void ListBoxShow(List<Students> studentList) { //listboxos megjelenítés
            lbStudents.Items.Clear();
            foreach (var s in studentList) { //Végig megyek a listán és kiíratom
                lbStudents.Items.Add(s);
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            AddStudents newStudent = new AddStudents(); //példány, hogy a AddStudent formból kimentsünk az adatokat
            if (newStudent.ShowDialog() == DialogResult.OK) {//Párbeszédet megnyitom a newStudentre, hogy tudjunk módosítani <- ShowDialog mûveletet vár
                allStudents.Add(newStudent.Student);
                ListBoxShow(allStudents);
            }
        }

        private void modifyBTN_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItem != null)
            {
                int index = lbStudents.SelectedIndex;
                AddStudents newStudent = new AddStudents(allStudents[index]);//mivel módosítok megadom neki kirõl van szó és mivel el van tárolva az allStudentsbe ott keresem a kijelölés alapján
                if (newStudent.ShowDialog() == DialogResult.OK) {
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
                List<Students> searchedStudent = new List<Students>();//ide gyûjtöm, a listázotakat
                searchedStudent = allStudents.Where(x => x.Name.Contains(studentNameTB.Text)).ToList(); //feltétel alapján szûrûnk majd listázunk

                lbStudents.Items.Clear();
                foreach (var searchedItem in searchedStudent) { 
                    lbStudents.Items.Add(searchedItem);
                }
            }
        }
    }
}
