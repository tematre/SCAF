using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Commands
{
    public class RelayCommandDefinition<ParamsType> : BotCommandDefinitionBase<RelayCommandHandler<ParamsType>, ParamsType> 
                                                                    where ParamsType : ICommandParameters
    {
        private ICommandHandler _handler;
        private string _name;

        public RelayCommandDefinition(string name, Action<ParamsType> action)
        {
            _handler = new RelayCommandHandler<ParamsType>(action);
            _name = name;
        }

        public override ICommandHandler Handler => _handler;

        public override string CommandName => _name;
    }
}
