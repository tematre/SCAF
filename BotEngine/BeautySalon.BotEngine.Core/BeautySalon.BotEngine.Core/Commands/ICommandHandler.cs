using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Commands
{
    public interface ICommandHandler 
    {
        void Handle(ICommandParameters parameters);
    }
}
