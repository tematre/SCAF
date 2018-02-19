using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Settings
{
    public interface IControllerSettingsProvider
    {
        T GetSettings<T>(string token) where T : IControllerSettings;
    }
}
