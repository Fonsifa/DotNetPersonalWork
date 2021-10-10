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
    class MyUserList<T>:List<KeyValuePair<string,string>>
    {
        public override string ToString()
        {
            string re = string.Empty;
            foreach (var m in this)
            {
                re += m.Key+"\n"+m.Value+"\n";
            }
            return re;
        }
    }
}
