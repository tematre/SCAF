using BeautySalon.BotEngine.Core.Events.Bots;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events.RelayEvent
{
    public class RelayEventDefinition<EventTrigger, EventArguments> : ControllerEventDefinitionBase<EventTrigger, RelayEventHandler<IEventArguments>, EventArguments> 
        where EventArguments : IEventArguments
        where EventTrigger : IEventTrigger, new()
    {
        private IEventHandler _handler;
        private string _name;
        private EventTrigger _trigger;

        public RelayEventDefinition(string name, Action<EventArguments> action)
        {
            _handler = new RelayEventHandler<EventArguments>(action);
            _name = name;
            _trigger = new EventTrigger();
        }

        public override string Name => _name;

        public override IEventHandler Handler => _handler;

        public override IEventTrigger Trigger => _trigger;
    }
}
