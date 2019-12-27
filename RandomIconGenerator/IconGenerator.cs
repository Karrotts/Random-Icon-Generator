using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomIconGenerator
{
    class IconGenerator
    {
        public float BlockSize { get; set; }
        public int ColorVariance { get; set; }
        public float PlaceChance { get; set; }
        public Bitmap Icon { get; set; }

        private float blockDensity;
        private Random rn;
        private Color rc;
        private Graphics graphics;

        public IconGenerator(int height, int width)
        {
            Icon = new Bitmap(height, width);
            graphics = Graphics.FromImage(Icon);
            rn = new Random();
            graphics.RotateTransform(45.0f);
        }

        /// <summary>
        /// Generate new Bitmap layer
        /// </summary>
        /// <param name="blockSize">How big the boxes should be generated</param>
        /// <param name="colorVariance">How close or different the colors should be from each other. 0 = none difference; 255 = completely random</param>
        /// <param name="placeChance">The percentage chance of the block being placed</param>
        /// <returns></returns>
        public Bitmap Generate(decimal blockSize, decimal colorVariance, decimal placeChance)
        {
            //Cast variable to proper types
            BlockSize = (float) blockSize;
            ColorVariance = (int) colorVariance;
            PlaceChance = (float) placeChance;

            float x = 0.0f;
            float y = 0.0f;

            blockDensity = ((Icon.Width / BlockSize * 2) / 2);
            x = BlockSize / -2f;
            y = BlockSize / -2f;

            rc = RandomColor();

            for (int i = 0; i < BlockSize * blockDensity; i++)
            {
                for (int j = 0; j < BlockSize * blockDensity; j++)
                {
                    if (rn.Next(1, 100) >= (100 - PlaceChance))
                    {
                        graphics.FillRectangle(new SolidBrush(
                            Color.FromArgb(255,
                            rn.Next(ColorRange(rc.R - ColorVariance), ColorRange(rc.R + ColorVariance)),
                            rn.Next(ColorRange(rc.G - ColorVariance), ColorRange(rc.G + ColorVariance)),
                            rn.Next(ColorRange(rc.B - ColorVariance), ColorRange(rc.B + ColorVariance)))), x, y, BlockSize, BlockSize);
                    }

                    x += BlockSize;
                    y -= BlockSize;
                }
                x = BlockSize / -2f;
                y = BlockSize / -2f + (i * BlockSize);
            }
            return Icon;
        }

        /// <summary>
        /// Clears the Bitmap to a blank Bitmap
        /// </summary>
        /// <returns>Blank Bitmap</returns>
        public Bitmap Clear()
        {
            Icon = new Bitmap(250, 250);
            graphics = Graphics.FromImage(Icon);
            graphics.RotateTransform(45.0f);
            return Icon;
        }

        /// <summary>
        /// Generates a random color
        /// </summary>
        /// <returns>Random color</returns>
        private Color RandomColor()
        {
            Random rn = new Random();
            Color random = Color.FromArgb(255, rn.Next(0, 255), rn.Next(0, 255), rn.Next(0, 255));
            return random;
        }

        /// <summary>
        /// Clamps value to appropriate color range
        /// </summary>
        /// <param name="v">value</param>
        /// <returns>A clamped value between 0-255</returns>
        private int ColorRange(int v)
        {
            if (v < 0)
                return 0;
            if (v > 255)
                return 255;
            else return v;
        }
    }
}
