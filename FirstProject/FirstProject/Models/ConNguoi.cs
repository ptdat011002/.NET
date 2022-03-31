using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Models
{
    public class ConNguoi
    {
        // Để đảm bảo tính đóng gói trong OOP, các vùng dữ liệu luôn luôn đặt ở trạng thái bảo vệ là tối đa
        // Khai báo các Fields
        private string CMND;
        private string HoTen;
        private string QueQuan;
        private int NamSinh;

        // Định nghĩa các Methods
        // Constructor
        // Constructor không tham số: Không cần khởi tạo giá trị mặc định cho các Fields, việc này do Tiến trình dọn rác thực hiện
        public ConNguoi() { }
        // Contructor có tham số
        public ConNguoi(string CMND, string HoTen, string QueQuan, int NamSinh)
        {
            this.CMND = CMND;
            this.HoTen = HoTen;
            this.QueQuan = QueQuan;
            this.NamSinh = NamSinh;
        }
        // Định nghĩa các phương thức truy vấn
        public virtual void Xuat()
        {
            Console.WriteLine($"{CMND}\t{HoTen}\t{QueQuan}\t{NamSinh}\t");
        }
        // Định nghĩa các phương thức cập nhật
        public virtual void Nhap()
        {
            Console.Write("CMND: ");
            CMND = Console.ReadLine();
            Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Que quan: ");
            QueQuan = Console.ReadLine();
            Console.Write("Nam sinh: ");
            NamSinh = Convert.ToInt32(Console.ReadLine());
        }
    }
}
