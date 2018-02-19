using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events.Bots
{
    public interface IControllersEventsDispatcher : IEventsDispatcher<IControllerEventDefinition, IEventsStore<IControllerEventDefinition>>
    {
    }
}
