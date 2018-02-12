using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Common
{
    public interface IObjectsStore<T>
    {
        void RegisterCommand(T obj);

        void Unregister(T obj);

        IEnumerable<T> Objects { get; }
    }
}
