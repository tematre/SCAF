using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core
{
    public interface IIsolatedRepositoryProvider
    {
        IIsolatedRepository GetStorage(string token);
    }
}
