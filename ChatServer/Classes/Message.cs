using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class Message
    {
        public int Id { set; get; }
        public string Sender { set; get; }
        public string Content { set; get; }
        public string SendTime { set; get; }
        public override string ToString()
        {
            return Id.ToString()+"\n" + Sender + "\n" + Content+"\n"+ SendTime + "\n";
        }
    }
}
