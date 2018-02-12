using BeautySalon.BotEngine.Core.Events;
using BeautySaloon.Bot.Bll.RabbitMq;
using System.Linq;

namespace BeautySaloon.Bot.Triggers
{
    public class InputMessageTrigger : IEventTrigger
    {
        public const int InputMessagesHandlingCount = 100;

        public Bll.RabbitMq.RabbitMqGateway RabbitMqGateway { get; set; }

        public bool Check(out IEventArguments arguments)
        {
            IEventArguments result = null;

            var messages = RabbitMqGateway.Recieve(InputMessagesHandlingCount);

            foreach (var message in messages)
            {
                HandleRabbitMqInput(message);
            }

            arguments = result;

            if (messages.Count() != 0)
            {
                return true;
            }

            return false;
        }

        private void HandleRabbitMqInput(RabbitMqMessage message)
        {
        }
    }
}
