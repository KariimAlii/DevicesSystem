using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.CoreLayer
{
    public class DeviceProperties
    {
        public Category? Category { get; set; }
        public Device? Device { get; set; }
        public Property? Property { get; set; }
        public User? User { get; set; }
        public String PropertyDescription { get; set; } = String.Empty;
    }
}
