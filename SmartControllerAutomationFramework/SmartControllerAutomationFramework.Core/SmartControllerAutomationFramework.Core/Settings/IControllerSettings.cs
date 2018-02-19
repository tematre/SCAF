using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Settings
{
    public interface IControllerSettings : ISettings
    {
        string Token { get; }
    }
}
