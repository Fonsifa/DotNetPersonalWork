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
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
        }
        private async void connect_button_Click(object sender, EventArgs e)
        {
            bool connect =await Program.clientService.Init(IP_Box.Text,Int32.Parse(Port_Box.Text));
            if (connect)
            {
                this.Hide();
                Land land = new Land();
                land.Show();
            }
            else MessageBox.Show("服务器未打开");
        }
    }
}
