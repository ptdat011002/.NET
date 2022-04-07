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

namespace PhamTriDat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS"; 
                string dbName = "DieuTraDS";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";

                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();

                string TaiKhoan = textBox1.Text;
                string MatKhau = textBox2.Text;

                string Query = $"select count(*) from NguoiDung where TaiKhoan = '{TaiKhoan}' and MatKhau = '{MatKhau}'";

                SqlCommand cmd = new SqlCommand(Query, conn);

                int SoLuong = (int)cmd.ExecuteScalar();

                conn.Close();

                if (SoLuong == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thoát hệ thống!");
            Application.Exit();
        }
    }
}
