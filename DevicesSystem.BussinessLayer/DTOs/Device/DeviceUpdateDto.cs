﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.BussinessLayer
{
    public class DeviceUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateOnly AcquisitionDate { get; set; }
        public string Memo { get; set; }
    }
}
