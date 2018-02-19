using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Commands
{
    public abstract class ControllerCommandDefinitionBase<HandlerType, ParamsType> : CommandDefinitionBase<HandlerType, ParamsType>, IControllerCommandDefinition
        where HandlerType : CommandHandlerBase<ParamsType>
        where ParamsType : ICommandParameters
    {
        public string Token { get; set; }
    }
}
