using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBtoHSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Helper.GenerateColorWheel(pictureBox1);

            textRGB_alpha.Text = "255";
            trackRGB_alpha.Value = 255;

            textRGB_red.Text = "0";
            trackRGB_red.Value = 0;

            textRGB_green.Text = "0";
            trackRGB_green.Value = 0;

            textRGB_blue.Text = "0";
            trackRGB_blue.Value = 0;

            textHSI_hue.Text = "0";
            trackHSI_hue.Value = 0;

            textHSI_saturation.Text = "0";
            trackHSI_intensity.Value = 0;

            textHSI_intensity.Text = "0";
            trackHSI_saturation.Value = 0;

            // Adaugă event handler pentru evenimentul Scroll pentru fiecare TrackBar
            trackRGB_alpha.Scroll += TrackBar_Scroll;
            trackRGB_red.Scroll += TrackBar_Scroll;
            trackRGB_green.Scroll += TrackBar_Scroll;
            trackRGB_blue.Scroll += TrackBar_Scroll;

            trackHSI_hue.Scroll += TrackBarHSI_Scroll;
            trackHSI_intensity.Scroll += TrackBarHSI_Scroll;
            trackHSI_saturation.Scroll += TrackBarHSI_Scroll;

            UpdateRGBControls();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Color color = Helper.GetColorAt(pictureBox1, e.X, e.Y);

            textRGB_red.Text = color.R.ToString();
            trackRGB_red.Value = color.R;

            textRGB_green.Text = color.G.ToString();
            trackRGB_green.Value = color.G;

            textRGB_blue.Text = color.B.ToString();
            trackRGB_blue.Value = color.B;

            UpdateRGBControls();
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateRGBControls();
        }

        private void TrackBarHSI_Scroll(object sender, EventArgs e)
        {
            UpdateHSIControls(trackHSI_hue.Value, trackHSI_saturation.Value / 100.000, trackHSI_intensity.Value / 100.000);
        }

        private void UpdateRGBControls()
        {
            Color color = Color.FromArgb(trackRGB_alpha.Value, trackRGB_red.Value, trackRGB_green.Value, trackRGB_blue.Value);

            colorBarRGB.BackColor = color;
            hexaRGB.Text = ColorTranslator.ToHtml(color);

            trackRGB_alpha.Value = trackRGB_alpha.Value;
            textRGB_alpha.Text = trackRGB_alpha.Value.ToString();

            trackRGB_red.Value = trackRGB_red.Value;
            textRGB_red.Text = trackRGB_red.Value.ToString();

            trackRGB_green.Value = trackRGB_green.Value;
            textRGB_green.Text = trackRGB_green.Value.ToString();

            trackRGB_blue.Value = trackRGB_blue.Value;
            textRGB_blue.Text = trackRGB_blue.Value.ToString();

            UpdateHSIControlsBasedOnRGB(color.R, color.G, color.B);
        }

        private void UpdateHSIControlsBasedOnRGB(int red, int green, int blue)
        {
            var hsiValues = Helper.ConvertRGBtoHSI(red, green, blue);
            var hue = (int)Math.Round(hsiValues[0]);
            var saturation = (int)Math.Round(hsiValues[1] * 100);
            var intensity = (int)Math.Round(hsiValues[2] * 100);

            trackHSI_hue.Value = hue;
            trackHSI_saturation.Value = saturation;
            trackHSI_intensity.Value = intensity;

            textHSI_hue.Text = hue.ToString();
            textHSI_saturation.Text = saturation.ToString();
            textHSI_intensity.Text = intensity.ToString();

            var rgbValues = Helper.ConvertHSItoRGB(hsiValues[0], hsiValues[1], hsiValues[2]);

            Color color = Color.FromArgb((int)rgbValues[0], (int)rgbValues[1], (int)rgbValues[2]);
            colorBarHSI.BackColor = color;
            hexaHSI.Text = ColorTranslator.ToHtml(color);
        }

        private void UpdateHSIControls(double hue, double saturation, double intensity)
        {
            Console.WriteLine("in functie " + hue + " " + saturation + " " + intensity);

            trackHSI_hue.Value = (int)hue;
            trackHSI_saturation.Value = (int)(saturation * 100);
            trackHSI_intensity.Value = (int)(intensity * 100);

            textHSI_hue.Text = hue.ToString();
            textHSI_saturation.Text = ((int)(saturation * 100)).ToString();
            textHSI_intensity.Text = ((int)(intensity * 100)).ToString();

            var rgbValues = Helper.ConvertHSItoRGB(hue, saturation, intensity);

            Color color = Color.FromArgb((int)rgbValues[0], (int)rgbValues[1], (int)rgbValues[2]);
            colorBarHSI.BackColor = color;
            hexaHSI.Text = ColorTranslator.ToHtml(color);

            UpdateRGBControlsBasedOnHSI(hue, saturation, intensity);
        }

        private void UpdateRGBControlsBasedOnHSI(double hue, double saturation, double intensity)
        {
            Console.WriteLine("in a 2a functie " + hue + " " + saturation + " " + intensity);

            var rgbValues = Helper.ConvertHSItoRGB(hue, saturation, intensity);
            var red = (int)rgbValues[0];
            var green = (int)rgbValues[1];
            var blue = (int)rgbValues[2];

            Console.WriteLine("in a 2a functie ver2 " + red + " " + green + " " + blue);

            trackRGB_red.Value = red;
            trackRGB_green.Value = green;
            trackRGB_blue.Value = blue;

            textRGB_red.Text = red.ToString();
            textRGB_green.Text = green.ToString();
            textRGB_blue.Text = blue.ToString();


            Color color = Color.FromArgb(red, green, blue);
            colorBarRGB.BackColor = color;
            hexaRGB.Text = ColorTranslator.ToHtml(color);

        }

    }
}
