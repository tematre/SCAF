using BeautySalon.BotEngine.Core;
using BeautySalon.BotEngine.Core.Lifescicle;
using BeautySalon.BotEngine.Core.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Queries
{
    public class QueriesDispatcher<QueryDefinition> : IQueriesDispatcher<QueryDefinition, IQueriesStore<QueryDefinition>>
        where QueryDefinition : IQueryDefinition
    {
        public IQueriesStore<QueryDefinition> QueriesStore { get; set; }

        public IQueryResult Dispatch(QueryDefinition definition, IQueryParameters args)
        {
            throw new NotImplementedException();
        }
    }
}
