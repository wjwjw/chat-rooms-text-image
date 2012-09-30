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

namespace Client
{
    public partial class ClientForm : Form
    {
        private Socket socket;
        private Thread tAcceptMSG;

        //接收信息函数
        private void AcceptMessage()
        {
            while (true)
            {
                try
                {
                    NetworkStream nStream = new NetworkStream(socket);
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
                    this.rtbAccept.Rtf = System.Text.Encoding.Unicode.GetString(message);
                }
                catch
                { }
            }
        }

        //发送信息函数


        public ClientForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //禁用异常，对 Windows 窗体控件进行线程安全调用
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        //连接服务器
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //服务器程序的IP和端口
            IPAddress ip = IPAddress.Parse(this.tbIP.Text);
            IPEndPoint IPP = new IPEndPoint(ip, Int32.Parse(this.tbPort.Text));

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect(IPP);
            }
            catch
            {
                MessageBox.Show("与服务器连接失败！");
                return;
            }
            this.lbServerState.Text = "与服务器 " + this.tbIP.Text + ":" + this.tbPort.Text + " 成功建立连接。";
            tAcceptMSG = new Thread(new ThreadStart(AcceptMessage));
            //后台运行以便窗体关闭时终止线程
            tAcceptMSG.IsBackground = true;
            tAcceptMSG.Start();
            this.buttonStart.Enabled = false;
 
        }
        //程序关闭时停止连接
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                socket.Close();
                tAcceptMSG.Abort();
            }
            catch
            { }
        }

        private void rtbSend_TextChanged(object sender, EventArgs e)
        {

        }


        private void rtbSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//回车
            {
                string str = this.rtbSend.Rtf;
                int i = str.Length;
                if (i == 0)
                {
                    return;
                }
                else
                {
                    i *= 2;//Unicode编码个字符占2字节
                }
                byte[] datasize = new byte[4];
                //将32位整数值转换为字节数组
                datasize = System.BitConverter.GetBytes(i);
                byte[] sendbytes = System.Text.Encoding.Unicode.GetBytes(str);
                try
                {
                    NetworkStream netStream = new NetworkStream(socket);
                    netStream.Write(datasize, 0, 4);
                    netStream.Write(sendbytes, 0, sendbytes.Length);
                    netStream.Flush();
                    this.rtbSend.Text = "";
                }
                catch
                {
                    MessageBox.Show("信息无法发送!");
                }
            }

        }

    }
}
