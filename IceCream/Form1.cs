using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetOrders_Click(object sender, EventArgs e)
        {
            string s;

            if (rdnBig.Checked == true)
            {
                s = "Big";
            }
            else if(rdnMedium.Checked == true)
            {
                s = "Medium";
            }
            else
            {
                s = "Small";
            }
            MessageBox.Show(s + " is selected!");
        }
    }
}
