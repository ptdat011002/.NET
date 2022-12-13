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
    public partial class Form1 : Form
    {
        Connect con;
        SqlConnection conn;
        
        public Form1()
        {
            con = new Connect();
            conn = con.connection();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            try
            {
                conn.Open();
                List<simthe> list = new List<simthe>();
                string query = $"select * from sim";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    simthe obj = new simthe();
                    obj.ID = (string)rd["ID"];
                    obj.SoSim = (string)rd["sosim"];
                    obj.MangID = (string)rd["mangID"];
                    obj.NgayKichHoat = (DateTime)rd["ngaykichhoat"];
                    obj.NgayHetHan = (DateTime)rd["ngayhethan"];
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string ID = textBox1.Text;
                string sosim = textBox2.Text;
                string mangID = textBox3.Text;
                string ngaykichhoat = maskedTextBox1.Text;
                string ngayhethan = maskedTextBox2.Text;
                string query = $"insert into sim(ID, sosim, mangID, ngaykichhoat, ngayhethan) values ('{ID}','{sosim}','{mangID}','{ngaykichhoat}','{ngayhethan}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
                {
                    MessageBox.Show("thêm thành công");
                }
                else
                {
                    MessageBox.Show("thêm thất bại");
                }
                
                conn.Close();

                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
    }
}
