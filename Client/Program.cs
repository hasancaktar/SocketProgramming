namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServerSettings.ServerAyarla("127.0.0.1",5050);
            ClientClass.Connect();
            
            Console.ReadLine();

        }
    }
}