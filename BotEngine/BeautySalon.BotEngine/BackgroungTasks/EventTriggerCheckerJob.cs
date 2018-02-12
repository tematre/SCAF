using BeautySalon.BotEngine.Core.BackgroungTasks;
using BeautySalon.BotEngine.Core.Events;
using BeautySalon.BotEngine.Core.Events.Bots;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Bll.BackgroungTasks
{
    public class EventTriggerCheckerJob : IJob
    {
        public IBotsEventsDispatcher _botsEventsDispatcher;
        private IBotEventRisingQueue _eventRisingQueue;

        public void Run()
        {
            var events = _botsEventsDispatcher.EventsStore.Events;

            foreach (var next in events)
            {
                IEventArguments args = null;

                var isTrigered = next.Trigger.Check(out args);

                if (isTrigered)
                {
                    _eventRisingQueue.Enqueue(next, args);
                }
            }
        }
    }
}
