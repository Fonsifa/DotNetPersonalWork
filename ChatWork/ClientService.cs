using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace ChatWork
{
    class ClientService
    {
        public User User = new User();//用户信息
        public Socket ClientSocket { set; get; }
        private Thread ClientThread;//接收信息的线程
        public string State="";//接收服务器返回的状态
        private bool SendState = false;//文件发送状态
        private List<ChatRoom> Rooms = new List<ChatRoom>();
        private List<Message> Messages = new List<Message>();
        private List<KeyValuePair<string, string>> Users = new List<KeyValuePair<string, string>>();
        public string Msg = null;
        public string RecvPath = null;//文件接收路径
        public bool DownloadFlag = false;//是否下载
        public File fileRecv = new File();
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="IP"></param>
        /// <param name="Port"></param>
        /// <returns></returns>
        public async Task<bool> Init(string IP,int Port)
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(IP), Port);
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            return await Task.Run(() =>
            {
                try
                {
                    ClientSocket.Connect(iPEndPoint);
                    ClientThread = new Thread(RecvMsg);
                    ClientThread.IsBackground = true;
                    ClientThread.Start();
                    // SendMsg(DateTime.Now.ToString() + "\n连接到服务器\r\n", "");
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            });
          
        }
        /// <summary>
        /// 接受连接的socket消息
        /// </summary>
        public async void RecvMsg()
        {
            while(true)
            {
                try
                {
                    byte[] RecvByte = new byte[1024 * 1024];
                    int len = ClientSocket.Receive(RecvByte);
                    if (len <= 0) throw new Exception();
                    string msg = Encoding.UTF8.GetString(RecvByte, 0, len);
                    Console.WriteLine(msg);
                    string[] ss = msg.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    if (msg.StartsWith("[REG]")||msg.StartsWith("[CRE]") ||msg.StartsWith("[FILE]")||
                        msg.StartsWith("[ENT]")||msg.StartsWith("[LOG]")|| msg.StartsWith("[LEA]"))
                    {
                        Console.WriteLine(msg);
                        if (ss[1].Contains("OK")) State = "Succ";
                        else State = "Fail";
                    }
                    else if(msg.StartsWith("[ROOM]"))//聊天室列表
                    {
                        int length = ss.Length;
                        for(int i=1;i<length;i+=3)
                        {
                            ChatRoom chatRoom = new ChatRoom();
                            chatRoom.Id = Int32.Parse(ss[i]);
                            chatRoom.Theme = ss[i + 1];
                            chatRoom.Content = ss[i + 2];
                            Rooms.Add(chatRoom);
                        }
                        SendState = true;
                    }
                    else if(msg.StartsWith("[MSGHIS]"))//历史消息
                    {
                        int length = ss.Length;
                        for(int i=1;i<length;i+=4)
                        {
                            Message m = new Message();
                            m.Id = Int32.Parse(ss[i]);
                            m.Sender = ss[i + 1];
                            m.Content = ss[i + 2];
                            m.SendTime = ss[i + 3];
                            Messages.Add(m);
                        }
                        SendState = true;
                    }
                    else if(msg.StartsWith("[FORBID]"))//禁言
                    {
                        User.Is_Forbid = !User.Is_Forbid;
                    }
                    else if(msg.StartsWith("[FILESEND]"))//接受文件
                    {
                        fileRecv.FileName = ss[1];
                        fileRecv.FileSize= Int64.Parse(ss[2]);
                        await RecvFile();
                    }
                    else if(msg.StartsWith("[USERS]"))//用户列表
                    {
                        Console.WriteLine(msg);
                        int length = ss.Length;
                        for (int i = 1; i < length; i += 2)
                        {
                            string Key = (ss[i]);
                            string Value = ss[i + 1];
                            Users.Add(new KeyValuePair<string, string>(Key, Value));
                        }
                        SendState = true;
                    }
                    else Msg += msg;
                }catch(Exception)
                {
                    Console.WriteLine("断开连接");
                    break;
                }
            }
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Password"></param>
        public async Task<bool> Regist(string Account, string Password)
        {
            State = string.Empty;
            ClientSocket.Send(Encoding.UTF8.GetBytes("[REG]\n"+Account+"\n"+Password));
            return await Task.Run(() =>
            {
                while (string.IsNullOrEmpty(State)) { };
                return State == "Succ";
            });
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Password"></param>
        public async Task<bool> Login(string Account,string Password)
        {
            State = string.Empty;
            ClientSocket.Send(Encoding.UTF8.GetBytes("[LOG]\n" + Account + "\n" + Password));
            return await Task.Run(() =>
            {
                while (string.IsNullOrEmpty(State)) { };
                return State == "Succ";
            });
        }
        /// <summary>
        /// 获取聊天室信息
        /// </summary>
        /// <returns></returns>
        public List<ChatRoom> GetAllChatRoom()
        {
            Rooms.Clear();
            SendState = false;
            ClientSocket.Send(Encoding.UTF8.GetBytes("[ROOM]"));
            while(!SendState)
            {}
            return Rooms;
        }
        /// <summary>
        /// 获取消息记录
        /// </summary>
        /// <param name="RoomId"></param>
        /// <returns></returns>
        public List<Message> GetMsg(int RoomId)
        {
            SendState = false;
            Messages.Clear();
            ClientSocket.Send(Encoding.UTF8.GetBytes($"[MSGHIS]\n{RoomId}"));
            while (!SendState) { }
            return Messages;
        }
        public List<KeyValuePair<string,string>> GetUser(int RoomId)
        {
            SendState = false;
            Users.Clear();
            ClientSocket.Send(Encoding.UTF8.GetBytes($"[USERS]\n{RoomId}"));
            while (!SendState) { }
            return Users;
        }
        /// <summary>
        /// 创建聊天室
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="content"></param>
        public async Task<bool> CreateChatRoom(string theme, string content)
        {
            State = string.Empty;
            ClientSocket.Send(Encoding.UTF8.GetBytes("[CRE]\n" + theme + "\n" + content));
            return await Task.Run(() =>
            {
                while (string.IsNullOrEmpty(State)) { };
                return State == "Succ";
            });
        }
        /// <summary>
        /// 进入聊天室
        /// </summary>
        /// <param name="RoomId"></param>
        public bool EnterChatRoom(int RoomId)
        {
            Msg = null;
            State = string.Empty;
            ClientSocket.Send(Encoding.UTF8.GetBytes("[ENT]\n" + RoomId.ToString()));
            while (string.IsNullOrEmpty(State)) { }
            return State=="Succ";
        }
        /// <summary>
        /// 离开聊天室
        /// </summary>
        /// <param name="RoomId"></param>
        public async Task<bool> LeaveChatRoom(int RoomId)
        {
            State = string.Empty;
            ClientSocket.Send(Encoding.UTF8.GetBytes("[LEA]\n" + RoomId.ToString()));
            return await Task.Run(() =>
            {
                while (string.IsNullOrEmpty(State)) { };
                return State == "Succ";
            });
        }
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="Msg"></param>
        /// <param name="To"></param>
        public bool SendMsg(string SendMsg,string To)
        {
            if(!User.Is_Forbid)
                ClientSocket.Send(Encoding.UTF8.GetBytes($"[MSG]\n{To}\n"+SendMsg));
            return !User.Is_Forbid;
        }
        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="Msg"></param>
        /// <param name="To"></param>
        public async Task<bool> SendFile(string FileName)
        {
            State = string.Empty;
            return await Task.Run(() =>
            {
                try
                {
                    using (FileStream reader = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None))
                    {
                        long send = 0L, length = reader.Length;
                        string sendStr = "[FILE]\n" + Path.GetFileName(FileName) + "\n" + length.ToString();

                        string fileName = Path.GetFileName(FileName);
                        ClientSocket.Send(Encoding.UTF8.GetBytes(sendStr));
                        int BufferSize = 1024;
                        byte[] FileBuffer = new byte[BufferSize];
                        int read, sent;
                        while (string.IsNullOrEmpty(State)) { }
                        if (State.Contains("Succ"))
                            while ((read = reader.Read(FileBuffer, 0, BufferSize)) != 0)
                            {
                                sent = 0;
                                while ((sent += ClientSocket.Send(FileBuffer, sent, read, SocketFlags.None)) < read)
                                {
                                    send += (long)sent;
                                }
                            }
                        return true;
                    }
                }
                catch (Exception) { return false; }
            });
        }
        /// <summary>
        /// 请求文件
        /// </summary>
        /// <param name="FileName"></param>
        public void RequestFile(string FileName)
        {
            State = string.Empty;
            ClientSocket.Send(Encoding.UTF8.GetBytes("[REQ]\n" + FileName));
        }
        /// <summary>
        /// 接受文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="FileSize"></param>
        public async Task<bool> RecvFile()
        {
            long receive = 0L;
            string path =  RecvPath;
            long length = fileRecv.FileSize;
            byte[] buffer = new byte[1024];
            return await Task.Run(() =>
            {
                try
                {
                    using (FileStream writer = new FileStream(Path.Combine(path, fileRecv.FileName),
                        FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        int received;
                        while (receive < length)
                        {
                            received = ClientSocket.Receive(buffer);
                            writer.Write(buffer, 0, received);
                            writer.Flush();
                            receive += (long)received;
                        }
                    }
                    return true;
                }
                catch
                {
                    throw new Exception();
                }
            });
           
        }
    }
    
}
