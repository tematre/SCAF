using BeautySalon.BotEngine.Core.Events.Bots;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Events.Bots
{
    public class BotsEventsDispatcher : EventsDispatcherBase<IBotEventDefinition>, IBotsEventsDispatcher
    {
    }
}
