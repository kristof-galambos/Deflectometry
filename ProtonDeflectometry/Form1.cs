using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtonDeflectometry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Simulation sim;


        //public void filereader(List<double> x, List<double> y)
        //{
        //    string[] lines = System.IO.File.ReadAllLines("screen.txt");
        //    foreach (string line in lines)
        //    {
        //        string[] fields = line.Split(' ');
        //        x.Add(Convert.ToDouble(fields[0]));
        //        y.Add(Convert.ToDouble(fields[1]));
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(Ntextbox.Text);
            double E = Convert.ToDouble(Etextbox.Text);
            double GD = Convert.ToDouble(GDtextbox.Text);
            double SD = Convert.ToDouble(SDtextbox.Text);
            string b = "nofield";
            if (rbUniform.Checked)
            {
                b = "uniform";
            }
            else if (rbZpinch.Checked)
            {
                b = "zpinch";
            }
            sim = new Simulation(n, E, GD, SD, b);
            double[,] myPoints = sim.points;
            ChartScreen.Series["Screen"].Points.Clear();
            for (int i = 0; i < n; i++)
            {
                ChartScreen.Series["Screen"].Points.AddXY(myPoints[i, 0], myPoints[i, 1]);
            }
            ChartScreen.ChartAreas[0].AxisX.Minimum = -sim.screenSize / 2.0;
            ChartScreen.ChartAreas[0].AxisX.Maximum = sim.screenSize / 2.0;
            ChartScreen.ChartAreas[0].AxisY.Minimum = -sim.screenSize / 2.0;
            ChartScreen.ChartAreas[0].AxisY.Maximum = sim.screenSize / 2.0;

            int[,] camera = sim.getCamera();

            //picture.Image = Image.FromFile("./profile_photo_small.jpg");

            Bitmap bmp = new Bitmap(sim.cameraResolution, sim.cameraResolution);
            Graphics flagGraphics = Graphics.FromImage(bmp);
            flagGraphics.FillRectangle(Brushes.Black, 0, 0, sim.cameraResolution, sim.cameraResolution);

            int camMax = 0;
            for (int i = 0; i < sim.cameraResolution; i++)
            {
                for (int j = 0; j < sim.cameraResolution; j++)
                {
                    if (camera[i, j] > camMax)
                    {
                        camMax = camera[i, j];
                    }
                }
            }
            int[,] cam = new int[sim.cameraResolution, sim.cameraResolution];
            for (int i = 0; i < sim.cameraResolution; i++)
            {
                for (int j = 0; j < sim.cameraResolution; j++)
                {
                    cam[i, j] = Convert.ToInt32(camera[i, j] * 255 / camMax);
                }
            }

            int len = sim.cameraResolution - 1;
            for (int i = 0; i < sim.cameraResolution; i++)
            {
                for (int j = 0; j < sim.cameraResolution; j++)
                {
                    Color colour = Color.FromArgb(cam[i, len - j], cam[i, len - j], cam[i, len - j]);
                    bmp.SetPixel(i, j, colour);
                }
            }
            bmp = ResizeBitmap(bmp, 200, 200);
            bmp.Save("camera.png", ImageFormat.Png);

            pictureBox1.Image = bmp;
        }

        public Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }

        //private void pictureBox_Paint(object sender, PaintEventArgs e)
        //{
        //    Bitmap flag = new Bitmap(200, 100);
        //    Graphics flagGraphics = Graphics.FromImage(flag);
        //    flagGraphics.FillRectangle(Brushes.Black, 0, 0, 200, 100);
        //    //for (int i = 0; i < sim.cameraResolution; i++)
        //    //{
        //    //    for (int j = 0; j < sim.cameraResolution; j++)
        //    //    {

        //    //    }
        //    //}
        //    int red = 0;
        //    int white = 11;
        //    while (white <= 100)
        //    {
        //        flagGraphics.FillRectangle(Brushes.Red, 0, red, 200, 10);
        //        flagGraphics.FillRectangle(Brushes.White, 0, white, 200, 10);
        //        red += 20;
        //        white += 20;
        //    }
        //    picture.Image = flag;

        //    //Graphics g = e.Graphics;
        //    //using (Bitmap bmp = new Bitmap(flag))
        //    //{

        //    //    // Set the image attribute's color mappings
        //    //    ColorMap[] colorMap = new System.Drawing.Imaging.ColorMap[1];
        //    //    colorMap[0] = new ColorMap();
        //    //    colorMap[0].OldColor = Color.Black;
        //    //    colorMap[0].NewColor = Color.Blue;
        //    //    ImageAttributes attr = new ImageAttributes();
        //    //    attr.SetRemapTable(colorMap);
        //    //    // Draw using the color map
        //    //    Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
        //    //    g.DrawImage(bmp, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
        //    //}
        //}
    }
}
