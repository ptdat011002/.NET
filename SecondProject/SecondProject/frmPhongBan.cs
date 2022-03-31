using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thư viện của SqlDataProvider

namespace SecondProject
{
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            // Sự kiện sảy ra khi giao diện được load lên
            // Thực hiện đọc dữ liệu của bảng Phòng/Ban và hiển thị dữ liệu này lên DataGridView
            //getData();
            getDataSet();

        }

        public void getData()
        {
            // Truy vấn để lấy dữ liệu
            try
            {
                // Khởi tạo Collection
                List<Model.PhongBan> data = new List<Model.PhongBan>();

                // B1: Khởi tạo chuỗi kết nối
                string svName = "(local)"; // DESKTOP-8SPQQOR\SQLEXPRESS
                string dbName = "QLNV";
                string Sec = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Sec}";
                // B2: Tạo kết nối
                SqlConnection conn = new SqlConnection(con_str);
                // B3: Mở kết nối
                conn.Open();

                // B?.1: Tạo truy vấn
                string Query = "select * from PhongBan";
                // B?.2: Tạo đối tượng thực thi truy vấn
                SqlCommand cmd = new SqlCommand(Query, conn);
                // B?.3: Chọn phương thức thực thi truy vấn, đọc dữ liệu
                // Câu lệnh select trả về nhiều giá trị của bảng PhongBan => chọn phương thức thực thi executeReader để đọc dữ liệu
                SqlDataReader rd = cmd.ExecuteReader();
                // Sử dụng cấu trúc lặp để đọc giá trị của từng dòng
                while(rd.Read())
                {
                    // Truy cập đến các thành phần dữ liệu của Row dựa trên key là tên của trường dữ liệu tương ứng
                    // Ghi nhận dữ liệu vào Collection
                    //MessageBox.Show($"{(string)rd["MaPhong"]}");
                    Model.PhongBan obj = new Model.PhongBan();
                    obj.MaPhong = (string)rd["MaPhong"];
                    obj.TenPhong = (string)rd["TenPhong"];
                    data.Add(obj);
                }
                // B4: Đóng kết nối
                conn.Close();

                // hiển thị dữ liệu truy vấn được lên DataGridView
                dgvPhongBan.DataSource = data;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void getDataSet()
        {
            try
            {
                // Lây dữ liệu từ Database thông qua select query, đổ lên dataSet
                // B1: Khởi tạo chuỗi kết nối
                string svName = "(local)";
                string dbName = "QLNV";
                string Sec = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Sec}";
                // B2: Tạo Connection, nhưng không mở kết nối trong trương hợp làm việc với SqlDataAdapter
                SqlConnection conn = new SqlConnection(con_str);
                // B3: Tạo truy vấn select
                string select_query = "select * from PhongBan";
                // B4: Tạo SqlDataAdapter
                SqlDataAdapter da = new SqlDataAdapter(select_query, conn);
                // B5: Tạo DataSet
                DataSet ds = new DataSet();
                // B6: Đổ dữ liệu truy vấn được, lưu trữ trên DataSet
                da.Fill(ds, "PhongBan"); // da sẽ tự mở kết nối và đóng kết nối sau khi thực thi xong

                // Hiển thị dữ liệu được lưu trữ lên DataGridView
                dgvPhongBan.DataSource = ds.Tables["PhongBan"];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                if (sl == 1) // Kiểm tra xem có bao nhiêu Row được thêm vào DB, nếu sl bằng 1 (1 row được thêm) thì thông báo là thêm mới thành công!
                {
                    MessageBox.Show("Thêm mới thành công!");

                    // Load lại dữ liệu trên DataGridView
                    getData();
                    clearText();
                }

                // Bước 4: Đóng kết nối
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xác định dòng mà người dùng đang click
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if(row >= 0) // Tránh trường hợp người dùng bấm vào tiêu đề của bảng
            {
                // Vô hiệu hóa textField Khóa chính
                txtMaPhong.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                // Đọc dữ liệu của các cột trên DataGridView, hiển thị sang phần thông tin
                txtMaPhong.Text = (string)dgvPhongBan.Rows[row].Cells["MaPhong"].Value;
                txtTenPhong.Text = (string)dgvPhongBan.Rows[row].Cells["TenPhong"].Value;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
        }

        public void clearText()
        {
            txtMaPhong.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
        }
    }
}
