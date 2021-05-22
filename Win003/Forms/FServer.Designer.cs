
namespace Win003
{
    partial class FServer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FServer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_Mode1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_Mode2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_Mode3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_Mode4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtn_Reset = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_Resive = new System.Windows.Forms.ListBox();
            this.lb_Resive = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lb_IP = new System.Windows.Forms.Label();
            this.txtBox_IP = new System.Windows.Forms.TextBox();
            this.lb_Port = new System.Windows.Forms.Label();
            this.txtBox_Port = new System.Windows.Forms.TextBox();
            this.txtBox_Message = new System.Windows.Forms.TextBox();
            this.lb_Send = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Aqua;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_Mode1,
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
            this.toolStrip1.Size = new System.Drawing.Size(423, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtn_Mode1
            // 
            this.toolStripBtn_Mode1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtn_Mode1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Mode1.Image")));
            this.toolStripBtn_Mode1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Mode1.Name = "toolStripBtn_Mode1";
            this.toolStripBtn_Mode1.Size = new System.Drawing.Size(51, 22);
            this.toolStripBtn_Mode1.Text = "Mode 1";
            this.toolStripBtn_Mode1.ToolTipText = "Режим Клиент-человек Сервер-человек";
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
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBtn_Reset
            // 
            this.toolStripBtn_Reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtn_Reset.ForeColor = System.Drawing.Color.Red;
            this.toolStripBtn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Reset.Image")));
            this.toolStripBtn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Reset.Name = "toolStripBtn_Reset";
            this.toolStripBtn_Reset.Size = new System.Drawing.Size(39, 22);
            this.toolStripBtn_Reset.Text = "Reset";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_Resive);
            this.panel1.Controls.Add(this.lb_Resive);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 222);
            this.panel1.TabIndex = 1;
            // 
            // listBox_Resive
            // 
            this.listBox_Resive.FormattingEnabled = true;
            this.listBox_Resive.HorizontalScrollbar = true;
            this.listBox_Resive.ItemHeight = 15;
            this.listBox_Resive.Location = new System.Drawing.Point(12, 18);
            this.listBox_Resive.Name = "listBox_Resive";
            this.listBox_Resive.ScrollAlwaysVisible = true;
            this.listBox_Resive.Size = new System.Drawing.Size(398, 184);
            this.listBox_Resive.TabIndex = 1;
            // 
            // lb_Resive
            // 
            this.lb_Resive.AutoSize = true;
            this.lb_Resive.Location = new System.Drawing.Point(0, 0);
            this.lb_Resive.Name = "lb_Resive";
            this.lb_Resive.Size = new System.Drawing.Size(155, 15);
            this.lb_Resive.TabIndex = 0;
            this.lb_Resive.Text = "Принемаемые сообщения";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // lb_IP
            // 
            this.lb_IP.AutoSize = true;
            this.lb_IP.Location = new System.Drawing.Point(12, 269);
            this.lb_IP.Name = "lb_IP";
            this.lb_IP.Size = new System.Drawing.Size(95, 15);
            this.lb_IP.TabIndex = 2;
            this.lb_IP.Text = "Введите свой  IP";
            // 
            // txtBox_IP
            // 
            this.txtBox_IP.Location = new System.Drawing.Point(12, 298);
            this.txtBox_IP.Name = "txtBox_IP";
            this.txtBox_IP.Size = new System.Drawing.Size(186, 23);
            this.txtBox_IP.TabIndex = 3;
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Location = new System.Drawing.Point(242, 269);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(124, 15);
            this.lb_Port.TabIndex = 4;
            this.lb_Port.Text = "Введите номер порта";
            // 
            // txtBox_Port
            // 
            this.txtBox_Port.Location = new System.Drawing.Point(210, 298);
            this.txtBox_Port.Name = "txtBox_Port";
            this.txtBox_Port.Size = new System.Drawing.Size(198, 23);
            this.txtBox_Port.TabIndex = 5;
            // 
            // txtBox_Message
            // 
            this.txtBox_Message.Location = new System.Drawing.Point(40, 411);
            this.txtBox_Message.Multiline = true;
            this.txtBox_Message.Name = "txtBox_Message";
            this.txtBox_Message.Size = new System.Drawing.Size(326, 98);
            this.txtBox_Message.TabIndex = 6;
            // 
            // lb_Send
            // 
            this.lb_Send.AutoSize = true;
            this.lb_Send.Location = new System.Drawing.Point(128, 393);
            this.lb_Send.Name = "lb_Send";
            this.lb_Send.Size = new System.Drawing.Size(120, 15);
            this.lb_Send.TabIndex = 7;
            this.lb_Send.Text = "Введите сообщение ";
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Send.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Send.Location = new System.Drawing.Point(128, 533);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(168, 47);
            this.btn_Send.TabIndex = 8;
            this.btn_Send.Text = "SEND";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(163, 346);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Connect";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 615);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.lb_Send);
            this.Controls.Add(this.txtBox_Message);
            this.Controls.Add(this.txtBox_Port);
            this.Controls.Add(this.lb_Port);
            this.Controls.Add(this.txtBox_IP);
            this.Controls.Add(this.lb_IP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FServer";
            this.Text = "Server";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Mode2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Mode1;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Mode3;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Mode4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Reset;
        private System.Windows.Forms.ListBox listBox_Resive;
        private System.Windows.Forms.Label lb_Resive;
        private System.Windows.Forms.Label lb_IP;
        private System.Windows.Forms.TextBox txtBox_IP;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.TextBox txtBox_Port;
        private System.Windows.Forms.TextBox txtBox_Message;
        private System.Windows.Forms.Label lb_Send;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Save;
    }
}

