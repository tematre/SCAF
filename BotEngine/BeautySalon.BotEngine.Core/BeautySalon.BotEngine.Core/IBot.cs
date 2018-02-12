using BeautySalon.BotEngine.Core.Events;
using BeautySalon.BotEngine.Core.Lifescicle;
using BeautySalon.BotEngine.Core.Queries;
using System.Collections.Generic;

namespace BeautySalon.BotEngine.Core
{
    public interface IBot : IUniqObject, ILifecicleObject
    {
        IEnumerable<ICommandDefinition> SupportedCommands { get; }

        IEnumerable<IQueryDefinition> SupportedQueries { get;  }
        
        IEnumerable<IEventDefinition> SupportedEvents { get; }
    }
}
