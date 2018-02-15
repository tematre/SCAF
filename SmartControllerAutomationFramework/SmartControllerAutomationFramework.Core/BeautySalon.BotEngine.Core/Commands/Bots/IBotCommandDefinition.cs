using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Commands
{
    public interface IBotCommandDefinition : ICommandDefinition
    {
        string Token { get; }
    }
}
