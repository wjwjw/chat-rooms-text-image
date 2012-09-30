namespace Server
{
    partial class ServerForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbAccept = new System.Windows.Forms.RichTextBox();
            this.rtbSend = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.tbIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器状态及状态";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(429, 41);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "启动";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click_1);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(249, 17);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(148, 21);
            this.tbPort.TabIndex = 4;
            this.tbPort.Text = "12121";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(30, 17);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(177, 21);
            this.tbIP.TabIndex = 3;
            this.tbIP.Text = "192.168.137.175";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // rtbAccept
            // 
            this.rtbAccept.Location = new System.Drawing.Point(13, 106);
            this.rtbAccept.Name = "rtbAccept";
            this.rtbAccept.Size = new System.Drawing.Size(528, 127);
            this.rtbAccept.TabIndex = 1;
            this.rtbAccept.Text = "";
            // 
            // rtbSend
            // 
            this.rtbSend.Location = new System.Drawing.Point(13, 239);
            this.rtbSend.Name = "rtbSend";
            this.rtbSend.Size = new System.Drawing.Size(528, 123);
            this.rtbSend.TabIndex = 2;
            this.rtbSend.Text = "";
            this.rtbSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbSend_KeyPress);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 374);
            this.Controls.Add(this.rtbSend);
            this.Controls.Add(this.rtbAccept);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServerForm";
            this.ShowIcon = false;
            this.Text = "服务器";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox rtbAccept;
        private System.Windows.Forms.RichTextBox rtbSend;

    }
}

