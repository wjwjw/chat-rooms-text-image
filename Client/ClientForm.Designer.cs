namespace Client
{
    partial class ClientForm
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
            this.lbServerState = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.lbServerState);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接状态";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(486, 40);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "连接";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(261, 21);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(165, 21);
            this.tbPort.TabIndex = 4;
            this.tbPort.Text = "12121";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(33, 21);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(186, 21);
            this.tbIP.TabIndex = 3;
            this.tbIP.Text = "192.168.137.175";
            // 
            // lbServerState
            // 
            this.lbServerState.AutoSize = true;
            this.lbServerState.Location = new System.Drawing.Point(9, 63);
            this.lbServerState.Name = "lbServerState";
            this.lbServerState.Size = new System.Drawing.Size(29, 12);
            this.lbServerState.TabIndex = 2;
            this.lbServerState.Text = "状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // rtbAccept
            // 
            this.rtbAccept.Location = new System.Drawing.Point(14, 121);
            this.rtbAccept.Name = "rtbAccept";
            this.rtbAccept.Size = new System.Drawing.Size(585, 130);
            this.rtbAccept.TabIndex = 1;
            this.rtbAccept.Text = "";
            // 
            // rtbSend
            // 
            this.rtbSend.Location = new System.Drawing.Point(13, 257);
            this.rtbSend.Name = "rtbSend";
            this.rtbSend.Size = new System.Drawing.Size(586, 104);
            this.rtbSend.TabIndex = 2;
            this.rtbSend.Text = "";
            this.rtbSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbSend_KeyPress);
            this.rtbSend.TextChanged += new System.EventHandler(this.rtbSend_TextChanged);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 373);
            this.Controls.Add(this.rtbSend);
            this.Controls.Add(this.rtbAccept);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientForm";
            this.ShowIcon = false;
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbServerState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbAccept;
        private System.Windows.Forms.RichTextBox rtbSend;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
    }
}

