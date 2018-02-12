using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Queries
{
    public abstract class QueryDefinitionBase<QueryHandler, QueryParameters, QueryResult> : IQueryDefinition
        where QueryHandler : IQueryHandler
        where QueryParameters : IQueryParameters
        where QueryResult : IQueryResult
    {
        public IQueryHandler Handler => throw new NotImplementedException();

        public Type ParametersType => typeof(QueryParameters);

        public Type QueryResultType => typeof(QueryResult);

        public string QueryName => throw new NotImplementedException();
    }
}
