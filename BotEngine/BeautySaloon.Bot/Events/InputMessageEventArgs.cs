using BeautySalon.BotEngine.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySaloon.Bot.Triggers
{
    public class InputMessageEventArgs : IEventArguments
    {
        public int UserId { get; set; }
        public string Message { get; set; }
    }
}
