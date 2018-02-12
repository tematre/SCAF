using BeautySalon.BotEngine.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events
{
    public interface IEventsStore<EventDefinition> : IObjectsStore<EventDefinition> where EventDefinition : IEventDefinition
    {
    }
}
