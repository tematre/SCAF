using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Settings
{
    public interface IBotSettings : ISettings
    {
        string BotToken { get; }
    }
}
