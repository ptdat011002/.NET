using System;

namespace ConsoleApp4.Models
{
    public class connguoi
    {
        // để đảm bảo tính đóng gói trong OOP, các vùng dữ liệu luôn đặt ở trạng thái bảo vệ tối đa
        // khai báo các fields
        protected string CMND;
        private string hoten;
        private string quequan;
        private int namsinh;

        // định nghĩa các methods
        // constructor
        // constructor không tham số: không cần khởi tạo giá trị mặc định cho các fields, việc này do tiến trình dọn rác thực hiện
        public connguoi() { }
        // constructor có tham số
        public connguoi(string CMND, string hoten, string quequan, int namsinh)
        {
            this.CMND = CMND;
            this.hoten = hoten;
            this.quequan = quequan;
            this.namsinh = namsinh;
        }
        // định nghĩa các phương thức truy vấn
        public void xuat()
        {
            Console.WriteLine($"{CMND}\t{hoten}\t{quequan}\t{namsinh}\t");
        }
        // định nghĩa các phương thức cập nhật
        public void nhap()
        {
            Console.Write("CMND: ");
            CMND = Console.ReadLine();
            Console.Write("ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("que quan: ");
            quequan = Console.ReadLine();
            Console.Write("nam sinh: ");
            namsinh = Convert.ToInt32(Console.ReadLine());
        }
        /*
        static void Main(string[] args)
        {
            Models.connguoi obj = new Models.connguoi("031202009095", "Pham Tri Dat", "Hai Phong", 2002);
            obj.xuat();

            Models.connguoi cn = new Models.connguoi();
            cn.nhap();
            cn.xuat();

            Console.ReadKey();
        }
        */
    }
    public class sinhvien : connguoi
    {
        // khai báo các fields
        private string masv;
        private string malop;
        private float dtb;

        // định nghĩa các methods
        // constructor
        public sinhvien() { }
        public sinhvien(string masv, string malop, float dtb, string CMND, string hoten, string quequan, int namsinh)
        {
            this.masv = masv;
            this.malop = malop;
            this.dtb = dtb;
            this.CMND = CMND;
        }

        // query methods
        public void xuatsv()
        {
            xuat();

            Console.WriteLine($"{masv}\t{malop}\t{dtb}\t");
        }
        // update methods
        public void nhapsv()
        {
            // gọi phương thức nhập của lớp connguoi
            nhap();

            Console.Write("ma sv: ");
            masv = Console.ReadLine();
            Console.Write("ma lop: ");
            malop = Console.ReadLine();
            Console.Write("diem trung binh: ");
            dtb = (float)Convert.ToDouble(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Models.sinhvien obj = new Models.sinhvien("123456789","D15CNPM5",(float)9.0,"031202009095", "Pham Tri Dat", "Hai Phong", 2002);
            obj.xuatsv();

            Models.sinhvien sv = new Models.sinhvien();
            sv.nhapsv();
            sv.xuatsv();
            
            Console.ReadKey();
        }
    }
}
