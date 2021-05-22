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

namespace Win001
{
    public partial class FClient : Form
    {
        public delegate void AddMessageDelegate(string sms);
        public Thread[] thread = new Thread[2];

        public Socket socket;
        public IPEndPoint endIp;
        public IPAddress ip;
        public FClient()
        {
            InitializeComponent();
        }
       
        public string Message { get; set; }
        public string Answer { get; set; }
       
        public ushort Port { get; set; }
        public string IP { get; set; }
        void AddText(String text)
        {          
            listBoxRecive.Items.Add(text);
        }
        #region Methods
        private  void ConectServer(object obj)
        {
             Socket socket1 = (Socket)obj;
             byte[] buffer = new byte[256];
            try
            { 


                EndPoint endPoint = new IPEndPoint(IPAddress.Parse(IP), Port);
               
                    do
                    {
                       int l = socket1.ReceiveFrom(buffer, ref endPoint);
                       String strClientIp = ((IPEndPoint)endPoint).Address.ToString();
                       string resiveSend = Encoding.UTF8.GetString(buffer);
                       listBoxRecive.BeginInvoke(new AddMessageDelegate(AddText),
                       $"Server answer:: {strClientIp}  echo::{resiveSend}");


                    } while (socket1.Available>0);



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
               // throw;
            }
           
           


           
                
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Message = textBoxSend.Text;
            listBoxRecive.Items.Add($"Client sends: {Message}");
                             
            thread[0] = new Thread(ConectServer);
            thread[0].Start(socket);

            thread[1] = new Thread(ConnectClient);
            thread[1].Start();  
            
            textBoxSend.Text = "";
          
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (socket != null && thread != null)
                return;

            GetPort();
            IP = textBoxIP.Text;
           
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
              ProtocolType.Udp);
            ip = IPAddress.Parse(textBoxIP.Text);

            endIp = new IPEndPoint(ip, Port);
            socket.Bind(endIp);


           
            lb_Connect.Text = "Online";
            lb_Connect.ForeColor = Color.Green;
        }

       
        private void GetPort()
        {
            ushort port = 0;
            var isPort = ushort.TryParse(textBoxPort.Text, out port);
            if (isPort != true)
            {
                MessageBox.Show("Неправильно указан порт");
                return;
            }
            Port = port;
        }
        #endregion

        private void ConnectClient()
        {
           
             endIp = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Port);
             socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
             socket.Connect(endIp);
           
            
            while (true)
            {

                try
                {
                                    
                    var date = Encoding.UTF8.GetBytes(Message ?? string.Empty);
                    var daterecive = Encoding.UTF8.GetBytes(Answer ?? string.Empty);
                    

                    do
                    { 
                                                              
                        int i=socket.Send(date);

                       i= socket.Receive(daterecive);
                        Answer = Encoding.UTF8.GetString(daterecive);

                    } while (socket.Available > 0);
             
                    socket.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
               


              
            }
        }     
        
    }
}
