using DevicesSystem.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.DataAccessLayer
{
    public class PropertyRepo : GenericRepository<Property> , IPropertyRepo
    {
        private readonly AppDbContext context;

        public PropertyRepo(AppDbContext _context): base(_context)
        {
            context = _context;
        }
    }
}
