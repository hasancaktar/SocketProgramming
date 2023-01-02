using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ServerSettings
    {
        public static string HOST { get; set; }
        public static int PORT { get; set; }
        public  static void ServerAyarla(string host, int port)
        {
            HOST = host;
            PORT = port;
        }




    }
}
