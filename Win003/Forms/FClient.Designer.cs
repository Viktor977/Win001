
namespace Win003
{
    partial class FClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FClient));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tolStripBtn_Mode1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_Mode2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_Mode3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_Mode4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_Reset = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxResive = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label_IP = new System.Windows.Forms.Label();
            this.txtBoxIP = new System.Windows.Forms.TextBox();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.txtBoxSend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_SwitchServer = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStripBtn_Mode1,
            this.toolStripSeparator1,
            this.toolStripBtn_Mode2,
            this.toolStripSeparator2,
            this.toolStripBtn_Mode3,
            this.toolStripSeparator3,
            this.toolStripBtn_Mode4,
            this.toolStripSeparator4,
            this.toolStripBtn_Reset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(424, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tolStripBtn_Mode1
            // 
            this.tolStripBtn_Mode1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolStripBtn_Mode1.Image = ((System.Drawing.Image)(resources.GetObject("tolStripBtn_Mode1.Image")));
            this.tolStripBtn_Mode1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolStripBtn_Mode1.Name = "tolStripBtn_Mode1";
            this.tolStripBtn_Mode1.Size = new System.Drawing.Size(51, 22);
            this.tolStripBtn_Mode1.Text = "Mode 1";
            this.tolStripBtn_Mode1.ToolTipText = "Режим:Комьютер(человек) :: Сервер(человек)";
            this.tolStripBtn_Mode1.Click += new System.EventHandler(this.tolStripBtn_Mode1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtn_Mode2
            // 
            this.toolStripBtn_Mode2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtn_Mode2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Mode2.Image")));
            this.toolStripBtn_Mode2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Mode2.Name = "toolStripBtn_Mode2";
            this.toolStripBtn_Mode2.Size = new System.Drawing.Size(51, 22);
            this.toolStripBtn_Mode2.Text = "Mode 2";
            this.toolStripBtn_Mode2.ToolTipText = "Режим: Компьютер(человек)::Сервер(копьютер)";
            this.toolStripBtn_Mode2.Click += new System.EventHandler(this.toolStripBtn_Mode2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtn_Mode3
            // 
            this.toolStripBtn_Mode3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtn_Mode3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Mode3.Image")));
            this.toolStripBtn_Mode3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Mode3.Name = "toolStripBtn_Mode3";
            this.toolStripBtn_Mode3.Size = new System.Drawing.Size(51, 22);
            this.toolStripBtn_Mode3.Text = "Mode 3";
            this.toolStripBtn_Mode3.ToolTipText = "Режим: Копьютер(копьютер)::Сервер(копьютер)";
            this.toolStripBtn_Mode3.Click += new System.EventHandler(this.toolStripBtn_Mode3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtn_Mode4
            // 
            this.toolStripBtn_Mode4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtn_Mode4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Mode4.Image")));
            this.toolStripBtn_Mode4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Mode4.Name = "toolStripBtn_Mode4";
            this.toolStripBtn_Mode4.Size = new System.Drawing.Size(51, 22);
            this.toolStripBtn_Mode4.Text = "Mode 4";
            this.toolStripBtn_Mode4.ToolTipText = "Режим: Копьютер(копьютер)::Сервер(копьютер)";
            this.toolStripBtn_Mode4.Click += new System.EventHandler(this.toolStripBtn_Mode4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtn_Reset
            // 
            this.toolStripBtn_Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Reset.Image")));
            this.toolStripBtn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Reset.Name = "toolStripBtn_Reset";
            this.toolStripBtn_Reset.Size = new System.Drawing.Size(39, 22);
            this.toolStripBtn_Reset.Text = "Reset";
            this.toolStripBtn_Reset.Click += new System.EventHandler(this.toolStripBtn_Reset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxResive);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 222);
            this.panel1.TabIndex = 1;
            // 
            // listBoxResive
            // 
            this.listBoxResive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResive.FormattingEnabled = true;
            this.listBoxResive.HorizontalScrollbar = true;
            this.listBoxResive.ItemHeight = 15;
            this.listBoxResive.Location = new System.Drawing.Point(0, 0);
            this.listBoxResive.Name = "listBoxResive";
            this.listBoxResive.ScrollAlwaysVisible = true;
            this.listBoxResive.Size = new System.Drawing.Size(400, 222);
            this.listBoxResive.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Принимаемые сообщения \r\n                от клиентов";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(42, 286);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(66, 15);
            this.label_IP.TabIndex = 3;
            this.label_IP.Text = "Укажите IP";
            // 
            // txtBoxIP
            // 
            this.txtBoxIP.Location = new System.Drawing.Point(9, 304);
            this.txtBoxIP.Name = "txtBoxIP";
            this.txtBoxIP.Size = new System.Drawing.Size(172, 23);
            this.txtBoxIP.TabIndex = 4;
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Location = new System.Drawing.Point(226, 304);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(169, 23);
            this.txtBoxPort.TabIndex = 6;
            // 
            // txtBoxSend
            // 
            this.txtBoxSend.Location = new System.Drawing.Point(12, 422);
            this.txtBoxSend.Multiline = true;
            this.txtBoxSend.Name = "txtBoxSend";
            this.txtBoxSend.Size = new System.Drawing.Size(400, 100);
            this.txtBoxSend.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите сообщение";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(245, 286);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(124, 15);
            this.lbPort.TabIndex = 9;
            this.lbPort.Text = "Введите номер порта";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(119, 538);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(160, 41);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(166, 352);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 11;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_SwitchServer
            // 
            this.btn_SwitchServer.Location = new System.Drawing.Point(320, 352);
            this.btn_SwitchServer.Name = "btn_SwitchServer";
            this.btn_SwitchServer.Size = new System.Drawing.Size(75, 23);
            this.btn_SwitchServer.TabIndex = 12;
            this.btn_SwitchServer.Text = "SERVER";
            this.btn_SwitchServer.UseVisualStyleBackColor = true;
            this.btn_SwitchServer.Click += new System.EventHandler(this.btn_SwitchServer_Click);
            // 
            // FClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 593);
            this.Controls.Add(this.btn_SwitchServer);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.txtBoxSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPort);
            this.Controls.Add(this.txtBoxIP);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FClient";
            this.Text = "Client";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tolStripBtn_Mode1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Mode2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Mode3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Mode4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.TextBox txtBoxSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.ListBox listBoxResive;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Reset;
        private System.Windows.Forms.Button btn_SwitchServer;
        public System.Windows.Forms.TextBox txtBoxIP;
        public System.Windows.Forms.TextBox txtBoxPort;
    }
}