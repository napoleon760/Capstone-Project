using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eticketer.Data.Repositories;
using Eticketer.Core.Managers;
using Eticketer.Core;
using Eticketer.Data.Entities;

namespace Eticketer.Data.Managers
{
    public class TripManager
    {
        private TripRepository _trip;

        public TripManager()
        {
            DataContext context = new DataContext();
           _trip = new TripRepository(context);

        }
        public TripManager(TripRepository trip)
        {
            _trip = trip;
        }

    }
    
}
