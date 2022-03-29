using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhamTriDat.Solution
{
    public partial class baitap3 : Form
    {
        public baitap3()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "DieuTraDS";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();

                string MaCD = textBox1.Text;
                string CMND = textBox2.Text;

                string Query = $"UPDATE CongDan SET CMND = '{CMND}' WHERE MaCD = '{MaCD}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
                {
                    MessageBox.Show("cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("cập nhật thất bại");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
    }
}
