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
        delegate void UpdateTableDelegate(DataTable table);

        static DB db = new DB();
        static MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT  `name`, `realName`, `mac`, `isOnline` FROM `bots` WHERE 1", db.GetConnection());
        static DataTable table = new DataTable();

        static bool flag;

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
                        //Thread.Sleep(90 * 1000);
                        //if
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
                MySqlCommand command = new MySqlCommand("UPDATE `bots` SET `name`=@name,`realName`=@realName,`isOnline`=@isOnline WHERE `mac`=@mac", db.GetConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@realName", MySqlDbType.VarChar).Value = realName;
                command.Parameters.Add("@mac", MySqlDbType.VarChar).Value = mac;
                command.Parameters.Add("@isOnline", MySqlDbType.VarChar).Value = "1";
            }
            else
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `bots` (`name`, `realName`, `mac`, `isOnline`) VALUES (@name, @realname, @mac, @isOnline)", db.GetConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@realName", MySqlDbType.VarChar).Value = realName;
                command.Parameters.Add("@mac", MySqlDbType.VarChar).Value = mac;
                command.Parameters.Add("@isOnline", MySqlDbType.VarChar).Value = "1";
            }
        }
        private void SetIsOnlineBot_DB(string mac, string isOnline)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `bots` SET `isOnline`=@isOnline WHERE `mac`=@mac", db.GetConnection());

            command.Parameters.Add("@mac", MySqlDbType.VarChar).Value = mac;
            command.Parameters.Add("@isOnline", MySqlDbType.VarChar).Value = isOnline;
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
        private void UpdateTable(DataTable table)
        {
            if (dataGridView1.InvokeRequired)
            {
                var d = new UpdateTableDelegate(UpdateTable);
                dataGridView1.Invoke(d, new object[] { table });
            }
            else
            {
                // Отображение БД
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                // Снять выделения строк
                dataGridView1.CurrentCell = null;
            }
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
        
        private async void Form1_Load(object sender, EventArgs e)
        {
            // Обновление таблицы каждые 5 секунд
            await Task.Run(() =>
            {
                while (true)
                {
                    // Отображение БД
                    UpdateTable(table);
                    Thread.Sleep(5 * 1000);
                }
            });
            // Запись ботов которые в сети
            await Task.Run(() =>
            {
                bool localFlag = flag;
                while (true)
                {
                    Thread.Sleep(60 * 1000);
                    //
                    if (flag == localFlag)
                    {

                    }
                }
            });
            // Не сортировать столбцы
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                //dataGridView1.Rows[2].Cells[3].Value = (bool)false;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (MouseButtons != MouseButtons.None)
                ((DataGridView)sender).CurrentCell = null;
        }
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
        }
    }
}
