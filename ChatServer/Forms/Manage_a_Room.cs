using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer.Forms
{
    public partial class Manage_a_Room : Form
    {
        private int RoomId;
        public Manage_a_Room(int RoomId)
        {
            InitializeComponent();
            this.RoomId = RoomId;
            this.User_list.Columns.Add("在线用户", 140, HorizontalAlignment.Center);
            this.User_list.Columns.Add("账户", 110, HorizontalAlignment.Center);
            Title_label.Text = "第" + RoomId.ToString() + "聊天室信息";
        }

        private void Manage_a_Room_Load(object sender, EventArgs e)
        {
            //得到在线用户列表
            var Endpoints = Program.serverService.GetUserEndPoint(RoomId);
            User_list.BeginUpdate();
            foreach(var s in Endpoints)
            {
                ListViewItem i = new ListViewItem();
                i.Text = s.Key;
                i.SubItems.Add(s.Value);
                User_list.Items.Add(i);
            }
            User_list.EndUpdate();
            //加载历史信息
            List<Message> msgs = Program.serverService.GetMsg(RoomId);
            string MsgHis = null;
            foreach (var m in msgs)
            {
                MsgHis += m.SendTime + "\n" + m.Sender + "说：" + m.Content + "\n";
            }
            Info_box.Text = MsgHis;
        }

        private void User_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (User_list.SelectedItems.Count != 0)
            {
                string remote = User_list.SelectedItems[0].Text;
                DialogResult result =
                MessageBox.Show("确定禁言吗？", "禁言", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Program.serverService.Forbid(remote);
                }
                else { return; }
            }
        }
        private void Dele_button_Click(object sender, EventArgs e)
        {
            bool flag = Program.serverService.DeleteRoom(RoomId);
            if (flag) { this.Close(); }
            else MessageBox.Show("删除失败,可能重复删除");
        }
    }
}
