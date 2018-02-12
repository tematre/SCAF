using BeautySalon.BotEngine.Core;
using System;
using BeautySalon.BotEngine.Core.Events;
using BeautySalon.BotEngine.Core.Queries;
using BeautySalon.BotEngine.Core.Settings;
using System.Collections.Generic;
using System.Linq;
using BeautySalon.BotEngine.Core.Events.RelayEvent;
using BeautySaloon.Bot.Triggers;

namespace BeautySaloon.Bot
{
    public class BeautyBot : IBot
    {
        public IEnumerable<ICommandDefinition> SupportedCommands => Enumerable.Empty<ICommandDefinition>();

        public IEnumerable<IQueryDefinition> SupportedQueries => Enumerable.Empty<IQueryDefinition>();

        public IEnumerable<IEventDefinition> SupportedEvents
        {
            get
            {
                yield return new RelayEventDefinition<InputMessageTrigger, InputMessageEventArgs>("inputMessageRecieved", x => HandleInputMessage(x));
            }
        }

        public IBotSettings Settings => null;

        public string Token { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void SaveState()
        {
            throw new NotImplementedException();
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }

        private void HandleInputMessage(InputMessageEventArgs inputMessageEventArgs)
        {
        }
    }
}
