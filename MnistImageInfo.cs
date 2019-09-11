using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnistImage
{
    ////https://msdn.microsoft.com/zh-cn/magazine/dn745868.aspx
    public class MnistImageInfo
    {
        public const int MNIST_WIDTH = 28;
        public const int MNIST_HEIGHT = 28;

        public int Width { get; set; }
        public int Height { get; set; }
        public string Label { get; set; }
        public byte[,] Pixels { get; set; }

        public MnistImageInfo(byte[,] sourcePixels, string sourceLabel) 
            : this(MNIST_WIDTH, MNIST_HEIGHT, sourcePixels, sourceLabel)
        {
        }

        public MnistImageInfo(int sourceWidth, int sourceHeight, byte[,] sourcePixels, string sourceLabel)
        {
            this.Width = sourceWidth;
            this.Height = sourceHeight;
            this.Label = sourceLabel;
            this.Pixels = new byte[this.Width,this.Height];
            for (int i = 0; i < this.Width; i++)
            {
                for (int j = 0; j < this.Height; j++)
                {
                    this.Pixels[i, j] = sourcePixels[i, j];
                }
            }
        }

        public string PixelString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < this.Width; i++)
                {
                    for (int j = 0; j < this.Height; j++)
                    {
                        sb.Append(this.Pixels[i, j].ToString("X2"));
                        sb.Append(" ");
                    }
                    sb.Append(Environment.NewLine);
                }
                return sb.ToString();
            }
        }

        public Bitmap GetBitmap()
        {
            return GetBitmap(1);
        }

        public Bitmap GetBitmap(int magnification)
        {
            int totalWidth = this.Width * magnification;
            int totalHeight = this.Height * magnification;
            Bitmap result = new Bitmap(totalWidth, totalHeight);
            Graphics graphic = Graphics.FromImage(result);
            for (int i = 0; i < this.Width; i++)
            {
                for (int j = 0; j < this.Height; j++)
                {
                    int colorValue = 255 - this.Pixels[i, j];
                    Color pixelColor = Color.FromArgb(colorValue, colorValue, colorValue);
                    SolidBrush brush = new SolidBrush(pixelColor);
                    graphic.FillRectangle(brush, j * magnification, i * magnification, magnification, magnification);
                }
            }
            return result;
        }
    }
}
