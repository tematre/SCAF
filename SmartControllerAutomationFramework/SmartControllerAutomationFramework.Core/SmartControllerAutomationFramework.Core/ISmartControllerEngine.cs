using BeautySalon.BotEngine.Core.Commands;
using BeautySalon.BotEngine.Core.Events;

namespace BeautySalon.BotEngine.Core
{
    public interface ISmartControllerEngine
    {
        void Initialize(ISmartControllerManager botManager);

        void Start();

        void Stop();
    }
}
