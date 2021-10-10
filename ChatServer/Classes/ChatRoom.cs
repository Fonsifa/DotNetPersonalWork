using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class ChatRoom
    {
        public int Id { set; get; }
        public string Theme { set; get; }
        public string Content { set; get; }
        public override string ToString()
        {
            return Id.ToString() + "\n" + Theme + "\n" + Content + "\n";
        }
    }
}

