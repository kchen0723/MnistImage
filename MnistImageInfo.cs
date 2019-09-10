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
        public byte[][] Pixels { get; set; }

        public MnistImageInfo(byte[][] pixels, string label) 
            : this(MNIST_WIDTH, MNIST_HEIGHT, pixels, label)
        {
        }

        public MnistImageInfo(int width, int height, byte[][] pixels, string label)
        {
            this.Width = width;
            this.Height = Height;
            this.Pixels = pixels;
            this.Label = label;
        }

        public string PixelString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < this.Height; i++)
                {
                    for (int j = 0; i < this.Width; j++)
                    {
                        sb.Append(this.Pixels[i][j].ToString("X2"));
                        sb.Append(" ");
                    }
                    sb.Append(Environment.NewLine);
                }
                return sb.ToString();
            }
        }

        public Bitmap GetDefaultmap()
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
                    int colorValue = 255 - this.Pixels[i][j];
                    Color pixelColor = Color.FromArgb(colorValue, colorValue, colorValue);
                    SolidBrush brush = new SolidBrush(pixelColor);
                    graphic.FillRectangle(brush, j * magnification, i * magnification, magnification, magnification);
                }
            }
            return result;
        }
    }
}
