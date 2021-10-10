using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 重载tostring方法，便于信息传输
/// </summary>
namespace ChatServer
{
    class MyList<ChatRoom>:List<ChatRoom>
    {
        public override string ToString()
        {
            string Msg = string.Empty;
            foreach (var r in this)
            {
                Msg += r.ToString();
            }
            return Msg;
        }
    }
}
