using BeautySalon.BotEngine.Core.Commands;
using BeautySalon.BotEngine.Core.Events;

namespace BeautySalon.BotEngine.Core
{
    public interface IBotEngine
    {
        void Initialize(IBotManager botManager);

        void Start();

        void Stop();
    }
}
