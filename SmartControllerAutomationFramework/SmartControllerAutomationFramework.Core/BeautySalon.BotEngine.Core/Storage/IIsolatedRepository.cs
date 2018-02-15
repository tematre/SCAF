using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core
{
    public interface IIsolatedRepository
    {
        string Token { get; set; }

        void SaveState<T>(string key, T data);

        T RestoreState<T>(string key);
    }
}
