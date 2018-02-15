using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Queries
{
    public interface ISystemQueriesDispatcher : IQueriesDispatcher<IQueryDefinition, IQueriesStore<IQueryDefinition>> 
    {
    }
}
