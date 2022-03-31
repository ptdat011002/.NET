using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Thư viện SqlDataProvider

namespace SecondProject
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        frmMain frm;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thoát hệ thống!");
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm.Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked == true)
            {
                // Nếu người dùng chọn hiển thị mật khẩu
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '♥';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đăng nhập của người dùng với hệ thống bằng cách thực hiện truy vấn select về Database
                // B1: Tạo chuỗi kết nối
                string svName = "(local)"; // DESKTOP-8SPQQOR\SQLEXPRESS
                string dbName = "QLNV";
                string Sec = "SSPI";
                string con_str = $"Data Source={svName}; Initial Catalog={dbName}; Integrated Security={Sec}";
                // B2: Tạo kết nối đến CSDL
                SqlConnection conn = new SqlConnection(con_str);
                // B3: Mở kết nối
                conn.Open();
                // B?.1: Tạo truy vấn
                string TaiKhoan = txtTaiKhoan.Text;
                string MatKhau = txtMatKhau.Text;
                // phải được mã hóa => phải có hàm mã hóa mật khẩu nếu là hệ thống thực tế để đảm bảo An toàn/bảo mật thông tin
                string Query = $"select count(*) from NguoiDung where TaiKhoan = '{TaiKhoan}' and MatKhau = '{MatKhau}'";
                // B?.2: Tạo đối tượng để thực thi truy vấn
                SqlCommand cmd = new SqlCommand(Query, conn);
                // B?.3: Chọn phương thức thực thi và nhận kết quả trả về
                // Ở trường hợp này, truy vấn có 1 dữ liệu trả về duy nhất => chọn executeScalar()
                int SoLuong = (int)cmd.ExecuteScalar();
                // B4: Đóng kết nối
                conn.Close();

                // Xác định trạng thái đăng nhập của người dùng dựa trên SoLuong row trả về
                if (SoLuong == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    // Mở giao diện chức năng của hệ thống lên
                    frmHeThong frm = new frmHeThong();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
