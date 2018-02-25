using System;
using System.IO;
using System.Drawing;

namespace IGCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap icon = new Bitmap(1000, 1000);
            Graphics graphics = Graphics.FromImage(icon);
            Color rc = new Color();
            Random rn = new Random();

            int colorVariance = 0;
            int passCounter = 0;
            float blockSize = 0f;
            float placeChance = 0f;
            float blockDensity = 0f;
            float x = 0f;
            float y = 0f;
            bool pass = true;
            string decision;

            graphics.RotateTransform(45.0f);

            do
            {
                Console.WriteLine("Please enter in the block size in pixels (Default: 15)");
                blockSize = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter in the spawn chance (Default: 33.33)");
                placeChance = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter in the color variance variable. (Default: 20)");
                colorVariance = int.Parse(Console.ReadLine());


                blockDensity = ((icon.Width / blockSize * 2) / 2);
                x = blockSize / -2f;
                y = blockSize / -2f;

                rc = randomColor(colorVariance);

                for (int i = 0; i < blockSize * blockDensity; i++)
                {
                    for (int j = 0; j < blockSize * blockDensity; j++)
                    {
                        if (rn.Next(1, 100) >= (100 - placeChance))
                        {
                            graphics.FillRectangle(new SolidBrush(
                                Color.FromArgb(255,
                                rn.Next(rc.R - colorVariance, rc.R + colorVariance),
                                rn.Next(rc.G - colorVariance, rc.G + colorVariance),
                                rn.Next(rc.B - colorVariance, rc.B + colorVariance))), x, y, blockSize, blockSize);
                        }

                        x += blockSize;
                        y -= blockSize;
                    }
                    x = blockSize / -2f;
                    y = blockSize / -2f + (i * blockSize);
                }

                Console.WriteLine("END OF PASS {0}. Continue? y/n", passCounter);
                passCounter++;
                decision = Console.ReadLine();
                switch (decision)
                {
                    case "y":
                        break;
                    case "n":
                        pass = false;
                        break;
                    default:
                        Console.WriteLine("Unexpected input ending program");
                        break;
                }

            } while (pass);
            if (!Directory.Exists(@"./icons"))
                Directory.CreateDirectory(@"./icons");

            int tries = 0;
            while (true){

                if (!File.Exists(@"./icons/icon"+ tries +".png"))
                {
                    icon.Save(@"./icons/icon"+ tries+ ".png");
                    break;
                }
                tries++;
            }
        }

        public static Color randomColor(int cv)
        {
            Random rn = new Random();
            Color random = Color.FromArgb(255, rn.Next(cv, 255 - cv), rn.Next(cv, 255 - cv), rn.Next(cv, 255 - cv));
            return random;
        }
    }
}
