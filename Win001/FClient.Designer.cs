
namespace Win001
{
    partial class FClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Connect = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_InText = new System.Windows.Forms.Label();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lb_Ip = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxRecive = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Connect);
            this.panel1.Controls.Add(this.btn_Connect);
            this.panel1.Controls.Add(this.textBoxPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_InText);
            this.panel1.Controls.Add(this.textBoxSend);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.lb_Ip);
            this.panel1.Controls.Add(this.textBoxIP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 512);
            this.panel1.TabIndex = 0;
            // 
            // lb_Connect
            // 
            this.lb_Connect.AutoSize = true;
            this.lb_Connect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Connect.Location = new System.Drawing.Point(121, 182);
            this.lb_Connect.Name = "lb_Connect";
            this.lb_Connect.Size = new System.Drawing.Size(51, 17);
            this.lb_Connect.TabIndex = 8;
            this.lb_Connect.Text = "Offline";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(12, 180);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 7;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(0, 131);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(205, 23);
            this.textBoxPort.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Укажите номер порта";
            // 
            // lb_InText
            // 
            this.lb_InText.AutoSize = true;
            this.lb_InText.Location = new System.Drawing.Point(24, 228);
            this.lb_InText.Name = "lb_InText";
            this.lb_InText.Size = new System.Drawing.Size(148, 15);
            this.lb_InText.TabIndex = 4;
            this.lb_InText.Text = "Введите текст сообщения";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(0, 256);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(205, 199);
            this.textBoxSend.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSend.Location = new System.Drawing.Point(0, 489);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(205, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lb_Ip
            // 
            this.lb_Ip.AutoSize = true;
            this.lb_Ip.Location = new System.Drawing.Point(0, 29);
            this.lb_Ip.Name = "lb_Ip";
            this.lb_Ip.Size = new System.Drawing.Size(63, 15);
            this.lb_Ip.TabIndex = 1;
            this.lb_Ip.Text = "Введите IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(0, 60);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(205, 23);
            this.textBoxIP.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxRecive);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(211, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 512);
            this.panel2.TabIndex = 1;
            // 
            // listBoxRecive
            // 
            this.listBoxRecive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRecive.FormattingEnabled = true;
            this.listBoxRecive.HorizontalScrollbar = true;
            this.listBoxRecive.ItemHeight = 15;
            this.listBoxRecive.Location = new System.Drawing.Point(0, 0);
            this.listBoxRecive.Name = "listBoxRecive";
            this.listBoxRecive.ScrollAlwaysVisible = true;
            this.listBoxRecive.Size = new System.Drawing.Size(394, 512);
            this.listBoxRecive.TabIndex = 0;
            // 
            // FClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FClient";
            this.Text = " Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lb_Ip;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxRecive;
        private System.Windows.Forms.Label lb_InText;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Connect;
        private System.Windows.Forms.Button btn_Connect;
    }
}

