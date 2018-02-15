using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Bll.Services
{
    public interface IBotСontrolService
    {
        void ExecuteCommand(string token, string commandName, string parameters);

        void ExecuteQuery(string token, string queryName, string parameters);

        void NotifyOfEvent(string token, string eventName, string eventArgs);
    }
}
