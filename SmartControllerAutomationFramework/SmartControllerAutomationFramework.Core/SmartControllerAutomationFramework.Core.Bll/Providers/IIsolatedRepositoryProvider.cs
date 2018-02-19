using BeautySalon.BotEngine.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartControllerAutomationFramework.Core.Bll.Providers
{
    public interface IIsolatedRepositoryProvider
    {
        IIsolatedRepository GetStorage(string token);
    }
}
