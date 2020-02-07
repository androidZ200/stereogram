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
    public partial class FormSettings : Form
    {
        FormMain form;

        public FormSettings(FormMain f)
        {
            InitializeComponent();
            form = f;
            maskedTextBoxW.Text = form.Width.ToString();
            maskedTextBoxH.Text = form.Height.ToString();
            maskedTextBoxC.Text = form.CycleWidth.ToString();
        }
        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            int w = Convert.ToInt32(maskedTextBoxW.Text);
            int h = Convert.ToInt32(maskedTextBoxH.Text);
            int c = Convert.ToInt32(maskedTextBoxC.Text);

            if (w > 10 && w < 1000000)
                form.Width = w;
            if (h > 10 && h < 1000000)
                form.Height = h;
            if (c > 0 && c < form.Width / 2)
                form.CycleWidth = c;

            form.resize();
        }
    }
}
