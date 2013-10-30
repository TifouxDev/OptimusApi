using Optimus.Common.Dispatching;
using Optimus.Common.Protocol.Messages;
using OptimusApi.Bot;
using OptimusApi.Game.logic.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OptimusApi.Game
{
    public class GameAuthentification
    {
        private BotManager client;

        public GameAuthentification(BotManager bot)
        {
            client = bot;
            bot.Network.Dispatcher.Register(this);
        }

        [MessageHandler(HelloGameMessage.Id)]
        public void HelloGame(HelloGameMessage message)
        {
            client.Network.Send(new AuthenticationTicketMessage("fr", client.Account.Ticket));
        }

        [MessageHandler(AuthenticationTicketAcceptedMessage.Id)]
        public void HandleAuthenticationTicketAcceptedMessage(AuthenticationTicketAcceptedMessage message)
        {
            Thread Thread = new Thread(() => CharacterRequest((int)(new Random().Next(150,500))));
            Thread.Start();
        }

        [MessageHandler(CharactersListMessage.Id)]
        public void HandleSelectionCharacter(CharactersListMessage message)
        {
            var character = message.characters[0];
            CharacterSelectionMessage reponse = new CharacterSelectionMessage(character.id);
            client.Network.Send(reponse);
            new ChatFrame(client);
            Optimus.Common.Log.Logger.GetInstance("PlayerD{Debug}").Debug(string.Format("Character : {0} level : {1} selected.", character.name, character.level));
        }

        private void CharacterRequest(int wait)
        {
            Thread.Sleep(wait);
            client.Network.Send(new CharactersListRequestMessage());
        }

    }
}
