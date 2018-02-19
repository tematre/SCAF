using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Queries.Bots
{
    public interface IControllerQueriesDispatcher : IQueriesDispatcher<IControllerQueryDefinition, IQueriesStore<IControllerQueryDefinition>>
    {
    }
}
