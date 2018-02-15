using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Commands
{
    public class RelayCommandHandler<T> : CommandHandlerBase<T> where T : ICommandParameters
    {
        private Action<T>  _action;

        public RelayCommandHandler(Action<T> action)
        {
            _action = action;
        }

        public override void Handle(T parameters)
        {
            _action(parameters);
        }
    }
}
