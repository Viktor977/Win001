
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_Resive = new System.Windows.Forms.ListBox();
            this.lb_Resive = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtBox_Message = new System.Windows.Forms.TextBox();
            this.lb_Send = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_Resive);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 281);
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
            this.listBox_Resive.Size = new System.Drawing.Size(398, 244);
            this.listBox_Resive.TabIndex = 1;
            // 
            // lb_Resive
            // 
            this.lb_Resive.AutoSize = true;
            this.lb_Resive.Location = new System.Drawing.Point(104, 10);
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
            this.lb_Send.Location = new System.Drawing.Point(139, 384);
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
            this.Controls.Add(this.lb_Resive);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.lb_Send);
            this.Controls.Add(this.txtBox_Message);
            this.Controls.Add(this.panel1);
            this.Name = "FServer";
            this.Text = "Server";
            this.Shown += new System.EventHandler(this.FServer_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listBox_Resive;
        private System.Windows.Forms.Label lb_Resive;
        private System.Windows.Forms.TextBox txtBox_Message;
        private System.Windows.Forms.Label lb_Send;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Save;
    }
}

