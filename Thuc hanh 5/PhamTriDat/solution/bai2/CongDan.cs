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

namespace PhamTriDat.solution
{
    public partial class bai_2 : Form
    {
        public bai_2()
        {
            InitializeComponent();
        }

        private void bai_2_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
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
                string Query = $"SELECT * FROM CongDan ORDER BY TenCD";
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
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }
    }
}
