using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Queries
{
    public interface IQueryDefinition
    {
        IQueryHandler Handler { get; }

        Type ParametersType { get; }

        Type QueryResultType { get; }

        string QueryName { get; }
    }
}
