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
            ModeSwitch();
        }

         Server server = new Server();
            
        private void ModeInit()
        {
            if (toolStrip1.Enabled)
            {
                MessageBox.Show("Не указан порт и IP", "ERROR",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);//TODO
                return;
            }
            server.IP = txtBox_IP.Text;
            server.RPort = ushort.Parse("30001");

            server.SPort = ushort.Parse(txtBox_Port.Text);

        }

        private async void btn_Send_Click(object sender, EventArgs e)
        {
            server.Message = txtBox_Message.Text;
            //listBox_Resive.Items.Add(server.Answer);
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

       
        private void ModeSwitch()
        {
            toolStrip1.Enabled = false;

        }
       
    }
}
