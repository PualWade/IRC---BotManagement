using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Meebey.SmartIrc4net;

namespace IRC___Bot_management
{
    public partial class Form1 : Form
    {
        static string nickBot = "botTest";

        static IrcClient Irc = new IrcClient();
        const int port = 6667;
        delegate void InOutText(IrcEventArgs e);

        public Form1()
        {
            Irc.Encoding = Encoding.UTF8;
            Irc.SendDelay = 200;
            Irc.ActiveChannelSyncing = true;
            Irc.OnRawMessage += Irc_OnRawMessage;
            Irc.OnErrorMessage += Irc_OnErrorMessage;

            InitializeComponent();
        }
        private void Irc_OnErrorMessage(object sender, IrcEventArgs e)
        {
            WriteTextError(e);
        }
        private void Irc_OnRawMessage(object sender, IrcEventArgs e)
        {
            string[] commands = ManagerBotHelp.checkCommand(e);
            if (commands != null) 
            {
                switch (commands[2])
                {
                    case "newBot":

                        break;
                    default:
                        break;
                }
            }
            WriteTextMessage(e);
        }
        
        private void WriteTextError(IrcEventArgs e)
        {
            if (outText.InvokeRequired)
            {
                var d = new InOutText(WriteTextError);
                outText.Invoke(d, new object[] { e });
            }
            else
            {
                outText.AppendText(string.Format("{1}   ERROR: {0}\n", e.Data.Message, DateTime.Now));
            }
        }
        private void WriteTextMessage(IrcEventArgs e)
        {
            if (outText.InvokeRequired)
            {
                var d = new InOutText(WriteTextMessage);
                outText.Invoke(d, new object[] { e });
            }
            else
            {
                outText.AppendText(string.Format("\r\n{2}   {0}: {1}", e.Data.Nick, e.Data.Message, DateTime.Now));
            }
        }
        private async void BConnect_Click(object sender, EventArgs e)
        {
            Irc.Connect(ipIn.Text, port);
            Irc.Login(usernameIn.Text, realnameIn.Text);
            Irc.RfcJoin(channelIn.Text); 
            await Task.Run(() => Irc.Listen());
        }

        private void BSend_Click(object sender, EventArgs e)
        {
            Irc.SendMessage(SendType.Message, channelIn.Text, msgSend.Text);
            outText.AppendText(string.Format("\r\n{2}   {0}: {1}", usernameIn.Text, msgSend.Text, DateTime.Now));
            msgSend.Clear();
        }

        private void BSendBot_Click(object sender, EventArgs e)
        {
            Irc.RfcPrivmsg(nickBot, "myPassword " + msgBotSend.Text); 
            outText.AppendText(string.Format("\r\n{2}   {0}: {1}", usernameIn.Text, msgBotSend.Text, DateTime.Now));
            msgBotSend.Clear();
        }
        private void textBotSend_TextChanged(object sender, EventArgs e)
        { 
        }
    }
}
