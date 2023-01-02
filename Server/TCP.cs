using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class TCP
    {
        public TcpClient socket;
        public int  Id { get; set; }

        public TCP(int id)
        {
                Id=id;
        }
    }
}
