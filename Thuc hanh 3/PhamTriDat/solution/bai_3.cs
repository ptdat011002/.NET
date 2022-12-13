using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamTriDat.solution
{
    public partial class bai_3 : Form
    {
        public bai_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int sqr = (int)Math.Sqrt(n);
            if (sqr * sqr == n)
            {
                label2.Text = "là số chính phương";
            }
            else label2.Text = "Không phải số chính phương";
        }
    }
}
