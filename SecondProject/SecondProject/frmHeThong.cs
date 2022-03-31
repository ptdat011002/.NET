using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thêm thư viện SqlDataProvider

namespace SecondProject
{
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Khởi tạo chuỗi kết nối
                string svName = "(local)";
                string dbName = "QLNV";
                //string Sec = "SSPI";
                string userID = "sa";
                string password = "123456";
                //string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Sec}";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; User ID={userID}; Password={password}";

                // Bước 2: Tạo kết nối đến CSDL
                SqlConnection conn = new SqlConnection(con_str);

                // Bước 3: Mở kết nối đến CSDL
                conn.Open();

                // Bước ?: Thông báo / thực hiện truy vấn tới CSDL
                MessageBox.Show("Kết nối thành công tới CSDL!");

                // Bước 4: Đóng kết nối
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Thực hiện truy vấn Insert
            try
            {
                // Bước 1: Khởi tạo chuỗi kết nối
                string svName = "(local)";
                string dbName = "QLNV";
                //string Sec = "SSPI";
                string userID = "sa";
                string password = "123456";
                //string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Sec}";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; User ID={userID}; Password={password}";

                // Bước 2: Tạo kết nối đến CSDL
                SqlConnection conn = new SqlConnection(con_str);

                // Bước 3: Mở kết nối đến CSDL
                conn.Open();

                // Bước ?.1: Tạo và thực hiện truy vấn Insert
                string MaPhong = txtMaPhong.Text;
                string TenPhong = txtTenPhong.Text;
                string Query = $"Insert into PhongBan (MaPhong, TenPhong)VALUES(N'{MaPhong}', N'{TenPhong}')";
                // Bước ?.2: Khởi tạo đối tượng truy vấn
                SqlCommand cmd = new SqlCommand(Query, conn);
                // Bước ?.3: Thực thi truy vấn và nhận kết quả => Chọn phương thức ExecuteNonQuery() vì đây không phải câu lệnh Select
                int sl = cmd.ExecuteNonQuery();
                if(sl == 1) // Kiểm tra xem có bao nhiêu Row được thêm vào DB, nếu sl bằng 1 (1 row được thêm) thì thông báo là thêm mới thành công!
                {
                    MessageBox.Show("Thêm mới thành công!");
                }

                // Bước 4: Đóng kết nối
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }


        }
    }
}
