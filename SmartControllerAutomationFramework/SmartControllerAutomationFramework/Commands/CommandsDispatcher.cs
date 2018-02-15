using BeautySalon.BotEngine.Core;
using BeautySalon.BotEngine.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Commands
{
    public abstract class CommandsDispatcherBase<CommandDefinition> : ICommandsDispatcher<CommandDefinition, ICommandsStore<CommandDefinition>> 
        where CommandDefinition : ICommandDefinition
    {
        public ICommandsStore<CommandDefinition> CommandsStore => throw new NotImplementedException();

        public void Dispatch(CommandDefinition definition, ICommandParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
