using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWork
{
    class Message
    {
        public int Id { set; get; }
        public string Sender { set; get; }
        public string Content { set; get; }
        public string SendTime { set; get; }
    }
}
