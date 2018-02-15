using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events
{
    public interface IEventHandler
    {
        void Handle(IEventArguments args);
    }
}
