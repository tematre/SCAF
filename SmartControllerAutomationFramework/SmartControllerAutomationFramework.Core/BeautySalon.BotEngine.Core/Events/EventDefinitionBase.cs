using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events
{
    public abstract class EventDefinitionBase<EventTrigger, EventHandler, EventArguments> : IEventDefinition
                                                                    where EventTrigger : IEventTrigger
                                                                    where EventHandler : IEventHandler
                                                                    where EventArguments : IEventArguments
    {
        public abstract string Name { get; }

        public abstract IEventHandler Handler { get; }

        public abstract IEventTrigger Trigger { get; }

        public Type ArgumentsType => typeof(EventArguments);

    }
}
