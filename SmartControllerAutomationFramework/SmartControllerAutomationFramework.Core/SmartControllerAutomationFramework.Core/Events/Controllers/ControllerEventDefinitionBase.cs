using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events.Bots
{
    public abstract class ControllerEventDefinitionBase<EventTrigger, EventHandler, EventArguments> : EventDefinitionBase<EventTrigger, EventHandler, EventArguments>, IControllerEventDefinition
                                                                    where EventTrigger : IEventTrigger
                                                                    where EventHandler : IEventHandler
                                                                    where EventArguments : IEventArguments
    {
        public string Token { get; set; }

        public IUniqObject Owner { get; }

    }
}
