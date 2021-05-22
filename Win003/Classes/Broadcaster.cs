using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Win003
{
    abstract public class Broadcaster
    {
        public Socket socket;
        public IPEndPoint endIp;
        public IPAddress ip;


        public string IP { get; set; }
        public ushort SPort { get; set; }
        public ushort RPort { get; set; }
        public string Answer { get; set; }
        public string Message { get; set; }
      
        private readonly string[] messeges  =
        {
        
            "Hello","How do you do?",
               "I`m well","And you?",
               "I`m good","By","Goodby" 
        };

        public string Conversation()
        {
            Random rnd = new Random();

            int k = rnd.Next(0, 6);
            string str = messeges[k];       
            return str;
        }



        public virtual void MyConnectResive() {/* todo */ }
        public virtual void MyConnectSend() {/* todo */ }
    }
}
