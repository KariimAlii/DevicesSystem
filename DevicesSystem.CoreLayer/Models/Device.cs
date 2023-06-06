using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.CoreLayer
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateOnly AcquisitionDate {get;set;}
        public string Memo { get; set; }
        public ICollection<DeviceProperties> DeviceProperties { get; set; } = new HashSet<DeviceProperties>();
    }
}
