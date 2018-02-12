using BeautySalon.BotEngine.Common;
using BeautySalon.BotEngine.Core.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Queries
{
    public class QueriesStore<QueryDefinition> : ObjectsStoreBase<QueryDefinition>, IQueriesStore<QueryDefinition> where QueryDefinition : IQueryDefinition
    {
    }
}
