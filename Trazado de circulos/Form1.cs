using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trazado_de_circulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void PutPixel(Graphics g, int x, int y, Color c)
        {
            Bitmap bm = new Bitmap(1, 1);
            bm.SetPixel(0, 0, c);
            g.DrawImageUnscaled(bm, x, y);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)

        {

            Graphics myGraphics = e.Graphics;
            myGraphics.Clear(Color.White);

            double radius = 100;

            for (int j = 1; j <= 25; j++)
            {
                for (double i = 0.0; i < 360.0; i += 0.1)
                {
                    radius = (j + 1) * 5;
                    double angle = i * System.Math.PI / 180;                    
                    int x = (int)(200 + radius * System.Math.Cos(angle));
                    int y = (int)(200 + radius * System.Math.Sin(angle));
                    PutPixel(myGraphics, x, y, Color.Green);

                    //System.Threading.Thread.Sleep();// If you want to draw circle very slowly.
                }

            }
            myGraphics.Dispose();
        }
    }
}
