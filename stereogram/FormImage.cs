using System;
using System.Drawing;
using System.Windows.Forms;

namespace stereogram
{
    public partial class FormImage : Form
    {
        Bitmap image;
        public FormImage(Bitmap bmp)
        {
            InitializeComponent();
            image = bmp;
            pictureBox.Image = image;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string path;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                image.Save(path);
            }
        }
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(image);
        }
    }
}
