using System.Net.Sockets;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServerClass.SetupServer(17000,5050);
            ServerClass.StartServer();  
            Console.ReadLine();
        }
    }
}