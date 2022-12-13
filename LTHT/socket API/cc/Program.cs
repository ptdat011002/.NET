using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;


namespace cc
{
    class Program
    {
        static public void server()
        {
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 100);
            Socket server = new Socket(SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipendpoint);
            server.Listen(10);
            Socket rs = server.Accept();
            byte[] receive = new byte[225];
            int n;
            String abc;
            int max;
            int len;
            len = rs.Receive(receive);
            abc = ASCIIEncoding.ASCII.GetString(receive, 0, len);
            max = Int32.Parse(abc);
            Console.WriteLine(max);
            try
            {
                while (true)
                {
                    len = rs.Receive(receive);
                    abc = ASCIIEncoding.ASCII.GetString(receive, 0, len);
                    n = Int32.Parse(abc);
                    if (n > max)
                        max = n;
                        Console.WriteLine("max = " + max );
                    if (n > 20000) break;
                }

            }
            catch (Exception) { }
        }
        static void Main(string[] args)
        {
            server();
            Console.ReadKey();
        }
    }
}
