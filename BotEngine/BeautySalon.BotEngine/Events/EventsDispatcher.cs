using BeautySalon.BotEngine.Core.Commands;
using BeautySalon.BotEngine.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Events
{
    public abstract class EventsDispatcherBase<EventDefinition> : IEventsDispatcher<EventDefinition, IEventsStore<EventDefinition>>
        where EventDefinition : IEventDefinition
    {
        public IEventsStore<EventDefinition> EventsStore { get; set; }

        public void Dispatch(EventDefinition definition, IEventArguments args)
        {
            throw new NotImplementedException();
        }
    }
}
