using System.Drawing.Imaging;
namespace PaintCopy
{
    public partial class Form1 : Form
    {
        bool isDrawing = false;
        Point lastPoint = Point.Empty;//beépített
        Pen drawingPen;
        Bitmap drawingBitmap;
        Graphics bitmapGraphics;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;//kicsit smoothabb lesz a rajzolás
            drawingPen = new Pen(Color.Black, 1);
            drawingBitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            bitmapGraphics = Graphics.FromImage(drawingBitmap);//bitmap alapján rajzoljon magának
            bitmapGraphics.Clear(Color.White);//Fehér háttér
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Billentyû lekérése is beépített
            {
                isDrawing = true;
                lastPoint = e.Location;//mentjük a lokációt, ahol az egér van
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = CreateGraphics()) //beépített vászon
                {
                    g.DrawLine(Pens.DeepPink, lastPoint, e.Location); //milyen szín mettõl meddig | itt lerajzolja
                    //ezen a grafikus felületen = g szeretnék vonalat húzni
                    bitmapGraphics.DrawLine(drawingPen, lastPoint, e.Location); //itt tudjuk kimenteni
                }
                lastPoint = e.Location;
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                lastPoint = Point.Empty;
            }
        }


        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                drawingPen.Color = colorDialog1.Color;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bitmapGraphics.Clear(Color.White);
            Invalidate();//Újrarajzolja a formot a kezdõ állapotra
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                drawingBitmap.Save(filePath, ImageFormat.Png );
            }
        }

        private void LineThickness_ValueChanged(object sender, EventArgs e)
        {
            drawingPen.Width = (float)LineThickness.Value;
        }
    }
}
