using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events
{
    public interface IEventRisingQueue<EventDefinition>  where EventDefinition : IEventDefinition
    {
        void Enqueue(EventDefinition eventDefinition, IEventArguments args);

        KeyValuePair<EventDefinition, IEventArguments> Dequeue();

        bool IsEmpty();
    }
}
