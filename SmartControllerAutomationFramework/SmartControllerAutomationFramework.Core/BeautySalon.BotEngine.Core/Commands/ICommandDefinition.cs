using BeautySalon.BotEngine.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core
{
    public interface ICommandDefinition
    {
        ICommandHandler Handler { get; }

        Type ParametersType { get; }

        string CommandName { get; }
    }
}
