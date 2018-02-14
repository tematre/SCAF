using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Dal.Entities
{
    public class BotSettingsEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}
