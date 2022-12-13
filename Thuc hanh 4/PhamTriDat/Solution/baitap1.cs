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
    public partial class baitap1 : Form
    {
        public baitap1()
        {
            InitializeComponent();
        }
        private void ketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "DieuTraDS";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                MessageBox.Show($"kết nối thành công đến SV: {svName},    DB: {dbName}!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }

        private void themmoi_Click(object sender, EventArgs e)
        {
            try
            {
                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "DieuTraDS";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();

                string MaCD = txtMCD.Text;
                string MaPhuong = txtMP.Text;
                string TenCD = txtTCD.Text;
                int CMND = Convert.ToInt32(txtCMND.Text);
                string GioiTinh = txtGT.Text;
                int NamSinh = Convert.ToInt32(txtNS.Text);
                int SoDienThoai = Convert.ToInt32(txtSDT.Text);

                string Query = $"Insert into CongDan (MaCD, MaPhuong, TenCD, CMND, GioiTinh, NamSinh, SoDienThoai) VALUES(N'{MaCD}', N'{MaPhuong}', N'{TenCD}', N'{CMND}', N'{GioiTinh}', N'{NamSinh}', N'{SoDienThoai}')";
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
