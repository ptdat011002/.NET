using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamTriDat
{
    public partial class bai_1 : Form
    {
        public bai_1()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "You pressed Yes button";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "You pressed No button";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = "You pressed Maybe button";
        }
    }
}
