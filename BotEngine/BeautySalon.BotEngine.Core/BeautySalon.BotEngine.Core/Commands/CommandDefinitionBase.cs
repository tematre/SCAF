using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Commands
{
    public abstract class CommandDefinitionBase<HandlerType, ParamsType> : ICommandDefinition
                                                                    where HandlerType : CommandHandlerBase<ParamsType>
                                                                    where ParamsType : ICommandParameters
    {
        public abstract ICommandHandler Handler { get; }

        public Type ParametersType => typeof(ParamsType);

        public abstract string CommandName { get; }
    }
}
