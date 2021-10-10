using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatWork.Forms
{
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
        }
        private async Task<bool> WaitSignal()
        {
            return await Task.Run(() =>
            {
                while (string.IsNullOrEmpty(Program.clientService.State)) { }
                return Program.clientService.State.Contains("Succ");
            });
        }
        private async void Confirm_Click(object sender, EventArgs e)
        {
            string acc = Account_Box.Text;
            string pass = Psw_Box.Text;
            string conf_pass = ConfirmPsw_Box.Text;
            if(conf_pass!=pass)
            {
                Psw_Box.Text = null;
                ConfirmPsw_Box.Text = null;
                MessageBox.Show("两次密码不一致");
            }
            else if(pass.Length<6||pass.Length>16)
            {
                Psw_Box.Text = null;
                ConfirmPsw_Box.Text = null;
                MessageBox.Show("密码过短或过长");
            }
            else
            {
                Program.clientService.Regist(acc,pass);
                if (await WaitSignal())
                {
                    MessageBox.Show("注册成功！");
                    this.Hide();
                    Land land = new Land();
                    land.Show();
                }
                else MessageBox.Show("账号已被注册");
            }
        }
    }
}
