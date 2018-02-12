using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core
{
    public interface IUniqObject
    {
        string Token { get; }

        void Initialize();

        void SaveState();

        void Terminate();
    }
}
