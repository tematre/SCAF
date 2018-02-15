using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events.Bots
{
    public abstract class BotEventDefinitionBase<EventTrigger, EventHandler, EventArguments> : EventDefinitionBase<EventTrigger, EventHandler, EventArguments>, IBotEventDefinition
                                                                    where EventTrigger : IEventTrigger
                                                                    where EventHandler : IEventHandler
                                                                    where EventArguments : IEventArguments
    {
        public string Token { get; set; }

        public IUniqObject Owner { get; }

    }
}
