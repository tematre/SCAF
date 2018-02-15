using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.BackgroungTasks
{
    public interface IJobPool
    {
        void RegisterJob<T>() where T : IJob;

        void UnregisterJob<T>() where T : IJob;

        void Start();

        void Stop();
    }
}