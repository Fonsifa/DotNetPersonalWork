using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace ChatServer
{
    class ServerService
    {
        public Socket Listener { set; get; }
        public List<int> Forbidden = new List<int>();//禁言用户列表
        private Dictionary<string, Socket> SocketsConnected = new Dictionary<string, Socket>();//连接的客户端
        private Dictionary<string, User> UserOnline = new Dictionary<string, User>();//ip与用户的映射
        public string Msg =null;
        public int PeopleNum = 0;//在线用户
        public long FileSize = 0;
        private Thread ListenThread;
        /// <summary>
        /// 开启监听
        /// </summary>
        /// <param name="limit"></param>
        public bool Start(string limit,string ip)
        {
            string[] ss = ip.Split(new char[] { '\r', ':' }, StringSplitOptions.RemoveEmptyEntries);
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ss[0]),Int32.Parse(ss[1]));
            try
            {
                Listener = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
                Listener.Bind(iPEndPoint);
                Listener.Listen(Int32.Parse(limit));
                ListenThread = new Thread(ListenConnection);
                ListenThread.IsBackground = true;
                ListenThread.Start();
                Msg += (DateTime.Now.ToString()+"\n服务器打开成功\n");
                return true;
            }
            catch(Exception)
            {
                Msg+=("端口被占用，无法打开服务器\n");
                Console.WriteLine("端口被占用，无法打开服务器");
                return false;
            }
        }
        /// <summary>
        /// 监听连接
        /// </summary>
        private void ListenConnection()
        {
            Socket connect = null;
            while (true)
            {
                try
                {
                    connect = Listener.Accept();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                string remote = connect.RemoteEndPoint.ToString();
                if(!SocketsConnected.ContainsKey(remote))
                SocketsConnected.Add(remote, connect);
                Msg += (DateTime.Now.ToString() + "\n" + remote + "连接到服务器" + "\r\n");
                PeopleNum += 1;
                Thread Recv = new Thread(RecvMsg);
                Recv.IsBackground = true;
                Recv.Start(remote);
            }
        }
        /// <summary>
        /// 处理信息
        /// </summary>
        /// <param name="remote"></param>
        private async void RecvMsg(object remote)
        {
            string Remote = remote as string;
            Socket connect = SocketsConnected[Remote];
            while(true)
            {
                byte[] Recv = new byte[1024 * 1024];
                try
                {
                    int len = connect.Receive(Recv);
                    if (len <= 0) throw new Exception();
                    string RecvStr = Encoding.UTF8.GetString(Recv, 0, len);
                    Console.WriteLine(RecvStr);
                    string[] ss = RecvStr.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    if (RecvStr.StartsWith("[REG]"))//判断是否是客户端发送的登录消息
                    {
                        if (await Regist(ss[1].Trim(), ss[2].Trim()))
                            connect.Send(Encoding.UTF8.GetBytes("[REG]\nOK"));
                        else connect.Send(Encoding.UTF8.GetBytes("[REG]\nFail"));
                    }
                    else if (RecvStr.StartsWith("[LOG]"))
                    {
                        if (await Login(ss[1].Trim(), ss[2].Trim()))
                        {
                            connect.Send(Encoding.UTF8.GetBytes("[LOG]\nOK"));
                            User user = new User();
                            user.Id = GetUserId(ss[1].Trim());
                            user.Account = ss[1].Trim();
                            user.Localep = Remote;
                            UserOnline.Add(Remote, user);
                        }
                        else connect.Send(Encoding.UTF8.GetBytes("[LOG]\nFail"));
                    }
                    else if (RecvStr.StartsWith("[ROOM]"))
                    {
                        connect.Send(Encoding.UTF8.GetBytes("[ROOM]\n" + GetAllChatRoom().ToString()));
                    }
                    else if (RecvStr.StartsWith("[MSGHIS]"))
                    {
                        connect.Send(Encoding.UTF8.GetBytes("[MSGHIS]\n" + GetMsg(Int32.Parse(ss[1])).ToString()));
                    }
                    else if (RecvStr.StartsWith("[MSG]"))
                    {
                        if (UserOnline[Remote].Is_Forbid != true)
                        {
                            if (!ss[1].Contains(":"))//如果含有：，表示是私聊对象
                                TransMsg(Remote, ss[2], ss[1], false);
                            else TransMsg(Remote, ss[2], ss[1], true);
                        }
                    }
                    else if (RecvStr.StartsWith("[CRE]"))
                    {
                        if (await CreateChatRoom(ss[1], ss[2]))
                        {
                            connect.Send(Encoding.UTF8.GetBytes("[CRE]\nOK"));
                        }
                        else connect.Send(Encoding.UTF8.GetBytes("[CRE]\nFail"));
                    }
                    else if (RecvStr.StartsWith("[ENT]"))
                    {
                        if (EnterChatRoom(Remote, Int32.Parse(ss[1])))
                            connect.Send(Encoding.UTF8.GetBytes("[ENT]\nOK"));
                        else connect.Send(Encoding.UTF8.GetBytes("[ENT]\nFail"));
                    }
                    else if (RecvStr.StartsWith("[LEA]"))
                    {
                        Console.WriteLine(RecvStr);
                        if (LeaveChatRoom(Remote, Int32.Parse(ss[1])))
                            connect.Send(Encoding.UTF8.GetBytes("[LEA]\nOK"));
                        else connect.Send(Encoding.UTF8.GetBytes("[LEA]\nFail"));
                    }
                    else if (RecvStr.StartsWith("[FILE]"))
                    {
                        string fileName = ss[1];
                        FileSize = Int64.Parse(ss[2]);
                        connect.Send(Encoding.UTF8.GetBytes("[FILE]\nOK"));
                        await RecvFile(fileName, Remote);                       
                    }
                    else if(RecvStr.StartsWith("[USERS]"))
                    {
                        connect.Send(Encoding.UTF8.GetBytes("[USERS]\n" + GetUserEndPoint(Int32.Parse(ss[1])).ToString()));
                    }
                    else if(RecvStr.StartsWith("[REQ]"))
                    {
                        await SendFile(ss[1], Remote);
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("连接中断");
                    Msg += (DateTime.Now.ToString() + "\n" + connect.RemoteEndPoint.ToString() + "断开连接\r\n");
                    PeopleNum -= 1;
                    if (SocketsConnected.ContainsKey(connect.RemoteEndPoint.ToString())) 
                        SocketsConnected.Remove(connect.RemoteEndPoint.ToString());
                    if (UserOnline.ContainsKey(connect.RemoteEndPoint.ToString()))
                        UserOnline.Remove(connect.RemoteEndPoint.ToString());
                    connect.Close();
                    break;
                }
            }
        }
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
        private static MySqlConnection GetConnection()
        {
            string ConnectString = "server=localhost;User Id=root;password=root;Database=chatdatabase";
            MySqlConnection conn = new MySqlConnection(ConnectString);
            return conn;
        }
        /// <summary>
        /// 获取聊天室信息
        /// </summary>
        /// <returns></returns>
        public MyList<ChatRoom> GetAllChatRoom()
        {
            MyList<ChatRoom> chatRooms = new MyList<ChatRoom>();
            MySqlConnection conn = GetConnection();
            conn.Open();
            using (MySqlCommand MyCmd=new MySqlCommand("select * from chatrooms",conn))
            {
                try
                {
                    MySqlDataReader reader = MyCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            ChatRoom cr = new ChatRoom();
                            cr.Id = reader.GetInt32(0);
                            cr.Theme = reader.GetString(1);
                            cr.Content = reader.GetString(2);
                            chatRooms.Add(cr);
                        }
                    }
                    reader.Close();
                }catch(Exception)
                {
                    Console.WriteLine("查询失败");
                }
                conn.Close();
            }
            return chatRooms;
        }
        /// <summary>
        /// 获取某个房间的消息记录
        /// </summary>
        /// <param name="RoomId"></param>
        /// <returns></returns>
        public MyMsgList<Message> GetMsg(int RoomId)
        {
            MyMsgList<Message> lm = new MyMsgList<Message>();
            if (RoomId <= 0) return null;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand MyCmd = new MySqlCommand($"select idMsg,sendtime,content,account from Msg,users where " +
                    $"Msg.iduser=users.idusers and idroom={RoomId};", conn))
                {
                    try
                    {
                        MySqlDataReader reader = MyCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                Message msg = new Message();
                                msg.Id = reader.GetInt32(0);
                                msg.SendTime = reader.GetString(1);
                                msg.Content = reader.GetString(2);
                                msg.Sender = reader.GetString(3);
                                lm.Add(msg);
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("信息加载失败");
                    }
                }
            }
            return lm;
        }
        /// <summary>
        /// 获取一个聊天室的成员信息
        /// </summary>
        /// <param name="RoomId"></param>
        /// <returns></returns>
        public MyUserList<KeyValuePair<string,string>> GetUserEndPoint(int RoomId)
        {
            MyUserList<KeyValuePair<string, string>> re = new MyUserList<KeyValuePair<string, string>>();
           foreach(var item in UserOnline)
           {
                if(item.Value.IdRoom==RoomId)
               re.Add(new KeyValuePair<string, string>(item.Key, item.Value.Account));
           }
            return re;
        }
        /// <summary>
        /// 转发信息
        /// </summary>
        /// <param name="remote"></param>
        /// <param name="RecvStr"></param>
        /// <param name="RoomId"></param>
        public void TransMsg(string remote,string RecvStr,string RoomId,bool IsPrivate)
        {
            string m = string.Empty;//转发给客户端的字符串
            string m1 = string.Empty;//转发给服务端的字符串
            if (!RecvStr.Contains(@"File"))//不是转发文件
            {
                m = (DateTime.Now.ToString() + "\n" + UserOnline[remote].Account +
                                $"{(IsPrivate ? $"私聊{UserOnline[RoomId].Account}" : null)}说:" + RecvStr + "\r\n");
                m1 = (DateTime.Now.ToString() + "\n" + remote +
                                $"{(IsPrivate ? $"私聊{RoomId}" : null)}说:" + RecvStr + "\r\n");
            }
            else//文件超链接
            {
                RecvStr = $@"File:///{RecvStr.Substring(RecvStr.LastIndexOf('/') + 1)}";
                m = (DateTime.Now.ToString() + "\n" + UserOnline[remote].Account +
                               $"{(IsPrivate ? $"私聊{UserOnline[RoomId].Account}" : null)}发送文件:\n" + @RecvStr + "\r\n");
                m1 = (DateTime.Now.ToString() + "\n" + remote +
                                $"{(IsPrivate ? $"私聊{RoomId}" : null)}发送文件:\n" +@RecvStr + "\r\n");
            }
            Msg += m1;
            //转发消息
            foreach (var item in SocketsConnected)//将消息转发到指定房间内
            {
                var user = UserOnline[item.Key];
                if(!IsPrivate&&user.IdRoom==Int32.Parse(RoomId))//公聊
                    item.Value.Send(Encoding.UTF8.GetBytes(m));
                else if(IsPrivate&&(item.Key==RoomId||item.Key==remote))//私聊
                    item.Value.Send(Encoding.UTF8.GetBytes(m));
            }
            //存储消息记录
            using (MySqlConnection conn =GetConnection())
            {
                conn.Open();
                var user = UserOnline[remote];
                using (MySqlCommand MyCmd=new MySqlCommand($"insert into msg(iduser,content,sendtime,idroom) value" +
                    $"({user.Id},'{RecvStr}','{DateTime.Now}',{RoomId})",conn))
                {
                    try { int flag = MyCmd.ExecuteNonQuery(); }
                    catch { }
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
            int flag = 0;
            return await Task.Run(() =>
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand UserInsert = new MySqlCommand($"insert into Users(Account,Password,IsManager,Isforbid)" +
                        $"values('{Account}','{Password}',{false},{false})", conn))
                    {
                        try
                        {
                            flag = UserInsert.ExecuteNonQuery();
                        }
                        catch (Exception)
                        { }
                    }
                }
                return flag > 0;
            });
            
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Password"></param>
        public async Task<bool> Login(string Account, string Password)
        {
            bool flag = false;
            return await Task.Run(() =>
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand MyCmd = new MySqlCommand($"select password from users where account=" +
                            $"('{Account}')", conn))
                    {
                        MySqlDataReader reader = MyCmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            if (Password == reader.GetString(0)) flag = true;
                        }
                        reader.Close();
                    }
                }
                return flag;
            });
        }
        /// <summary>
        /// 创建聊天室
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="content"></param>
        public async Task<bool> CreateChatRoom(string theme, string content)
        {
            int flag = 0;
            return await Task.Run(()=> 
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand MyCmd = new MySqlCommand($"insert into chatrooms(theme,content) value" +
                        $"('{theme}','{content}')", conn))
                    {
                        try
                        {
                            flag = MyCmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("创建失败");
                        }
                    }
                }
                return flag > 0;
            });
        }
        /// <summary>
        /// 获取Id
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        public int GetUserId(string Account)
        {
            int id = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand MyCmd=new MySqlCommand($"select idusers from users where account='{Account}'",conn))
                {
                    using (MySqlDataReader reader=MyCmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            reader.Read();
                            id = reader.GetInt32(0);
                        }
                    }
                }
            }
            return id;
        }
        /// <summary>
        /// 进入聊天室
        /// </summary>
        /// <param name="RoomId"></param>
        public bool EnterChatRoom(string remote,int RoomId)
        {
            int flag = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand MyCmd = new MySqlCommand($"insert into chat(endpoint,idroom) value" +
                    $"('{remote}',{RoomId})", conn))
                {
                    flag = MyCmd.ExecuteNonQuery();
                }
            }
            //改变在线用户的Id
            var user = UserOnline[remote];
            user.IdRoom = RoomId;
            UserOnline[remote] = user;
            return flag > 0;
        }
        /// <summary>
        /// 离开聊天室
        /// </summary>
        /// <param name="RoomId"></param>
        public bool LeaveChatRoom(string remote,int RoomId)
        {
            int flag = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlCommand MyCmd = new MySqlCommand($"delete from chat where " +
                    $"endpoint='{remote}' and idRoom={RoomId} and idchat>0", conn))
                {
                    flag = MyCmd.ExecuteNonQuery();
                }
            }
            //改变在线用户的Id
            var user = UserOnline[remote];
            user.IdRoom = 0;
            UserOnline[remote] = user;
            return flag > 0;
        }
        /// <summary>
        /// 禁言
        /// </summary>
        /// <param name="User_Id"></param>
        public void Forbid(string remote)
        {
            var user = UserOnline[remote];
            user.Is_Forbid = !user.Is_Forbid;
            UserOnline[remote] = user;
            var connect = SocketsConnected[remote];
            connect.Send(Encoding.UTF8.GetBytes("[FORBID]"));
        }
        /// <summary>
        /// 删除聊天室
        /// </summary>
        /// <param name="RoomId"></param>
        /// <returns></returns>
        public bool DeleteRoom(int RoomId)
        {
            int flag = 0;
            using (MySqlConnection conn=GetConnection())
            {
                conn.Open();
                using (MySqlCommand MyCmd=new MySqlCommand($"delete from chatrooms where idchatrooms={RoomId}",conn))
                {
                    flag = MyCmd.ExecuteNonQuery();
                }
            }
            return flag > 0;
        }
        /// <summary>
        /// 接受客户端文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="remote"></param>
        public async Task<bool> RecvFile(string fileName,string Remote)
        {
            return await Task.Run(() =>
            {
                var connect = SocketsConnected[Remote];
                long receive = 0L;
                string path = "D:/test";
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                long length = FileSize;
                byte[] buffer = new byte[1024];
                try
                {
                    using (FileStream writer = new FileStream(Path.Combine(path, fileName), FileMode.Create,
                        FileAccess.Write,FileShare.None))
                    {
                        int received;
                        Console.WriteLine(receive+length);
                        while (receive < length)
                        {
                            received = SocketsConnected[Remote].Receive(buffer);
                            writer.Write(buffer, 0, received);
                            writer.Flush();
                            receive += (long)received;
                        }
                    }
                    
                    TransMsg(Remote, $@"File:///D:/test/{fileName}", Convert.ToString(UserOnline[Remote].IdRoom), false);
                    return true;
                }
                catch (Exception)
                {
                    return false; 
                }
            });
        }
        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public async Task<bool> SendFile(string FileName,string remote)
        {
            var ClientSocket = SocketsConnected[remote];
            FileName = FileName.Substring(FileName.IndexOf('D'));
            return await Task.Run(() =>
            {
                try
                {
                    using (FileStream reader = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None))
                    {
                        long send = 0L, length = reader.Length;
                        string sendStr = "[FILESEND]\n" + Path.GetFileName(FileName) + "\n" + length.ToString();
                        string fileName = Path.GetFileName(FileName);
                        ClientSocket.Send(Encoding.UTF8.GetBytes(sendStr));
                        int BufferSize = 1024;
                        byte[] FileBuffer = new byte[BufferSize];
                        int read, sent;
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
                catch (Exception ex) { throw ex; }
            });
        }
    }
}
