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

namespace PhamTriDat.Solution
{
    public partial class baitap6 : Form
    {
        public baitap6()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "HoaHong";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();

                string MaBN = textBox1.Text;
                string MaLop = textBox2.Text;
                string TenBeNgoan = textBox3.Text;
                string NgaySinh = textBox4.Text;
                string GioiTinh = textBox5.Text;
                string HoTenBo = textBox6.Text;
                string HoTenMe = textBox7.Text;
                string DiaChi = textBox8.Text;

                string Query = $"Insert into BeNgoan (MaBN, Malop, TenBeNgoan, NgaySinh, GioiTinh, HoTenBo, HoTenMe, DiaChi) VALUES(N'{MaBN}', N'{MaLop}', N'{TenBeNgoan}', N'{NgaySinh}', N'{GioiTinh}', N'{HoTenBo}', N'{HoTenMe}',N'{DiaChi}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
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
