using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
            this.Room_list.Columns.Add("Id", 100, HorizontalAlignment.Left);
            this.Room_list.Columns.Add("主题", 220, HorizontalAlignment.Left);
            this.Room_list.Columns.Add("介绍", 320, HorizontalAlignment.Left);
        }
        private void Manage_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ThreadStart start = new ThreadStart(load_text);
            Thread thread = new Thread(start);
           // thread.IsBackground = true;
            thread.Start();
        }
        private void start_button_Click(object sender, EventArgs e)
        {
            bool start=Program.serverService.Start(Limited_box.Text,textBox1.Text);
            if (start)
            {
                UpdateRoom();
            }
            else MessageBox.Show("开启失败");
        }
        private void load_text()
        {
            while(true)
            {
                Msg_richbox.Text = Program.serverService.Msg;
                Peo_online_box.Text = Program.serverService.PeopleNum.ToString();
            }
        }
        private void Room_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Room_list.SelectedItems.Count != 0)
            {
                string id = Room_list.SelectedItems[0].Text;
                Forms.Manage_a_Room manage = new Forms.Manage_a_Room(Int32.Parse(id));
                manage.Show();
            }
            else return;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            UpdateRoom();
        }
        private void UpdateRoom()
        {
            Room_list.Items.Clear();
            var rooms = Program.serverService.GetAllChatRoom();
            Room_list.BeginUpdate();
            foreach (var room in rooms)
            {
                ListViewItem i = new ListViewItem();
                i.Text = room.Id.ToString();
                i.SubItems.Add(room.Theme);
                i.SubItems.Add(room.Content);
                Room_list.Items.Add(i);
            }
            Room_list.EndUpdate();
        }
    }
}
