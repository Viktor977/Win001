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

namespace Win003
{
    public partial class FServer : Form
    {
        public FServer()
        {
            InitializeComponent();
           
        }

         Server server = new Server();
            
        private void ModeInit()
        {
                 
            server.RPort = ushort.Parse("30001");        
            server.IP = FClient.GetInstance().txtBoxIP.Text;
            server.SPort = ushort.Parse(FClient.GetInstance().txtBoxPort.Text);

        }

        private async void btn_Send_Click(object sender, EventArgs e)
        {
            server.Message = txtBox_Message.Text;         
            listBox_Resive.Items.Add(server.Message);

           
            server.SendMsg();
            btn_Send.Invoke(new Action(() =>
            {
                listBox_Resive.Items.Add(server.Answer);
            }));

            txtBox_Message.Text = "";
           
        }

       

        private void btn_Save_Click(object sender, EventArgs e)
        {
           
             ModeInit();
             Thread thread = new Thread(server.Listen);
             thread.Start();       
                        
        }

        private void FServer_Shown(object sender, EventArgs e)
        {
            listBox_Resive.Invoke(new Action(() => {

                ;
            
            }));
            
    
        }
    }
}
