namespace RGBtoHSI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.hexaHSI = new System.Windows.Forms.TextBox();
            this.trackHSI_intensity = new System.Windows.Forms.TrackBar();
            this.trackHSI_saturation = new System.Windows.Forms.TrackBar();
            this.trackHSI_hue = new System.Windows.Forms.TrackBar();
            this.colorBarHSI = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textHSI_intensity = new System.Windows.Forms.TextBox();
            this.textHSI_saturation = new System.Windows.Forms.TextBox();
            this.textHSI_hue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorBarRGB = new System.Windows.Forms.PictureBox();
            this.hexaRGB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textRGB_blue = new System.Windows.Forms.TextBox();
            this.textRGB_green = new System.Windows.Forms.TextBox();
            this.textRGB_red = new System.Windows.Forms.TextBox();
            this.textRGB_alpha = new System.Windows.Forms.TextBox();
            this.trackRGB_blue = new System.Windows.Forms.TrackBar();
            this.trackRGB_green = new System.Windows.Forms.TrackBar();
            this.trackRGB_red = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackRGB_alpha = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHSI_intensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHSI_saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHSI_hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarHSI)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarRGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRGB_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRGB_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRGB_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRGB_alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.hexaHSI);
            this.panel2.Controls.Add(this.trackHSI_intensity);
            this.panel2.Controls.Add(this.trackHSI_saturation);
            this.panel2.Controls.Add(this.trackHSI_hue);
            this.panel2.Controls.Add(this.colorBarHSI);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textHSI_intensity);
            this.panel2.Controls.Add(this.textHSI_saturation);
            this.panel2.Controls.Add(this.textHSI_hue);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(488, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 173);
            this.panel2.TabIndex = 5;
            // 
            // hexaHSI
            // 
            this.hexaHSI.Location = new System.Drawing.Point(26, 137);
            this.hexaHSI.Name = "hexaHSI";
            this.hexaHSI.Size = new System.Drawing.Size(100, 20);
            this.hexaHSI.TabIndex = 14;
            // 
            // trackHSI_intensity
            // 
            this.trackHSI_intensity.Location = new System.Drawing.Point(79, 95);
            this.trackHSI_intensity.Maximum = 100;
            this.trackHSI_intensity.Name = "trackHSI_intensity";
            this.trackHSI_intensity.Size = new System.Drawing.Size(104, 45);
            this.trackHSI_intensity.TabIndex = 3;
            this.trackHSI_intensity.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackHSI_saturation
            // 
            this.trackHSI_saturation.Location = new System.Drawing.Point(79, 71);
            this.trackHSI_saturation.Maximum = 100;
            this.trackHSI_saturation.Name = "trackHSI_saturation";
            this.trackHSI_saturation.Size = new System.Drawing.Size(104, 45);
            this.trackHSI_saturation.TabIndex = 4;
            this.trackHSI_saturation.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackHSI_hue
            // 
            this.trackHSI_hue.Location = new System.Drawing.Point(79, 46);
            this.trackHSI_hue.Maximum = 360;
            this.trackHSI_hue.Name = "trackHSI_hue";
            this.trackHSI_hue.Size = new System.Drawing.Size(104, 45);
            this.trackHSI_hue.TabIndex = 16;
            this.trackHSI_hue.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // colorBarHSI
            // 
            this.colorBarHSI.Location = new System.Drawing.Point(29, 37);
            this.colorBarHSI.Name = "colorBarHSI";
            this.colorBarHSI.Size = new System.Drawing.Size(24, 90);
            this.colorBarHSI.TabIndex = 16;
            this.colorBarHSI.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Intensity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Saturation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hue";
            // 
            // textHSI_intensity
            // 
            this.textHSI_intensity.Location = new System.Drawing.Point(189, 95);
            this.textHSI_intensity.Name = "textHSI_intensity";
            this.textHSI_intensity.Size = new System.Drawing.Size(27, 20);
            this.textHSI_intensity.TabIndex = 8;
            // 
            // textHSI_saturation
            // 
            this.textHSI_saturation.Location = new System.Drawing.Point(189, 68);
            this.textHSI_saturation.Name = "textHSI_saturation";
            this.textHSI_saturation.Size = new System.Drawing.Size(27, 20);
            this.textHSI_saturation.TabIndex = 7;
            // 
            // textHSI_hue
            // 
            this.textHSI_hue.Location = new System.Drawing.Point(189, 43);
            this.textHSI_hue.Name = "textHSI_hue";
            this.textHSI_hue.Size = new System.Drawing.Size(27, 20);
            this.textHSI_hue.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "HSI- format";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.colorBarRGB);
            this.panel1.Controls.Add(this.hexaRGB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Green);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textRGB_blue);
            this.panel1.Controls.Add(this.textRGB_green);
            this.panel1.Controls.Add(this.textRGB_red);
            this.panel1.Controls.Add(this.textRGB_alpha);
            this.panel1.Controls.Add(this.trackRGB_blue);
            this.panel1.Controls.Add(this.trackRGB_green);
            this.panel1.Controls.Add(this.trackRGB_red);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackRGB_alpha);
            this.panel1.Location = new System.Drawing.Point(488, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 173);
            this.panel1.TabIndex = 4;
            // 
            // colorBarRGB
            // 
            this.colorBarRGB.Location = new System.Drawing.Point(29, 37);
            this.colorBarRGB.Name = "colorBarRGB";
            this.colorBarRGB.Size = new System.Drawing.Size(24, 90);
            this.colorBarRGB.TabIndex = 3;
            this.colorBarRGB.TabStop = false;
            // 
            // hexaRGB
            // 
            this.hexaRGB.Location = new System.Drawing.Point(26, 137);
            this.hexaRGB.Name = "hexaRGB";
            this.hexaRGB.Size = new System.Drawing.Size(100, 20);
            this.hexaRGB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Blue";
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(222, 87);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(36, 13);
            this.Green.TabIndex = 11;
            this.Green.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alpha";
            // 
            // textRGB_blue
            // 
            this.textRGB_blue.Location = new System.Drawing.Point(189, 111);
            this.textRGB_blue.Name = "textRGB_blue";
            this.textRGB_blue.Size = new System.Drawing.Size(27, 20);
            this.textRGB_blue.TabIndex = 8;
            // 
            // textRGB_green
            // 
            this.textRGB_green.Location = new System.Drawing.Point(189, 84);
            this.textRGB_green.Name = "textRGB_green";
            this.textRGB_green.Size = new System.Drawing.Size(27, 20);
            this.textRGB_green.TabIndex = 7;
            // 
            // textRGB_red
            // 
            this.textRGB_red.Location = new System.Drawing.Point(189, 59);
            this.textRGB_red.Name = "textRGB_red";
            this.textRGB_red.Size = new System.Drawing.Size(27, 20);
            this.textRGB_red.TabIndex = 6;
            // 
            // textRGB_alpha
            // 
            this.textRGB_alpha.Location = new System.Drawing.Point(189, 33);
            this.textRGB_alpha.Name = "textRGB_alpha";
            this.textRGB_alpha.Size = new System.Drawing.Size(27, 20);
            this.textRGB_alpha.TabIndex = 5;
            // 
            // trackRGB_blue
            // 
            this.trackRGB_blue.Location = new System.Drawing.Point(79, 111);
            this.trackRGB_blue.Maximum = 255;
            this.trackRGB_blue.Name = "trackRGB_blue";
            this.trackRGB_blue.Size = new System.Drawing.Size(104, 45);
            this.trackRGB_blue.TabIndex = 4;
            this.trackRGB_blue.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackRGB_green
            // 
            this.trackRGB_green.Location = new System.Drawing.Point(79, 84);
            this.trackRGB_green.Maximum = 255;
            this.trackRGB_green.Name = "trackRGB_green";
            this.trackRGB_green.Size = new System.Drawing.Size(104, 45);
            this.trackRGB_green.TabIndex = 3;
            this.trackRGB_green.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackRGB_red
            // 
            this.trackRGB_red.Location = new System.Drawing.Point(79, 59);
            this.trackRGB_red.Maximum = 255;
            this.trackRGB_red.Name = "trackRGB_red";
            this.trackRGB_red.Size = new System.Drawing.Size(104, 45);
            this.trackRGB_red.TabIndex = 2;
            this.trackRGB_red.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARGB - format";
            // 
            // trackRGB_alpha
            // 
            this.trackRGB_alpha.Location = new System.Drawing.Point(79, 37);
            this.trackRGB_alpha.Maximum = 255;
            this.trackRGB_alpha.Name = "trackRGB_alpha";
            this.trackRGB_alpha.Size = new System.Drawing.Size(104, 45);
            this.trackRGB_alpha.TabIndex = 0;
            this.trackRGB_alpha.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 410);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHSI_intensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHSI_saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHSI_hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarHSI)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBarRGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRGB_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRGB_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRGB_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRGB_alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox hexaHSI;
        private System.Windows.Forms.TrackBar trackHSI_intensity;
        private System.Windows.Forms.TrackBar trackHSI_saturation;
        private System.Windows.Forms.TrackBar trackHSI_hue;
        private System.Windows.Forms.PictureBox colorBarHSI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textHSI_intensity;
        private System.Windows.Forms.TextBox textHSI_saturation;
        private System.Windows.Forms.TextBox textHSI_hue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox colorBarRGB;
        private System.Windows.Forms.TextBox hexaRGB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRGB_blue;
        private System.Windows.Forms.TextBox textRGB_green;
        private System.Windows.Forms.TextBox textRGB_red;
        private System.Windows.Forms.TextBox textRGB_alpha;
        private System.Windows.Forms.TrackBar trackRGB_blue;
        private System.Windows.Forms.TrackBar trackRGB_green;
        private System.Windows.Forms.TrackBar trackRGB_red;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackRGB_alpha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

