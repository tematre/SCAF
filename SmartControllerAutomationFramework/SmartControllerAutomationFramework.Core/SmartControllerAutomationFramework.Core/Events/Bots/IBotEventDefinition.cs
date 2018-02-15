using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Events.Bots
{
    public interface IBotEventDefinition : IEventDefinition
    {
        string Token { get; }
    }
}
