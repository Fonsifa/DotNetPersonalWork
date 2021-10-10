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
    class MyMsgList<Message>:List<Message>
    {
        public override string ToString()
        {
            string re = string.Empty;
            foreach(var m in this)
            {
                re += m.ToString();
            }
            return re;
        }
    }
}
