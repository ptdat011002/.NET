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
    public partial class baitap4 : Form
    {
        public baitap4()
        {
            InitializeComponent();
        }

        private void ketnoi_Click_1(object sender, EventArgs e)
        {
            try
            {
                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "DieuTraDS";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                MessageBox.Show($"kết nối thành công đến: \nSV: {svName}\nDB: {dbName}");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "DieuTraDS";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();

                string MaCD = textBoxMCD.Text;
                string Query = $"DELETE CongDan WHERE MaCD = '{MaCD}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
                {
                    MessageBox.Show("xóa thành công");
                }
                else
                {
                    MessageBox.Show("không có công dân phù hợp");
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
