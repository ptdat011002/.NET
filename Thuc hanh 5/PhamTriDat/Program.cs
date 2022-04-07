using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamTriDat.solution
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new bai1.DangNhap());
            // Application.Run(new bai2.CongDan());
            // Application.Run(new bai3.TimKiem());
            // Application.Run(new bai4.BeNgoan());
            // Application.Run(new bai5.Loc());
            // Application.Run(new bai6.SanPham());
            Application.Run(new bai7.SanPham());
        }
    }
}
