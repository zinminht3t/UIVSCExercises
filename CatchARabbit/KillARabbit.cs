using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchARabbit
{
    public partial class KillARabbit : Form
    {
        public KillARabbit()
        {
            InitializeComponent();
        }

        private void btnRabbit_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnRabbit.BackgroundImage = Image.FromFile("C:/Users/Zin Min Htet/Downloads/Image/sadRabbit.gif");
        }

        private void btnRabbit_MouseUp(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int x = r.Next(1, 300);
            int y = r.Next(1, 300);
            this.btnRabbit.Location = new Point(x, y);
            this.btnRabbit.BackgroundImage = Image.FromFile("C:/Users/Zin Min Htet/Downloads/Image/happyrabbit.gif");
        }
    }
}
