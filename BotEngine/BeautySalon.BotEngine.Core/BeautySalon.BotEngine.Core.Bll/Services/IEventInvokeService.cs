using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Bll.Services
{
    public interface IEventInvokeService
    {
        void Notify(string eventName, string eventParameters);
    }
}
