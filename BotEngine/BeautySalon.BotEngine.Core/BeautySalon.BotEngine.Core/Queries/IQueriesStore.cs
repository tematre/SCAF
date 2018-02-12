using BeautySalon.BotEngine.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Queries
{
    public interface IQueriesStore<QueryDefinition> : IObjectsStore<QueryDefinition> where QueryDefinition : IQueryDefinition
    {
    }
}
