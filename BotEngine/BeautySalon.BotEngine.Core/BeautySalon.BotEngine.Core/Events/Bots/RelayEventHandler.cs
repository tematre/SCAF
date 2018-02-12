using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events.RelayEvent
{
    public class RelayEventHandler<T> : EventHandlerBase<T> where T : IEventArguments
    {
        private Action<T> _action;

        public RelayEventHandler(Action<T> action)
        {
            _action = action;
        }
        public override void Handle(T parameters)
        {
            _action(parameters);
        }
    }
}
