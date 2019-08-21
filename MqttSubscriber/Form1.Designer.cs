namespace MqttSubscriber
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.txtGetIpAddress = new System.Windows.Forms.TextBox();
            this.txtGetTopic = new System.Windows.Forms.RichTextBox();
            this.txtGetPortNumber = new System.Windows.Forms.TextBox();
            this.richTbIncomingMessages = new System.Windows.Forms.RichTextBox();
            this.cmBoxGetQosLevel = new System.Windows.Forms.ComboBox();
            this.lblIncomingTotalMessage = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUnSubscribe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "QoS Level :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Topic:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Incoming Messages:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "İncoming Total Message Count = ";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(257, 398);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(101, 54);
            this.btnSubscribe.TabIndex = 7;
            this.btnSubscribe.Text = "SUBSCRİBE";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.BtnSubscribe_Click);
            // 
            // txtGetIpAddress
            // 
            this.txtGetIpAddress.Location = new System.Drawing.Point(78, 27);
            this.txtGetIpAddress.Name = "txtGetIpAddress";
            this.txtGetIpAddress.Size = new System.Drawing.Size(100, 20);
            this.txtGetIpAddress.TabIndex = 8;
            this.txtGetIpAddress.Text = "localhost";
            // 
            // txtGetTopic
            // 
            this.txtGetTopic.Location = new System.Drawing.Point(18, 206);
            this.txtGetTopic.Name = "txtGetTopic";
            this.txtGetTopic.Size = new System.Drawing.Size(178, 127);
            this.txtGetTopic.TabIndex = 9;
            this.txtGetTopic.Text = "hello/world";
            // 
            // txtGetPortNumber
            // 
            this.txtGetPortNumber.Location = new System.Drawing.Point(94, 61);
            this.txtGetPortNumber.Name = "txtGetPortNumber";
            this.txtGetPortNumber.Size = new System.Drawing.Size(68, 20);
            this.txtGetPortNumber.TabIndex = 10;
            this.txtGetPortNumber.Text = "1883";
            // 
            // richTbIncomingMessages
            // 
            this.richTbIncomingMessages.Location = new System.Drawing.Point(227, 80);
            this.richTbIncomingMessages.Name = "richTbIncomingMessages";
            this.richTbIncomingMessages.Size = new System.Drawing.Size(250, 268);
            this.richTbIncomingMessages.TabIndex = 11;
            this.richTbIncomingMessages.Text = "";
            // 
            // cmBoxGetQosLevel
            // 
            this.cmBoxGetQosLevel.FormattingEnabled = true;
            this.cmBoxGetQosLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmBoxGetQosLevel.Location = new System.Drawing.Point(361, 370);
            this.cmBoxGetQosLevel.Name = "cmBoxGetQosLevel";
            this.cmBoxGetQosLevel.Size = new System.Drawing.Size(49, 21);
            this.cmBoxGetQosLevel.TabIndex = 12;
            // 
            // lblIncomingTotalMessage
            // 
            this.lblIncomingTotalMessage.AutoSize = true;
            this.lblIncomingTotalMessage.Location = new System.Drawing.Point(447, 9);
            this.lblIncomingTotalMessage.Name = "lblIncomingTotalMessage";
            this.lblIncomingTotalMessage.Size = new System.Drawing.Size(13, 13);
            this.lblIncomingTotalMessage.TabIndex = 14;
            this.lblIncomingTotalMessage.Text = "0";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(31, 113);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(109, 33);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(402, 52);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnUnSubscribe
            // 
            this.btnUnSubscribe.Location = new System.Drawing.Point(376, 397);
            this.btnUnSubscribe.Name = "btnUnSubscribe";
            this.btnUnSubscribe.Size = new System.Drawing.Size(101, 54);
            this.btnUnSubscribe.TabIndex = 17;
            this.btnUnSubscribe.Text = "UNSUBSCRİBE";
            this.btnUnSubscribe.UseVisualStyleBackColor = true;
            this.btnUnSubscribe.Click += new System.EventHandler(this.BtnUnSubscribe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 481);
            this.Controls.Add(this.btnUnSubscribe);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblIncomingTotalMessage);
            this.Controls.Add(this.cmBoxGetQosLevel);
            this.Controls.Add(this.richTbIncomingMessages);
            this.Controls.Add(this.txtGetPortNumber);
            this.Controls.Add(this.txtGetTopic);
            this.Controls.Add(this.txtGetIpAddress);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.TextBox txtGetIpAddress;
        private System.Windows.Forms.RichTextBox txtGetTopic;
        private System.Windows.Forms.TextBox txtGetPortNumber;
        private System.Windows.Forms.RichTextBox richTbIncomingMessages;
        private System.Windows.Forms.ComboBox cmBoxGetQosLevel;
        private System.Windows.Forms.Label lblIncomingTotalMessage;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUnSubscribe;
    }
}

