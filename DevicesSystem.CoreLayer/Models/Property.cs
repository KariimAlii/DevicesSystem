using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.CoreLayer
{
    public class Property
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public ICollection<DeviceProperties> DeviceProperties { get; set; } = new HashSet<DeviceProperties>();
    }
}
