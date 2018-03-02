using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenu
{
    public partial class Form1 : Form
    {
        int normalHeight;
        int normalWidth;
        public Form1()
        {
            InitializeComponent();
            normalHeight = pictureBox1.Height;
            normalWidth = pictureBox1.Width;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
       {
            pictureBox1.Height = normalHeight;
            pictureBox1.Width = normalWidth;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = normalHeight / 2;
            pictureBox1.Width = normalWidth / 2;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = normalHeight * 2;
            pictureBox1.Width = normalWidth * 2;
        }
    }
}
