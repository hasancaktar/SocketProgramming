using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerClass
    {
        public static int MaxUsers { get; set; }
        public static int Port { get; set; }
        public static TcpListener serverListener;
        public static SortedDictionary<int, Client> clients = new SortedDictionary<int, Client>();

        public static void SetupServer(int _maxUser, int _port)
        {
            MaxUsers = _maxUser;
            Port = _port;

            serverListener = new TcpListener(IPAddress.Any, Port);
           Console.WriteLine($"Server Kuruldu : Maximum kullanıcı sayısı : {MaxUsers}, Dinlenen port : {Port}");
            
            // serverListener.Start();
        }

        public static void StartServer()
        {
            serverListener.Start();
            Console.WriteLine($"Server başlatıldı. {Port}'unda dinleniyor");
            IntializeServerData();
            serverListener.BeginAcceptTcpClient(AcceptClientCallBack, null);
            Console.WriteLine("Kullanıcılar Bekleniyor...");

        }

        public static void AcceptClientCallBack(IAsyncResult ar)
        {
            //StartServer();
            TcpClient client = serverListener.EndAcceptTcpClient(ar);
            serverListener.BeginAcceptTcpClient(AcceptClientCallBack, null);
            Console.WriteLine("Kullanıcı katılıyor...");



            Console.WriteLine($"Bir kullanıcı geldi. {client.Client.RemoteEndPoint}");


            //NetworkStream networkStream = client.GetStream();
        }

        public static void IntializeServerData()
        {
            for (int i = 1; i <= clients.Count; i++)
            {
                clients.Add(i, new  Client(i));
            }
        }
    }
}
