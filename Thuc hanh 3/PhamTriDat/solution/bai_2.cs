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
    public partial class bai_2 : Form
    {
        public bai_2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox4.Text);
            float b = float.Parse(textBox5.Text);
            if (a == 0)
            {
                if (b == 0)
                    MessageBox.Show("Phương trình vô số nghiệm");
                else
                    MessageBox.Show("Phương trình vô nghiệm");
            }
            else
            {
                float x = -b / a;
                textBox6.Text = x.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thoát",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }       
    }
}
