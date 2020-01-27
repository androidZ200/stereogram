using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stereogram
{
    public partial class FormMain : Form
    {
        Random rand = new Random();
        Bitmap background;
        Bitmap imageBW;

        private void GenerateBackground(int width, int height, int cycle)
        {
            background = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(background);

            for(int i = 0; i < 800; i++)
            {
                Bitmap figure = GenerateFigure(cycle);
                Point beg = new Point(rand.Next(-cycle, -cycle / 2), rand.Next(height));
                while(beg.X < width)
                {
                    g.DrawImage(figure, beg);
                    beg.X += cycle;
                }
            }
        }
        private Bitmap GenerateFigure(int maxSize)
        {
            Bitmap bmp = new Bitmap(rand.Next(10, maxSize), rand.Next(10, maxSize));
            Graphics g = Graphics.FromImage(bmp);
            Pen p = new Pen(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)), rand.Next(5, 15));
            if(rand.Next(2) == 0)
                g.DrawLine(p, 0, rand.Next(0, bmp.Height), bmp.Width, rand.Next(0, bmp.Height));
            else
                g.DrawLine(p, rand.Next(0, bmp.Width), 0, rand.Next(0, bmp.Width), bmp.Height);
            return bmp;
        }
        public void setImage(Bitmap image)
        {
            imageBW = image;
            pictureBoxImage.Image = imageBW;
        }
                     
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            GenerateBackground(1280, 720, 128);
            pictureBoxBackground.Image = background;
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            FormDraw form;
            if (imageBW == null) form = new FormDraw(this);
            else form = new FormDraw(this, imageBW);
            form.ShowDialog();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (imageBW == null) imageBW = new Bitmap(1280, 720);
                string path = openFileDialog1.FileName;
                Bitmap t = (Bitmap)Bitmap.FromFile(path);
                double k = Math.Min(720.0 / t.Height, 1280.0 / t.Width);
                int paddingTop = (int)((720 - t.Height * k) / 2);
                int paddingLeft = (int)((1280.0 - t.Width * k) / 2);
                Graphics g = Graphics.FromImage(imageBW);
                g.Clear(Color.Black);
                g.DrawImage(new Bitmap(t, (int)(t.Width * k), (int)(t.Height * k)), paddingLeft, paddingTop);
                pictureBoxImage.Image = imageBW;
            }
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (background != null && imageBW != null)
            {
                Bitmap result = (Bitmap)background.Clone();
                int[,] depths = new int[1280, 720];
                for (int y = 0; y < 720; y++)
                    for (int x = 0; x < 1280; x++)
                        depths[x, y] = (imageBW.GetPixel(x, y).R + imageBW.GetPixel(x, y).G + imageBW.GetPixel(x, y).B) / 24;

                for (int y = 0; y < 720; y++)
                    for (int x = 0; x < 1280; x++)
                        if (depths[x, y] > 0 && x + depths[x, y] < 1280)
                        {
                            Color c = result.GetPixel(x + depths[x, y], y);
                            for (int i = x; i < 1280; i += 128)
                                result.SetPixel(i, y, c);
                        }

                FormImage form = new FormImage(result);
                form.Show();
            }
        }
        private void pictureBoxBackground_Click(object sender, EventArgs e)
        {
            if(background != null)
            {
                FormImage form = new FormImage(background);
                form.Show();
            }
        }
        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            if (imageBW != null)
            {
                FormImage form = new FormImage(imageBW);
                form.Show();
            }
        }
    }
}
