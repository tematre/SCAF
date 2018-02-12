using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Commands
{
    public interface ICommandsDispatcher<CommandDefinition, CommandsStorage> 
        where CommandDefinition : ICommandDefinition
        where CommandsStorage : ICommandsStore<CommandDefinition>
    {
        CommandsStorage CommandsStore { get; }

        void Dispatch(CommandDefinition definition, ICommandParameters parameters);
    }
}