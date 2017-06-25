using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticketer.Data.Entities
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int TripID { get; set; }
        public int BusID { get; set; }

        //navigation property that maps ticket to customer
        public virtual ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();
        //navigation property that maps ticket to bus
        public virtual Trip Trip { get; set; }
        //navigation property that maps ticket to route
        public virtual Route Route { get; set; }

    }
}
