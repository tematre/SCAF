using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Lifescicle
{
    public interface ILifescicleObjectsPool
    {
        void Add(ILifecicleObject obj);

        void Remove(ILifecicleObject obj);

        void Start();

        void Stop();

        void Pause();

        void Resule();
    }
}
