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
    public partial class bai_4 : Form
    {
        public bai_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked)
            {
                int a = (x + y)*2;
                textBox3.Text = a.ToString();
                int b = x * y;
                textBox4.Text = b.ToString();
            }
            else if (radioButton2.Checked)
            {
                float a = (float)Math.PI * 2 * x;
                textBox3.Text = a.ToString();
                float b = (float)Math.PI * x * x;
                textBox4.Text = b.ToString();
            }
            else if (radioButton3.Checked)
            {
                int a = x * 4;
                textBox3.Text = a.ToString();
                int b = x * x;
                textBox4.Text = b.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {          
                DialogResult thoat;
                this.Close();
        }
    }
}
