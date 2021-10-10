using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ChatWork.Forms
{
    public partial class Chat : Form
    {
        private readonly int id;//房间Id
        private string MsgHis = null;
        private bool IsPrivate = false;
        private string PrivateRemote = null;//私聊对象的IP
        Thread thread;
        public Chat(string Id,string theme,string content)
        {
            id = Int32.Parse(Id);
            InitializeComponent();
            Tiltle.Text = "关于 "+theme + " 的聊天";
            ChatInfo_Box.Text += "\n简介：\n"+content;
            this.Member_List.Columns.Add("IP", 180, HorizontalAlignment.Left);
            this.Member_List.Columns.Add("账户", 68, HorizontalAlignment.Left);
        }
        private void Chat_Load(object sender, EventArgs e)
        {
            //加载历史信息
            List<Message> msgs = Program.clientService.GetMsg(id);
            foreach(var m in msgs)
            {
                MsgHis += m.SendTime + "\n" + m.Sender + "说：" + m.Content + "\n";
            }
            Msg_Box.Text = MsgHis;
            Msg_Box.SelectionStart = Msg_Box.TextLength;
            Member_List.Items.Clear();
            //加载在线用户
            List<KeyValuePair<string, string>> users = Program.clientService.GetUser(id);
            Member_List.BeginUpdate();
            foreach (var user in users)
            {
                ListViewItem i = new ListViewItem();
                i.Text = user.Key;
                i.SubItems.Add(user.Value);
                Member_List.Items.Add(i);
            }
            Member_List.EndUpdate();
            //信息滑到最底部
            Msg_Box.ScrollToCaret();
            CheckForIllegalCrossThreadCalls = false;
            //开启更新信息的线程
            thread = new Thread(RefreshMsg);
            thread.IsBackground = true;
            thread.Start();
        }
        private void RefreshMsg()//更新信息
        {
            while (true)
            {
                Msg_Box.Text = MsgHis + Program.clientService.Msg;
            }
        }
        //异步等待信号
        private async Task<bool> WaitSignal()
        {
            return await Task.Run(() =>
            {
                while (string.IsNullOrEmpty(Program.clientService.State)) { };
                return Program.clientService.State.Contains("Succ");
            });
        }
        private void Send_button_Click(object sender, EventArgs e)
        {
            string Msg = MsgSend_Box.Text.Trim();
            MsgSend_Box.Text = null;
            //消息类型判断
            if (Msg == "") MessageBox.Show("发送信息不能为空");
            else if (Msg.StartsWith("文件"))//发送文件
            {
                string[] ss = Msg.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                Program.clientService.SendFile(ss[1]);
                new Action(async () =>
                {
                    Task<bool> task = WaitSignal();
                    if (!await task)
                    {
                        MessageBox.Show("发送失败");
                    }
                })();
            }
            else//发送正常消息
            {
                if (!IsPrivate)//公聊
                {
                    if (!Program.clientService.SendMsg(Msg, id.ToString()))
                    {
                        MessageBox.Show("您已被禁言");
                        return;
                    }
                }
                else Program.clientService.SendMsg(Msg, PrivateRemote);       
            }
        }
        private async void Leave_button_Click(object sender, EventArgs e)
        {
            Program.clientService.LeaveChatRoom(id);
            if (await WaitSignal())
            {
                thread.Abort();
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else MessageBox.Show("请稍等");
        }
        private void File_Button_Click(object sender, EventArgs e)
        {
            string file=string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file = dialog.FileName;
            }
            if (!string.IsNullOrEmpty(file))
            {
                MsgSend_Box.Text = "文件：\n"+file;
            }
        }
        private void Member_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Member_List.SelectedItems.Count!=0)
            {
                if (!IsPrivate)
                {
                    DialogResult result =
                   MessageBox.Show("是否和该用户私聊？", "私聊确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        IsPrivate = true;
                    }
                    else IsPrivate = false;
                }
                else
                {
                    DialogResult result =
                   MessageBox.Show("是否和该用户取消私聊？", "取消私聊", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        IsPrivate = false;
                    }
                    else IsPrivate = true;
                }
                PrivateRemote = Member_List.SelectedItems[0].Text;
            }
        }
        //点击文件超链接
        private void Msg_Box_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            string path = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            Program.clientService.RecvPath = path;
            string s = e.LinkText;
            Program.clientService.RequestFile(s.Substring(0,s.LastIndexOf('/'))+"D:/test/"
                +s.Substring(s.LastIndexOf('/')+1));
        }
    }
}
