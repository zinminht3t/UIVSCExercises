using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchAGenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = true;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Visible = false;
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            this.pictureBox1.Size = new Size(200, 200);
        }
    }
}
