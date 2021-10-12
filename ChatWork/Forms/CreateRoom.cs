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
        private async void Create_button_Click(object sender, EventArgs e)
        {
            var re=await Program.clientService.CreateChatRoom(Theme_box.Text, Introu_box.Text);
            if (!re)
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
