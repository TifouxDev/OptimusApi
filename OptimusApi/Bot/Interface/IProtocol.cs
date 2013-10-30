using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Bot.Interface
{
    public interface IProtocol
    {
        BotManager client { set; get; }
        void Register();
    }
}
