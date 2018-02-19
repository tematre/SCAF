using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Queries.Bots
{
    public interface IControllerQueryDefinition : IQueryDefinition
    {
        string Token { get; }
    }
}
