using DevicesSystem.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesSystem.DataAccessLayer
{
    public class UserRepo : GenericRepository<User> , IUserRepo
    {
        private readonly AppDbContext context;

        public UserRepo(AppDbContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
