using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Queries
{
    public interface IQueriesDispatcher<QueryDefinition, QueryStorage>
        where QueryDefinition : IQueryDefinition
        where QueryStorage : IQueriesStore<QueryDefinition>
    {
        QueryStorage QueriesStore { get; set; }

        IQueryResult Dispatch(QueryDefinition definition, IQueryParameters args);
    }
}
