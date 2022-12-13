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

namespace PhamTriDat.solution.bai5
{
    public partial class Loc : Form
    {
        public Loc()
        {
            InitializeComponent();
        }

        private void Loc_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            try
            {
                List<model.SanPham> data = new List<model.SanPham>();

                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "PMStore";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string Query = $"SELECT * FROM SanPham WHERE SoLuongTon = 0 OR NgayHetHan < '2022-3-31'";
                SqlCommand cmd = new SqlCommand(Query, conn);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    model.SanPham obj = new model.SanPham();
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
