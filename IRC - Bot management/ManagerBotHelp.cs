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
        public static string[] checkCommand(IrcEventArgs e)
        {

            if (e.Data.MessageArray != null)
            {
                if (e.Data.MessageArray[0] == "myPassword") 
                    return e.Data.MessageArray.Skip(1).ToArray();
                else 
                    return null; 
            }
            return null;
        }
    }
}
