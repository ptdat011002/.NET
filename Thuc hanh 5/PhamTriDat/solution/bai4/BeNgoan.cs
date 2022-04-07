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

namespace PhamTriDat.solution.bai4
{
    public partial class BeNgoan : Form
    {
        public BeNgoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<model.BeNgoan> data = new List<model.BeNgoan>();

                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "HoaHong";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string MaLop = textBox1.Text;
                string Query = $"SELECT * FROM BeNgoan WHERE MaLop = '{MaLop}'";
                SqlCommand cmd = new SqlCommand(Query, conn);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    model.BeNgoan obj = new model.BeNgoan();
                    obj.MaBN = (string)rd["MaBN"];
                    obj.MaLop = (string)rd["MaLop"];
                    obj.TenBeNgoan = (string)rd["TenBeNgoan"];
                    obj.NgaySinh = (DateTime)rd["NgaySinh"];
                    obj.GioiTinh = (string)rd["GioiTinh"];
                    obj.HoTenBo = (string)rd["HoTenBo"];
                    obj.HoTenMe = (string)rd["HoTenMe"];
                    obj.DiaChi = (string)rd["DiaChi"];
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
