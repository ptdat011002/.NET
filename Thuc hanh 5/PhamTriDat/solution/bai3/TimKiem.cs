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

namespace PhamTriDat.solution.bai3
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<model.CongDan> data = new List<model.CongDan>();

                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "DieuTraDS";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string CMND = textBox1.Text;
                string Query = $"SELECT * FROM CongDan WHERE CMND = '{CMND}'";
                SqlCommand cmd = new SqlCommand(Query, conn);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    model.CongDan obj = new model.CongDan();
                    obj.MaCD = (string)rd["MaCD"];
                    obj.MaPhuong = (string)rd["MaPhuong"];
                    obj.TenCD = (string)rd["TenCD"];
                    obj.CMND = (string)rd["CMND"];
                    obj.GioiTinh = (string)rd["GioiTinh"];
                    obj.NamSinh = (int)rd["NamSinh"];
                    obj.SoDienThoai = (string)rd["SoDienThoai"];
                    data.Add(obj);
                }
                conn.Close();

                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }        
    }
}
