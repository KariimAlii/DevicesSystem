using DevicesSystem.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.DataAccessLayer
{
    public class DeviceRepo : GenericRepository<Device> , IDeviceRepo
    {
        private readonly AppDbContext context;

        public DeviceRepo(AppDbContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
