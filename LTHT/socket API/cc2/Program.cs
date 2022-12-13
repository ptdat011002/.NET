using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace cc2
{
    class Program
    {
        static public void client()
        {
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 100);
            Socket client = new Socket(SocketType.Stream, ProtocolType.Tcp);
            client.Connect(ipendpoint);
            int n;
            byte[] send = new byte[225];
            Random rd = new Random();
            do
            {
                n = rd.Next(-999999,99999);
                send = ASCIIEncoding.ASCII.GetBytes(n.ToString());
                client.Send(send);
                Console.WriteLine(n);
            } while (n < 20000 );
        }
        static void Main(string[] args)
        {
            client();
            Console.ReadKey();
        }
    }
}
