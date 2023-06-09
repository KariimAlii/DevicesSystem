﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.CoreLayer
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<DeviceProperties> DeviceProperties { get; set; } = new HashSet<DeviceProperties>();
    }
}
