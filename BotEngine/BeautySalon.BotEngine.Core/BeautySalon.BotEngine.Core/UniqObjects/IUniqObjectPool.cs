using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core
{
    public interface IUniqObjectPool
    {
        void SaveObjects();

        void Restore();

        void Add(IUniqObject obj);

        void Remove(IUniqObject obj);

        IEnumerable<IUniqObject> GetObjects();

        void Attach(IUniqObject obj);
    }
}
