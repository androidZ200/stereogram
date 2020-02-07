using System;
using System.Drawing;
using System.Windows.Forms;

namespace stereogram
{
    public partial class FormMain : Form
    {
        Random rand = new Random();
        Bitmap background;
        Bitmap imageBW;
        public new int Width = 1280;
        public new int Height = 720;
        public int CycleWidth = 128;

        private void GenerateBackground()
        {
            background = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(background);

            for (int i = 0; i < 800; i++)
            {
                Bitmap figure = GenerateFigure();
                Point beg = new Point(rand.Next(-CycleWidth * 2, -CycleWidth), rand.Next(-100, Height));
                while (beg.X < Width)
                {
                    g.DrawImage(figure, beg);
                    beg.X += CycleWidth;
                }
            }
        }
        private Bitmap GenerateFigure()
        {
            Bitmap bmp = new Bitmap(rand.Next(20, CycleWidth + 50), rand.Next(20, CycleWidth + 50));
            Graphics g = Graphics.FromImage(bmp);
            Pen p = new Pen(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)), rand.Next(5, 15));
            if (rand.Next(2) == 0)
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
        public void resize()
        {
            background = null;
            imageBW = null;
            pictureBoxBackground.Image = null;
            pictureBoxImage.Image = null;
        }

        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            GenerateBackground();
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (imageBW == null) imageBW = new Bitmap(Width - CycleWidth, Height);
                string path = openFileDialog1.FileName;
                Bitmap t = (Bitmap)Bitmap.FromFile(path);
                double k = Math.Min(imageBW.Height * 1.0 / t.Height, imageBW.Width * 1.0 / t.Width);
                int paddingTop = (int)((imageBW.Height - t.Height * k) / 2);
                int paddingLeft = (int)((imageBW.Width - t.Width * k) / 2);
                Graphics g = Graphics.FromImage(imageBW);
                g.Clear(Color.Black);
                g.DrawImage(new Bitmap(t, (int)(t.Width * k), (int)(t.Height * k)), paddingLeft, paddingTop);
                for (int y = 0; y < imageBW.Height; y++)
                    for (int x = 0; x < imageBW.Width; x++)
                    {
                        int tt = (imageBW.GetPixel(x, y).R + imageBW.GetPixel(x, y).G + imageBW.GetPixel(x, y).B) / 3;
                        imageBW.SetPixel(x, y, Color.FromArgb(tt, tt, tt));
                    }
                pictureBoxImage.Image = imageBW;
            }
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (background != null && imageBW != null)
            {
                Bitmap result = (Bitmap)background.Clone();
                int[,] depths = new int[imageBW.Width, imageBW.Height];
                for (int y = 0; y < imageBW.Height; y++)
                    for (int x = 0; x < imageBW.Width; x++)
                        depths[x, y] = imageBW.GetPixel(x, y).R * CycleWidth / 255 / 6;

                for (int y = 0; y < Height; y++)
                    for (int x = CycleWidth; x < Width; x++)
                        if (depths[x - CycleWidth, y] > 0 && x + depths[x - CycleWidth, y] < Width)
                        {
                            Color c = result.GetPixel(x + depths[x - CycleWidth, y], y);
                            for (int i = x; i < Width; i += CycleWidth)
                                result.SetPixel(i, y, c);
                        }

                FormImage form = new FormImage(result);
                form.Show();
            }
        }
        private void pictureBoxBackground_Click(object sender, EventArgs e)
        {
            if (background != null)
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
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings(this);
            form.ShowDialog();
        }
    }
}
