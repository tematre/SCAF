using BeautySalon.BotEngine.Common;
using BeautySalon.BotEngine.Core;
using BeautySalon.BotEngine.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Commands
{
    public class CommandsStore<CommandDefinition> : ObjectsStoreBase<CommandDefinition>, ICommandsStore<CommandDefinition> where CommandDefinition : ICommandDefinition
    {
    }
}
