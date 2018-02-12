using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events
{
    public interface IEventsDispatcher<EventDefinition, EventsStorage> 
        where EventDefinition : IEventDefinition
        where EventsStorage : IEventsStore<EventDefinition>
    {
        EventsStorage EventsStore { get; set; }

        void Dispatch(EventDefinition definition, IEventArguments args);
    }
}
