using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Commands
{
    public abstract class CommandHandlerBase<CommandParameters> : ICommandHandler where CommandParameters : ICommandParameters
    {
        public void Handle(ICommandParameters parameters)
        {
            Handle((CommandParameters)parameters);
        }
        
        public abstract void Handle(CommandParameters parameters);
    }
}
