﻿namespace IRC___Bot_management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.outText = new System.Windows.Forms.TextBox();
            this.ipIn = new System.Windows.Forms.TextBox();
            this.channelIn = new System.Windows.Forms.TextBox();
            this.usernameIn = new System.Windows.Forms.TextBox();
            this.realnameIn = new System.Windows.Forms.TextBox();
            this.msgSend = new System.Windows.Forms.TextBox();
            this.BConnect = new System.Windows.Forms.Button();
            this.BSend = new System.Windows.Forms.Button();
            this.msgBotSend = new System.Windows.Forms.TextBox();
            this.BSendBot = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // outText
            // 
            this.outText.Location = new System.Drawing.Point(153, 12);
            this.outText.Multiline = true;
            this.outText.Name = "outText";
            this.outText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outText.Size = new System.Drawing.Size(819, 463);
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
            this.usernameIn.Text = "Agrinutel";
            // 
            // realnameIn
            // 
            this.realnameIn.Location = new System.Drawing.Point(12, 141);
            this.realnameIn.Name = "realnameIn";
            this.realnameIn.Size = new System.Drawing.Size(135, 20);
            this.realnameIn.TabIndex = 4;
            this.realnameIn.Text = "Paul";
            // 
            // msgSend
            // 
            this.msgSend.Location = new System.Drawing.Point(153, 481);
            this.msgSend.Multiline = true;
            this.msgSend.Name = "msgSend";
            this.msgSend.Size = new System.Drawing.Size(738, 68);
            this.msgSend.TabIndex = 5;
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
            this.BSend.Location = new System.Drawing.Point(897, 481);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(75, 69);
            this.BSend.TabIndex = 7;
            this.BSend.Text = "Send";
            this.BSend.UseVisualStyleBackColor = true;
            this.BSend.Click += new System.EventHandler(this.BSend_Click);
            // 
            // msgBotSend
            // 
            this.msgBotSend.Location = new System.Drawing.Point(153, 558);
            this.msgBotSend.Name = "msgBotSend";
            this.msgBotSend.Size = new System.Drawing.Size(738, 20);
            this.msgBotSend.TabIndex = 8;
            this.msgBotSend.Text = "ping";
            this.msgBotSend.TextChanged += new System.EventHandler(this.textBotSend_TextChanged);
            // 
            // BSendBot
            // 
            this.BSendBot.Location = new System.Drawing.Point(897, 556);
            this.BSendBot.Name = "BSendBot";
            this.BSendBot.Size = new System.Drawing.Size(75, 23);
            this.BSendBot.TabIndex = 9;
            this.BSendBot.Text = "Send Bot";
            this.BSendBot.UseVisualStyleBackColor = true;
            this.BSendBot.Click += new System.EventHandler(this.BSendBot_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Agrinutel",
            "Selpock",
            "Nidetom",
            "Bidemsiq",
            "Hotseck",
            "Sharvolq",
            "Melotubs",
            "Madesolch",
            "Lindibitex",
            "Salomonixeu"});
            this.comboBox1.Location = new System.Drawing.Point(12, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Agrinutel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(978, 11);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(607, 464);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 591);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BSendBot);
            this.Controls.Add(this.msgBotSend);
            this.Controls.Add(this.BSend);
            this.Controls.Add(this.BConnect);
            this.Controls.Add(this.msgSend);
            this.Controls.Add(this.realnameIn);
            this.Controls.Add(this.usernameIn);
            this.Controls.Add(this.channelIn);
            this.Controls.Add(this.ipIn);
            this.Controls.Add(this.outText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outText;
        private System.Windows.Forms.TextBox ipIn;
        private System.Windows.Forms.TextBox channelIn;
        private System.Windows.Forms.TextBox usernameIn;
        private System.Windows.Forms.TextBox realnameIn;
        private System.Windows.Forms.TextBox msgSend;
        private System.Windows.Forms.Button BConnect;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.TextBox msgBotSend;
        private System.Windows.Forms.Button BSendBot;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

