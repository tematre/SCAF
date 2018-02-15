using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events.Bots
{
    public interface IBotsEventsDispatcher : IEventsDispatcher<IBotEventDefinition, IEventsStore<IBotEventDefinition>>
    {
    }
}
