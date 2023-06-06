using DevicesSystem.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.DataAccessLayer
{
    public class CategoryRepo : GenericRepository<Category> , ICategoryRepo
    {
        private readonly AppDbContext context;

        public CategoryRepo(AppDbContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
