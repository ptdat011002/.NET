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
    public partial class Form2 : Form
    {
        Class1 con;
        SqlConnection conn;

        public Form2()
        {
            con = new Class1();
            conn = con.connection();
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            try
            {
                List<Class2> list = new List<Class2>();

                conn.Open();
                string Query = $"SELECT * FROM SanPham WHERE SoLuongTon = 0 OR NgayHetHan > '2022-3-31'";
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
                    list.Add(obj);
                }
                conn.Close();

                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
    }
}
