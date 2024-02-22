using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBtoHSI
{
    public static class Helper
    {
        public static double[] ConvertRGBtoHSI(double red, double green, double blue)
        {
            double r = red / 255.0;
            double g = green / 255.0;
            double b = blue / 255.0;

            double intensity = (r + g + b) / 3.0;

            if (intensity < 1e-10)
            {
                return new double[] { 0, 0, 0 }; 
            }

            double min = Math.Min(Math.Min(r, g), b);
            double saturation;
            if (r == g && g == b)
            {
                saturation = 0;
            }
            else
            {
                saturation = 1.0 - (3.0 / (r + g + b) * min);
            }

            double hue = 0.0;
            if (saturation != 0)
            {
                double num = 0.5 * ((r - g) + (r - b));
                double den = Math.Sqrt((r - g) * (r - g) + (r - b) * (g - b));
                double theta = Math.Acos(num / Math.Max(den, 1e-10));

                if (b <= g)
                {
                    hue = theta;
                }
                else
                {
                    hue = 2.0 * Math.PI - theta;
                }
            }

            hue = hue * (180.0 / Math.PI);

            return new double[] { hue, saturation, intensity };
        }

        public static double[] ConvertHSItoRGB(double h, double s, double i)
        {
            double rValue, gValue, bValue;

            if (s == 0)
            {
                rValue = gValue = bValue = i;
            }
            else
            {
                h = (h + 360) % 360;

                double chroma = (1 - Math.Abs(2 * i - 1)) * s;
                double x = chroma * (1 - Math.Abs((h / 60) % 2 - 1));

                rValue = gValue = bValue = 0;

                if (h >= 0 && h < 60)
                {
                    rValue = chroma;
                    gValue = x;
                }
                else if (h >= 60 && h < 120)
                {
                    rValue = x;
                    gValue = chroma;
                }
                else if (h >= 120 && h < 180)
                {
                    gValue = chroma;
                    bValue = x;
                }
                else if (h >= 180 && h < 240)
                {
                    gValue = x;
                    bValue = chroma;
                }
                else if (h >= 240 && h < 300)
                {
                    rValue = x;
                    bValue = chroma;
                }
                else if (h >= 300 && h < 360)
                {
                    rValue = chroma;
                    bValue = x;
                }

                double m = i - chroma / 2;
                rValue += m;
                gValue += m;
                bValue += m;
            }

            double red = (byte)(Math.Round(rValue * 255));
            double green = (byte)(Math.Round(gValue * 255));
            double blue = (byte)(Math.Round(bValue * 255));

            double[] rgbColor = { red, green, blue };

            return rgbColor;
        }

        public static Color GetColorAt(PictureBox pictureBox, int x, int y)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Image);

            return bitmap.GetPixel(x, y);
        }

        public static void GenerateColorWheel(PictureBox pictureBox)
        {
            int width = pictureBox.Width;
            int height = pictureBox.Height;

            Bitmap colorWheelBitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            for (int angle = 0; angle < 360; angle++)
            {
                double radians = angle * (Math.PI / 180);
                int red = (int)((Math.Cos(radians) + 1) * 0.5 * 255);
                int green = (int)((Math.Sin(radians) + 1) * 0.5 * 255);
                int blue = 255 - red;

                Color color = Color.FromArgb(red, green, blue);
                using (SolidBrush brush = new SolidBrush(color))
                {
                    using (Graphics g = Graphics.FromImage(colorWheelBitmap))
                    {
                        g.FillPie(brush, 0, 0, width, height, angle, 1);
                    }
                }
            }

            pictureBox.Image = colorWheelBitmap;
        }
    }
}
