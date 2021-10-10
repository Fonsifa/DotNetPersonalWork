using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatWork
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        public static ClientService clientService;
        [STAThread]
        static void Main()
        {
            clientService = new ClientService();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Connect());
            //Application.Run(new Forms.Chat("1","",""));
        }
    }
}
