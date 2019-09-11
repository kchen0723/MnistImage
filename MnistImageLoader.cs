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
        public static List<MnistImageInfo> LoadMnistImages(string pixelFile, string lableFile)
        {
            List<MnistImageInfo> result = new List<MnistImageInfo>(1000);
            if (File.Exists(pixelFile) && File.Exists(lableFile))
            { 
                using (FileStream fsPixels = new FileStream(pixelFile, FileMode.Open), fsLables = new FileStream(lableFile, FileMode.Open))
                {
                    using (BinaryReader imageReader = new BinaryReader(fsPixels), labelReader = new BinaryReader(fsLables))
                    {
                        int magicNumber = reverseBytes(imageReader.ReadInt32());
                        int imageCount = reverseBytes(imageReader.ReadInt32());
                        int imageWidth = reverseBytes(imageReader.ReadInt32());
                        int imageHeight = reverseBytes(imageReader.ReadInt32());
                        int magicNumber2 = reverseBytes(labelReader.ReadInt32());
                        int labelCount = reverseBytes(labelReader.ReadInt32());

                        if (imageCount > 0 && imageWidth > 0 && imageHeight > 0 && imageCount == labelCount)
                        {
                            byte[,] pixels = new byte[imageWidth, imageHeight];
                            for (int i = 0; i < imageCount; i++)
                            {
                                for (int j = 0; j < imageWidth; j++)
                                {
                                    for (int k = 0; k < imageHeight; k++)
                                    {
                                        byte b = imageReader.ReadByte();
                                        pixels[j, k] = b;
                                    }
                                }
                                string label = labelReader.ReadByte().ToString();
                                MnistImageInfo mnistImage = new MnistImageInfo(imageWidth, imageHeight, pixels, label);
                                result.Add(mnistImage);
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
