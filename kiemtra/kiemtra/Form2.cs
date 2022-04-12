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

namespace kiemtra
{
    public partial class Form2 : Form
    {
        Connect con;
        SqlConnection conn;

        public Form2()
        {
            con = new Connect();
            conn = con.connection();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            try
            {
                conn.Open();
                List<maybay> list = new List<maybay>();
                string query = $"select * from maybay where khuvucdo = 'khu b'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    maybay obj = new maybay();
                    obj.Mamaybay = (string)rd["mamaybay"];
                    obj.Tenmaybay = (string)rd["tenmaybay"];
                    obj.Namsanxuat = (int)rd["namsanxuat"];
                    obj.Hangsanxuat = (string)rd["hangsanxuat"];
                    obj.Khuvucdo = (string)rd["khuvucdo"];
                    list.Add(obj);
                }
                conn.Close();
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                List<maybay> list = new List<maybay>();
                string hangsanxuat = textBox2.Text;
                string query = $"select * from maybay where hangsanxuat = '{hangsanxuat}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    maybay obj = new maybay();
                    obj.Mamaybay = (string)rd["mamaybay"];
                    obj.Tenmaybay = (string)rd["tenmaybay"];
                    obj.Namsanxuat = (int)rd["namsanxuat"];
                    obj.Hangsanxuat = (string)rd["hangsanxuat"];
                    obj.Khuvucdo = (string)rd["khuvucdo"];
                    list.Add(obj);
                }
                conn.Close();
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
