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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // bước 1: tạo chuỗi kết nối
                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "nhanvat";
                string Security = "SSPI";

                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                // bước 2: tạo đối tượng kết nối
                SqlConnection conn = new SqlConnection(con_str);
                // bước 3: Mở kết nối đến CSDL
                conn.Open();
                MessageBox.Show($"kết nối thành công đến SV: {svName}, DB: {dbName}!");
                // bước 4: đóng kết nối
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // thêm mới nhân vật vào CSDL
            try
            {
                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "nhanvat";
                string Security = "SSPI";

                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";

                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();
                string Tennhanvat = textBox1.Text;
                string Quocgia = textBox2.Text;
                string Sosao = textBox3.Text;
                string Vision = textBox4.Text;
                string Query = $"Insert into nhanvat (Tennhanvat, Quocgia, Sosao, Vision)VALUES(N'{Tennhanvat}', N'{Quocgia}', N'{Sosao}', N'{Vision}')";

                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = cmd.ExecuteNonQuery();
                if(sl == 1)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
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
