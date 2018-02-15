using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events
{
    public interface IEventTrigger
    {
        IUniqObject Owner { get; }

        bool Check(out IEventArguments arguments);
    }
}
