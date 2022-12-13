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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // sự kiện xảy ra khi giao diện đc load lên
            // thực hiện đo dữ liệu của bảng nhanvat và hiển thị dữ liệu này lên DataGridView
            getData();
        }
        public void getData()
        {
            // truy vấn dữ liệu
            try
            {
                // khởi tạo collection
                List<Model.nhanvat> data = new List<Model.nhanvat>();

                string svName = "DESKTOP-3IU0BFP\\SQLEXPRESS";
                string dbName = "nhanvat";
                string Security = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Security}";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string Query = $"SELECT * FROM nhanvat ORDER BY Sosao";
                SqlCommand cmd = new SqlCommand(Query, conn);
                // câu lệnh select trả về nhiều giá trị của bảng nhanvat, chọn phương thức thực thi executeReader để đọc dữ liệu
                SqlDataReader rd = cmd.ExecuteReader();
                // dùng cấu trúc lặp để đọc giá trị từng dòng
                while(rd.Read())
                {
                    // truy cập dến các dữ liệu của row dựa trên key là tên của trường dữ liệu tương ứng
                    // ghi nhận dữ liệu vào collection
                    // MessageBox.Show($"{(string)rd["Tennhanvat"]}");
                    Model.nhanvat obj = new Model.nhanvat();
                    obj.Tennhanvat = (string)rd["Tennhanvat"];
                    obj.Quocgia = (string)rd["Quocgia"];
                    obj.Sosao = (int)rd["Sosao"];
                    obj.Vision = (string)rd["Vision"];
                    data.Add(obj);
                }
                conn.Close();
                // hiển thị dữ liệu truy vấn được lên DataGridView
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối: " + ex.Message);
            }
        }

    }
}
