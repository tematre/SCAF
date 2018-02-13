using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Settings
{
    public interface IBotSettingsProvider
    {
        T GetSettings<T>(string token) where T : IBotSettings;
    }
}
