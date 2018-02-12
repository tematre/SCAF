using BeautySalon.BotEngine.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Commands
{
    public interface ICommandsStore<CommandDefinition> : IObjectsStore<CommandDefinition> where CommandDefinition : ICommandDefinition
    {
    }
}
