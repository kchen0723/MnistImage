using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnistImage
{
    public class MnistImageLoader
    {
        public const int MNIST_IMAGE_NUMBER = 60000;
        public static MnistImageInfo[] LoadMnistImages(string pixelFile, string lableFile)
        {
            MnistImageInfo[] result = new MnistImageInfo[MNIST_IMAGE_NUMBER];
            byte[][] pixels = new byte[MnistImageInfo.MNIST_HEIGHT][];
            for (int i = 0; i < pixels.Length; i++)
            {
                pixels[i] = new byte[MnistImageInfo.MNIST_WIDTH];
            }
            using (FileStream fsPixels = new FileStream(pixelFile, FileMode.Open))
            {
                using (FileStream fsLables = new FileStream(lableFile, FileMode.Open))
                {
                    using (BinaryReader imageReader = new BinaryReader(fsPixels))
                    {
                        using (BinaryReader labelReader = new BinaryReader(fsLables))
                        {
                            int magicNumber = reverseBytes(imageReader.ReadInt32());
                            int imageCount = reverseBytes(imageReader.ReadInt32());
                            int rowCount = reverseBytes(imageReader.ReadInt32());
                            int colcount = reverseBytes(imageReader.ReadInt32());
                            int magicNumber2 = reverseBytes(labelReader.ReadInt32());
                            int labelCount = reverseBytes(labelReader.ReadInt32());
                            for (int i = 0; i < MNIST_IMAGE_NUMBER; i++)
                            {
                                for (int j = 0; j < MnistImageInfo.MNIST_HEIGHT; j++)
                                {
                                    for (int k = 0; k < MnistImageInfo.MNIST_WIDTH; k++)
                                    {
                                        byte b = imageReader.ReadByte();
                                        pixels[i][j] = b;
                                    }
                                }
                                Byte lbl = labelReader.ReadByte();
                                MnistImageInfo image = new MnistImageInfo(pixels, lbl.ToString());
                                result[i] = image;
                            }
                        }
                    }
                }
            }
            return result;
        }

        private static int reverseBytes(int source)
        {
            byte[] intAsBytes = BitConverter.GetBytes(source);
            Array.Reverse(intAsBytes);
            return BitConverter.ToInt32(intAsBytes, 0);
        }
    }
}
