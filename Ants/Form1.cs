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
            var myBitmap = new Bitmap(pct_Output.Width, pct_Output.Height);
            int centerX = Convert.ToInt16( pct_Output.Width * 0.5);
            int centerY =  Convert.ToInt16(pct_Output.Height * 0.5);
           
            var firstAnt = new Ant();

            firstAnt.locX = centerX;
            firstAnt.locY = centerY;

            myBitmap.SetPixel(firstAnt.locX, firstAnt.locY, Color.Black);

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
