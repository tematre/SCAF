using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events
{
    public interface ISystemEventDispatcher : IEventsDispatcher<IEventDefinition, IEventsStore<IEventDefinition>>
    {
    }
}
