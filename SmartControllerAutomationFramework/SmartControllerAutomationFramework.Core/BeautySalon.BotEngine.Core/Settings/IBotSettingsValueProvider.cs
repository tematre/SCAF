using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Settings
{
    public interface IBotSettingsValueProvider
    {
        T GetSettingValue<T>(string settingCode, string token);
    }
}
