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
    public partial class baitap5 : Form
    {
        public baitap5()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "HoaHong";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();

                string MaLop = textBox1.Text;
                string Query = $"DELETE FROM LopHoc WHERE MaLop = '{MaLop}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
                {
                    MessageBox.Show("xóa thành công");
                }
                else
                {
                    MessageBox.Show("Không có lớp học phù hợp");
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
    }
}
