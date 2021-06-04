using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Win003
{
    public class Server : Broadcaster
    {


        public string Report { get; set; }



        private void InitForBroadcast(ushort port)
        {

            ip = IPAddress.Parse(IP);
            endIp = new IPEndPoint(ip, port);

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            socket.Bind(endIp);


        }
      //---------------------------------------------------------------------
        public void Listen()
        {

            InitForBroadcast(RPort);
            
            
                while (true)
                {

                    var bilder = new StringBuilder();
                    var bytes = 0;
                    var data = new byte[256];
                    var tempEndPoint = (EndPoint)new IPEndPoint(IPAddress.Any, 0);
                    do
                    {
                        bytes = socket.ReceiveFrom(data, ref tempEndPoint);
                        bilder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                    } while (socket.Available > 0);

                    var tempStr = bilder.ToString();
                    var newMassege = $"{DateTime.Now.ToLongTimeString()} -- {tempStr}";

                    Answer = newMassege;

                    Thread.Sleep(50);
                }
               

            
        }


        public async void SendMsg()
        {
         
            try
            {

                var tempsocet = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                var tempIpEndPoint = new IPEndPoint(IPAddress.Parse(IP), SPort);
                await tempsocet.ConnectAsync(tempIpEndPoint);
                if (tempsocet.Connected)
                {
                    var tempmassege = $"{Message}";
                    var date = Encoding.UTF8.GetBytes(tempmassege);
                    var result = tempsocet.Send(date);
                    if (result > 0)
                    {
                        var newMassege = $"{DateTime.Now.ToLongTimeString()} {Message}";

                    }
                }
                tempsocet.Close();
            }
            catch (Exception ex)
            {
                Report = ex.Message;
                return;
            }


        }
    }
}
