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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRabbit_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int xco = r.Next(1, 300);
            int yco = r.Next(1, 300);
            this.btnRabbit.Location = new System.Drawing.Point(xco, yco);

        }
    }
}
