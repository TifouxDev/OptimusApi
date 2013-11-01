using Optimus.Common.Cryptography;
using Optimus.Common.Dispatching;
using Optimus.Common.Protocol.Messages;
using Optimus.Common.Protocol.Types;
using OptimusApi.Bot;
using OptimusApi.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Login
{
    public class AuthentificationMessage
    {
        private BotManager client;
        public AuthentificationMessage(BotManager bot)
        {
            client = bot;
        }

        [MessageHandler(HelloConnectMessage.Id)]
        private void HandleHelloConnectMessage(HelloConnectMessage message)
        {
            sbyte[] encrypted = Array.ConvertAll(RSAManager.Encrypt(message.key, message.salt, client.Account.Name, client.Account.Password), (a) => (sbyte)a);
            VersionExtended DofusVersion = new VersionExtended(2, 16, 0, 78510, 3,0,0,0);
            IdentificationMessage idenficationMessage = new IdentificationMessage(false, false, false, DofusVersion, "fr", encrypted, 0, 0);
            client.Network.Send(idenficationMessage);
        }

        [MessageHandler(ServersListMessage.Id)]
        private void HandleServerSelection(ServersListMessage message)
        {
            var selection = new ServerSelectionMessage((short)(message.servers.FirstOrDefault(server => server.charactersCount > 0 && server.isSelectable == true)).id);
            client.Network.Send(selection);
        }

        [MessageHandler(SelectedServerDataMessage.Id)]
        private void ServerSelected(SelectedServerDataMessage message)
        {
            client.Account.Ticket = message.ticket;
            client.Network.Reconnect(message.address, message.port);
            new GameAuthentification(client);
        }
    }
}
