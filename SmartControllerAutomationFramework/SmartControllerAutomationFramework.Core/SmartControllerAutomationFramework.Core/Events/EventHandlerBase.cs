using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events
{
    public abstract class EventHandlerBase<EventArguments> : IEventHandler where EventArguments : IEventArguments
    {
        public void Handle(IEventArguments args)
        {
            Handle((EventArguments)args);
        }

        public abstract void Handle(EventArguments args);
    }
}
