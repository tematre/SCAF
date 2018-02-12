using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Queries.Bots
{
    public interface IBotQueriesDispatcher : IQueriesDispatcher<IBotQueryDefinition, IQueriesStore<IBotQueryDefinition>>
    {
    }
}
