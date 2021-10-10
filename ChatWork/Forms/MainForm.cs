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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Room_list.Columns.Add("Id", 100, HorizontalAlignment.Left);
            this.Room_list.Columns.Add("主题", 220, HorizontalAlignment.Left);
            this.Room_list.Columns.Add("介绍", 320, HorizontalAlignment.Left);
            UpdateRoom();
        }
        private void UpdateRoom()
        {
            Room_list.Items.Clear();
            List<ChatRoom> rooms = Program.clientService.GetAllChatRoom();
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
        private void Room_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Room_list.SelectedItems.Count != 0)
            {
                string id = Room_list.SelectedItems[0].Text;
                string theme = Room_list.SelectedItems[0].SubItems[1].Text;
                string content = Room_list.SelectedItems[0].SubItems[2].Text;
                Chat chat = new Chat(id, theme, content);
                this.Hide();
                Program.clientService.EnterChatRoom(Int32.Parse(id));
                chat.Show();
            }
            else return;
        }
        private void createRoom_button_Click(object sender, EventArgs e)
        {
            CreateRoom createRoom = new CreateRoom();
            createRoom.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UpdateRoom();
        }
    }
}
