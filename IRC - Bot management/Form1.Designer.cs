namespace IRC___Bot_management
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.outText = new System.Windows.Forms.TextBox();
            this.ipIn = new System.Windows.Forms.TextBox();
            this.channelIn = new System.Windows.Forms.TextBox();
            this.usernameIn = new System.Windows.Forms.TextBox();
            this.realnameIn = new System.Windows.Forms.TextBox();
            this.textSend = new System.Windows.Forms.TextBox();
            this.BConnect = new System.Windows.Forms.Button();
            this.BSend = new System.Windows.Forms.Button();
            this.textBotSend = new System.Windows.Forms.TextBox();
            this.BSendBot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outText
            // 
            this.outText.Location = new System.Drawing.Point(153, 12);
            this.outText.Multiline = true;
            this.outText.Name = "outText";
            this.outText.Size = new System.Drawing.Size(424, 392);
            this.outText.TabIndex = 0;
            // 
            // ipIn
            // 
            this.ipIn.Location = new System.Drawing.Point(12, 29);
            this.ipIn.Name = "ipIn";
            this.ipIn.Size = new System.Drawing.Size(135, 20);
            this.ipIn.TabIndex = 1;
            this.ipIn.Text = "irc.root-me.org";
            // 
            // channelIn
            // 
            this.channelIn.Location = new System.Drawing.Point(12, 66);
            this.channelIn.Name = "channelIn";
            this.channelIn.Size = new System.Drawing.Size(135, 20);
            this.channelIn.TabIndex = 2;
            this.channelIn.Text = "#root-me_challenge";
            // 
            // usernameIn
            // 
            this.usernameIn.Location = new System.Drawing.Point(12, 104);
            this.usernameIn.Name = "usernameIn";
            this.usernameIn.Size = new System.Drawing.Size(135, 20);
            this.usernameIn.TabIndex = 3;
            this.usernameIn.Text = "Paul_Wade";
            // 
            // realnameIn
            // 
            this.realnameIn.Location = new System.Drawing.Point(12, 141);
            this.realnameIn.Name = "realnameIn";
            this.realnameIn.Size = new System.Drawing.Size(135, 20);
            this.realnameIn.TabIndex = 4;
            this.realnameIn.Text = "Paul";
            // 
            // textSend
            // 
            this.textSend.Location = new System.Drawing.Point(153, 420);
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(343, 20);
            this.textSend.TabIndex = 5;
            // 
            // BConnect
            // 
            this.BConnect.Location = new System.Drawing.Point(12, 181);
            this.BConnect.Name = "BConnect";
            this.BConnect.Size = new System.Drawing.Size(75, 23);
            this.BConnect.TabIndex = 6;
            this.BConnect.Text = "Connect";
            this.BConnect.UseVisualStyleBackColor = true;
            this.BConnect.Click += new System.EventHandler(this.BConnect_Click);
            // 
            // BSend
            // 
            this.BSend.Location = new System.Drawing.Point(502, 418);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(75, 23);
            this.BSend.TabIndex = 7;
            this.BSend.Text = "Send";
            this.BSend.UseVisualStyleBackColor = true;
            this.BSend.Click += new System.EventHandler(this.BSend_Click);
            // 
            // textBotSend
            // 
            this.textBotSend.Location = new System.Drawing.Point(153, 458);
            this.textBotSend.Name = "textBotSend";
            this.textBotSend.Size = new System.Drawing.Size(343, 20);
            this.textBotSend.TabIndex = 8;
            this.textBotSend.Text = "ping";
            // 
            // BSendBot
            // 
            this.BSendBot.Location = new System.Drawing.Point(502, 456);
            this.BSendBot.Name = "BSendBot";
            this.BSendBot.Size = new System.Drawing.Size(75, 23);
            this.BSendBot.TabIndex = 9;
            this.BSendBot.Text = "Send Bot";
            this.BSendBot.UseVisualStyleBackColor = true;
            this.BSendBot.Click += new System.EventHandler(this.BSendBot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 494);
            this.Controls.Add(this.BSendBot);
            this.Controls.Add(this.textBotSend);
            this.Controls.Add(this.BSend);
            this.Controls.Add(this.BConnect);
            this.Controls.Add(this.textSend);
            this.Controls.Add(this.realnameIn);
            this.Controls.Add(this.usernameIn);
            this.Controls.Add(this.channelIn);
            this.Controls.Add(this.ipIn);
            this.Controls.Add(this.outText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outText;
        private System.Windows.Forms.TextBox ipIn;
        private System.Windows.Forms.TextBox channelIn;
        private System.Windows.Forms.TextBox usernameIn;
        private System.Windows.Forms.TextBox realnameIn;
        private System.Windows.Forms.TextBox textSend;
        private System.Windows.Forms.Button BConnect;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.TextBox textBotSend;
        private System.Windows.Forms.Button BSendBot;
    }
}

