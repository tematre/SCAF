using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events
{
    public interface IEventDefinition
    {
        string Name { get; }

        Type ArgumentsType { get; }

        IEventHandler Handler { get; }

        IEventTrigger Trigger { get; }
    }
}
