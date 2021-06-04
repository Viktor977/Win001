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
    public partial class FClient : Form
    {
        private static FClient _instanse;
        private FClient()
        {
            InitializeComponent();
           
        }
        public static FClient GetInstance() => _instanse ??= new FClient();

        Client client = new Client();
        private  void btnSend_Click(object sender, EventArgs e)
        {
            client.Message = txtBoxSend.Text;
            client.SendMsg();
            listBoxResive.Items.Add(client.Message);
            txtBoxSend.Text = "";
          
        }

        private void ModeInit()
        {
            if (toolStrip1.Enabled)
            {
                MessageBox.Show("Не указан порт и IP","ERROR",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);//TODO
                return;
            }
            client.IP = txtBoxIP.Text;
            client.RPort = ushort.Parse("30001");
            client.SPort = ushort.Parse(txtBoxPort.Text);
            
           
        }

        

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (toolStrip1.Enabled) {
                MessageBox.Show("Не выбран режим работы","ERROR",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Thread thread = new Thread(client.Listen);
            thread.Start();
            toolStrip1.Enabled = true;

        }

        private void btn_SwitchServer_Click(object sender, EventArgs e)
        {
           
              FServer server = new FServer();
           
              server.Show();
        }

      

        private void ModeSwitch(int i)
        {
            switch (i)
            {
                case 1:
                    tolStripBtn_Mode1.Enabled = true;
                    toolStripBtn_Mode2.Enabled = false;
                    toolStripBtn_Mode3.Enabled = false;
                    toolStripBtn_Mode4.Enabled = false;
                    toolStrip1.Enabled = false;
                   break;
                case 2:
                    tolStripBtn_Mode1.Enabled = false;
                    toolStripBtn_Mode2.Enabled = true;
                    toolStripBtn_Mode3.Enabled = false;
                    toolStripBtn_Mode4.Enabled = false;
                    toolStrip1.Enabled = false;

                    break;
                case 3:
                    tolStripBtn_Mode1.Enabled = false;
                    toolStripBtn_Mode2.Enabled = false;
                    toolStripBtn_Mode3.Enabled = true;
                    toolStripBtn_Mode4.Enabled = false;
                    toolStrip1.Enabled = false;

                    break;
                case 4:
                    tolStripBtn_Mode1.Enabled = false;
                    toolStripBtn_Mode2.Enabled = false;
                    toolStripBtn_Mode3.Enabled = true;
                    toolStripBtn_Mode4.Enabled = false;
                    toolStrip1.Enabled = false;

                    break;
                case 5:
                    tolStripBtn_Mode1.Enabled = true;
                    toolStripBtn_Mode2.Enabled = true;
                    toolStripBtn_Mode3.Enabled = true;
                    toolStripBtn_Mode4.Enabled = true;
                    toolStrip1.Enabled = true;
                    break;
                default:
                    goto case 1;
                    break;

            }
        }

        private void tolStripBtn_Mode1_Click(object sender, EventArgs e)
        {
           ModeSwitch(1);
            ModeInit();
        }

        private void toolStripBtn_Mode2_Click(object sender, EventArgs e)
        {
            ModeInit();
            ModeSwitch(2);
            
            //TODO Человек (клиент) — компьютер (сервер);
        }

        private void toolStripBtn_Mode3_Click(object sender, EventArgs e)
        {
            ModeInit();
            ModeSwitch(3);
           
            // TODO Компьютер (клиент) — человек (сервер);
        }

        private void toolStripBtn_Mode4_Click(object sender, EventArgs e)
        {
            ModeSwitch(4);
            ModeInit();
           //TODO  Компьютер(клиент) — компьютер(сервер).
        }

        private void toolStripBtn_Reset_Click(object sender, EventArgs e)
        {
            ModeSwitch(5);
        }

        
    }
}
