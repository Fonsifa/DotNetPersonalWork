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
    public partial class CreateRoom : Form
    {
        public CreateRoom()
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
        private async void Create_button_Click(object sender, EventArgs e)
        {
            Program.clientService.CreateChatRoom(Theme_box.Text, Introu_box.Text);
            if (!await WaitSignal())
            {
                MessageBox.Show("创建失败");
            }
            else
            {
                this.Close();
            }
        }
    }
}
