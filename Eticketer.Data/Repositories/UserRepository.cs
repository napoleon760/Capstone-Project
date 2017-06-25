using Eticketer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticketer.Data.Repositories
{
    public class UserRepository
    {
        private DataContext _context;

        public UserRepository()
        {
            _context = new DataContext();
        }

        public UserRepository( DataContext context)
        {
            _context = context;
        }
    }
}
