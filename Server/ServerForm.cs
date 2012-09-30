using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public partial class ServerForm : Form
    {
        private List<Socket> socketList;
        private List<Thread> threadList;
        public ServerForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //禁用异常，对 Windows 窗体控件进行线程安全调用
        }


        //接受信息
        private void AcceptMessage(Object data)
        {
            Socket clientSocket = (Socket)data;
            bool isConnecting = true;
            while (isConnecting)
            {
                try
                {
                    NetworkStream nStream = new NetworkStream(clientSocket);
                    byte[] datasize = new byte[4];
                    nStream.Read(datasize, 0, 4);
                    int size = System.BitConverter.ToInt32(datasize, 0);
                    Byte[] message = new byte[size];
                    int dataleft = size;
                    int start = 0;
                    while (dataleft > 0)
                    {
                        int recv = nStream.Read(message, start, dataleft);
                        start += recv;
                        dataleft -= recv;
                    }
                    rtbAccept.AppendText(clientSocket.RemoteEndPoint.ToString() + ":");
                    rtbAccept.Select();
                    rtbAccept.SelectedRtf = System.Text.Encoding.Unicode.GetString(message);
//                    rtbAccept.Rtf =System.Text.Encoding.Unicode.GetString(message);


                    rtbSend.Rtf = rtbAccept.Rtf;
                    SendMessage(false);

                }
                catch
                {
                    isConnecting = false;
                    socketList.Remove(clientSocket);
                    break;
                }
            }
        }





        private void ServerForm_Load(object sender, EventArgs e)
        {

        }

        private void multi()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ip = IPAddress.Parse(this.tbIP.Text);
            IPEndPoint IPP = new IPEndPoint(ip, Int32.Parse(this.tbPort.Text));


            //绑定
            socket.Bind(IPP);
            //侦听客户端连接
            socket.Listen(10);

            socketList = new List<Socket>();
            threadList = new List<Thread>();
             while (true)
            {
                Socket clientSocket = socket.Accept();
                //显示客户IP和端口号
                rtbAccept.AppendText("与客户机 " + clientSocket.RemoteEndPoint.ToString() + " 成功建立连接。");
                socketList.Add(clientSocket);
                Thread clientThread = new Thread(AcceptMessage);
                threadList.Add(clientThread);
                clientThread.IsBackground = true;
                clientThread.Start(clientSocket);
            }

        }

        //启动侦听
        private void buttonStart_Click_1(object sender, EventArgs e)
        {
           this.buttonStart.Enabled = false;
           Thread clientThread = new Thread(multi);//用后台进程避免阻塞
           clientThread.IsBackground = true;
           clientThread.Start();

        }

        private void rtbSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            //发送信息
            if (e.KeyChar == (char)13)//按下的是回车键
            {
                SendMessage(true);
            }

        }
        private void SendMessage(bool flat)
        {
            string str;
            if (flat)
            {
                str = rtbAccept.Rtf;
                rtbSend.AppendText("(服务器发出的消息)");
                rtbAccept.Rtf = rtbSend.Rtf;
                str = str + rtbSend.Rtf;
            }
            str = rtbSend.Rtf;
            int i = str.Length;
            if (i == 0)
            {
                return;
            }
            else
            {
                i *= 2;//因为str为Unicode编码，每个字符占2字节，所以实际字节数应*2

            }
            byte[] datasize = new byte[4];
            //将32位整数值转换为字节数组
            datasize = System.BitConverter.GetBytes(i);
            byte[] sendbytes = System.Text.Encoding.Unicode.GetBytes(str);
            try
            {
                foreach (Socket clientSocket in socketList)
                {
                    try
                    {
                        NetworkStream netStream = new NetworkStream(clientSocket);
                        netStream.Write(datasize, 0, 4);
                        netStream.Write(sendbytes, 0, sendbytes.Length);
                        netStream.Flush();//调用 Flush 方法不会引发异常
                    }
                    catch
                    {
                        MessageBox.Show(clientSocket.RemoteEndPoint.ToString() + "的信息无法发送!");
                    }
                }
                this.rtbSend.Rtf = "";
            }
            catch
            {
                MessageBox.Show("信息无法发送!");
            }

        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (Socket s in socketList)
                {
                    s.Close();
                }
                foreach (Thread t in threadList)
                {
                    t.Abort();
                }
            }
            catch{}
        }

    }
}
