using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace BingDunDun
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        bool isTimeTick = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int bannerLeft = (this.Width - this.imageBanner.Width) / 2;
            if (isTimeTick)
            {
                this.imageBanner.Location = new Point(bannerLeft - 5, 1);
                this.imageDundunLeft.Visible = false;
                this.imageDundunRight.Visible = true;
            }
            else
            {
                this.imageBanner.Location = new Point(bannerLeft + 5, 1);
                this.imageDundunLeft.Visible = true;
                this.imageDundunRight.Visible = false;
            }
            isTimeTick = !isTimeTick;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
