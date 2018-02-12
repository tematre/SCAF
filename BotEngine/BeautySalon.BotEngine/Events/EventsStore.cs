using BeautySalon.BotEngine.Common;
using BeautySalon.BotEngine.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Events
{
    public abstract class EventsStore<EventDefinition> : ObjectsStoreBase<EventDefinition>, IEventsStore<EventDefinition> where EventDefinition : IEventDefinition
    {
    }
}
