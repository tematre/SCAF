using BeautySalon.BotEngine.Core.BackgroungTasks;
using BeautySalon.BotEngine.Core.Events.Bots;

namespace BeautySalon.BotEngine.BackgroungTasks
{
    public class EventNotificationJob : IJob
    {

        private IControllersEventsDispatcher _botsEventsDispatcher;
        private IControllerEventRisingQueue _eventRisingQueue;

        public void Run()
        {
            while(! _eventRisingQueue.IsEmpty())
            {
                var next = _eventRisingQueue.Dequeue();

                _botsEventsDispatcher.Dispatch(next.Key, next.Value);
            }
        }
    }
}
