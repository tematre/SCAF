using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Commands
{
    public interface ICommandHandler 
    {
        IUniqObject Owner { get; }

        void Handle(ICommandParameters parameters);
    }
}
