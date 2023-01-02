using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientClass
    {
        public static TcpClient socket = new TcpClient();

        public static void Connect()
        {
            socket.BeginConnect(ServerSettings.HOST, ServerSettings.PORT, new AsyncCallback(ConnectCallBack), null);
            Console.WriteLine("Bağlanmaya Çalışıyor");
        }

        public static void ConnectCallBack(IAsyncResult result)
        {
            socket.EndConnect(result);
            if (socket.Connected)
                Console.WriteLine("Bağlandı");
        }
    }
}
