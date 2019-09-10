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
        private MnistImageInfo[] images;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            images = MnistImageLoader.LoadMnistImages(tbImage.Text, tbLabel.Text);
            MessageBox.Show("Loaded");
        }

        private void BtnShowImage_Click(object sender, EventArgs e)
        {
            var index = int.Parse(tbIndex.Text);
            var currentImage = images[index];
            this.lblResult.Text = currentImage.Label;
            this.pbImage.Image = currentImage.GetBitmap(3);
            this.tbPixelString.Text = currentImage.PixelString;
        }
    }
}
