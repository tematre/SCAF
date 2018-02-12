using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Queries
{
    public abstract class QueryHandlerBase<QueryParameters, QueryResult> : IQueryHandler
        where QueryParameters : IQueryParameters
        where QueryResult : IQueryResult
    {
        public IQueryResult Handle(IQueryParameters parameters)
        {
            var result = Handle((QueryParameters)parameters);

            return result;
        }

        public abstract QueryResult Handle(QueryParameters parameters);
    }
}
