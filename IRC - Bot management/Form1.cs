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
using MySql.Data.MySqlClient;

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
                switch (commands[0])
                {
                    case "autentification":
                        if (!IsBotExists(commands[3]))
                            EditBot_DB(commands[1], commands[2], commands[3]);
                        else
                            EditBot_DB(commands[1], commands[2], commands[3]);
                        break;
                    case "isOnline":
                        
                        break;
                    default:
                        break;
                }
            }
            WriteTextMessage(e);
        }
        private void EditBot_DB(string name, string realName, string mac)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `bots` WHERE `mac` LIKE @mac", db.GetConnection());
            command1.Parameters.Add("@mac", MySqlDbType.VarChar).Value = mac;

            adapter.SelectCommand = command1;
                adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MySqlCommand command = new MySqlCommand("UPDATE `bots` SET `name`=@name,`realName`=@realName WHERE `mac`=@mac", db.GetConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@realName", MySqlDbType.VarChar).Value = realName;
                command.Parameters.Add("@mac", MySqlDbType.VarChar).Value = mac;


                //db.openConnection();

                //if (command.ExecuteNonQuery() == 1)
                //    MessageBox.Show("Бот изменен");
                //else
                //    MessageBox.Show("Бот не был изменен");

                //db.closeConnection();
            }
            else
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `bots` (`name`, `realName`, `mac`) VALUES (@name, @realname, @mac)", db.GetConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@realName", MySqlDbType.VarChar).Value = realName;
                command.Parameters.Add("@mac", MySqlDbType.VarChar).Value = mac;

                //db.openConnection();

                //if (command.ExecuteNonQuery() == 1)
                //    MessageBox.Show("Бот изменен");
                //else
                //    MessageBox.Show("Бот не был изменен");

                //db.closeConnection();
            }
        }
        private bool IsBotExists(string mac)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `bots` WHERE `mac` = @mac", db.GetConnection());
            command.Parameters.Add("@mac", MySqlDbType.VarChar).Value = mac;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            DB bd= new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `bots`",bd.GetConnection());
            DataTable table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
