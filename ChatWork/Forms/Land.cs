using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatWork
{
    public partial class Land : Form
    {
        public Land()
        {
            InitializeComponent();
        }
        private async void Login_button_Click(object sender, EventArgs e)
        {
            var re=await Program.clientService.Login(Account.Text, Password.Text);
            if (re)
            {
                this.Hide();
                Forms.MainForm mainForm = new Forms.MainForm();
                mainForm.Show();
            }
            else MessageBox.Show("账户不存在或者密码错误"); 
        }

        private void Regist_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Regist regist = new Forms.Regist();
            regist.Show();
        }
    }
}
