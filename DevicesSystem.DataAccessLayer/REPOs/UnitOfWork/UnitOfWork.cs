
using DevicesSystem.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepo CategoryRepo { get; }
        public IDeviceRepo DeviceRepo {get;}
        public IPropertyRepo PropertyRepo {get;}
        public IUserRepo UserRepo {get;}
        private readonly AppDbContext context;


        public UnitOfWork
        (
            ICategoryRepo _CategoryRepo,
            IDeviceRepo _DeviceRepo,
            IPropertyRepo _PropertyRepo,
            IUserRepo _UserRepo,
            AppDbContext _context
        )
        {
            CategoryRepo = _CategoryRepo;
            DeviceRepo = _DeviceRepo;
            PropertyRepo = _PropertyRepo;
            UserRepo = _UserRepo;
            context = _context;
        }
        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}
