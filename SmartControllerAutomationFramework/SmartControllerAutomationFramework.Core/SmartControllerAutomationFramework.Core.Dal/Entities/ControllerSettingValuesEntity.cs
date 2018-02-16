using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Dal.Entities
{
    public class ControllerSettingValuesEntity
    {
        public Guid ControllerId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }
    }
}
