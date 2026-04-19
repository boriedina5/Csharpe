namespace _11._10._1._feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                decimal first = numb1.Value;
                decimal second = numb2.Value;
                decimal results = 0;

                if (sum.Checked)
                {
                    results = first + second;
                }
                if (sub.Checked)
                {
                    results = first - second;
                }
                if (div.Checked)
                {
                    if (second == 0)
                    {
                        MessageBox.Show("We do not divide by zero.");
                    }
                    results = first / second;
                }
                if (mul.Checked)
                {
                    results = first * second;
                }
                if (!(mul.Checked) || !(sum.Checked) || !(sub.Checked) || !(div.Checked))
                {
                    MessageBox.Show("Select an operation.");
                }
                MessageBox.Show($"The result is: {results}.");

        }
    }
}
