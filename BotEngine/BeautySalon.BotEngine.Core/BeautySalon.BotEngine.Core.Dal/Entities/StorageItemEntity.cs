﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BotEngine.Core.Dal.Entities
{
    public class StorageItemEntity
    {
        public Guid ObjectId { get; set; }

        public string Name { get; set; }

        public String Value { get; set; }
    }
}
