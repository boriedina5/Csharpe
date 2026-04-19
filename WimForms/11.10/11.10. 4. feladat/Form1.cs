namespace _11._10._4._feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void On_Click(object sender, EventArgs e)
        {
            status.Text = "Game status: On";
        }
        private void Off_Click_1(object sender, EventArgs e)
        {
            status.Text = "Game status: Off";
        }
    }
}
