using Optimus.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Bot.Interface.Tchat
{
    public interface IMessenger
    {
        string Author
        {
            get;
        }

        string Message
        {
            get;
        }

        ChannelTchatEnum Channel
        {
            get;
        }
    }
}
