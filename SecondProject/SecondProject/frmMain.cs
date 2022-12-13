using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            // Xác định vị trí người dùng đang chọn
            //int idx = lstAnimal.SelectedIndex;
            //string item = lstAnimal.SelectedItem.ToString();
            foreach(int idx in lstAnimal.SelectedIndices) {
                string item = lstAnimal.Items[idx].ToString();
                MessageBox.Show($"Người dùng chọn vị trí {idx}: {item}");
            }

        }
    }
}
