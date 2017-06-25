using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticketer.Data.Entities
{
    public class Route

    {
        public int RouteID { get; set; }


        //navigation property that map route to bus
        public virtual ICollection<Trip> Trips { get; set; }
        //navigation property that map route to ticket
        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}
