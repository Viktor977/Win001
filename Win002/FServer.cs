using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win002
{
    public partial class FServer : Form
    {
        public delegate void BroadcastServer(string text);
        Thread thread;
        Socket socket;
        IPAddress ip;
        IPEndPoint ipEnd;
        public FServer()
        {
            InitializeComponent();
        }
        public ushort Port { get; set; }
        public string IP { get; set; }
        public string Message { get; set; }
        public string Answer { get; set; }
        private void btn_Connect_Click(object sender, EventArgs e)
        {

            SetValues();
            SetSocet();
           
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (socket != null)
            {
              //  thread.Suspend();
                thread.IsBackground = false;
                socket.Shutdown(SocketShutdown.Receive);
                socket.Close();
                socket = null;
                listBoxResive.Items.Clear();
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {

            Message = textBox_Send.Text;
          
            thread = new Thread(ServerWork);
            thread.Start(socket);
            Thread thread1 = new Thread(MessegeSend);
            thread1.Start();
               
            listBoxResive.Items.Add($"server::{Message}");
            textBox_Send.Text = "";
            
        }

        private void MessegeSend()
        {
            btn_Send.Invoke(new Action(() => Message = textBox_Send.Text));
            Socket socket1 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            socket1.SendTo(Encoding.Unicode.GetBytes(textBox_Send.Text), new IPEndPoint(IPAddress.Parse(IP), 30002));
            socket1.Shutdown(SocketShutdown.Send);
            socket1.Close();
        }

        private void ServerWork(object obj)
        {
            Socket serverSoket = (Socket)obj;
           
            byte[] bufferResive = new byte[256];
            var bilder = new StringBuilder();
            var bilderResive = new StringBuilder();
            try
            {

                  do
                  {
                    EndPoint end = new IPEndPoint(IPAddress.Parse(IP), Port);
                    int l = serverSoket.Receive(bufferResive);
                    bilderResive.Append(Encoding.UTF8.GetString(bufferResive));
                    listBoxResive.BeginInvoke(new BroadcastServer(AddMessage), $"client::{bilderResive}");
              

                  } while (true);
                  serverSoket.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
           
        }
        private void AddMessage(string text)
        {
            listBoxResive.Items.Add(text);
        }
        private void SetSocet()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ip = IPAddress.Parse(IP);
            ipEnd = new IPEndPoint(ip, Port);
            socket.Bind(ipEnd); 
            lb_Connection.Text = "online";
            lb_Connection.ForeColor = Color.Aqua;
        }

        private void SetValues()
        {
            IP = textBox_IP.Text;
            if(IP==" " && textBox_IP.Text== null)//HACK
            {
                MessageBox.Show("Не указан IP", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ushort port = 0;
            var isPort =ushort.TryParse( textBox_Port.Text, out port);
            if (isPort != true)
            {
                MessageBox.Show("Не правильно указан порт", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Port = port;
        }

      

    }
}
