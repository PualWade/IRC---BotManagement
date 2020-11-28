using Meebey.SmartIrc4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRC___Bot_management
{
    public class ManagerBotHelp
    {
        public static bool checkCommand(IrcEventArgs e)
        {
            if (e.Data.MessageArray[0] == "MyPassword") return true;
            else return false;
        }
    }
}
