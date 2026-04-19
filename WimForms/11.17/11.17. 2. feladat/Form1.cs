using System.Runtime.CompilerServices;

namespace _11._17._2._feladat
{
    public partial class Form1 : Form
    {
        Employee employeeSample;
        List<Employee> employeesList;
        public Form1()
        {
            InitializeComponent();
            employeesList = new List<Employee>();
            LBS(employeesList);
        }

        public void LBS(List<Employee> elp) { 
            lbEmployee.Items.Clear();
            foreach (var item in elp) { 
                lbEmployee.Items.Add(item);
            }
        }
        private void addBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTB.Text)) { 
                string employeeName = nameTB.Text;
                string employeePosition = positionTB.Text;
                int employeeSalary = (int)salaryN.Value;

                employeeSample = new Employee(employeeName, employeePosition, employeeSalary);
                

                employeesList.Add(employeeSample);
                LBS(employeesList);

                DialogResult = DialogResult.OK;

            }
        }

        private void calculateAvarageSalaryBTN_Click(object sender, EventArgs e)
        {
            decimal avarageSalary = 0;
            decimal sum = 0;
            for (int i = 0; i < employeesList.Count; i++) { 
                sum += employeesList[i].Salary;
            }
            avarageSalary = sum / employeesList.Count;


            avarageSalaryL.Text = $"Avarage Salary: {avarageSalary.ToString("0.00")}";
        }
    }
}
