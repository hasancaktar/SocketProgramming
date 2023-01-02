using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Client
    {
        public int Id { get; set; }
        public TCP Tcp;
        public Client(int id)
        {
            Id = id;
            Tcp = new TCP(id);
        }

    }
}
