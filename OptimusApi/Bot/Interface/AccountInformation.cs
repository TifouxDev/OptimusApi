using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Bot.Account
{
    public class AccountInformation
    {
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Ticket { get; set; }

        public AccountInformation(string accountName, string accountPassword)
        {
            Name = accountName;
            Password = accountPassword;
        }
    }
}
