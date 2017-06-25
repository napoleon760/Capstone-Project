using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eticketer.Data.Entities;
using Eticketer.Core;

namespace Eticketer.Data.Repositories
{
    public class TripRepository
    {
        
        private DataContext _context;

        public TripRepository()
        {
            _context = new DataContext();
        }

        public TripRepository(DataContext context)
        {
            _context = context;
        }

    }
}
