using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Bll.Settings
{
    public interface ISettingsValueProvider
    {
        T GetSettingValue<T>(string settingCode);
    }
}
