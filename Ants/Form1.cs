using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ants
{
    public partial class frm_Output : Form
    {
        public frm_Output()
        {
            InitializeComponent();
        }

        private void pct_Output_Click(object sender, EventArgs e)
        {

        }

        public void frm_Output_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            var myBitmap = new Bitmap(pct_Output.Width, pct_Output.Height);
            int centerX = Convert.ToInt16(pct_Output.Width * 0.5);
            int centerY = Convert.ToInt16(pct_Output.Height * 0.5);

            var firstAnt = new Ant();

            firstAnt.locX = centerX;
            firstAnt.locY = centerY;
            firstAnt.speedY = 0;
            firstAnt.speedX = 1;
            
            pct_Output.Image = myBitmap;

            myBitmap.SetPixel(firstAnt.locX, firstAnt.locY, Color.Black);

            for (int n = 0; n < 20000; n++)
            {
                Color pixel = myBitmap.GetPixel(firstAnt.locX, firstAnt.locY);

                if (pixel.R == 0 && pixel.G == 0 && pixel.B == 0)
                {
                    //set this pixel white and turn left 
                    myBitmap.SetPixel(firstAnt.locX, firstAnt.locY, Color.White);
                    TurnLeft(firstAnt);
                }
                else
                {
                    //set this pixel black and turn right
                    myBitmap.SetPixel(firstAnt.locX, firstAnt.locY, Color.Black);
                    TurnRight(firstAnt);
                }
                firstAnt.locX += firstAnt.speedX;
                firstAnt.locY += firstAnt.speedY;
            }
            //myBitmap.SetPixel(MousePosition.X, MousePosition.Y, Color.Black);
        }

        private void TurnLeft(Ant ant)
        {
            if (ant.speedX == 1)
            {
                ant.speedX = 0;
                ant.speedY = -1;
            }
            else if (ant.speedX == -1)
            {
                ant.speedX = 0;
                ant.speedY = 1;
            }
            else if (ant.speedY == 1)
            {
                ant.speedY = 0;
                ant.speedX = 1;
            }
            else if (ant.speedY == -1)
            {
                ant.speedY = 0;
                ant.speedX = -1;
            }
        }
        private void TurnRight(Ant ant)
        {
            if (ant.speedX == 1)
            {
                ant.speedX = 0;
                ant.speedY = 1;
            }
            else if (ant.speedX == -1)
            {
                ant.speedX = 0;
                ant.speedY = -1;
            }
            else if (ant.speedY == 1)
            {
                ant.speedY = 0;
                ant.speedX = -1;
            }
            else if (ant.speedY == -1)
            {
                ant.speedY = 0;
                ant.speedX = 1;
            }
        }
    }


    public class Ant
    {
        // X and Y current locations
        // speed in X and Y (ony one will be either +1 or -1 the other must be 0)
        public int locX;
        public int locY;

        public int speedX = 0;
        public int speedY = 0;
        
    }
}
