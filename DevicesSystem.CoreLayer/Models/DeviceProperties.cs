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
        #region Foreign Keys
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        [ForeignKey("Device")]
        public int Device_Id { get; set; }
        [ForeignKey("Property")]
        public int Property_Id { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        #endregion

        #region Propagation Properties
        public Category? Category { get; set; }
        public Device? Device { get; set; }
        public Property? Property { get; set; }
        public User? User { get; set; } 
        #endregion
        public String PropertyDescription { get; set; } = String.Empty;
        public ICollection<DeviceProperties> DeviceProperties { get; set; } = new HashSet<DeviceProperties>();
    }
}
