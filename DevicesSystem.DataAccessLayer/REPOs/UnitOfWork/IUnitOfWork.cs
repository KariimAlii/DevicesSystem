using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.DataAccessLayer
{
    public interface IUnitOfWork
    {
        public ICategoryRepo CategoryRepo { get; }
        public IDeviceRepo DeviceRepo { get; }
        public IPropertyRepo PropertyRepo { get; }
        public IUserRepo UserRepo { get; }
        Task<int> SaveChanges();
    }
}
