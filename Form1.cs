using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnistImage
{
    public partial class Form1 : Form
    {
        private List<MnistImageInfo> _images = new List<MnistImageInfo>();
        private readonly int _magnification = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            _images = MnistImageLoader.LoadMnistImages(tbImage.Text, tbLabel.Text);
            MessageBox.Show("Loaded");
            btnShowImage.Enabled = true;
        }

        private void BtnShowImage_Click(object sender, EventArgs e)
        {
            var index = 0;
            int.TryParse(tbIndex.Text, out index);
            if (index < _images.Count && index >= 0)
            { 
                var currentImage = _images[index];
                this.lblResult.Text = currentImage.Label;
                this.pbImage.Image = currentImage.GetBitmap(_magnification);
                this.tbPixelString.Text = currentImage.PixelString;
            }
        }
    }
}
