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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Class1 con;
        SqlConnection conn;

        public Form1()
        {
            con = new Class1();
            conn = con.connection();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Class2> data = new List<Class2>();
                conn.Open();

                string NhaCungCap = textBox1.Text;
                string Query = $"SELECT * FROM SanPham WHERE NhaCungCap = '{NhaCungCap}'";

                SqlCommand cmd = new SqlCommand(Query, conn);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Class2 obj = new Class2();
                    obj.MaSanPham = (string)rd["MaSanPham"];
                    obj.TenSanPham = (string)rd["TenSanPham"];
                    obj.SoLuongTon = (int)rd["SoLuongTon"];
                    obj.NgaySanXuat = (DateTime)rd["NgaySanXuat"];
                    obj.NgayHetHan = (DateTime)rd["NgayHetHan"];
                    obj.NhaCungCap = (string)rd["NhaCungCap"];
                    data.Add(obj);
                }
                conn.Close();

                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
    }
}
    