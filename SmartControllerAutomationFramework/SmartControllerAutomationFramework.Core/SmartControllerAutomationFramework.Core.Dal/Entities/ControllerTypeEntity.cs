﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalon.BotEngine.Core.Dal.Entities
{
    public class ControllerTypeEntity
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        public string SettingsType { get; set; }
    }
}
