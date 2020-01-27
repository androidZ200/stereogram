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
    public partial class FormDraw : Form
    {
        FormMain form;
        Bitmap image;
        Graphics g;
        int Depth = 255;
        int Thickness = 50;

        Point prev;
        bool isClick = false;

        void Draw(Point prev, Point curr)
        {
            Pen p = new Pen(Color.FromArgb(Depth, Depth, Depth), Thickness);
            g.DrawLine(p, prev, curr);
            SolidBrush s = new SolidBrush(Color.FromArgb(Depth, Depth, Depth));
            g.FillEllipse(s, prev.X - Thickness / 2, prev.Y - Thickness / 2, Thickness, Thickness);
            g.FillEllipse(s, curr.X - Thickness / 2, curr.Y - Thickness / 2, Thickness, Thickness);
        }
        Point Convert(Point pixel)
        {
            double k = Math.Min(pictureBox.Height / 720.0, pictureBox.Width / 1280.0);
            int paddingTop = (int)((pictureBox.Height - 720 * k) / 2);
            int paddingLeft = (int)((pictureBox.Width - 1280 * k) / 2);
            pixel.X -= paddingLeft;
            pixel.Y -= paddingTop;
            pixel.X = (int)(pixel.X / k);
            pixel.Y = (int)(pixel.Y / k);
            return pixel;
        }

        public FormDraw(FormMain form)
        {
            InitializeComponent();
            this.form = form;
            image = new Bitmap(1280, 720);
            g = Graphics.FromImage(image);
            g.Clear(Color.Black);
            pictureBox.Image = image;
        }
        public FormDraw(FormMain form, Bitmap image) : this(form)
        {
            this.image = image;
            g = Graphics.FromImage(image);
            pictureBox.Image = image;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            form.setImage(image);
            Close();
        }
        private void trackBarThickness_Scroll(object sender, EventArgs e)
        {
            Thickness = trackBarThickness.Value * 10;
        }
        private void trackBarDepth_Scroll(object sender, EventArgs e)
        {
            Depth = trackBarDepth.Value * 255 / 20;
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isClick = true;
            prev = e.Location;
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isClick = false;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(isClick)
            {
                Draw(Convert(prev), Convert(e.Location));
                prev = e.Location;
                pictureBox.Image = image;
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            pictureBox.Image = image;
        }
    }
}
