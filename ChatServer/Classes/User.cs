using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class User
    {
        public int Id { set; get; }
        public string Account { set; get; }
        public string PassWord { set; get; }
        public bool Is_Manager { set; get; }
        public bool Is_Forbid { set; get; }
        public string Localep { set; get; }
        public int IdRoom { set; get; }
    }
}
