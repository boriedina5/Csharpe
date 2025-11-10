namespace _11._10._2._feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog pic = new OpenFileDialog()) {
                pic.Title = "Choose a picture";
                pic.Filter = "Képfájlok|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (pic.ShowDialog() == DialogResult.OK) {
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom; //Arányosan jelenik meg
                    pictureBox.Image = System.Drawing.Image.FromFile(pic.FileName);
                }
            }
        }
    }
}
