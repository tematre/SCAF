using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Lifescicle
{
    public interface ILifecicleObject
    {
        void OnStart();

        void OnStop();

        void OnPause();

        void OnResume();
    }
}
