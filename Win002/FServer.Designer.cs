
namespace Win002
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.lb_Connection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.lb_IP = new System.Windows.Forms.Label();
            this.listBoxResive = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Stop);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Connection);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Send);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Connect);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Port);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_IP);
            this.splitContainer1.Panel1.Controls.Add(this.lb_IP);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxResive);
            this.splitContainer1.Size = new System.Drawing.Size(517, 483);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(112, 179);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 9;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lb_Connection
            // 
            this.lb_Connection.AutoSize = true;
            this.lb_Connection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Connection.ForeColor = System.Drawing.Color.Blue;
            this.lb_Connection.Location = new System.Drawing.Point(64, 23);
            this.lb_Connection.Name = "lb_Connection";
            this.lb_Connection.Size = new System.Drawing.Size(44, 15);
            this.lb_Connection.TabIndex = 8;
            this.lb_Connection.Text = "offline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, -62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // btn_Send
            // 
            this.btn_Send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Send.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Send.ForeColor = System.Drawing.Color.Blue;
            this.btn_Send.Location = new System.Drawing.Point(0, 456);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(200, 27);
            this.btn_Send.TabIndex = 6;
            this.btn_Send.Text = "SEND";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Send);
            this.panel1.Location = new System.Drawing.Point(3, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 228);
            this.panel1.TabIndex = 5;
            // 
            // textBox_Send
            // 
            this.textBox_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Send.Location = new System.Drawing.Point(0, 0);
            this.textBox_Send.Multiline = true;
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Send.Size = new System.Drawing.Size(194, 228);
            this.textBox_Send.TabIndex = 0;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(3, 179);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "START";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(0, 125);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(187, 23);
            this.textBox_Port.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите номер порта";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(0, 72);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(187, 23);
            this.textBox_IP.TabIndex = 1;
            // 
            // lb_IP
            // 
            this.lb_IP.AutoSize = true;
            this.lb_IP.Location = new System.Drawing.Point(3, 54);
            this.lb_IP.Name = "lb_IP";
            this.lb_IP.Size = new System.Drawing.Size(70, 15);
            this.lb_IP.TabIndex = 0;
            this.lb_IP.Text = "Введите IP";
            // 
            // listBoxResive
            // 
            this.listBoxResive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResive.FormattingEnabled = true;
            this.listBoxResive.ItemHeight = 15;
            this.listBoxResive.Location = new System.Drawing.Point(0, 0);
            this.listBoxResive.Name = "listBoxResive";
            this.listBoxResive.ScrollAlwaysVisible = true;
            this.listBoxResive.Size = new System.Drawing.Size(313, 483);
            this.listBoxResive.TabIndex = 0;
            // 
            // FServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 483);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FServer";
            this.Text = "Server";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label lb_IP;
        private System.Windows.Forms.ListBox listBoxResive;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Connection;
        private System.Windows.Forms.Button btn_Stop;
    }
}

